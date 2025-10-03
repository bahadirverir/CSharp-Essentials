namespace PROJECT
{
  class Program
  {
    static void Main(string[] args)
    {
      while (true)
      {
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("1-) Araba Ekle");
        Console.WriteLine("2-) Araba Sil");
        Console.WriteLine("3-) Motosiklet Ekle");
        Console.WriteLine("4-) Motosiklet Sil");
        Console.WriteLine("5-) Arabaları Listele");
        Console.WriteLine("6-) Motosikletleri Listele");
        Console.WriteLine("7-) Programdan Çık\n");
        Console.Write("Seçenek >>> ");
        int secenek;                

        try
        {
          secenek = Convert.ToInt32(Console.ReadLine());
        }
        catch (FormatException)
        {
          Console.ForegroundColor = ConsoleColor.Red;
          Console.Write("\nGeçersiz giriş, tekrar deneyin.\n");
          continue;
        }

        switch (secenek)
        {
          case 1:
            string arabaMarka = Metotlar.StringGirdi("Marka: ");
            string arabaSeri = Metotlar.StringGirdi("Seri: ");
            string arabaModel = Metotlar.StringGirdi("Model: ");
            int arabaYil = Metotlar.IntGirdi("Yıl: ");
            string arabaYakit = Metotlar.StringGirdi("Yakıt: ");
            string arabaVites = Metotlar.StringGirdi("Vites: ");
            int arabaKilometre = Metotlar.IntGirdi("Kilometre: ");
            string arabaKasaTipi = Metotlar.StringGirdi("Kasa tipi: ");
            int arabaBeygirGucu = Metotlar.IntGirdi("Beygir gücü: ");
            int arabaMotorHacmi = Metotlar.IntGirdi("Motor hacmi: ");
            string arabaCekis = Metotlar.StringGirdi("Çekiş: ");
            string arabaRenk = Metotlar.StringGirdi("Renk: ");
            int arabaYakitTuketimi = Metotlar.IntGirdi("Yakıt tüketimi: ");

            Araba araba = new Araba(arabaMarka, arabaSeri, arabaModel, arabaYil, arabaYakit,
                  arabaVites, arabaKilometre, arabaKasaTipi, arabaBeygirGucu,
                  arabaMotorHacmi, arabaCekis, arabaRenk, arabaYakitTuketimi);

            Metotlar.ArabaEkle(araba);
              Console.WriteLine("Ana menüye dönülüyor...");
              Thread.Sleep(2500);
              Console.Clear();
              break;

          case 2:
            Metotlar.ArabaSil();
              break;

          case 3:
            string motosikletMarka = Metotlar.StringGirdi("Marka: ");
            string motosikletModel = Metotlar.StringGirdi("Model: ");
            string motosikletTur = Metotlar.StringGirdi("Tür: ");
            int motosikletYil = Metotlar.IntGirdi("Yıl: ");
            string motosikletYakit = Metotlar.StringGirdi("Yakıt: ");
            int motosikletKilometre = Metotlar.IntGirdi("Kilometre: ");
            int motosikletMotorHacmi = Metotlar.IntGirdi("Motor hacmi: ");
            int motosikletBeygirGucu = Metotlar.IntGirdi("Beygir gücü: ");
            int motosikletZamanlamaTipi = Metotlar.IntGirdi("Zamanlama tipi: ");
            int motosikletSilindirSayisi = Metotlar.IntGirdi("Silindir sayısı: ");
            string motosikletVites = Metotlar.StringGirdi("Vites: ");
            string motosikletRenk = Metotlar.StringGirdi("Renk: ");
            int motosikletYakitTuketimi = Metotlar.IntGirdi("Yakıt tüketimi: ");

            Motosiklet motosiklet = new Motosiklet(motosikletMarka, motosikletModel, motosikletTur, motosikletYil, motosikletYakit,
                  motosikletKilometre, motosikletMotorHacmi, motosikletBeygirGucu, motosikletZamanlamaTipi,
                  motosikletSilindirSayisi, motosikletVites, motosikletRenk, motosikletYakitTuketimi);

            Metotlar.MotosikletEkle(motosiklet);
              Console.WriteLine("Ana menüye dönülüyor...");
              Thread.Sleep(2500);
              Console.Clear();
              break;

          case 4:
            Metotlar.MotosikletSil();
              break;

          case 5:
            Metotlar.ArabalariListele();
              break;

          case 6:
            Metotlar.MotosikletleriListele();
              break;

          case 7:
            Console.WriteLine("Program başarıyla kapatıldı.");
            return;

          default:
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\nGeçersiz giriş, tekrar deneyin.");
            while (true)
            {
              Console.WriteLine("1-) Ana menüye dön.");
              Console.WriteLine("2-) Programdan çık.");
              Console.Write("\nSeçenek >>  ");

              try
              {
                int secim = Convert.ToInt32(Console.ReadLine());
                if (secim == 1)
                {
                  Console.WriteLine("Ana menüye dönülüyor...");
                  Thread.Sleep(2000);
                  Console.Clear();
                  break;
                }
                else if (secim == 2)
                {
                  Console.WriteLine("Program başarıyla kapatıldı.");
                  return;
                }
                else
                {
                  Console.WriteLine("Geçersiz giriş, tekrar deneyin.");
                }
              }
              catch (FormatException)
              {
                Console.WriteLine("Geçersiz giriş, tekrar deneyin.");
              }
            }
          break;
        }
      }
    }
  }
}