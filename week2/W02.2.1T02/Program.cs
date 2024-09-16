class Program
{
    public static void Main()
    {
        Artist artist = new Artist("Rihanna");
        Artist artist2 = new Artist("Unknown");

        Song song = artist.WriteSong("Umbrella");
        Console.WriteLine(song.Info());

        artist.Name = "Robyn Rihanna Fenty";
        Console.WriteLine(song.Info());
    }
}