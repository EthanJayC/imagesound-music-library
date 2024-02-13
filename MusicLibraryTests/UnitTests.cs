using Xunit;

namespace MusicLibraryTests;

public class UnitTest1
{
    [Fact]
    public void GetMusicTracks_ReturnAtleastOneTrack()
    {
        //arrange
        IMusicLibrary musicLibrary = new MusicLibrary();
        string genre = "Pop";

        //act
        var tracks = musicLibrary.GetMusicTracks(genre);


        //assert
        Assert.True(tracks.Count > 0);
    }
    [Fact]
    public void GetMusicTracks_ReturnTracksWith_MatchingGenre()
    {
        //arrange
        IMusicLibrary musicLibrary = new MusicLibrary();
        string genre = "Death metal";

        //act
        var tracks = musicLibrary.GetMusicTracks(genre);


        //assert
        Assert.All(tracks, track => Assert.Equal(genre, track.Genre));
    }

    [Fact]
    public void GetMusicTracks_ReturnNoTracks_WithZeroDuration()
    {
        //arrange
        IMusicLibrary musicLibrary = new MusicLibrary();
        string genre = "Indie Rock";

        //act
        var tracks = musicLibrary.GetMusicTracks(genre);


        //assert
        Assert.DoesNotContain(tracks, track => track.Duration == 0);
    }
}