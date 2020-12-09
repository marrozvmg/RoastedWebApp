using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace RoastedWebApp.Models
{
	public class Order
	{
		public int ID { get; set; }
		public int AccountID { get; set; }
		public int ProductID { get; set; }
		public int ProductAmount { get; set; }
	}
}
