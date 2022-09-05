using mhcb.Syd.Business.Repository;
using mhcb.Syd.DataAccess.Repository;
using mhcb.Syd.Interface;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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

            //Note: AddDbContextPool is better over AddDbContext
            services.AddDbContext<GUIDEDbContext>(options =>
                            options.UseSqlServer(Configuration.GetConnectionString("GUIDEConnection")));
            services.AddDbContext<LOANDbContext>(options =>
                            options.UseSqlServer(Configuration.GetConnectionString("LOANConnection")));
            services.AddDbContext<EDocumentDbContext>(options =>
                            options.UseSqlServer(Configuration.GetConnectionString("EDocumentConnection")));
            services.AddDbContext<EUCDbArchiveDbContext>(options =>
                            options.UseSqlServer(Configuration.GetConnectionString("EUCDbArchiveConnection")));
            services.AddDbContext<RatesDbContext>(options =>
                            options.UseSqlServer(Configuration.GetConnectionString("RatesConnection")));


            services.AddCors(opt =>
            {
                opt.AddPolicy(name: _policyName, builder =>
                {
                    builder.AllowAnyOrigin()
                    .AllowAnyHeader()
                    .AllowAnyMethod();
                });
            });



            // this is line pattern for API
            services.AddControllers();

            // this is option
            //services.AddMvc().AddJsonOptions(options =>
            //{
            //    options.JsonSerializerOptions.WriteIndented = true;
            //});

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "mhcb.Syd.Api", Version = "v1" });
            });

            // Dependent Injection           
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
            services.AddScoped<IUser, UserRepository>();
            services.AddScoped<IUserSecurity, UserSecurityRepository>();
            services.AddScoped<IFacilityTypeOverride, FacilityTypeOverrideRepository>();
            services.AddScoped<IDistributionPreference, DistributionPreferenceRepository>();
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
            app.UseStaticFiles();
            app.UseRouting();

            // call this method after the UseRouting method and before the UseAuthorization method.
            app.UseCors(_policyName);

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
