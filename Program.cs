using Martinez_Bank.Config;
using Martinez_Bank.View.Admin;
using Martinez_Bank.View.Mdi;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Martinez_Bank
{
	internal static class Program
	{
		/// <summary>
		/// The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{

			//var services = new ServiceCollection();
			//services.Services();
			//var serviceProvider = services.BuildServiceProvider();

			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			//Application.Run(new SignInForm());
			//Application.Run(new CreateAccountForm());
			Application.Run(new AdminMDIParent());
		}
	}
}
