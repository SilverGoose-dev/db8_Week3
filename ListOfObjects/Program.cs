List<Song> playlist = new List<Song>();

Song song1 = new Song("The Beatles", "I want to hold your hand", "Rock", 1964);
playlist.Add(song1);

Song song2 = new Song("Pink Floydd", "Comfortably Numb", "Progressive", 1979);
playlist.Add(song2);

Song song3 = new Song("Britney Spears", "Toxic", "Pop", 2003);
playlist.Add(song3);

Console.WriteLine("Here are your songs!");
foreach (Song song in playlist)
{
    Console.WriteLine(song.title);
}

Console.WriteLine();
Console.Write("Which song do you want more details on: ");
string mySong = Console.ReadLine();



class Song
{
    public string artist;
    public string title;
    public string genre;
    public int year;

    public Song(string _artist, string _title, string _genre, int _year)
    {
        artist = _artist;
        title = _title;
        genre = _genre;
        year = _year;
    }

    public override string ToString()
    {
        return $"\"{title}\" by {artist}, from {year} ({genre})";
    }
}