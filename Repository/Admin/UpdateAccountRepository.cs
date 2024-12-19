using Martinez_Bank.Dto;
using Martinez_Bank.Persistence.Data;
using Martinez_Bank.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martinez_Bank.Repository.Admin
{
	public class UpdateAccountRepository
	{
		private readonly PCBDataContext _context;

		public UpdateAccountRepository(PCBDataContext context)
		{
			_context = context;
		}

		public IEnumerable<AccountDto> FindByKey(string Key)
		{
			var result = from i in _context.SP_FindUserByKey(Key)
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
							 ProfileImage = ImageUtility.ByteArrayToBitmap(i.ProfileImage.ToArray()),
							 OriginalSizeProfileImage = ImageUtility.ByteArrayToImage(i.ProfileImage.ToArray())
						 };

			return result;
		}

		public bool Update(UpdateAccountDto dto)
		{
			string result = "";
			if (string.IsNullOrEmpty(dto.Password) && string.IsNullOrEmpty(dto.RepeatPassword))
				result = _context.SP_UpdateAccountWithoutPassword
					(dto.Id, dto.Fullname, dto.Email, dto.Role,
					dto.MarriageStatus, dto.DateOfBirth, dto.Phonenumber,
					dto.Address, dto.Gender, dto.Fathername,
					dto.Mothername, dto.Balance, dto.ProfileImage)
					.FirstOrDefault()
					.MESSAGE
					.ToString();
			else
				result = _context.SP_UpdateAccountWithPassword
					(dto.Id, dto.Fullname, dto.Email, dto.Password,
					dto.RepeatPassword, dto.Role, dto.MarriageStatus,
					dto.DateOfBirth, dto.Phonenumber, dto.Address,
					dto.Gender, dto.Fathername, dto.Mothername,
					dto.Balance, dto.ProfileImage)
					.FirstOrDefault()
					.MESSAGE
					.ToString();

			return result == "1" ? true : throw new Exception(result);
		}
	}
}
