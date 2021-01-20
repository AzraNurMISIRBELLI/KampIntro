using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{//snippet=hazırkodlar-->prop tab tab
	class Product
	{
		public int Id { get; set; }//Primary Key

		public int CategoryId { get; set; }  //Referans Foreign Key
		public string ProductName { get; set; }

		public double UnitPrice { get; set; } //Fiyat

		public int UnitInStock { get; set; }  //Stok

		//CRUD Operasyonları

			
	}
}
