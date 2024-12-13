using Martinez_Bank.Persistence.Data;
using Martinez_Bank.Repository.Common;
using Martinez_Bank.View.Admin;
using Martinez_Bank.View.Mdi;
using Microsoft.Extensions.DependencyInjection;

namespace Martinez_Bank.Config
{
	public static class ServiceInjection
	{
		public static IServiceCollection Services(this IServiceCollection services)
		{
			services.AddTransient<PCBDataContext>();
			services.AddTransient<CommonRepository>();
			services.AddTransient<CreateAccountForm>();
			services.AddTransient<AdminMDIParent>();

			return services;
		}
	}
}
