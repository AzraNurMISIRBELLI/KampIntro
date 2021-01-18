using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
	class SepetManager
	{
		public void Ekle(Product urun)
		{
			Console.WriteLine("Tebrikler. Sepete Eklendi:" + urun.Adi);

		}
		public void Ekle2(string urunAdi,string urunAciklama,double fiyat,int stok)
		{
			Console.WriteLine("Tebrikler .Sepete Eklendi:" + urunAdi);

		}
	}
}
