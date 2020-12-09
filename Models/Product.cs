using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RoastedWebApp.Models
{
	public class Product
	{
		public int ID { get; set; }
		public double Price { get; set; }
		public string Name { get; set; }
		public string Desription { get; set; }
		public string ImageLink { get; set; }
	}
}
