﻿using System;

namespace KampIntro
{
	class Program
	{
		static void Main(string[] args)
		{
			//type safety-tip güvenliği
			//Do Not repeat yourself-Kendini tekrarlama
			//değer tutucu-alias
			string kategoriEtiketi = "Kategori";
			int ogrenciSayisi = 32000;
			double faizOrani = 1.45;
			bool sistemeGirisYapmisMi = false;
			double dolarDun = 7.35;
			double dolarBugun = 7.45;
			if (dolarDun>dolarBugun)
			{
				Console.WriteLine("Azalış Buton");
			}
			else if (dolarDun<dolarBugun)
			{
				Console.WriteLine("Artış Butonu");

			}else
			{
				Console.WriteLine("değişmedi Butonu");

			}



			if (sistemeGirisYapmisMi== true)
			{
				Console.WriteLine("Kullanıcı ayarları butonu");
			}
			else
			{
				Console.WriteLine("Giriş Yap Butonu");
			}

			Console.WriteLine(kategoriEtiketi);
			Console.WriteLine(ogrenciSayisi);

		}
	}
}
