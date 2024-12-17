using Martinez_Bank.Dto;
using Martinez_Bank.Persistence.Data;
using Martinez_Bank.Utilities;
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

		public IEnumerable<AccountDto> GetAll()
		{
			var result = from i in _context.SP_GetAllNewAccount()
						 select new AccountDto()
						 {
							 Id = i.Id,
							 Email = i.Email,
							 DateOfBirth = i.DateOfBirth,
							 Fullname = i.Fullname,
							 Phonenumber = i.PhoneNumber,
							 Address = i.Address,
							 MarriageStatus = i.MarriageStatus,
							 Gender = i.Gender,
							 Mothername = i.Mothername,
							 Fathername = i.Fathername,
							 Role = i.Role,
							 Balance = i.Balance,
							 ProfileImage = ImageUtility.ByteArrayToBitmap(i.ProfileImage.ToArray())
						 };

			return result;
		}
	}
}
