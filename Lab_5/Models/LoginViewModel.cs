﻿using System.ComponentModel.DataAnnotations;

namespace Lab_5.Models
{
    public class LoginViewModel
    {
		[Required]
		[EmailAddress]
		public string Email { get; set; }

		[Required]
		[DataType(DataType.Password)]
		public string Password { get; set; }
	}
}
