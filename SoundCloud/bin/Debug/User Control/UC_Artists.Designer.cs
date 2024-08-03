namespace SoundCloud.User_Control
{
    partial class UC_Artists
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbArtist = new System.Windows.Forms.Label();
            this.lbYOO = new System.Windows.Forms.Label();
            this.pnInfo = new System.Windows.Forms.Panel();
            this.llbDetails = new System.Windows.Forms.LinkLabel();
            this.lbCategory = new System.Windows.Forms.Label();
            this.pbImg = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pnInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).BeginInit();
            this.SuspendLayout();
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
            this.txtSearch.Click += new System.EventHandler(this.txtSearch_Click);
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Font = new System.Drawing.Font("Bree Serif", 10F);
            this.dataGridView1.Location = new System.Drawing.Point(0, 40);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(446, 360);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // lbArtist
            // 
            this.lbArtist.AutoSize = true;
            this.lbArtist.Font = new System.Drawing.Font("Bree Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbArtist.Location = new System.Drawing.Point(28, 217);
            this.lbArtist.Name = "lbArtist";
            this.lbArtist.Size = new System.Drawing.Size(77, 32);
            this.lbArtist.TabIndex = 1;
            this.lbArtist.Text = "Artist";
            // 
            // lbYOO
            // 
            this.lbYOO.AutoSize = true;
            this.lbYOO.Font = new System.Drawing.Font("Bree Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbYOO.Location = new System.Drawing.Point(29, 276);
            this.lbYOO.Name = "lbYOO";
            this.lbYOO.Size = new System.Drawing.Size(63, 25);
            this.lbYOO.TabIndex = 2;
            this.lbYOO.Text = "Since: ";
            // 
            // pnInfo
            // 
            this.pnInfo.Controls.Add(this.llbDetails);
            this.pnInfo.Controls.Add(this.lbCategory);
            this.pnInfo.Controls.Add(this.lbYOO);
            this.pnInfo.Controls.Add(this.lbArtist);
            this.pnInfo.Controls.Add(this.pbImg);
            this.pnInfo.Location = new System.Drawing.Point(446, 0);
            this.pnInfo.Name = "pnInfo";
            this.pnInfo.Size = new System.Drawing.Size(354, 395);
            this.pnInfo.TabIndex = 5;
            // 
            // llbDetails
            // 
            this.llbDetails.AutoSize = true;
            this.llbDetails.Font = new System.Drawing.Font("Bree Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llbDetails.Location = new System.Drawing.Point(31, 353);
            this.llbDetails.Name = "llbDetails";
            this.llbDetails.Size = new System.Drawing.Size(82, 18);
            this.llbDetails.TabIndex = 3;
            this.llbDetails.TabStop = true;
            this.llbDetails.Text = "More Details";
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Font = new System.Drawing.Font("Bree Serif", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCategory.Location = new System.Drawing.Point(29, 301);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(95, 25);
            this.lbCategory.TabIndex = 2;
            this.lbCategory.Text = "Category: ";
            // 
            // pbImg
            // 
            this.pbImg.Location = new System.Drawing.Point(77, 14);
            this.pbImg.Name = "pbImg";
            this.pbImg.Size = new System.Drawing.Size(200, 200);
            this.pbImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbImg.TabIndex = 0;
            this.pbImg.TabStop = false;
            // 
            // UC_Artists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnInfo);
            this.Controls.Add(this.panel1);
            this.Name = "UC_Artists";
            this.Size = new System.Drawing.Size(800, 400);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pnInfo.ResumeLayout(false);
            this.pnInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pbImg;
        private System.Windows.Forms.Label lbArtist;
        private System.Windows.Forms.Label lbYOO;
        private System.Windows.Forms.Panel pnInfo;
        private System.Windows.Forms.LinkLabel llbDetails;
        private System.Windows.Forms.Label lbCategory;
    }
}
