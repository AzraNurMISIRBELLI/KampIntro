using System;

namespace Metotlar
{
	class Program
	{   //Dont repaet  yourself -Dry- Clean code- Best Practice
		static void Main(string[] args)
		{
			Product pr1= new Product();
			pr1.Adi = "Elma";
			pr1.Fiyati = 15;
			pr1.Aciklama = "Amasya Elması";

			Product pr2 = new Product();
			pr2.Adi = "Karpuz";
			pr2.Fiyati = 80;
			pr2.Aciklama = "Diyarbakır Karpuzu";

			Product[] urunler = new Product[] { pr1,pr2};
			foreach (var product in urunler)
			{
				Console.WriteLine(product.Adi);
				Console.WriteLine(product.Fiyati);
				Console.WriteLine(product.Aciklama);
				Console.WriteLine("------------------");




			}

			Console.WriteLine("----MEtodlar-------");
			SepetManager sepetManager = new SepetManager();
			sepetManager.Ekle(pr1);
			sepetManager.Ekle(pr2);

			sepetManager.Ekle2("Karpuz", "Diyarbakır Karpuzu", 80,10);
			sepetManager.Ekle2("Elma", "Yeşil Elma", 150,3);
			sepetManager.Ekle2("Elma", "Kırmızı Elma ", 100,5);


		}
	}
}
