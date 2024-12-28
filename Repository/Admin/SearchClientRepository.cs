using Martinez_Bank.Persistence.Data;
using Martinez_Bank.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using User = Martinez_Bank.Dto.User;

namespace Martinez_Bank.Repository.Admin
{
	public class SearchClientRepository
	{
		private readonly PCBDataContext _context;
		public SearchClientRepository(PCBDataContext context)
		{
			_context = context;
		}

		public IEnumerable<User> FindClientByKey(string Key)
		{
			return from i in _context.SP_FindClientByKey(Key)
				   select new User()
				   {
					   Id = i.Id,
					   AccountNumber = i.AccountNumber,
					   ProfileImage = ImageUtility.ByteArrayToBitmap(i.ProfileImage.ToArray()),
					   Fullname = i.Fullname,
					   Balance = "Php " + i.Balance,
					   Email = i.Email,
					   Address = i.Address,
					   DateOfBirth = i.DateOfBirth.ToString(),
					   PhoneNumber = i.PhoneNumber,
					   Gender = i.Gender,
					   Role = i.Role,
					   Marriage = i.MarriageStatus,
					   Fathername = i.Fathername,
					   Mothername = i.Mothername
				   };
		}

		public IEnumerable<User> GetAllClient()
		{
			return from i in _context.SP_GetAllClient() select new User()
			{
				Id = i.Id,
				AccountNumber = i.AccountNumber,
				ProfileImage = ImageUtility.ByteArrayToBitmap(i.ProfileImage.ToArray()),
				Fullname = i.Fullname,
				Balance = "Php " + i.Balance,
				Email = i.Email,
				Address = i.Address,
				DateOfBirth = i.DateOfBirth.ToString(),
				PhoneNumber = i.PhoneNumber,
				Gender = i.Gender,
				Role = i.Role,
				Marriage = i.MarriageStatus,
				Fathername = i.Fathername,
				Mothername = i.Mothername
			};
		}
	}
}
