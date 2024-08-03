namespace SoundCloud
{
    partial class AdminForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnEmpty = new System.Windows.Forms.Panel();
            this.pnOption = new System.Windows.Forms.Panel();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnArtists = new System.Windows.Forms.Button();
            this.btnSongs = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.pnOption.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pnEmpty);
            this.panel1.Controls.Add(this.pnOption);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 2;
            // 
            // pnEmpty
            // 
            this.pnEmpty.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnEmpty.Location = new System.Drawing.Point(0, 55);
            this.pnEmpty.Name = "pnEmpty";
            this.pnEmpty.Size = new System.Drawing.Size(800, 395);
            this.pnEmpty.TabIndex = 1;
            // 
            // pnOption
            // 
            this.pnOption.BackColor = System.Drawing.Color.DimGray;
            this.pnOption.Controls.Add(this.btnLogOut);
            this.pnOption.Controls.Add(this.btnArtists);
            this.pnOption.Controls.Add(this.btnSongs);
            this.pnOption.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnOption.Location = new System.Drawing.Point(0, 0);
            this.pnOption.Name = "pnOption";
            this.pnOption.Size = new System.Drawing.Size(800, 55);
            this.pnOption.TabIndex = 0;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.DimGray;
            this.btnLogOut.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnLogOut.Location = new System.Drawing.Point(629, 7);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(159, 42);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnArtists
            // 
            this.btnArtists.BackColor = System.Drawing.Color.DimGray;
            this.btnArtists.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArtists.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnArtists.Location = new System.Drawing.Point(214, 7);
            this.btnArtists.Name = "btnArtists";
            this.btnArtists.Size = new System.Drawing.Size(196, 42);
            this.btnArtists.TabIndex = 2;
            this.btnArtists.Text = "Artists";
            this.btnArtists.UseVisualStyleBackColor = false;
            this.btnArtists.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSongs
            // 
            this.btnSongs.AutoSize = true;
            this.btnSongs.BackColor = System.Drawing.Color.DimGray;
            this.btnSongs.Font = new System.Drawing.Font("Berlin Sans FB", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSongs.ForeColor = System.Drawing.Color.LightSalmon;
            this.btnSongs.Location = new System.Drawing.Point(12, 7);
            this.btnSongs.Name = "btnSongs";
            this.btnSongs.Size = new System.Drawing.Size(196, 42);
            this.btnSongs.TabIndex = 1;
            this.btnSongs.Text = "Songs";
            this.btnSongs.UseVisualStyleBackColor = false;
            this.btnSongs.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.panel1.ResumeLayout(false);
            this.pnOption.ResumeLayout(false);
            this.pnOption.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnOption;
        private System.Windows.Forms.Panel pnEmpty;
        private System.Windows.Forms.Button btnSongs;
        private System.Windows.Forms.Button btnArtists;
        private System.Windows.Forms.Button btnLogOut;
    }
}