using System;
using Core.Entities;

namespace Entities.Concrete
{
	public class User:IEntity
	{
		public int userId { get; set; }
		public string userFirstName { get; set; }
		public string userLastName { get; set; }
		public string userEmail { get; set; }
		public string userPassword { get; set; }
	}
}

