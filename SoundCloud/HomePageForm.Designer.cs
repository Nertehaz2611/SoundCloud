namespace SoundCloud
{
    partial class HomePageForm
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
            this.btnPlaylist = new System.Windows.Forms.Button();
            this.pnOption = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSongs = new System.Windows.Forms.Button();
            this.btnArtists = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.pnEmpty = new System.Windows.Forms.Panel();
            this.pnOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPlaylist
            // 
            this.btnPlaylist.BackColor = System.Drawing.Color.DimGray;
            this.btnPlaylist.Enabled = false;
            this.btnPlaylist.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaylist.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnPlaylist.Location = new System.Drawing.Point(407, 3);
            this.btnPlaylist.Name = "btnPlaylist";
            this.btnPlaylist.Size = new System.Drawing.Size(212, 42);
            this.btnPlaylist.TabIndex = 1;
            this.btnPlaylist.Text = "Playlist";
            this.btnPlaylist.UseVisualStyleBackColor = false;
            this.btnPlaylist.Visible = false;
            this.btnPlaylist.Click += new System.EventHandler(this.btnPlaylist_Click);
            // 
            // pnOption
            // 
            this.pnOption.BackColor = System.Drawing.Color.DimGray;
            this.pnOption.Controls.Add(this.btnSongs);
            this.pnOption.Controls.Add(this.btnArtists);
            this.pnOption.Controls.Add(this.btnPlaylist);
            this.pnOption.Controls.Add(this.btnLogOut);
            this.pnOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnOption.Location = new System.Drawing.Point(0, 0);
            this.pnOption.Name = "pnOption";
            this.pnOption.Size = new System.Drawing.Size(800, 50);
            this.pnOption.TabIndex = 3;
            // 
            // btnSongs
            // 
            this.btnSongs.AutoSize = true;
            this.btnSongs.BackColor = System.Drawing.Color.DimGray;
            this.btnSongs.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSongs.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnSongs.Location = new System.Drawing.Point(3, 3);
            this.btnSongs.Name = "btnSongs";
            this.btnSongs.Size = new System.Drawing.Size(196, 42);
            this.btnSongs.TabIndex = 0;
            this.btnSongs.Text = "Songs";
            this.btnSongs.UseVisualStyleBackColor = false;
            this.btnSongs.Click += new System.EventHandler(this.btnSongs_Click);
            // 
            // btnArtists
            // 
            this.btnArtists.BackColor = System.Drawing.Color.DimGray;
            this.btnArtists.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtists.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnArtists.Location = new System.Drawing.Point(205, 3);
            this.btnArtists.Name = "btnArtists";
            this.btnArtists.Size = new System.Drawing.Size(196, 42);
            this.btnArtists.TabIndex = 1;
            this.btnArtists.Text = "Artists";
            this.btnArtists.UseVisualStyleBackColor = false;
            this.btnArtists.Click += new System.EventHandler(this.btnArtists_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.DimGray;
            this.btnLogOut.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnLogOut.Location = new System.Drawing.Point(625, 3);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(159, 42);
            this.btnLogOut.TabIndex = 1;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // pnEmpty
            // 
            this.pnEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnEmpty.Location = new System.Drawing.Point(0, 50);
            this.pnEmpty.Name = "pnEmpty";
            this.pnEmpty.Size = new System.Drawing.Size(800, 400);
            this.pnEmpty.TabIndex = 4;
            // 
            // HomePageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnEmpty);
            this.Controls.Add(this.pnOption);
            this.Name = "HomePageForm";
            this.Text = "HomePageForm";
            this.pnOption.ResumeLayout(false);
            this.pnOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnPlaylist;
        private System.Windows.Forms.FlowLayoutPanel pnOption;
        private System.Windows.Forms.Button btnSongs;
        private System.Windows.Forms.Button btnArtists;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Panel pnEmpty;
    }
}