using Martinez_Bank.Dto;
using Martinez_Bank.Persistence.Data;
using Martinez_Bank.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Martinez_Bank.Repository.Admin
{
	public class CreateAccountRepository
	{
		private readonly PCBDataContext _context;

		public CreateAccountRepository(PCBDataContext context)
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
							 ProfileImage = ImageUtility.ByteArrayToBitmap(i.ProfileImage.ToArray())
						 };

			return result;
		}

		public bool AddAccount(CreateAccountDto dto)
		{
			var result = _context.SP_AddAccount
			(dto.Fullname, dto.Email, dto.Password, dto.RepeatPassword,
			dto.Role, dto.MarriageStatus, dto.DateOfBirth,
			dto.Phonenumber, dto.Address, dto.Gender,
			dto.Fathername, dto.Mothername, dto.Balance, dto.ProfileImage).FirstOrDefault().MESSAGE;

			return result == "1" ? true : throw new Exception(result.ToString());
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
