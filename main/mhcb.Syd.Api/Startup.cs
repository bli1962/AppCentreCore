using System;
using System.Text;

using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;

using mhcb.Syd.Api.Data;
using mhcb.Syd.Business.Repository;
using mhcb.Syd.Business.Repository.LOAN;
using mhcb.Syd.Business.Repository.EDistribution;
using mhcb.Syd.Business.Repository.Message;
using mhcb.Syd.Business.Repository.RATES;
using mhcb.Syd.Business.Repository.Dashboard;
using mhcb.Syd.Business.Utilities;
using mhcb.Syd.Interface;
using mhcb.Syd.Interface.Dashboard;
using mhcb.Syd.DataAccess.Repository;

namespace mhcb.Syd.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }
        private readonly string _policyName = "CorsPolicy";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            // *********************************************
            // Part 1.1 : Add ApplicationDbContext to service 
            // ********************************************* 
            services.AddDbContext<AppIdentityDbContext>(options =>
                            options.UseSqlServer(Configuration.GetConnectionString("AppCenterConnection")));

            // *********************************************
            // Part 1.2 : Add Identity to service 
            // ********************************************* 
            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<AppIdentityDbContext>();


            // Note: AddDbContextPool is better over AddDbContext
            // *********************************************
            // Part 1.3 : Add DbContext to service 
            // ********************************************* 
            services.AddDbContext<GUIDEDbContext>(options =>
                            options.UseSqlServer(Configuration.GetConnectionString("GUIDEConnection"))
                            .EnableSensitiveDataLogging()
                            .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddLog4Net())));

            services.AddDbContext<LOANDbContext>(options =>
                            options.UseSqlServer(Configuration.GetConnectionString("LOANConnection"))
                            .EnableSensitiveDataLogging()
                            .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddLog4Net())));

            services.AddDbContext<EDocumentDbContext>(options =>
                            options.UseSqlServer(Configuration.GetConnectionString("EDocumentConnection"))
                            .EnableSensitiveDataLogging()
                            .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddLog4Net())));

            services.AddDbContext<eDistributionContext>(options =>
                            options.UseSqlServer(Configuration.GetConnectionString("EDistributionConnection"))
                            .EnableSensitiveDataLogging()
                            .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddLog4Net())));

            services.AddDbContext<EUCDbArchiveDbContext>(options =>
                            options.UseSqlServer(Configuration.GetConnectionString("EUCDbArchiveConnection"))
                            .EnableSensitiveDataLogging()
                            .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddLog4Net())));

            services.AddDbContext<RatesDbContext>(options =>
                            options.UseSqlServer(Configuration.GetConnectionString("RatesConnection"))
                            .EnableSensitiveDataLogging()
                            .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddLog4Net())));

            services.AddDbContext<AppCenterDbContext>(options =>
                            options.UseSqlServer(Configuration.GetConnectionString("AppCenterConnection"))
                            .EnableSensitiveDataLogging()
                            .UseLoggerFactory(LoggerFactory.Create(builder => builder.AddLog4Net())));

            services.AddCors(opt =>
            {
                opt.AddPolicy(name: _policyName, builder =>
                {
                    builder.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            });

            //services.AddCors(options =>
            //{
            //    options.AddPolicy("CorsPolicy", builder =>
            //    {
            //        builder.AllowAnyOrigin()
            //               .AllowAnyMethod()
            //               .AllowAnyHeader();
            //    });
            //});

            //var key = Encoding.ASCII.GetBytes(SECRET);
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(options =>
            {
                options.RequireHttpsMetadata = true;
                options.SaveToken = true;
                options.TokenValidationParameters = new TokenValidationParameters
                {
                    //ValidateIssuerSigningKey = true,
                    //ValidateIssuer = false,
                    //ValidateAudience = false,
                    ////IssuerSigningKey = new SymmetricSecurityKey(key),
                    //IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("IamMizuhoBankSydnyKey")),

                    ValidateIssuerSigningKey = true,
                    ValidateIssuer = true,
                    ValidateAudience = true,

                    IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["Jwt:Key"])),
                    ValidIssuer = Configuration["Jwt:Issuer"],       //Usually this is your application base URL                                           
                    ValidAudience = Configuration["Jwt:Audience"],   //If the JWT is created using a web service then this could be the consumer URL   

                    // It forces tokens to expire exactly at token expiration time instead of 5 minutes later
                    ClockSkew = TimeSpan.Zero
                };
            })
            .AddCookie(); 


            // this is line pattern for API
            services.AddControllers();	
            
			//services.AddScoped<IJwtToken, JwtToken>();
			//services.AddTransient<IEmailSender, EmailSender>();

            // if using custom Logging service
            //services.AddSingleton<ILoggerManager, LoggerManager>();

			// this is option
			//services.AddMvc().AddJsonOptions(options =>
			//{
			//    options.JsonSerializerOptions.WriteIndented = true;
			//});

			services.AddAutoMapper(typeof(Startup));

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "mhcb.Syd.Api", Version = "v1" });
            });

            // Dependent Injection           
            RegisterBusinessRepository(services);
        }

        private static void RegisterBusinessRepository(IServiceCollection services)
        {
            services.AddScoped<IAuditLog, AuditLogRepository>();
            services.AddScoped<IBankInf, BankInfRepository>();
            services.AddScoped<ICovenantMasterRecord, CovenantMasterRecordRepository>();
            services.AddScoped<ICustomerMaster, CustomerMasterRepository>();
            services.AddScoped<IEDocument, EDocumentRepository>();
            services.AddScoped<IEUCBalanceEvent, EUCBalanceEventRepository>();

            services.AddScoped<IEUCOnDemandBatch, EUCOnDemandBatchRepository>();
            services.AddScoped<IFacilityMasterLoanTrans, FacilityMasterLoanTransRepository>();
            services.AddScoped<IFXFCust, FXFCustRepository>();

            services.AddScoped<IFXDelivery, FXDeliveryRepository>();
            services.AddScoped<IFXTransactionExt, FXTransactionExtRepository>();
            services.AddScoped<IFXTransaction, FXTransactionRepository>();

            services.AddScoped<IGAS, GASRepository>();
            services.AddScoped<ILoanMasterTranche, LoanMasterTrancheRepository>();
            services.AddScoped<IMoneyMarketTicket, MoneyMarketTicketRepository>();

            services.AddScoped<IPaymentControl, PaymentControlRepository>();
            services.AddScoped<IDomesticClearing, DomesticClearingRepository>();
            services.AddScoped<IRFRInterest, RFRInterestRepository>();
            services.AddScoped<ISettlementInf, SettlementInfRepository>();
			services.AddScoped<ISpecialRate, SpecialRateRepository>();
			services.AddScoped<ITrancheCovenantType, TrancheCovenantTypeRepository>();
			services.AddScoped<IUser, UserRepository>();
            services.AddScoped<IUserSecurity, UserSecurityRepository>();
            services.AddScoped<IFacilityTypeOverride, FacilityTypeOverrideRepository>();
            services.AddScoped<IDistribution, DistributionRepository>();
            //services.AddScoped<IDistributionPassword, DistributionPasswordRepository>();

            services.AddScoped<IBisRate, BisRateRepository>();
            services.AddScoped<IDepositsRate, DepositRateRepository>();
            services.AddScoped<IFxRate, FxRateRepository>();
            services.AddScoped<IRevaluationRate, RevaluationRateRepository>();
            services.AddScoped<ISwapRate, SwapRateRepository>();

            services.AddScoped<IRatesGbaseUploadCtl, RatesGbaseUploadCtlRepository>();
			services.AddScoped<IRatesMessage, RatesMessageRepository>();

			services.AddScoped<IFXTransactionCount, FXTransactionCountRepository>();
			services.AddScoped<IFXDeliveryCount, FXDeliveryCountRepository>();
			services.AddScoped<IBankInfCount, BIFCountRepository>();
			services.AddScoped<ISettlementInfCount, SIFCountRepository>();
			services.AddScoped<ICustomerCount, CustomerCountRepository>();
			services.AddScoped<IMoneyMarketCount, MoneyMarketCountRepository>();
			services.AddScoped<IPaymentControlCount, PaymentControlCountRepository>();
			services.AddScoped<IDocumentCount, DocumentCountRepository>();
			services.AddScoped<IDistributionCount, DistributionCountRepository>();
            services.AddScoped<IDomesticClearingCount, DomesticClearingCountRepository>();
            services.AddScoped<IFXConfirmationCount, FxConfirmationCountRepository>();
        }


        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "mhcb.Syd.Api v1"));
            }

            app.UseHttpsRedirection();
            app.UseAuthentication();

            app.UseCors(builder =>
            {
                builder
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader();
            });
        
            //app.UseSession();
            app.UseStaticFiles();
            app.UseRouting();

            //Call this method after the UseRouting method and before the UseAuthorization method.
            //app.UseCors(_policyName);
            //app.UseCors("CorsPolicy");

            app.UseAuthorization();

            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.MapControllers();
            //});

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                           name: "default",
                           pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
