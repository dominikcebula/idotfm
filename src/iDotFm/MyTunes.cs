/*
 * iDotFm - LastFm scrobbler for iTunes
 * Dominik Cebula
 * dominikcebula@gmail.com
 * gg: 3837462
 * 
 */

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using iTunesLib;
using System.Threading;

namespace iDotFm
{
    class MyTunes
    {
        private iTunesAppClass itunes;
        private main fmain;

        public MyTunes(main fmain)
        {
            itunes = new iTunesAppClass();
            this.fmain = fmain;
        }

        private IITPlaylist GetRecentyPlayed()
        {
            IITPlaylistCollection playlists = itunes.LibrarySource.Playlists;
            return playlists.get_ItemByName("iDotFm");
        }

        public void FillGrid(DataGridView dataGrid, ProgressBar bar)
        {
            IITPlaylist recently=GetRecentyPlayed();

            if (recently == null)
                throw new Exception("No iDotFm list found in iTunes");

            dataGrid.Rows.Clear();
            bar.Maximum = recently.Tracks.Count;
            bar.Value = 0;

            foreach (IITTrack track in recently.Tracks)
            {
                bar.Value = bar.Value + 1;

                for (int j=0;j<track.PlayedCount;j++)
                    dataGrid.Rows.Add(new String[]{
                                           track.Artist,
                                           track.Album,
                                           track.Name,
                                           (track.PlayedDate.AddSeconds(j*(track.Duration/2)+1)).ToString(),
                                           track.Duration.ToString()
                                      });
            }

            dataGrid.Sort(dataGrid.Columns[3], System.ComponentModel.ListSortDirection.Ascending);

            fmain.SubmitTracks.Enabled = dataGrid.Rows.Count > 0;
        }

        public void Clear()
        {
            IITPlaylist recently = GetRecentyPlayed();

            if (recently == null)
                throw new Exception("No iDotFm list found in iTunes");

            foreach (IITTrack track in recently.Tracks)
                track.PlayedCount=0;
        }
    }
}
