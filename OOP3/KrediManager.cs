using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
	interface IKrediManager
	{
		//Bu operasyonlar alt sınıfta mutlaka çağırılmalı
		void Hesapla();
		void BiseyYap();
	}
}
