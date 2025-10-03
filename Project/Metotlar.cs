namespace PROJECT
{
    class Metotlar
    {
        public static List<Araba> Arabalar = new List<Araba>();
        public static List<Motosiklet> Motosikletler = new List<Motosiklet>();

        public static void ArabaEkle(Araba araba)
        {
            Arabalar.Add(araba);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nAraba başarıyla eklendi.");
        }

        public static void MotosikletEkle(Motosiklet motosiklet)
        {
            Motosikletler.Add(motosiklet);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nMotosiklet başarıyla eklendi.");
        }

        public static void ArabaSil()
        {
            Console.Write("Silmek istediğiniz arabanın ID'sini girin: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Araba araba = Arabalar.Find(a => a.Id == id);
            if (araba != null)
            {
                Arabalar.Remove(araba);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Araba başarıyla silindi.\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nGirilen ID'ye sahip araba bulunamadı.\n");
            }
        }

        public static void MotosikletSil()
        {
            Console.Write("Silmek istediğiniz motosikletin ID'sini girin: ");
            int id = Convert.ToInt32(Console.ReadLine());
            Motosiklet motosiklet = Motosikletler.Find(m => m.Id == id);
            if (motosiklet != null)
            {
                Motosikletler.Remove(motosiklet);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Motosiklet başarıyla silindi.\n");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nGirilen ID'ye sahip motosiklet bulunamadı.\n");
            }
        }

        public static void ArabalariListele()
        {
            if (Arabalar.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nListelenecek araba yok.\n");
                return;
            }
            Console.WriteLine("\nArabalar listeleniyor...\n");
            foreach (var araba in Arabalar)
            {
                Console.WriteLine("ID: {0}\nMarka: {1}\nSeri: {2}\nModel: {3}\nYıl: {4}", araba.Id, araba.Marka, araba.Seri, araba.Model, araba.Yil);
                Console.WriteLine("Yakıt: {0}\nVites: {1}\nKilometre: {2}", araba.Yakit, araba.Vites, araba.Kilometre);
                Console.WriteLine("Kasa tipi: {0}\nBeygir gücü: {1}\nMotor hacmi: {2}", araba.KasaTipi, araba.BeygirGucu, araba.MotorHacmi);
                Console.WriteLine("Çekiş: {0}\nRenk: {1}\nYakıt tüketimi: {2}\n", araba.Cekis, araba.Renk, araba.YakitTuketimi);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Mevcut arabalar başarıyla listelendi.\n");
        }

        public static void MotosikletleriListele()
        {
            if (Motosikletler.Count == 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nListelenecek motosiklet yok.\n");
                return;
            }
            Console.WriteLine("\nMotosikletler listeleniyor...\n");
            foreach (var motosiklet in Motosikletler)
            {
                Console.WriteLine("ID: {0}\nMarka: {1}\nModel: {2}\nTür: {3}\nYıl: {4}", motosiklet.Id, motosiklet.Marka, motosiklet.Model, motosiklet.Tur, motosiklet.Yil);
                Console.WriteLine("Yakıt: {0}\nKilometre: {1}\nMotor hacmi: {2}", motosiklet.Yakit, motosiklet.Kilometre, motosiklet.MotorHacmi);
                Console.WriteLine("Beygir gücü: {0}\nZamanlama tipi: {1}\nSilindir sayısı: {2}", motosiklet.BeygirGucu, motosiklet.ZamanlamaTipi, motosiklet.SilindirSayisi);
                Console.WriteLine("Vites: {0}\nRenk: {1}\nYakıt tüketimi: {2}\n", motosiklet.Vites, motosiklet.Renk, motosiklet.YakitTuketimi);
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Mevcut motosikletler başarıyla listelendi.\n");
        }

        public static string StringGirdi(string mesaj)
        {
            string girdi;
            while (true)
            {
                Console.Write(mesaj);
                girdi = Console.ReadLine();
                if (!string.IsNullOrWhiteSpace(girdi))
                {
                    break;
                }
                Console.WriteLine("Geçersiz giriş; boş değerler kabul edilmez, tekrar deneyin.");
            }
            return girdi;
        }

        public static int IntGirdi(string mesaj)
        {
            int sonuc;
            while (true)
            {
                Console.Write(mesaj);
                if (int.TryParse(Console.ReadLine(), out sonuc))
                {
                    break;
                }
                Console.WriteLine("Geçersiz giriş, lütfen geçerli bir tam sayı girin.");
            }
            return sonuc;
        }
    }
}