﻿namespace Entities.Dtos.Products
{
	public class ProductGetDto
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
		public DateTime Created { get; set; }
		public string Description { get; set; }
		public bool IsDeleted { get; set; }
	}
}
