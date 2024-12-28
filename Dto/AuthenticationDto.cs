using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Martinez_Bank.Dto
{
	public class AuthenticationDto
	{
		public int Id { get; set; }
		public string Email { get; set; }
		public byte[] ProfilImage { get; set; }
		public string Role { get; set; }
		public string Balance { get; set; }
		public string AccountNumber { get; set; }
	}
}
