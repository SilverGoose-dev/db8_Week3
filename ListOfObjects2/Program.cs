List<Song> playlist = new List<Song>();

// We don't need to keep making a new variable after we put the object in the list. 
Song song1 = new Song("The Beatles", "I want to hold your hand", "Rock", 1964);
playlist.Add(song1);

// Let's just re-use the song1 variable
song1 = new Song("Pink Floydd", "Comfortably Numb", "Progressive", 1979);
playlist.Add(song1);

song1 = new Song("Britney Spears", "Toxic", "Pop", 2003);
playlist.Add(song1);

//In fact, we don't need a variable ata ll. We can just create the object and hand its address right over to the list's add method. 
playlist.Add(new Song("Dave Brubeck", "Take 5", "Jazz", 1959));

Console.WriteLine("Here is your playlist:  ");

foreach  (Song song in playlist)
{
    Console.WriteLine(song.title);
}



Console.Write("Which song title do you want more info on:  ");
string mysong = Console.ReadLine().ToLower();


Song found = FindSong(playlist, mysong);


if (found == null)
{
    Console.WriteLine("Sorry we don't have that song.");
}
else
{
    Console.WriteLine(found);
}





static Song FindSong(List<Song> theList, string theTitle)
{
    Song found = null;
    foreach (Song song in theList)
    {
        if (song.title.ToLower() == theTitle.ToLower())
        {
            return song;
        }
    }
    return null;
}

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