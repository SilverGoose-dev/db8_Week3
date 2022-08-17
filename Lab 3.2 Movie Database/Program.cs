using System.Threading.Tasks;
// Create class with two memebers
//create the contructor
// new list to store at least 10 movies
List<Film> filmList = new List<Film>();
filmList.Add(new Film("The Lord of the Rings: The Fellowship of the Ring", "Fantasy", 178 , 2001));
filmList.Add(new Film("The Lord of the Rings: The Two Towers", "Fantasy", 223, 2002));
filmList.Add(new Film("The Lord of the Rings: Return of the King", "Fantasy", 263, 2003));
filmList.Add(new Film("A Bugs Life", "Animation", 95, 1998));
filmList.Add(new Film("Saving Private Ryan", "Action", 169, 1998));
filmList.Add(new Film("Hereditary", "Horror", 127, 2018));
filmList.Add(new Film("The Exorcist", "Horror", 132, 1973));
filmList.Add(new Film("Shrek", "Animation", 90, 2001));
filmList.Add(new Film("Predator", "Action", 107, 1987));
filmList.Add(new Film("The Fast and the Furious", "Action", 106, 2001));
filmList.Add(new Film("Spider-Man: Into the Spider-Verse", "Animation", 117,  2018));
filmList.Add(new Film("The Evil Dead", "Horror", 85, 1981));


Menu();
Thread.Sleep(1000);

Console.WriteLine($"There are currently {filmList.Count} titles in this library. \n");
Console.WriteLine("Here are the categories:  ");

List<string> categories = new List<string>();
foreach (Film next in filmList)
{
    if (categories.IndexOf(next.category) == -1)
    {
        categories.Add(next.category);
    }
}
foreach (string category in categories)
{
    Console.WriteLine(category);
}
Console.WriteLine();


do
{

    Console.Write("Please choose a genre you are interested in:  ");
    string entry = Console.ReadLine();
    FindCategory(filmList, entry);

}while(KeepGoing());



static bool KeepGoing()
{
    while (true)
    {
        // Print out message asking if user wants to continue
        Console.WriteLine("Would you like to go again? (y/n)");
        // Ask the user for their input
        string response = Console.ReadLine();
        response = response.ToLower();
        // Check if they typed "y". If so, return true.
        // Otherwise return false.   YES   yes
        if (response == "y" || response == "yes")
        {
            return true;
        }
        else if (response == "n" || response == "no")
        {
            return false;
        }
        else
        {
            Console.WriteLine("Please enter y or n");
        }
    }
}


static void FindCategory(List<Film> _filmList, string _entry)
{
    List<Film> moviesByCat = new List<Film>();
    if (_entry == "Action" || _entry == "Horror" || _entry == "Fantasy" || _entry == "Animation")
    {

        foreach (Film next in _filmList)
        {
            
            if (next.category == _entry)
            {
                moviesByCat.Add(next);
                Console.WriteLine(next.ToString());
                
            }
            
        }
        
    }
    
    else
    {
        Console.WriteLine("That category does not exist.");
    }
    
}

static void Menu()
{
    Console.WriteLine("===================================");
    Console.WriteLine("|  Welcome to the Movie Database  |");
    Console.WriteLine("===================================\n");
}

class Film
{
    public string title;
    public string category;
    public int runtime;
    public int year;

    public Film(string _title, string _category, int _runtime, int _year)
    {
        title = _title;
        category = _category;
        runtime = _runtime;
        year = _year;
    }

    public override string ToString()
    {
        return $"\"{title}\" ({year})  Genre: {category}  Runtime: {runtime} mins.";
    }
}


