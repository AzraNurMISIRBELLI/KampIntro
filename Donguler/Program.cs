﻿using System;

namespace Donguler
{
	class Program
	{
		static void Main(string[] args)
		{
			string[] kurslar = new string[] {"Yazılım Geliştirici Yetiştirme Kampı",
				"Programlamaya Başlangıç için Temel Kurs","JAVA","Python"};
			for (int i = 0; i < kurslar.Length; i++)
			{
				Console.WriteLine(kurslar[i]);
			}
			Console.WriteLine("for bitti.");
			foreach (string kurs in kurslar)
			{
				Console.WriteLine(kurs);

			}
			Console.WriteLine("Sayfa Sonu- Footer");


		}
	}
}