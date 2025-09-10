namespace IntroToEnums
{
    internal class Program
    {
        enum CardValue
        {
            Two = 2,
            Three, Four, Five, Six, Seven, Eight, Nine, Ten,
            Jack, Queen, King, Ace
        }

        enum Suit
        {
            Heart, Diamond, Club, Spade
        }

        static void Main(string[] args)
        {
            Random rnd = new Random();

            CardValue cardValue = (CardValue)rnd.Next(2, 15);
            Suit suit = (Suit)rnd.Next(0, 4);

            Console.WriteLine(cardValue + " of " + suit);
        }
    }
}
