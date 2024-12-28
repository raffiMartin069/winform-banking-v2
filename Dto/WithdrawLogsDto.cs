using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martinez_Bank.Dto
{
	public class WithdrawLogsDto
	{
		public int Id { get; set; }
		public string AccountNumber { get; set; }
		public string Fullname { get; set; }
		public decimal PreviousBalance { get; set; }
		public decimal CurrentBalance { get; set; }
		public DateTime DateUpdated { get; set; }
		public string TimeUpdated { get; set; }
	}
}
