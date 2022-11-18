using System.Text.Json;
using Newtonsoft.Json;
using JSONProject.Models;

namespace JSONProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            // My Books , and Directories
            var root = "C:\\Users\\webbec\\source\\repos\\JSONProject\\JSONProject\\Data";
            var file1 = root + Path.DirectorySeparatorChar + "game.json";
            var file2 = root + Path.DirectorySeparatorChar + "clash.json";
            var file3 = root + Path.DirectorySeparatorChar + "storm.json";
            var file4 = root + Path.DirectorySeparatorChar + "feast.json";
            var file5 = root + Path.DirectorySeparatorChar + "dance.json";


            var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };

            string jsonString = string.Empty;

            // Book #1

            using (var Sr = new StreamReader(file1))
            {
                jsonString = Sr.ReadToEnd();
            }

            var game = JsonConvert.DeserializeObject<Book>(jsonString);

            Console.WriteLine(game);


            // -----

            // Book #2
            using (var Sr = new StreamReader(file2))
            {
                jsonString = Sr.ReadToEnd();
            }

            var clash = JsonConvert.DeserializeObject<Book>(jsonString);

            Console.WriteLine(clash);


            // -----


            // Book #3
            using (var Sr = new StreamReader(file3))
            {
                jsonString = Sr.ReadToEnd();
            }

            var storm = JsonConvert.DeserializeObject<Book>(jsonString);

            Console.WriteLine(storm);

            // -----


            // Book #4
            using (var Sr = new StreamReader(file4))
            {
                jsonString = Sr.ReadToEnd();
            }

            var feast = JsonConvert.DeserializeObject<Book>(jsonString);

            Console.WriteLine(feast);

            // -----


            // Book #5
            using (var Sr = new StreamReader(file5))
            {
                jsonString = Sr.ReadToEnd();
            }

            var dance = JsonConvert.DeserializeObject<Book>(jsonString);

            Console.WriteLine(dance);


            // -----




            // Create a Book

            VolumeInfo v = new VolumeInfo("QueryBuilder Rules", "Rules, wooo.....", new string[] { "Ethan Webb" });
            Items i = new Items("ldkslkdsls", "http://clickthislink.org", v);
            Book newBook = new Book(new Items[] { i });


            var queryBuilder = JsonConvert.SerializeObject(newBook);
            Console.WriteLine(queryBuilder);
        }
    }
}
