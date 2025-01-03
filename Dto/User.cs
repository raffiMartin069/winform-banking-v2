﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martinez_Bank.Dto
{
	public class User
	{
		public int Id { get; set; }
		public string AccountNumber { get; set; }
		public Bitmap ProfileImage { get; set; }
		public string Fullname { get; set; }
		public string Balance { get; set; }
		public string Email { get; set; }
		public string Address { get; set; }
		public string DateOfBirth { get; set; }
		public string PhoneNumber { get; set; }
		public string Gender { get; set; }
		public string Role { get; set; }
		public string Marriage { get; set; }
		public string Fathername { get; set; }
		public string Mothername { get; set; }
	}
}
