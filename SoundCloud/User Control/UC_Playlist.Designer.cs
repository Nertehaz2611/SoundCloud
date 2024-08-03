namespace SoundCloud.User_Control
{
    partial class UC_Playlist
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.lbCurTime = new System.Windows.Forms.Label();
            this.lb = new System.Windows.Forms.Label();
            this.lbTime = new System.Windows.Forms.Label();
            this.pbNext = new System.Windows.Forms.PictureBox();
            this.pbBack = new System.Windows.Forms.PictureBox();
            this.pbPlayPause = new System.Windows.Forms.PictureBox();
            this.lbArtist = new System.Windows.Forms.Label();
            this.lbSongName = new System.Windows.Forms.Label();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.pbPause = new System.Windows.Forms.PictureBox();
            this.btnRemove = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.pnInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayPause)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPause)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(446, 360);
            this.dataGridView1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // txtSearch
            // 
            this.txtSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtSearch.Font = new System.Drawing.Font("Bree Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(0, 0);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(446, 40);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.Text = "Search";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 400);
            this.panel1.TabIndex = 4;
            // 
            // pnInfo
            // 
            this.pnInfo.Controls.Add(this.btnRemove);
            this.pnInfo.Controls.Add(this.pbPause);
            this.pnInfo.Controls.Add(this.lbCurTime);
            this.pnInfo.Controls.Add(this.lb);
            this.pnInfo.Controls.Add(this.lbTime);
            this.pnInfo.Controls.Add(this.pbNext);
            this.pnInfo.Controls.Add(this.pbBack);
            this.pnInfo.Controls.Add(this.pbPlayPause);
            this.pnInfo.Controls.Add(this.lbArtist);
            this.pnInfo.Controls.Add(this.lbSongName);
            this.pnInfo.Controls.Add(this.pbImg);
            this.pnInfo.Location = new System.Drawing.Point(446, 0);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(354, 400);
            this.pnInfo.TabIndex = 5;
            this.pnInfo.Paint += new System.Windows.Forms.PaintEventHandler(this.pnInfo_Paint);
            // 
            // lbCurTime
            // 
            this.lbCurTime.AutoSize = true;
            this.lbCurTime.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCurTime.Location = new System.Drawing.Point(116, 351);
            this.lbCurTime.Name = "lbCurTime";
            this.lbCurTime.Size = new System.Drawing.Size(50, 22);
            this.lbCurTime.TabIndex = 5;
            this.lbCurTime.Text = "00:00";
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(172, 351);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(14, 22);
            this.lb.TabIndex = 5;
            this.lb.Text = "|";
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Microsoft Tai Le", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTime.Location = new System.Drawing.Point(192, 351);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(50, 22);
            this.lbTime.TabIndex = 5;
            this.lbTime.Text = "00:00";
            // 
            // pbNext
            // 
            this.pbNext.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbNext.Image = global::SoundCloud.Properties.Resources.next;
            this.pbNext.Location = new System.Drawing.Point(270, 291);
            this.pbNext.Name = "pbNext";
            this.pbNext.Size = new System.Drawing.Size(40, 40);
            this.pbNext.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNext.TabIndex = 3;
            this.pbNext.TabStop = false;
            // 
            // pbBack
            // 
            this.pbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbBack.Image = global::SoundCloud.Properties.Resources.back;
            this.pbBack.Location = new System.Drawing.Point(48, 291);
            this.pbBack.Name = "pbBack";
            this.pbBack.Size = new System.Drawing.Size(40, 40);
            this.pbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBack.TabIndex = 3;
            this.pbBack.TabStop = false;
            // 
            // pbPlayPause
            // 
            this.pbPlayPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPlayPause.Image = global::SoundCloud.Properties.Resources.play;
            this.pbPlayPause.Location = new System.Drawing.Point(192, 281);
            this.pbPlayPause.Name = "pbPlayPause";
            this.pbPlayPause.Size = new System.Drawing.Size(50, 50);
            this.pbPlayPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPlayPause.TabIndex = 3;
            this.pbPlayPause.TabStop = false;
            // 
            // lbArtist
            // 
            this.lbArtist.AutoSize = true;
            this.lbArtist.Font = new System.Drawing.Font("Bree Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArtist.Location = new System.Drawing.Point(29, 249);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(59, 25);
            this.lbArtist.TabIndex = 2;
            this.lbArtist.Text = "Artist";
            // 
            // lbSongName
            // 
            this.lbSongName.AutoSize = true;
            this.lbSongName.Font = new System.Drawing.Font("Bree Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSongName.Location = new System.Drawing.Point(28, 217);
            this.lbSongName.Name = "lbSongName";
            this.lbSongName.Size = new System.Drawing.Size(147, 32);
            this.lbSongName.TabIndex = 1;
            this.lbSongName.Text = "Song\'s name";
            // 
            // pbImg
            // 
            this.pbImg.Location = new System.Drawing.Point(77, 14);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(200, 200);
            this.pbImg.TabIndex = 0;
            this.pbImg.TabStop = false;
            // 
            // pbPause
            // 
            this.pbPause.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pbPause.Image = global::SoundCloud.Properties.Resources.pause;
            this.pbPause.Location = new System.Drawing.Point(120, 281);
            this.pbPause.Name = "pbPause";
            this.pbPause.Size = new System.Drawing.Size(50, 50);
            this.pbPause.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbPause.TabIndex = 6;
            this.pbPause.TabStop = false;
            // 
            // btnRemove
            // 
            this.btnRemove.BackColor = System.Drawing.Color.Salmon;
            this.btnRemove.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.BlanchedAlmond;
            this.btnRemove.Location = new System.Drawing.Point(213, 191);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(64, 23);
            this.btnRemove.TabIndex = 7;
            this.btnRemove.Text = "Remove";
            this.btnRemove.UseVisualStyleBackColor = false;
            // 
            // UC_Playlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnInfo);
            this.Name = "UC_Playlist";
            this.Size = new System.Drawing.Size(800, 400);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayPause)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPause)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.Label lbCurTime;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.PictureBox pbNext;
        private System.Windows.Forms.PictureBox pbBack;
        private System.Windows.Forms.PictureBox pbPlayPause;
        private System.Windows.Forms.Label lbArtist;
        private System.Windows.Forms.Label lbSongName;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.PictureBox pbPause;
        private System.Windows.Forms.Button btnRemove;
    }
}
