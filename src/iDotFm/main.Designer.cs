namespace iDotFm
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.TrackGridView = new System.Windows.Forms.DataGridView();
            this.Artist = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Album = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LastPlayed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pTrackSet = new System.Windows.Forms.Panel();
            this.pButtons = new System.Windows.Forms.Panel();
            this.btnAbout = new System.Windows.Forms.Button();
            this.pbSubmit = new System.Windows.Forms.ProgressBar();
            this.SubmitTracks = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.lPass = new System.Windows.Forms.Label();
            this.lUser = new System.Windows.Forms.Label();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.tbUser = new System.Windows.Forms.TextBox();
            this.pbGetTracks = new System.Windows.Forms.ProgressBar();
            this.GetTracks = new System.Windows.Forms.Button();
            this.SubmitTracksWorker = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.TrackGridView)).BeginInit();
            this.pTrackSet.SuspendLayout();
            this.pButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // TrackGridView
            // 
            this.TrackGridView.AllowUserToAddRows = false;
            this.TrackGridView.AllowUserToDeleteRows = false;
            this.TrackGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TrackGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.TrackGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.TrackGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TrackGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Artist,
            this.Album,
            this.Title,
            this.LastPlayed,
            this.Duration});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.TrackGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.TrackGridView.Location = new System.Drawing.Point(0, 0);
            this.TrackGridView.Margin = new System.Windows.Forms.Padding(0);
            this.TrackGridView.MultiSelect = false;
            this.TrackGridView.Name = "TrackGridView";
            this.TrackGridView.ReadOnly = true;
            this.TrackGridView.Size = new System.Drawing.Size(917, 450);
            this.TrackGridView.TabIndex = 0;
            this.TrackGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TrackGridView_KeyDown);
            // 
            // Artist
            // 
            this.Artist.HeaderText = "Artist";
            this.Artist.Name = "Artist";
            this.Artist.ReadOnly = true;
            // 
            // Album
            // 
            this.Album.HeaderText = "Album";
            this.Album.Name = "Album";
            this.Album.ReadOnly = true;
            // 
            // Title
            // 
            this.Title.HeaderText = "Title";
            this.Title.Name = "Title";
            this.Title.ReadOnly = true;
            // 
            // LastPlayed
            // 
            this.LastPlayed.HeaderText = "LastPlayed";
            this.LastPlayed.Name = "LastPlayed";
            this.LastPlayed.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // pTrackSet
            // 
            this.pTrackSet.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pTrackSet.Controls.Add(this.TrackGridView);
            this.pTrackSet.Location = new System.Drawing.Point(12, 150);
            this.pTrackSet.Name = "pTrackSet";
            this.pTrackSet.Size = new System.Drawing.Size(917, 450);
            this.pTrackSet.TabIndex = 1;
            // 
            // pButtons
            // 
            this.pButtons.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pButtons.Controls.Add(this.btnAbout);
            this.pButtons.Controls.Add(this.pbSubmit);
            this.pButtons.Controls.Add(this.SubmitTracks);
            this.pButtons.Controls.Add(this.btnSave);
            this.pButtons.Controls.Add(this.lPass);
            this.pButtons.Controls.Add(this.lUser);
            this.pButtons.Controls.Add(this.tbPass);
            this.pButtons.Controls.Add(this.tbUser);
            this.pButtons.Controls.Add(this.pbGetTracks);
            this.pButtons.Controls.Add(this.GetTracks);
            this.pButtons.Location = new System.Drawing.Point(9, 12);
            this.pButtons.Margin = new System.Windows.Forms.Padding(0);
            this.pButtons.Name = "pButtons";
            this.pButtons.Size = new System.Drawing.Size(920, 135);
            this.pButtons.TabIndex = 2;
            // 
            // btnAbout
            // 
            this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAbout.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnAbout.Location = new System.Drawing.Point(826, 105);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(91, 25);
            this.btnAbout.TabIndex = 11;
            this.btnAbout.Text = "About...";
            this.btnAbout.UseVisualStyleBackColor = true;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // pbSubmit
            // 
            this.pbSubmit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbSubmit.Location = new System.Drawing.Point(179, 34);
            this.pbSubmit.MarqueeAnimationSpeed = 10;
            this.pbSubmit.Name = "pbSubmit";
            this.pbSubmit.Size = new System.Drawing.Size(738, 25);
            this.pbSubmit.Step = 1;
            this.pbSubmit.TabIndex = 10;
            // 
            // SubmitTracks
            // 
            this.SubmitTracks.Enabled = false;
            this.SubmitTracks.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SubmitTracks.Location = new System.Drawing.Point(8, 34);
            this.SubmitTracks.Name = "SubmitTracks";
            this.SubmitTracks.Size = new System.Drawing.Size(165, 25);
            this.SubmitTracks.TabIndex = 9;
            this.SubmitTracks.Text = "Submit tracks";
            this.SubmitTracks.UseVisualStyleBackColor = true;
            this.SubmitTracks.Click += new System.EventHandler(this.SubmitTracks_Click);
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSave.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSave.Location = new System.Drawing.Point(243, 105);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 25);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lPass
            // 
            this.lPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lPass.AutoSize = true;
            this.lPass.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lPass.Location = new System.Drawing.Point(5, 109);
            this.lPass.Name = "lPass";
            this.lPass.Size = new System.Drawing.Size(68, 16);
            this.lPass.TabIndex = 5;
            this.lPass.Text = "Password:";
            // 
            // lUser
            // 
            this.lUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lUser.AutoSize = true;
            this.lUser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lUser.Location = new System.Drawing.Point(5, 80);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(71, 16);
            this.lUser.TabIndex = 4;
            this.lUser.Text = "Username:";
            // 
            // tbPass
            // 
            this.tbPass.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbPass.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPass.Location = new System.Drawing.Point(82, 106);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.Size = new System.Drawing.Size(155, 23);
            this.tbPass.TabIndex = 3;
            // 
            // tbUser
            // 
            this.tbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tbUser.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbUser.Location = new System.Drawing.Point(82, 77);
            this.tbUser.Name = "tbUser";
            this.tbUser.Size = new System.Drawing.Size(155, 23);
            this.tbUser.TabIndex = 2;
            // 
            // pbGetTracks
            // 
            this.pbGetTracks.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.pbGetTracks.Location = new System.Drawing.Point(179, 3);
            this.pbGetTracks.MarqueeAnimationSpeed = 10;
            this.pbGetTracks.Name = "pbGetTracks";
            this.pbGetTracks.Size = new System.Drawing.Size(738, 25);
            this.pbGetTracks.Step = 1;
            this.pbGetTracks.TabIndex = 1;
            // 
            // GetTracks
            // 
            this.GetTracks.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.GetTracks.Location = new System.Drawing.Point(6, 3);
            this.GetTracks.Name = "GetTracks";
            this.GetTracks.Size = new System.Drawing.Size(167, 25);
            this.GetTracks.TabIndex = 0;
            this.GetTracks.Text = "Get tracks from iTunes";
            this.GetTracks.UseVisualStyleBackColor = true;
            this.GetTracks.Click += new System.EventHandler(this.GetTracks_Click);
            // 
            // SubmitTracksWorker
            // 
            this.SubmitTracksWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.SubmitTracksWorker_DoWork);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 612);
            this.Controls.Add(this.pButtons);
            this.Controls.Add(this.pTrackSet);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "iDotFm";
            this.Shown += new System.EventHandler(this.main_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.TrackGridView)).EndInit();
            this.pTrackSet.ResumeLayout(false);
            this.pButtons.ResumeLayout(false);
            this.pButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView TrackGridView;
        private System.Windows.Forms.Panel pTrackSet;
        private System.Windows.Forms.Panel pButtons;
        private System.Windows.Forms.Button GetTracks;
        private System.Windows.Forms.ProgressBar pbGetTracks;
        private System.Windows.Forms.Label lPass;
        private System.Windows.Forms.Label lUser;
        public System.Windows.Forms.TextBox tbPass;
        public System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Button SubmitTracks;
        private System.Windows.Forms.DataGridViewTextBoxColumn Artist;
        private System.Windows.Forms.DataGridViewTextBoxColumn Album;
        private System.Windows.Forms.DataGridViewTextBoxColumn Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn LastPlayed;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.ComponentModel.BackgroundWorker SubmitTracksWorker;
        private System.Windows.Forms.ProgressBar pbSubmit;
        private System.Windows.Forms.Button btnAbout;
    }
}

