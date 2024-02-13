using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;


public class MusicLibrary : IMusicLibrary
{
    //Some mock data
    private List<MusicTrack> tracks = new List<MusicTrack>{
        new MusicTrack { Artist = "Sam Fender", Title = "Will we talk?", Genre = "Indie Rock", Duration = 180},
        new MusicTrack { Artist = "In Flames", Title = "Bullet Ride", Genre = "Death metal", Duration = 420},
        new MusicTrack { Artist = "Michael Jackson", Title = "Smooth Criminal", Genre = "Pop", Duration = 240},
    };

    public List<MusicTrack> GetMusicTracks(string genre)
    {
        List<MusicTrack> validateTracks = new List<MusicTrack>();

        foreach (var track in tracks)
        {
            if (track.Genre == genre && track.Duration > 0)
            {
                validateTracks.Add(track);
                Console.WriteLine("Track: " + track.Title + " added");
            }
            Console.WriteLine("Duration and/or genre is invalid");
        }
        return validateTracks;
    }
}