﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Appplication_Bartender.Models
{
    public class UserAccount
    {
        //UserID
        [Key]
        public int UserID { get; set; }

        //All information required to register
        //First Name 
        [Required(ErrorMessage = "First Name is required.")]
        public string FirstName { get; set; }

        //Last Name
        [Required(ErrorMessage = "Last Name is required.")]
        public string LastName { get; set; }

        //Email
        [Required(ErrorMessage = "Email is required.")]
        [RegularExpression(@"^([\w-\.]+)@((\[[0-9]{1,3]\.)|(([\w-]+\.)+))([a-zA-Z{2,4}|[0-9]{1,3})(\]?)$", ErrorMessage = "Please enter valid email.")]
        public string Email { get; set; }

        //Username
        [Required(ErrorMessage = "Username is required.")]
        public string Username { get; set; }

        //Password
        [Required(ErrorMessage = "Password is required.")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        //Confirm password
        [Compare("Password", ErrorMessage = "Please confirm your password")]
        [DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
    
}
}