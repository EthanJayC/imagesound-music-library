public class MusicTrack
{
    //The class that my MusicLibrary and interface use to create the lists with, I prefer using SOLID principles, I.e single use classes
    public string? Artist { get; set; }
    public string? Title { get; set; }
    public string? Genre { get; set; }
    public int Duration { get; set; }

    //NOTE: I made the strings nullable to stop vscode throwing a wobbly in compile time
}