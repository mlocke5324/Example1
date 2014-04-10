using System;
using System.Collections.Generic;

namespace Example1
{
	public class UserIndexDTO
	{
		public List<UserDTO> UserList { get; set;}

		public UserIndexDTO ()
		{
			UserList = new List<UserDTO> ();
		}

		public UserIndexDTO(List<UserDTO> userList)
		{
			UserList = userList;
		}
	}
}

