namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>
            {
                "Golden Axe", "Mortal Kombat", "Crazy Taxi", "Street Fighter"
            };
            IEnumerable<string> descendingVideoGames = videoGames.OrderByDescending(x=>x); 

            foreach (var i in descendingVideoGames)
            {
                Console.WriteLine(i);
            }

            

            
        }
    }
}
