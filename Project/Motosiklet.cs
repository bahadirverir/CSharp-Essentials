namespace PROJECT
{
    class Motosiklet : Taşıt
    {
        private int zamanlamaTipi;
        public int ZamanlamaTipi
        {
            get { return zamanlamaTipi; }
            set { zamanlamaTipi = value; }
        }

        private int silindirSayisi;
        public int SilindirSayisi
        {
            get { return silindirSayisi; }
            set { silindirSayisi = value; }
        }

        private string tur;
        public string Tur
        {
            get { return tur; }
            set { tur = value; }
        }

        private static int id = 1;
        public int Id { get; private set; }

        public Motosiklet(string marka, string model, string tur, int yil, string yakit,
                          int kilometre, int motorHacmi, int beygirGucu, int zamanlamaTipi,
                          int silindirSayisi, string vites, string renk, int yakitTuketimi)
        {
            Id = id++;
            Marka = marka;
            Model = model;
            Tur = tur;
            Yil = yil;
            Yakit = yakit;
            Kilometre = kilometre;
            MotorHacmi = motorHacmi;
            BeygirGucu = beygirGucu;
            ZamanlamaTipi = zamanlamaTipi;
            SilindirSayisi = silindirSayisi;
            Vites = vites;
            Renk = renk;
            YakitTuketimi = yakitTuketimi;
        }
    }
}