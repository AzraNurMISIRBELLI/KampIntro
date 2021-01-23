using System;

namespace OOP2
{
	class Program
	{
		static void Main(string[] args)
		{
			GercekMusteri musteri1 = new GercekMusteri();
			musteri1.MusteriNo = "123456";
			musteri1.Id = 1;
			musteri1.Adi = "Azra";
			musteri1.Soyadi = "BELLİ";
			musteri1.TcNo = "21212121";

			TuzelMusteri musteri2 = new TuzelMusteri();
			musteri2.MusteriNo = "12456";
			musteri2.Id = 2;
			musteri2.SirketAdi = "Kodlama";
			musteri2.VergiNo = "1592856";



			Musteri musteri3 = new GercekMusteri();
			Musteri musteri4 = new TuzelMusteri();

			CustomerManager customerManager = new CustomerManager();
			customerManager.Add(musteri1);
			customerManager.Add(musteri2);

			
		}


	}
}
