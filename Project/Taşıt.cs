namespace PROJECT
{
    abstract class Taşıt
    {
        private string marka;
        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }

        private string renk;
        public string Renk
        {
            get { return renk; }
            set { renk = value; }
        }

        private string yakit;
        public string Yakit
        {
            get { return yakit; }
            set { yakit = value; }
        }

        private string vites;
        public string Vites
        {
            get { return vites; }
            set { vites = value; }
        }

        private string model;
        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        private int yil;
        public int Yil
        {
            get { return yil; }
            set { yil = value; }
        }

        private int kilometre;
        public int Kilometre
        {
            get { return kilometre; }
            set { kilometre = value; }
        }

        private int beygirGucu;
        public int BeygirGucu
        {
            get { return beygirGucu; }
            set { beygirGucu = value; }
        }

        private int motorHacmi;
        public int MotorHacmi
        {
            get { return motorHacmi; }
            set { motorHacmi = value; }
        }

        private int yakitTuketimi;
        public int YakitTuketimi
        {
            get { return yakitTuketimi; }
            set { yakitTuketimi = value; }
        }
    }
}