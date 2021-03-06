﻿using System;
using System.Collections.Generic;

namespace OOP3
{
	class Program
	{
		static void Main(string[] args)
		{
			IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();		

			IKrediManager tasitKrediManager = new TasitKrediManager();

			IKrediManager konutKrediManager = new KonutKrediManager();
			IKrediManager esnafKrediManager = new EsnafKredisiManager();

			BasvuruManager basvuruManager = new BasvuruManager();
			ILoggerService databaseLoggerService = new DatabaseLoggerService();
			ILoggerService fileLoggerService = new FileLoggerService();
			ILoggerService smsLoggerService = new SmsLoggerService();

			List<ILoggerService> loggers = new List<ILoggerService> { databaseLoggerService, smsLoggerService };

			basvuruManager.BasvuruYap(esnafKrediManager, loggers);

			List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager,konutKrediManager};

			//basvuruManager.KrediOnBilgilendirmesiYap(krediler);


			
			
		}
	}
}
