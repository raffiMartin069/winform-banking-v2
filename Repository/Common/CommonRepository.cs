using Martinez_Bank.Persistence.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martinez_Bank.Repository.Common
{
	public class CommonRepository
	{
		private readonly PCBDataContext _context;

		public CommonRepository(PCBDataContext context)
		{
			_context = context;
		}

		public IEnumerable<SP_GetAllGenderResult> GetAllGender()
		{
			return _context.SP_GetAllGender();
		}

		public IEnumerable<SP_GetAllMarriageStatusResult> GetAllMarriageStatus()
		{
			return _context.SP_GetAllMarriageStatus();
		}

		public IEnumerable<SP_GetAllRoleResult> GetAllRole()
		{
			return _context.SP_GetAllRole();
		}
	}
}
