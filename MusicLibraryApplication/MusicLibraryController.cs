using Microsoft.AspNetCore.Mvc;

public class MusicController : Controller
{
    private readonly IMusicLibrary _musicLibrary;

    public MusicController(IMusicLibrary musicLibrary)
    {
        _musicLibrary = musicLibrary;
    }

    //This action should display the music library view
    public IActionResult MusicLibrary()
    {
        var tracks = _musicLibrary.GetMusicTracks("Indie Rock");
        return View(tracks);
    }
}