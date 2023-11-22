namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> retroVideoGames = new List<string>() { "Pac Man", "Donkey Kong", "Ms Pac Man", "Galaga" };

            retroVideoGames.Add("Centipede");
            retroVideoGames.Add("Defender");

            var videoGames = retroVideoGames.OrderBy(name => name.Length); //OrderByDescend to go in reverse

            foreach (var game in videoGames) 
            
            { 
                Console.WriteLine(game);
            
            }

        }
    }
}
