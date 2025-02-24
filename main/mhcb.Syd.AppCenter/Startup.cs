using System;
using System.Net.Http;
using Blazored.LocalStorage;
using Blazored.SessionStorage;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using mhcb.Syd.AppCenter.Services;
using mhcb.Syd.AppCenter.Services.Generic;
using mhcb.Syd.AppCenter.Services.Identity;
using mhcb.Syd.AppCenter.Services.RoleBase.API;
using mhcb.Syd.AppCenter.Services.RoleBase.Interface;

using mhcb.Syd.DataAccess.Models.EUCDbArchive;
using mhcb.Syd.DataAccess.Models.GUIDE;
using mhcb.Syd.DataAccess.Models.LOAN;
using mhcb.Syd.Models;
using mhcb.Syd.Models.Dashboard;
using mhcb.Syd.AppCenter.Middleware;

//using mhcb.Syd.Business.Utilities;

namespace mhcb.Syd.AppCenter
{
    public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		// For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddRazorPages();
			services.AddServerSideBlazor();
            services.AddSingleton<HttpClient>();

            // *********************************************************
            // Part 1: Inject service for IJwtToken, BlazoredLocalStorage etc
            // *********************************************************
            services.AddScoped<IJwtToken, JwtToken>();
            //services.AddTransient<IEmailSender, EmailSender>();
            //services.AddSingleton<ILoggerManager, LoggerManager>();

            services.AddBlazoredSessionStorage();
            services.AddBlazoredLocalStorage();

            // *********************************************
            // Part 2 : register HttpClint service for API call
            // *********************************************
            // Note: It depends on ISessionStorageService, IJwtToken           
            RegisterGenericHttpClientService(services);
            RegisterRolebaseHttpClientService(services);


            // for connection manager
            services.AddScoped<ConnectionManager, ConnectionManager>();
            // for session storage
            services.AddScoped<SessionStorageHelper>();
            // for session storage
            services.AddScoped<SessionStorageServiceJS>();

            // Note It depends on IHttpService, ISessionStorageService, IUserSecurityHttpService, IUserHttpService
            services.AddScoped<AuthenticationStateProvider, CustomAuthenticationStateProvider>();

            // *********************************************
            // Part 3 : Add Session option
            // ********************************************* 
            services.AddSession(option =>
            {
                option.IdleTimeout = TimeSpan.FromMinutes(30);
            });

            // *********************************************
            // Part 4 : Add HttpContext service
            // ********************************************* 
            services.AddHttpContextAccessor();
        }
     

        private void RegisterGenericHttpClientService(IServiceCollection services)
        {
            var RemoteApiAddress = Configuration["ApiAddress"];

            // Register HttpClient service 
            services.AddTransient<ValidateHeaderHandler>();


            // 1. Confirmation
            services.AddHttpClient<IHttpService<MMStatementView>, HttpService<MMStatementView>>()
                         .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<MMConfirmationView>, HttpService<MMConfirmationView>>()
                         .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<FXConfirmationView>, HttpService<FXConfirmationView>>()
                         .AddHttpMessageHandler<ValidateHeaderHandler>();

            // 2. BIF
            services.AddHttpClient<IHttpService<BankInfView>, HttpService<BankInfView>>()
                         .AddHttpMessageHandler<ValidateHeaderHandler>();

            // 3. SIF
            services.AddHttpClient<IHttpService<SettlementInfView>, HttpService<SettlementInfView>>()
                    .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<mhcb.Syd.DataAccess.Models.GUIDE.SettlementInf>, HttpService<mhcb.Syd.DataAccess.Models.GUIDE.SettlementInf>>()
                         .AddHttpMessageHandler<ValidateHeaderHandler>();

            // 4. FX transaction & delivery
            services.AddHttpClient<IHttpService<FxDeliveryView>, HttpService<FxDeliveryView>>()
                        .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<FxDeliveryCorpSummaryView>, HttpService<FxDeliveryCorpSummaryView>>()
                         .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<FxTransactionCompleteView>, HttpService<FxTransactionCompleteView>>()
                         .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<FXTransactionView>, HttpService<FXTransactionView>>()
                         .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<FXTransactionExtView>, HttpService<FXTransactionExtView>>()
                         .AddHttpMessageHandler<ValidateHeaderHandler>();  

            // 5. Distribution
            services.AddHttpClient<IHttpService<DistributionPasswordView>, HttpService<DistributionPasswordView>>()
                    .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<CustDistirbutionInfo>, HttpService<CustDistirbutionInfo>>()
                         .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<DistributionView>, HttpService<DistributionView>>()
                         .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<DistributionPreferenceView>, HttpService<DistributionPreferenceView>>()
                         .AddHttpMessageHandler<ValidateHeaderHandler>();

            // 6. Money Market
            services.AddHttpClient<IHttpService<MoneyMarketReportView>, HttpService<MoneyMarketReportView>>()
                         .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<MoneyMarketTicketView>, HttpService<MoneyMarketTicketView>>()
                         .AddHttpMessageHandler<ValidateHeaderHandler>();

            // 7. Inbound and EUC
            services.AddHttpClient<IHttpService<MxEucBalanceView>, HttpService<MxEucBalanceView>>()
               .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<MxEucBalanceEventView>, HttpService<MxEucBalanceEventView>>()
                         .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<MxInboundEventLogView>, HttpService<MxInboundEventLogView>>()
                         .AddHttpMessageHandler<ValidateHeaderHandler>();

            // 8. GAS
            services.AddHttpClient<IHttpService<GASDebitView>, HttpService<GASDebitView>>()
                   .AddHttpMessageHandler<ValidateHeaderHandler>();

            // 9. Payment control
            services.AddHttpClient<IHttpService<DomesticClearingPaymentView>, 
                HttpService<DomesticClearingPaymentView>>()
                    .AddHttpMessageHandler<ValidateHeaderHandler>();

            services.AddHttpClient<IHttpService<SwiftPaymentView>, HttpService<SwiftPaymentView>>()
                         .AddHttpMessageHandler<ValidateHeaderHandler>();

            // 10. ELCS/Rates
            services.AddHttpClient<IHttpService<RFRInterestLoanView>, HttpService<RFRInterestLoanView>>()
                         .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<RFRInterestSwapView>, HttpService<RFRInterestSwapView>>()
                         .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<ExchRateView>, HttpService<ExchRateView>>()
                         .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<FacilityMasterLoanTransView>, HttpService<FacilityMasterLoanTransView>>()
                         .AddHttpMessageHandler<ValidateHeaderHandler>();

            // 11. ELCS
            services.AddHttpClient<IHttpService<FacilityTypeOverride>, HttpService<FacilityTypeOverride>>()
         .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<CovenantRatioView>, HttpService<CovenantRatioView>>()
                         .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<TrancheType>, HttpService<TrancheType>>()
                       .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<CovenantConditionGroup>, HttpService<CovenantConditionGroup>>()
                       .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<CovenantReceiptTiming>, HttpService<CovenantReceiptTiming>>()
                    .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<CovenantConditionViewModel>, HttpService<CovenantConditionViewModel>>()
                       .AddHttpMessageHandler<ValidateHeaderHandler>();

            // 12. GUIDE users
            services.AddHttpClient<IHttpService<FXFCustomerView>, HttpService<FXFCustomerView>>()
                         .AddHttpMessageHandler<ValidateHeaderHandler>();

            services.AddHttpClient<IHttpService<UserView>, HttpService<UserView>>()
                         .AddHttpMessageHandler<ValidateHeaderHandler>();

            services.AddHttpClient<IHttpService<DataAccess.Models.GUIDE.AuditLog>, HttpService<DataAccess.Models.GUIDE.AuditLog>>()
                         .AddHttpMessageHandler<ValidateHeaderHandler>();

            // 13. Market Rates
            services.AddHttpClient<IHttpService<FxRateViewModel>, HttpService<FxRateViewModel>>()
                        .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<RevaluationRateViewModel>, HttpService<RevaluationRateViewModel>>()
                        .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<SwapRateViewModel>, HttpService<SwapRateViewModel>>()
                               .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<DepositsRateViewModel>, HttpService<DepositsRateViewModel>>()
                       .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<BisRateViewModel>, HttpService<BisRateViewModel>>()
                    .AddHttpMessageHandler<ValidateHeaderHandler>();

            // 14. Rates Upload
            services.AddHttpClient<IHttpService<RatesGbaseUploadCtl>, HttpService<RatesGbaseUploadCtl>>()
                   .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<MessageDTO>, HttpService<MessageDTO>>()
                   .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<RatesAvailablityStatus>, HttpService<RatesAvailablityStatus>>()
                   .AddHttpMessageHandler<ValidateHeaderHandler>();


            // 15 Dashboard
            services.AddHttpClient<IHttpService<StatusCounterDTO>, HttpService<StatusCounterDTO>>()
                             .AddHttpMessageHandler<ValidateHeaderHandler>();
            services.AddHttpClient<IHttpService<StatusCounterSameDayDTO>, HttpService<StatusCounterSameDayDTO>>()
                             .AddHttpMessageHandler<ValidateHeaderHandler>();
            
            // 16. Others -
            // for string class 
            services.AddHttpClient<IHttpService<string>, HttpService<string>>()
                        .AddHttpMessageHandler<ValidateHeaderHandler>();
            // for int class 
            services.AddHttpClient<IHttpService<int>, HttpService<int>>()
                        .AddHttpMessageHandler<ValidateHeaderHandler>();
        }

        private void RegisterRolebaseHttpClientService(IServiceCollection services)
        {
            var RemoteApiAddress = Configuration["ApiAddress"];
            // 2.Register HttpService for role base


            // 1. BIF
            services.AddHttpClient<IBankInfHttpService, BankInfHttpService>();

            // 2. SIF
            services.AddHttpClient<ISettlementInfHttpService, SettlementInfHttpService>();

            // 3. FX transaction & delivery
            services.AddHttpClient<IFXDeliveryHttpService, FXDeliveryHttpService>();
            services.AddHttpClient<IFXTransactionExtHttpService, FXTransactionExtHttpService>();
            services.AddHttpClient<IFXTransactionHttpService, FXTransactionHttpService>();

            // 4. Distribution
            services.AddHttpClient<IDistributionService, DistributionHttpService>(
                           client => { client.BaseAddress = new Uri(RemoteApiAddress); }
                       );

            // 5. Confirmation
            services.AddHttpClient<IEDocumentHttpService, EDocumentHttpService>();

            // 6. Money Market
            services.AddHttpClient<IMoneyMarketTicketHttpService, MoneyMarketTicketHttpService>();

            // 7. Payment control
            services.AddHttpClient<IPaymentControlHttpService, PaymentControlHttpService>();
            services.AddHttpClient<ISwiftPaymentHttpService, SwiftPaymentHttpService>();

            // 8. Domestic Clearing
            services.AddHttpClient<IDomesticClearingHttpService, DomesticClearingHttpService>();


            // 9. Inbound and EUC
            services.AddHttpClient<IEUCBalanceEventHttpService, EUCBalanceEventHttpService>();
            services.AddHttpClient<IEUCOnDemandBatchHttpService, EUCOnDemandBatchHttpService>();

            // 10. ELCS
            services.AddHttpClient<ISpecialRateHttpService, SpecialRateHttpService>();
            services.AddHttpClient<IFacilityTypeHttpService, FacilityTypeHttpService>();
            services.AddHttpClient<ITrancheCovenantTypeHttpService, TrancheCovenantTypeHttpService>(
                     client => { client.BaseAddress = new Uri(RemoteApiAddress); }
                        );
           

            // 11. GUIDE Customer master / FXCust
            services.AddHttpClient<IFXFCustHttpService, FXFCustHttpService>();
            

            // 12. GAS
            services.AddHttpClient<IGASService, GASHttpService>();


            // 13. Rates
            services.AddHttpClient<IFxRateHttpService, FxRateHttpService>();
            services.AddHttpClient<IRevaluationRateHttpService, RevaluationRateHttpService>();
            services.AddHttpClient<ISwapRateHttpService, SwapRateHttpService>();
            services.AddHttpClient<IDepositsRateHttpService, DepositsRateHttpService>();
            services.AddHttpClient<IBisRateHttpService, BisRateHttpService>();


            // 14 Rate Message Post
            services.AddHttpClient<IRatesMessageHttpService, RatesMessageHttpService>();


            // 15 GBASE upload control table
            services.AddHttpClient<IRatesGbaseUploadCtrlHttpService, RatesGbaseUploadCtrlHttpService>();


            // Please not remove
            //************************************************************************
            services.AddHttpClient<IUserHttpService, UserHttpService>();
            services.AddHttpClient<IUserSecurityHttpService, UserSecurityHttpService>(
                      client => { client.BaseAddress = new Uri(RemoteApiAddress); }
            );
            //************************************************************************

            services.AddHttpClient<IAccountHttpService, AccountHttpService>(
                         client => { client.BaseAddress = new Uri(RemoteApiAddress); }
                        );

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
            //if (env.IsDevelopment())
            //{
            //	app.UseDeveloperExceptionPage();
            //}
            //else
            //{
            //	app.UseExceptionHandler("/Error");
            //	// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            //	app.UseHsts();
            //}
            if (!env.IsDevelopment())
            {               
                app.UseExceptionHandler("/Error");
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

            // Register custom security headers middleware
            app.UseMiddleware<SecurityHeadersMiddleware>();

            // register the custom middleware
            app.UseMiddleware<ExceptionMiddleware>();


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
