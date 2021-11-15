namespace _04MamakSuDeposu
{
    internal class SuDeposu
    {
        public event DepoDolmaOlaySorumlusu DepoDoldu; //Event Tanımlama
        public SuDeposu(int kapasite)
        {
            Kapasite = kapasite;
        }
        public int Kapasite { get; private set; }
        public int SuMiktari { get; private set; }
        public decimal DolulukOrani => SuMiktari / (decimal)Kapasite;

        public void SuEkle(int miktar)
        {
            SuMiktari += miktar;
            if(SuMiktari >= Kapasite)
            {
                int tasan = SuMiktari - Kapasite;
                SuMiktari = Kapasite;
                if (DepoDoldu!= null) // DepoDoldu event'ini kimse kullanmadıysa.
                {
                    DepoDoldu(tasan);
                }
            }
        }


    }
}
