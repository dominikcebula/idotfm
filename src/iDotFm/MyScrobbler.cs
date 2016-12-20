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
using Lastfm;
using Lastfm.Scrobbling;
using System.IO;

namespace iDotFm
{
    class MyScrobbler
    {
        private String clientID;
        private String versionID;
        private String user;
        private String md5pass;
        private main fmain;

        public MyScrobbler(main fmain, String clientID, String versionID, String user, String md5pass)
        {
            this.clientID = clientID;
            this.versionID = versionID;
            this.user = user;
            this.md5pass = md5pass;
            this.fmain = fmain;
        }

        public void Submit(DataGridView tracks, ProgressBar bar) 
        {
            if (user=="" || md5pass=="")
                throw new Exception("Write down and save your login/password first");

            String artist, album, title;
            DateTime dateStarted;
            TimeSpan duration;
            Entry entry;
            int s = 0;

            Connection conn = new Connection(clientID, versionID, user, md5pass);
            ScrobbleManager scrobb = new ScrobbleManager(conn, Config.GetAppPath());

            File.Delete(scrobb.CacheDir + scrobb.cacheFileName);

            bar.Maximum = tracks.Rows.Count+1;
            bar.Value = 0;

            foreach (DataGridViewRow row in tracks.Rows) 
            {
                bar.Value = bar.Value + 1;
                bar.Refresh();

                artist=row.Cells[0].Value.ToString();
                album = row.Cells[1].Value.ToString();
                title=row.Cells[2].Value.ToString();
                dateStarted=DateTime.Parse(row.Cells[3].Value.ToString()).ToUniversalTime();
                duration=TimeSpan.FromSeconds(Double.Parse(row.Cells[4].Value.ToString()));

                entry = new Entry(artist, title, dateStarted, PlaybackSource.User, duration, ScrobbleMode.Played);
                entry.Album = album;
                scrobb.Queue(entry);
                s++;

                if (s > 25)
                {
                    scrobb.Submit();
                    s = 0;
                }
            }

            if (s>0)
                scrobb.Submit();

            bar.Value = bar.Value + 1;

            MyTunes mytunes = new MyTunes(fmain);
            mytunes.Clear();

            fmain.SubmitTracks.Enabled = false;
        }
    }
}
