## Files - Directories Structure

 - Default directory: Music Folder
 - .mp3 files (tracks) in the default directory
 - Playlists Folder inside the default directory, includes .wpl files (lists of tracks)

## Data Sources

 - On disks
 - Streaming (from other servers, could be downloaded and stored on disks)

## User Controls

**1. AnimateLabel**

 - A label which can move its text forward and backward repeatedly
 
 **2. FolderLocation**
 
 - ???

**3. InputForm**

 - Get the input values then return

**4. MediaController**

 - Load MediaItem(s) (tracks on disks)
 - Load Streaming(s) (tracks from other servers)
 - Skip/Back 10s
 - Forward/Backward tracks
 - Volume up/down
 - Specify the playing track's position

**5. TrackItem**

 - Load tracks data from disks then display (basic information)
 - Click to play the track (pass its URL to MediaController)
 - etc.

**6. TrackLyrics**

 - Display the playing track's lyrics if there is one

**7. MediaVisualizer**

 - Display sound waves using the playing's track rhythm

**8. PlaylistItem**

 - Load playlists data from disks then display (their names and there corresponding tracks)
 - etc.

**9. IntegrationSearchBox**

 - Search the track's name on the other servers (the client interface of the server must be an Integration kind - implemented using the interface IIntegration)
 - Able to switch among different IIntegration(s)

**10. IntegrationSearchResult**

