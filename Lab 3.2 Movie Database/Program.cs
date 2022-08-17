using System.Threading.Tasks;
// Create class with two memebers
//create the contructor
// new list to store at least 10 movies
List<Film> filmList = new List<Film>();
filmList.Add(new Film("The Lord of the Rings: The Fellowship of the Ring", "Fantasy", 2001));
filmList.Add(new Film("The Lord of the Rings: The Two Towers", "Fantasy", 2002));
filmList.Add(new Film("The Lord of the Rings: Return of the King", "Fantasy", 2003));
filmList.Add(new Film("A Bugs Life", "Animation", 1998));
filmList.Add(new Film("Saving Private Ryan", "Action", 1998));
filmList.Add(new Film("Hereditary", "Horror", 2018));
filmList.Add(new Film("The Exorcist", "Horror", 1973));
filmList.Add(new Film("Shrek", "Animation", 2001));
filmList.Add(new Film("Predator", "Action", 1987));
filmList.Add(new Film("The Fast and the Furious", "Action", 2001));
filmList.Add(new Film("Spider-Man: Into the Spider-Verse", "Animation", 2018));
filmList.Add(new Film("The Evil Dead", "Horror", 1981));

Menu();
Thread.Sleep(1000);
Console.WriteLine($"There are currently {filmList.Count} titles in this library. \n");
Console.Write("Please choose a genre you are interested in:  ");
string choice = Console.ReadLine().ToLower();
Film categoryFound = FindCategory(filmList, choice);


if (categoryFound == null)
{
    Console.WriteLine("We don't have that category.");
}
else
{
    foreach (Film catergoryFound in filmList)
    {
        Console.WriteLine(categoryFound.title);
    }
}





static Film FindCategory(List<Film> _filmList, string _category)
{
    Film categoryFound = null;
    foreach (Film next in _filmList)
    {
        
        if (next.category.ToLower()  == _category.ToLower())
        {
            return next;
        }
    }
    return null;
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
    public int year;

    public Film(string _title, string _category, int _year)
    {
        title = _title;
        category = _category;
        year = _year;
    }



    public override string ToString()
    {
        return $"\"{title}\" {category} ({year})";
    }
}


