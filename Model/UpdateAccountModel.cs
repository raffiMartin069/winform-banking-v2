using Martinez_Bank.Dto;
using Martinez_Bank.Persistence.Data;
using Martinez_Bank.Repository.Admin;
using Martinez_Bank.Repository.Common;
using Martinez_Bank.Utilities;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Martinez_Bank.Model
{
	public class UpdateAccountModel
	{
		private readonly CommonRepository _repository;
		private readonly CreateAccountRepository _accountRepo;

		public UpdateAccountModel
			(string email, string dateOfBirth, string password,
			string repeatPassword, string fullname, string phonenumber,
			string address, string marriageStatus, string gender,
			string mothername, string fathername, string role,
			string balance, CommonRepository repository, Image profileImage, CreateAccountRepository accountRepo)
		{
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
			_repository = repository;
			ProfileImage = profileImage;
			_accountRepo = accountRepo;
		}

		public UpdateAccountModel
			(string email, string dateOfBirth, string password,
			string repeatPassword, string fullname, string phonenumber,
			string address, string marriageStatus, string gender,
			string mothername, string fathername, string role,
			string balance, CommonRepository repository, Image profileImage, CreateAccountRepository accountRepo, int id)
		{
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
			_repository = repository;
			ProfileImage = profileImage;
			_accountRepo = accountRepo;
			Id = id;
		}

		public int Id { get; set; }
		public string Email { get; set; }
		public string DateOfBirth { get; set; }
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
		public string Balance { get; set; }
		public Image ProfileImage { get; set; }

		public static IEnumerable<AccountDto> GetAll()
		{
			var repo = new CreateAccountRepository(new PCBDataContext());
			return repo.GetAll();
		}

		public bool AddAccount()
		{
			string email = EmailValidator();
			DateTime date = DateOfBirthValidator();
			PasswordValidator();
			FullnameValidator();
			PhonenumberValidator();
			AddressValidator();
			MarriageStatusValidator();
			GenderValidator();
			ParentNamesValidator();
			RoleValidator();
			decimal balance = BalanceValidator();
			byte[] image = ValidateAndConvertProfileImage();

			var dto = new CreateAccountDto
				(email, date, Password,
				RepeatPassword, Fullname, Phonenumber,
				Address, MarriageStatus, Gender,
				Mothername, Fathername, Role,
				balance, image);

			return _accountRepo.AddAccount(dto);
		}

		private byte[] ValidateAndConvertProfileImage()
		{
			if (ProfileImage == null)
				throw new Exception("Profile image can not be empty.");

			byte[] imageBytes = ImageUtility.ImageToByteArray(ProfileImage);

			if (imageBytes == null)
				throw new Exception("Profile image can not be empty.");

			if (imageBytes.Length > 1000000)
				throw new Exception("Profile image size must not exceed 1MB.");

			if (imageBytes.Length < 1000)
				throw new Exception("Profile image size must be atleast 1KB.");

			return imageBytes;
		}

		private decimal BalanceValidator()
		{
			if (string.IsNullOrEmpty(Balance))
				throw new Exception("Balance can not be empty.");

			if (!decimal.TryParse(Balance, out decimal balance))
				throw new Exception("Invalid balance format.");

			// Mantaining balance or initial balance should be in hundreds or thousands.
			// This ensures that there are no cents and the balance is a whole number for initial deposit.
			if (balance % 100 != 0)
				throw new Exception("Balance must be a in hundreds or thousands. E.g.\n\n* 100.00\n* 500.00\n* 1500.00");

			if (balance < 100)
				throw new Exception("Initial balance must be at least Php 100.00");

			return balance;
		}

		private void RoleValidator()
		{

			var roles = _repository.GetAllRole();
			bool isRoleValid = false;

			foreach (var i in roles)
			{
				if (Role == i.RoleType)
				{
					isRoleValid = true;
					break;
				}
			}

			if (!isRoleValid)
				throw new Exception("Role is not valid.");
		}

		private void ParentNamesValidator()
		{
			if (string.IsNullOrEmpty(Mothername))
				throw new Exception("Mothername can not be empty.");

			if (string.IsNullOrEmpty(Fathername))
				throw new Exception("Fathername can not be empty.");
		}

		private void GenderValidator()
		{
			var genders = _repository.GetAllGender();
			bool isGenderValid = false;
			foreach (var i in genders)
			{
				if (Gender == i.Name)
				{
					isGenderValid = true;
					break;
				}

			}
			if (!isGenderValid)
				throw new Exception("Gender is invalid.");
		}

		private void MarriageStatusValidator()
		{
			// change this for database query.
			var status = _repository.GetAllMarriageStatus();
			bool isMarriageStatusValid = false;

			foreach (var i in status)
			{
				if (MarriageStatus == i.Name)
				{
					isMarriageStatusValid = true;
					break;
				}
			}

			if (!isMarriageStatusValid)
				throw new Exception("Marriage status is not valid.");
		}

		private void AddressValidator()
		{
			if (string.IsNullOrEmpty(Address))
				throw new Exception("Address can not be empty.");
		}

		private void PhonenumberValidator()
		{
			if (string.IsNullOrEmpty(Phonenumber))
				throw new Exception("Phonenumber can not be empty.");

			if (!long.TryParse(Phonenumber, out long phoneNum))
				throw new Exception("Invalid phone number format.");

			if (!Phonenumber.StartsWith("09"))
				throw new Exception("Phone number must start with 09.");

			if (Phonenumber.Length != 11)
				throw new Exception("Phone number must be 11 digits long."); // 09xx xxx xxxx for Philippines mobile number
		}

		private void FullnameValidator()
		{
			if (string.IsNullOrEmpty(Fullname))
				throw new Exception("Fullname can not be empty.");
		}

		private void PasswordValidator()
		{
			if (string.IsNullOrEmpty(Password))
				throw new Exception("Password can not be empty.");

			if (string.IsNullOrEmpty(RepeatPassword))
				throw new Exception("Repeat password can not be empty.");

			//if (Password.Length < 8)
			//	throw new Exception("Password must be at least 8 characters long.");

			if (Password != RepeatPassword)
				throw new Exception("Password and repeat password must be the same.");
		}

		private DateTime DateOfBirthValidator()
		{
			if (DateOfBirth == null)
				throw new Exception("Date of birth can not be empty.");

			if (DateOfBirth.ToString() == "")
				throw new Exception("Date of birth can not be empty.");

			if (string.IsNullOrEmpty(DateOfBirth.ToString()))
				throw new Exception("Date of birth can not be empty.");

			if (!DateTime.TryParse(DateOfBirth, out DateTime dateOfBirth))
				throw new Exception("Invalid date of birth format.");

			// check if user is atleast 7 years old
			if (DateTime.Now.Year - dateOfBirth.Year < 7)
				throw new Exception("Client must be atleast 7 years old to create an account.");

			return dateOfBirth.Date;
		}

		private string EmailValidator()
		{
			if (string.IsNullOrEmpty(Email))
				throw new Exception("Email can not be empty.");

			if (!Email.Contains("@"))
				throw new Exception("Email is not valid.");

			// validate email using regular expression characters
			string isValid = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
			if (!Regex.IsMatch(Email, isValid))
				throw new Exception("Email is not valid.");

			string[] domains = { "gmail.com", "outlook.com", "yahoo.com", "hotmail.com" };

			if (!domains.Any(d => Email.EndsWith(d)))
				throw new Exception($"Email domain is not valid. Allowed domains are:\n\n\n1. {domains[0]}\n2. {domains[1]}\n3. {domains[2]}\n4. {domains[3]}");

			string normalizedEmail = Email.ToLower();

			return normalizedEmail;
		}
	}
}
