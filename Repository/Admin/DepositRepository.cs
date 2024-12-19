using Martinez_Bank.Dto;
using Martinez_Bank.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martinez_Bank.Repository.Admin
{
	public class DepositRepository
	{
		private readonly PCBDataContext _context;

		public DepositRepository(PCBDataContext context)
		{
			_context = context;
		}

		public IEnumerable<DepositLogsDto> FindLogsByKey(string Key)
		{
			return from i in _context.SP_FindDepositLogByKey(Key)
				   select new DepositLogsDto
				   {
					   Id = Convert.ToInt32(i.Id.ToString()),
					   AccountNumber = i.AccountNumber,
					   Fullname = i.Fullname,
					   PreviousBalance = decimal.Parse(i.PreviousBalance.ToString()),
					   CurrentBalance = decimal.Parse(i.CurrentBalance.ToString()),
					   DateUpdated = DateTime.Parse(i.DateUpdate.ToString()),
					   TimeUpdated = i.TimeUpdated.ToString(),
				   };
		}

		public IEnumerable<SP_GetAllDepositModeResult> GetAllMode()
		{
			return _context.SP_GetAllDepositMode();
		}

		public IEnumerable<DepositLogsDto> GetAllDepositLogs()
		{
			return from i in _context.SP_GetAllDepositRecords()
				   select new DepositLogsDto
				   {
					   Id = Convert.ToInt32(i.Id.ToString()),
					   AccountNumber = i.AccountNumber,
					   Fullname = i.Fullname,
					   PreviousBalance = decimal.Parse(i.PreviousBalance.ToString()),
					   CurrentBalance = decimal.Parse(i.CurrentBalance.ToString()),
					   DateUpdated = DateTime.Parse(i.DateUpdate.ToString()),
					   TimeUpdated = i.TimeUpdated.ToString(),
				   };
		}

		public bool AddDeposit(DepositDto dto)
		{
			var result = _context.SP_AddDeposit
				(dto.AccountNumber, dto.Fullname,
				dto.DepositMode, dto.CurrentBalance,
				dto.DepositAmount).FirstOrDefault().MESSAGE;

			return result == "1" ? true : throw new Exception(result);
		}
	}
}
