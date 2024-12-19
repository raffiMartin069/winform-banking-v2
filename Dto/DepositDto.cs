using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martinez_Bank.Dto
{
	public class DepositDto
	{
		public string AccountNumber { get; set; }
		public string Fullname { get; set; }
		public string DepositMode { get; set; }
		public decimal CurrentBalance { get; set; }
		public decimal DepositAmount { get; set; }
	}
}
