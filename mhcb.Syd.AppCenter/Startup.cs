using mhcb.Syd.AppCenter.Services.API;
using mhcb.Syd.AppCenter.Services.Interface;
using mhcb.Syd.Interface;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Authorization;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;
using mhcb.Syd.AppCenter.CustomHandler;
using System.Security.Claims; 

namespace mhcb.Syd.AppCenter
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            // *********************************************
            // Part 1.1 : Add Identity service 
            // ********************************************* 
            services.AddAuthentication("Identity.Application")
                            .AddCookie(options =>
                            {
                                
                                // Cookie settings
                                options.Cookie.Name = "AppCenterCookies";   // Name of cookie 
                                options.Cookie.SameSite = SameSiteMode.None;
                                options.Cookie.SecurePolicy = CookieSecurePolicy.Always;
                                options.Cookie.HttpOnly = true;
                                options.Cookie.IsEssential = true;
                                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);
                                options.SlidingExpiration = false;

                                options.LoginPath = "/Account/Login";
                                options.AccessDeniedPath = "/Account/UserAccessDenied";
                            });



            // *********************************************
            //  Part 1.2  Add Jwt token
            // ********************************************* 
            //services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
            //               .AddJwtBearer(options =>
            //               {
            //                   options.TokenValidationParameters = new TokenValidationParameters
            //                   {
            //                       ValidateIssuer = true,
            //                       ValidateAudience = true,
            //                       ValidateLifetime = true,
            //                       ValidateIssuerSigningKey = true,
            //                       ValidIssuer = Configuration["Jwt:Issuer"],
            //                       ValidAudience = Configuration["Jwt:Audience"],
            //                       IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"]))
            //                   };
            //               });


            //services.AddAuthentication(options =>
            //        {
            //            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            //            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            //            options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            //        })
            //        .AddJwtBearer(options =>
            //        {
            //            options.SaveToken = true;
            //            options.RequireHttpsMetadata = false;
            //            options.TokenValidationParameters = new Microsoft.IdentityModel.Tokens.TokenValidationParameters()
            //            {
            //                IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("IamMizuhoBankSydnyKey")),

            //                ValidateIssuer = true,
            //                ValidateAudience = true,

            //                //Usually this is your application base URL 
            //                ValidIssuer = "https://www.mizuho.com",

            //                //If the JWT is created using a web service then this could be the consumer URL 
            //                ValidAudience = "https://www.mizuho.com",

            //                // It forces tokens to expire exactly at token expiration time instead of 5 minutes later
            //                ClockSkew = TimeSpan.Zero
            //            };
            //        });


            // *********************************************
            // Part 1.3 : Add Authorization with policy 
            // ********************************************* 
            services.AddAuthorization(config =>
            {
                config.AddPolicy("MizhoPolicy", policyBuilder =>
                {
                    policyBuilder.UserRequireCustomClaim(ClaimTypes.Email);
                    policyBuilder.UserRequireCustomClaim(ClaimTypes.DateOfBirth);
                });
            });
            services.AddScoped<IAuthorizationHandler, PoliciesAuthorizationHandler>();

            services.AddScoped<IAuthorizationHandler, RolesAuthorizationHandler>();


            // *Create a policy instance 
            //var policy = new AuthorizationPolicyBuilder()
            //                  .RequireAuthenticatedUser()
            //                  .RequireRole("Admin")
            //                  .Build();

            // *Create the policy instance 
            //services.AddMvc(obj =>
            //        {
            //            var policy = new AuthorizationPolicyBuilder()
            //                .RequireAuthenticatedUser()
            //                .Build();
            //            obj.Filters.Add(new AuthorizeFilter(policy));
            //        });

            //// register policy based on role
            //services.AddAuthorization(options =>
            //            {
            //                options.AddPolicy("RequireManagerOnly", policy => policy.RequireRole("Manager"));
            //            });
            //services.AddAuthorization(options =>
            //            {
            //                options.AddPolicy("RequireManagerOnly", policy => policy.RequireRole("Manager", "Administrator"));
            //            });


            ////Step: for role auth, and Claim auth
            //// Register Policy
            //services.AddAuthorization(option =>
            //    {
            //        option.AddPolicy("admin-policy", policy => policy.RequireClaim("admin-policy", "true"));
            //        option.AddPolicy("IsAdmin", policy => policy.RequireRole("admin", "moderator", "superuser"));
            //    });


            //services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            //services.AddAuthorization(options =>
            //                {
            //                    options.AddPolicy(
            //                        "MinExperience", policy =>
            //                        policy.Requirements.Add(new MinimumExpRequirement(5)));
            //                });
            //services.AddSingleton<IAuthorizationHandler, MinimumExpHandler>();


            // *********************************************
            // Part 3 : Add Cors service
            // ********************************************* 
            services.AddCors();


            // *********************************************
            // Part 4 : service for AppDbContext
            //*********************************************
            // this is for Mock layer call only, not for API
            //services.AddDbContext<GUIDEDbContext>(options =>
            //                options.UseSqlServer(Configuration.GetConnectionString("GUIDEConnection")));
            //services.AddDbContext<LOANDbContext>(options =>
            //                options.UseSqlServer(Configuration.GetConnectionString("LOANConnection")));


            // *********************************************************
            // Part 5: service for Dependence Inject for Repository if don't use API
            // *********************************************************
            //services.AddScoped<IBankInf, BankInfRepository>();


            // *********************************************
            // Part 6 : Add Session option
            // ********************************************* 
            services.AddSession(option =>
            {
                option.IdleTimeout = TimeSpan.FromMinutes(30);
            });


            // *********************************************
            // Part 7 : Add MVC
            // ********************************************* 
            services.AddMvc();
            //services.AddMvc(config => {
            //    var policy = new AuthorizationPolicyBuilder()
            //                    .RequireAuthenticatedUser()
            //                    .Build();
            //    config.Filters.Add(new AuthorizeFilter(policy));
            //});


            // *********************************************
            // Part 8 : Add Http service
            // ********************************************* 
            services.AddHttpContextAccessor();


            // *********************************************
            // Part 9 : service for Blazor and Razor pages
            // *********************************************
            services.AddRazorPages();
            services.AddServerSideBlazor();


            // *********************************************
            // Part 10 : service of register HtthClint for API call
            // *********************************************
            // Register HttpClient service 
            var RemoteApiAddress = Configuration["ApiAddress"];
            services.AddHttpClient<IAuditLogService, AuditLogService>(
                                client => { client.BaseAddress = new Uri(RemoteApiAddress); }
            );
            services.AddHttpClient<IBankInfService, BankInfService>(
                                client => { client.BaseAddress = new Uri(RemoteApiAddress); }
            );
            services.AddHttpClient<ICovenantMasterService, CovenantMasterService>(
                                client => { client.BaseAddress = new Uri(RemoteApiAddress); }
            );
            services.AddHttpClient<ICustomerMasterService, CustomerMasterService>(
                                client => { client.BaseAddress = new Uri(RemoteApiAddress); }
            );
            services.AddHttpClient<IEDocumentService, EDocumentService>(
                                client => { client.BaseAddress = new Uri(RemoteApiAddress); }
            );
            services.AddHttpClient<IEUCBalanceEventService, EUCBalanceEventService>(
                                client => { client.BaseAddress = new Uri(RemoteApiAddress); }
            );
            services.AddHttpClient<IEUCOnDemandBatchService, EUCOnDemandBatchService>(
                                client => { client.BaseAddress = new Uri(RemoteApiAddress); }
            );
            services.AddHttpClient<IFacilityMasterLoanTransService, FacilityMasterLoanTransService>(
                                client => { client.BaseAddress = new Uri(RemoteApiAddress); }
            );
            services.AddHttpClient<IFXFCustService, FXFCustService>(
                                client => { client.BaseAddress = new Uri(RemoteApiAddress); }
            );
            services.AddHttpClient<IFXDeliveryService, FXDeliveryService>(
                                client => { client.BaseAddress = new Uri(RemoteApiAddress); }
            );
            services.AddHttpClient<IFXTransactionExtService, FXTransactionExtService>(
                                client => { client.BaseAddress = new Uri(RemoteApiAddress); }
            );
            services.AddHttpClient<IFXTransactionService, FXTransactionService>(
                                client => { client.BaseAddress = new Uri(RemoteApiAddress); }
            );
            services.AddHttpClient<IGASService, GASService>(
                                client => { client.BaseAddress = new Uri(RemoteApiAddress); }
            );
            services.AddHttpClient<ILoanMasterTrancheService, LoanMasterTrancheService>(
                                client => { client.BaseAddress = new Uri(RemoteApiAddress); }
            );
            services.AddHttpClient<IMoneyMarketTicketService, MoneyMarketTicketService>(
                                client => { client.BaseAddress = new Uri(RemoteApiAddress); }
            );
            services.AddHttpClient<IPaymentControlService, PaymentControlService>(
                                client => { client.BaseAddress = new Uri(RemoteApiAddress); }
            );
            services.AddHttpClient<ISwiftPaymentService, SwiftPaymentService>(
                                client => { client.BaseAddress = new Uri(RemoteApiAddress); }
            );
            services.AddHttpClient<IRFRInterestService, RFRInterestService>(
                                client => { client.BaseAddress = new Uri(RemoteApiAddress); }
            );
            services.AddHttpClient<ISettlementInfService, SettlementInfService>(
                                client => { client.BaseAddress = new Uri(RemoteApiAddress); }
            );
            services.AddHttpClient<ISpecialRateService, SpecialRateService>(
                                client => { client.BaseAddress = new Uri(RemoteApiAddress); }
            );
            services.AddHttpClient<IUserService, UserService>(
                                client => { client.BaseAddress = new Uri(RemoteApiAddress); }
            );
            services.AddHttpClient<IUserSecurityService, UserSecurityService>(
                      client => { client.BaseAddress = new Uri(RemoteApiAddress); }
            );
            services.AddHttpClient<IDomesticClearingService, DomesticClearingService>(
                         client => { client.BaseAddress = new Uri(RemoteApiAddress); }
            );
            services.AddHttpClient<IFacilityTypeService, FacilityTypeService>(
                         client => { client.BaseAddress = new Uri(RemoteApiAddress); }
            );
            services.AddHttpClient<IDistributionPreferenceService, DistributionPreferenceService>(
                                client => { client.BaseAddress = new Uri(RemoteApiAddress); }
         );


            // *********************************************
            // Part 11 : service for Automapper 
            // *********************************************
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseCors(builder =>
            {
                builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            });
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();
         
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapBlazorHub();
                endpoints.MapFallbackToPage("/_Host");
            });
        }
    }
}
