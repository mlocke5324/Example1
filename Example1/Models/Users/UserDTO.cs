using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using Example1.DbLinq;

namespace Example1
{
	public class UserDTO
	{
		[Display(Name="Id")]
		public int ID { get; set;}

		[Display(Name="Created")]
		public System.DateTime CreateTime { get; set;}

		[Display(Name="E-Mail")]
		public string Email { get; set;}

		[Display(Name="First Name")]
		public string FirstName { get; set; }

		[Display(Name="Last Name")]
		public string LastName { get; set;}

		[Display(Name="Password")]
		public string Password { get; set;}
		public List<Articles> Articles { get; set;}

		public UserDTO ()
		{
			Articles = new List<Articles>();
		}

		public UserDTO(Users user)
		{
			Articles = user.Articles.ToList();
			ID = user.ID;
			CreateTime = user.CreateTime;
			Email = user.Email;
			FirstName = user.FirstName;
			LastName = user.LastName;
			Password = user.Password;
		}
	}
}

