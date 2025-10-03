namespace PROJECT
{
   class Araba : Taşıt
   {
      private string seri;
      public string Seri
      {
         get { return seri; }
         set { seri = value; }
      }

      private string cekis;
      public string Cekis
      {
         get { return cekis; }
         set { cekis = value; }
      }

      private string kasaTipi;
      public string KasaTipi
      {
         get { return kasaTipi; }
         set { kasaTipi = value; }
      }

      private static int id = 1;
      public int Id { get; private set; }

      public Araba(string marka, string seri, string model, int yil, string yakit,
                string vites, int kilometre, string kasaTipi, int beygirGucu,
                int motorHacmi, string cekis, string renk, int yakitTuketimi)
      {
         Id = id++;
         Marka = marka;
         Seri = seri;
         Model = model;
         Yil = yil;
         Yakit = yakit;
         Vites = vites;
         Kilometre = kilometre;
         KasaTipi = kasaTipi;
         BeygirGucu = beygirGucu;
         MotorHacmi = motorHacmi;
         Cekis = cekis;
         Renk = renk;
         YakitTuketimi = yakitTuketimi;
      }
   }
}