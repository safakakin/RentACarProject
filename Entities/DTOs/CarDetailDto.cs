using System;
using Core.Entities;

namespace Entities.DTOs
{
	public class CarDetailDto:IDto
	{
		public int CarId { get; set; }
		public string Description { get; set; }
		public int ColorID { get; set; }
		public string ColorName { get; set; }
	}
}

