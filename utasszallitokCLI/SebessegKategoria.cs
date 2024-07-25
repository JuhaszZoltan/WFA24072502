namespace UtasszallitokCLI
{
    internal class SebessegKategoria
    {
        public int UtazoSebesseg { get; set; }
        public string KategoriaNev => UtazoSebesseg switch
        {
            < 500 => "Alacsony sebességű",
            < 1000 => "Szubszonikus",
            < 1200 => "Transzszonikus",
            _ => "Szuperszonikus"
        };
        public SebessegKategoria(int utazoSebesseg)
        {
            UtazoSebesseg = utazoSebesseg;
        }
    }
}
