using Martinez_Bank.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martinez_Bank.Repository.Admin
{
	public class CashTransferRepository
	{
		private readonly PCBDataContext _context;

		public CashTransferRepository(PCBDataContext context)
		{
			_context = context;
		}

		public string GetUser(string accountNumber) => _context.SP_GetSpecificUser(accountNumber).FirstOrDefault().Fullname;

		public bool Send(string sender, string recipient, decimal amount)
		{
			var result = _context.SP_XPreSend(sender, recipient, amount).FirstOrDefault().MESSAGE;
			return result == "1" ? true : throw new Exception(result);
		}
	}
}
