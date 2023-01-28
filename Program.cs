namespace Demo253
{
    class program
    {
        public static void Main(string[] args)
        {
            Maruti maruti = new Maruti("Swift", 200000, "White");
            Console.WriteLine(maruti.Model);
            Console.WriteLine(maruti.Price);
            Console.WriteLine(maruti.Colour);

        }
        public class Maruti
        {
            public string Model;
            public int Price;
            public string Colour;

            public Maruti(string model, int price, string colour)
            {
                Model = model;
                Price = price;
                Colour = colour;
            }
            public string GetModel()
            {
                return "Swift";
            }
            public static string GetColour()
            {
                return "Red";
            }
        }
    }
}
