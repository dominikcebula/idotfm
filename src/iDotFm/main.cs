/*
 * iDotFm - LastFm scrobbler for iTunes
 * Dominik Cebula
 * dominikcebula@gmail.com
 * gg: 3837462
 * 
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace iDotFm
{
    public partial class main : Form
    {
        private Config conf = new Config();

        public static DebugForm debugForm = new DebugForm();

        public main()
        {
            InitializeComponent();
        }

        private void GetTracks_Click(object sender, EventArgs e)
        {
            try
            {
                SubmitTracks.Enabled = false;
                MyTunes myTunes = new MyTunes(this);
                myTunes.FillGrid(TrackGridView, pbGetTracks);

                if (TrackGridView.Rows.Count>0)
                    MessageBox.Show(TrackGridView.Rows.Count+" track(s) trasnferred from iTunes", "Information",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                else
                    MessageBox.Show("No tracks with playcount greater than 0 found in iDotFm list.", "Information",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error getting tracks from iTunes: " + exp.Message, "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void main_Shown(object sender, EventArgs e)
        {
            this.Text += " " + Application.ProductVersion;

            try
            {
                conf.LoadSettings();
                conf.ToForm(this);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error loading config file: " + exp.Message, "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                conf.FromForm(this);
                conf.SaveSettings();

                MessageBox.Show("Config saved.", "Information",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error while saving config: " + exp.Message, "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void SubmitTracks_Click(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            SubmitTracksWorker.RunWorkerAsync();
        }

        private void SubmitTracksWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            if (TrackGridView.Rows.Count == 0)
            {
                MessageBox.Show("No songs to submit, Get tracks from iTunes first.", "Information",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
                return;
            }

            try
            {
                MyScrobbler scrob = new MyScrobbler(this, "idf", Application.ProductVersion, conf.User, conf.MD5Pass);
                scrob.Submit(TrackGridView, pbSubmit);
                conf.ToForm(this);
                conf.SaveSettings();

                MessageBox.Show("Tracks submitted.", "Information",
                                 MessageBoxButtons.OK,
                                 MessageBoxIcon.Information);
            }
            catch (Exception exp)
            {
                MessageBox.Show("Error while submitting songs: " + exp.Message, "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }

            CheckForIllegalCrossThreadCalls = true;
        }

        private void TrackGridView_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt && e.KeyCode.ToString() == "D")
                debugForm.ShowDialog();
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            new AboutBox().ShowDialog();
        }
    }
}
