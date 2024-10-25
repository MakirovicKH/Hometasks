namespace İndexerTask
{
    internal class Program
    {
        static void Main(string[] city)
        {

            static void Main()
            {
                string[] indexOfCity = { "Baki", "NewYork", "İndoneziya", "İsmayilli" };
                StringList cityList = new StringList(indexOfCity);

                Console.WriteLine(cityList["Baki"]);       
                Console.WriteLine(cityList["NewYork"]);   
                Console.WriteLine(cityList["İndoneziya"]);      
                Console.WriteLine(cityList["İsmayilli"]); 
            }
        }
    }
}
