//using Microsoft.AspNetCore.Hosting;
//using Microsoft.Extensions.Hosting;

//namespace mhcb.Syd.AppCenter
//{
//	public class Program
//	{
//		public static void Main(string[] args)
//		{
//			CreateHostBuilder(args).Build().Run();
//		}

//		public static IHostBuilder CreateHostBuilder(string[] args) =>
//			Host.CreateDefaultBuilder(args)
//				.ConfigureWebHostDefaults(webBuilder =>
//				{
//					webBuilder.UseStartup<Startup>();
//				});
//	}
//}

// Reference : https://learn.microsoft.com/en-us/aspnet/core/migration/50-to-60?view=aspnetcore-8.0&tabs=visual-studio

using mhcb.Syd.AppCenter;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Logging;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddLog4Net();


var startup = new Startup(builder.Configuration);
startup.ConfigureServices(builder.Services);

var app = builder.Build();

startup.Configure(app, app.Environment);

app.Run();