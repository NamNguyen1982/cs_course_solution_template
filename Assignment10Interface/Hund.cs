namespace Assignment10Interface
{
    public class Hund : IDbFunktioner{

        public string Navn { get; set; }

        public void Gem()
        {
            System.Console.WriteLine("Gemmer Hund...");
        }
    }
}
