using Martinez_Bank.Dto;
using Martinez_Bank.Repository.Admin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martinez_Bank.Model
{
	public class WithdrawModel
	{

		private readonly WithdrawRepository _repo;

		public WithdrawModel(WithdrawRepository repo, string accountNumber, string fullname, string withdrawMode, string currentBalance, string withdrawAmount)
		{
			_repo = repo;
			AccountNumber = accountNumber;
			Fullname = fullname;
			WithdrawMode = withdrawMode;
			CurrentBalance = currentBalance;
			WithdrawAmount = withdrawAmount;
		}

		public string AccountNumber { get; set; }
		public string Fullname { get; set; }
		public string WithdrawMode { get; set; }
		public string CurrentBalance { get; set; }
		public string WithdrawAmount { get; set; }

		public bool Withdraw()
		{
			ValidateAccountNumber();
			ValidateFullname();
			ValidateDepositMode();
			decimal currentBalance = ValidateCurrentBalance();
			decimal withdraw = ValidateDepositAmount();

			var dto = new WithdrawDto
			{
				AccountNumber = AccountNumber,
				Fullname = Fullname,
				WithdrawMode = WithdrawMode,
				CurrentBalance = currentBalance,
				WithdrawAmount = withdraw
			};

			return _repo.Save(dto);
		}

		private decimal ValidateDepositAmount()
		{
			if (string.IsNullOrEmpty(WithdrawAmount))
				throw new Exception("Deposit Amount is required");

			if (!decimal.TryParse(WithdrawAmount, out decimal withdrawAmount))
				throw new Exception("Deposit Amount must be a number");

			if (withdrawAmount < 1)
				throw new Exception("Deposit amount is invalid. Please try again.");
		
			return withdrawAmount;
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
			if (string.IsNullOrEmpty(WithdrawMode))
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
