using Blazored.SessionStorage;
using mhcb.Syd.AppCenter.Services.Generic;
using mhcb.Syd.AppCenter.Services.RoleBase.Interface;
using mhcb.Syd.Models;
using Microsoft.AspNetCore.Components.Authorization;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Threading.Tasks;

namespace mhcb.Syd.AppCenter.Services
{
    public class CustomAuthenticationStateProvider : AuthenticationStateProvider
    {
        public ISessionStorageService _sessionStorageService { get; }
        //private ILocalStorageService _storageService { get; }
        //public HttpClient _httpClient;
        public IHttpService<UserView> _httpService1 { get; set; }    
        public IHttpService<string> _httpService2 { get; set; } 
        private readonly IUserSecurityHttpService _userSecurityHttpService;  // same  as _httpService2
        public CustomAuthenticationStateProvider(ISessionStorageService sessionStorageService,
                                                IHttpService<UserView> httpServiceUser,
                                                IHttpService<string> httpServiceString,
                                                IUserSecurityHttpService userSecurityHttpService
                                                )
        {
            _sessionStorageService = sessionStorageService;
            _httpService1 = httpServiceUser;
            _httpService2 = httpServiceString;
            _userSecurityHttpService = userSecurityHttpService;
        }

        //public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        //{
        //    // ** Hard code test for authentication**
        //    var identity = new ClaimsIdentity(
        //                    new[] { new Claim(ClaimTypes.Name, "ben.li@gmail.com") }, "apiauth_type");

        //    // ** hard code to test for non-authentication
        //    //var identity = new ClaimsIdentity();

        //    var user = new ClaimsPrincipal(identity);
        //    return await Task.FromResult(new AuthenticationState(user));
        //}

        public override async Task<AuthenticationState> GetAuthenticationStateAsync()
        {
            var userName = await _sessionStorageService.GetItemAsync<string>("UserName");

            ClaimsIdentity identity;
            if (userName != null && userName != string.Empty)
            {
                identity = await GetClaimsIdentity(userName);
            }
            else
            {
                identity = new ClaimsIdentity();
            }

            var claimsPrincipal = new ClaimsPrincipal(identity);
            return await Task.FromResult(new AuthenticationState(claimsPrincipal));
        }

        // The method will be called when user sign in
        public async Task MarkUserAsAuthenticatedAsync(string UserName)
        {
            // 1. add some user information in session
            await _sessionStorageService.SetItemAsync("UserName", UserName);

            // 2. Create identity
            var identity = await GetClaimsIdentity(UserName);

            // 3. Create principal
            var claimsPrincipal = new ClaimsPrincipal(identity);

            // 4. Authenticate claimsPrincipal
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
        }


        // The method will be called when user sign-out
        public async Task MarkUserAsLoggedOut()
        {
            // 1. remove some user information in session
            await _sessionStorageService.RemoveItemAsync("UserName");

            // 2. create empty ClaimsIdentity
            var identity = new ClaimsIdentity();

            // 3. Create ClaimsPrincipal from empty ClaimsIdentity
            var claimsPrincipal = new ClaimsPrincipal(identity);

            // 4. Authenticate claimsPrincipal
            NotifyAuthenticationStateChanged(Task.FromResult(new AuthenticationState(claimsPrincipal)));
        }


        // Compose the claimed user Identity, including user roles defined in external GUIDE system
        private async Task<ClaimsIdentity> GetClaimsIdentity(string userName)
        {
            var claimsIdentity = new ClaimsIdentity();
            if (userName != null && userName != "")
            {
                List<string> roles = await _httpService2.GetAllAsync($"api/UserSecuritys/GetAuthorizations/{userName}", null);

                // ** the first version, which get roles information from Web client side. Now it is from server side.
                //List<string> roles = (List<string>)await _userSecurityHttpService.GetAuthorizations(userName);

                var claims = new List<Claim>();
                foreach (var roleDesc in roles)
                {
                    claims.Add(new Claim(ClaimTypes.Role, roleDesc));
                }
                claims.Add(new Claim(ClaimTypes.Name, userName));
                claimsIdentity = new ClaimsIdentity(claims, "apiAuth_type");
            }

            return claimsIdentity;
        }

    }
}
