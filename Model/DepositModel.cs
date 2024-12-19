using Martinez_Bank.Dto;
using Martinez_Bank.Repository.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martinez_Bank.Model
{
	public class DepositModel
	{

		private readonly DepositRepository _depositRepository;

		public DepositModel(DepositRepository depositRepository, string accountNumber, string fullname, string depositMode, string currentBalance, string depositAmount)
		{
			_depositRepository = depositRepository;
			AccountNumber = accountNumber;
			Fullname = fullname;
			DepositMode = depositMode;
			CurrentBalance = currentBalance;
			DepositAmount = depositAmount;
		}

		public string AccountNumber { get; set; }
		public string Fullname { get; set; }
		public string DepositMode { get; set; }
		public string CurrentBalance { get; set; }
		public string DepositAmount { get; set; }

		public bool AddDeposit()
		{
			ValidateAccountNumber();
			ValidateFullname();
			ValidateDepositMode();
			decimal currentBalance = ValidateCurrentBalance();
			decimal deposit = ValidateDepositAmount();

			var dto = new DepositDto
			{
				AccountNumber = AccountNumber,
				Fullname = Fullname,
				DepositMode = DepositMode,
				CurrentBalance = currentBalance,
				DepositAmount = deposit
			};

			return _depositRepository.AddDeposit(dto);
		}

		private decimal ValidateDepositAmount()
		{
			if (string.IsNullOrEmpty(DepositAmount))
				throw new Exception("Deposit Amount is required");

			if (!decimal.TryParse(DepositAmount, out decimal depositAmount))
				throw new Exception("Deposit Amount must be a number");

			if (depositAmount < 1)
				throw new Exception("Deposit amount is invalid. Please try again.");
		
			return depositAmount;
		}

		private decimal ValidateCurrentBalance()
		{
			if (string.IsNullOrEmpty(CurrentBalance))
				throw new Exception("Current Balance is required");

			if (!decimal.TryParse(CurrentBalance, out decimal currentBalance))
				throw new Exception("Current Balance must be a number");

			if (currentBalance < 1)
				throw new Exception("Current balance is invalid. Please try again.");

			return currentBalance;
		}

		private void ValidateDepositMode()
		{
			if (string.IsNullOrEmpty(DepositMode))
				throw new Exception("Mode is required");
		}

		private void ValidateFullname()
		{
			if (string.IsNullOrEmpty(Fullname))
				throw new Exception("Name is required");
		}

		private void ValidateAccountNumber()
		{
			if (string.IsNullOrEmpty(AccountNumber))
				throw new Exception("Account Number is required");

			if (AccountNumber.Length != 17)
				throw new Exception("Account Number must be 17 characters");

			// use regex to verify if account number does not contain letters
			if (!System.Text.RegularExpressions.Regex.IsMatch(AccountNumber, "^[0-9]*$"))
				throw new Exception("Account Number must not contain letters");
		}
	}
}
