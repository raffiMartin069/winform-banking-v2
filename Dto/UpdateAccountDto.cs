using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martinez_Bank.Dto
{
	public class UpdateAccountDto
	{
		public UpdateAccountDto
			(int id, string email, DateTime dateOfBirth, string password,
			string repeatPassword, string fullname, string phonenumber,
			string address, string marriageStatus, string gender,
			string mothername, string fathername, string role,
			decimal balance, byte[] profileImage)
		{
			Id = id;
			Email = email;
			DateOfBirth = dateOfBirth;
			Password = password;
			RepeatPassword = repeatPassword;
			Fullname = fullname;
			Phonenumber = phonenumber;
			Address = address;
			MarriageStatus = marriageStatus;
			Gender = gender;
			Mothername = mothername;
			Fathername = fathername;
			Role = role;
			Balance = balance;
			ProfileImage = profileImage;
		}

		public int Id { get; set; }
		public string Email { get; set; }
		public DateTime DateOfBirth { get; set; }
		public string Password { get; set; }
		public string RepeatPassword { get; set; }
		public string Fullname { get; set; }
		public string Phonenumber { get; set; }
		public string Address { get; set; }
		public string MarriageStatus { get; set; }
		public string Gender { get; set; }
		public string Mothername { get; set; }
		public string Fathername { get; set; }
		public string Role { get; set; }
		public decimal Balance { get; set; }
		public byte[] ProfileImage { get; set; }
	}
}
