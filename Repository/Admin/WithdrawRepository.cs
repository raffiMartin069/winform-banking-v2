using Martinez_Bank.Dto;
using Martinez_Bank.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martinez_Bank.Repository.Admin
{
	public class WithdrawRepository
	{
		private readonly PCBDataContext _context;

		public WithdrawRepository(PCBDataContext context)
		{
			_context = context;
		}

		public IEnumerable<WithdrawLogsDto> FindByKey(string Key)
		{
			return from i in _context.SP_FindWithdrawLogByKey(Key)
				   select new WithdrawLogsDto()
				   {
					   Id = i.Id,
					   AccountNumber = i.AccountNumber,
					   Fullname = i.Fullname,
					   PreviousBalance = i.PreviousBalance,
					   CurrentBalance = i.CurrentBalance,
					   DateUpdated = DateTime.Parse(i.DateUpdate.ToString()).Date,
					   TimeUpdated = i.TimeUpdated.ToString()
				   };
		}

		public IEnumerable<WithdrawLogsDto> GetLogs()
		{
			return from i in _context.SP_GetAllWithdrawLogs()
				   select new WithdrawLogsDto()
				   {
					   Id = i.Id,
					   AccountNumber = i.AccountNumber,
					   Fullname = i.Fullname,
					   PreviousBalance = i.PreviousBalance,
					   CurrentBalance = i.CurrentBalance,
					   DateUpdated = DateTime.Parse(i.DateUpdate.ToString()).Date,
					   TimeUpdated = i.TimeUpdated.ToString()
				   };
		}

		public bool Save(WithdrawDto dto)
		{
			var result = _context
				.SP_Withdraw
				(dto.AccountNumber, dto.Fullname, dto.WithdrawMode, dto.CurrentBalance, dto.WithdrawAmount)
				.FirstOrDefault()
				.MESSAGE;
			return result == "1" ? true : throw new Exception(result);
		}

		public IEnumerable<SP_GetAllWithdrawModeResult> GetAllMode()
		{
			return _context.SP_GetAllWithdrawMode();
		}

	}
}
