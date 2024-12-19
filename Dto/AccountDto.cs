using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martinez_Bank.Dto
{
	public class AccountDto
	{
		public Bitmap ProfileImage { get; set; }
		public int Id { get; set; }
		public string Fullname { get; set; }
		public string Email { get; set; }
		public string Phonenumber { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string MarriageStatus { get; set; }
		public string Gender { get; set; }
		public string Address { get; set; }
		public string Mothername { get; set; }
		public string Fathername { get; set; }
		public string Role { get; set; }
		public decimal Balance { get; set; }
		public Bitmap OriginalSizeProfileImage { get; set; }

	}
}
