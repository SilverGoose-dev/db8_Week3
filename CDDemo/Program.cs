// First CompactDisc

CompactDisc thewall = new CompactDisc("Pink Floyd", "Rock", 80);
Console.WriteLine(thewall);

thewall.Songs.Add("In the Flesh?");
thewall.Songs.Add("The Thin Ice");
thewall.Songs.Add("Another Brick in the Wall, Part 1");
thewall.Songs.Add("The Happiest Days of Our Lives");
thewall.Songs.Add("Another Brick in the Wall, Part 2");

foreach (string song in thewall.Songs)
{
    Console.WriteLine(song);
}

Console.WriteLine($"This album has {thewall.Songcount()} songs on it.");

//Let's practice copying -- we actually have the same object referenced by two variables 

CompactDisc another = thewall;
Console.WriteLine(another.Artist);






class CompactDisc
{
    public string Artist;
    public string Genre;
    public int Duration;
    public List<string> Songs;
    

    public CompactDisc(string _artist, string _genre, int _duration)
    {
        Artist = _artist;
        Genre = _genre;
        Duration = _duration;
        Songs = new List<string>();
       
    }

    public int Songcount()
    {
        return Songs.Count;
    }

    public override string ToString()
    {
        return $"Artist: {Artist}  Genre: {Genre}  Duration: {Duration} minutes";
    }
}