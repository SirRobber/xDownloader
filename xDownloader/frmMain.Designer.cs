namespace xDownloader
{
    partial class frmMain
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.listView1 = new System.Windows.Forms.ListView();
            this.tsAddUrl = new System.Windows.Forms.ToolStripButton();
            this.tsRemove = new System.Windows.Forms.ToolStripButton();
            this.tsSetting = new System.Windows.Forms.ToolStripButton();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsAddUrl,
            this.toolStripSeparator1,
            this.tsRemove,
            this.toolStripSeparator2,
            this.tsSetting});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(663, 80);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 80);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 80);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 80);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(663, 559);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // tsAddUrl
            // 
            this.tsAddUrl.AutoSize = false;
            this.tsAddUrl.Image = global::xDownloader.Properties.Resources.if_link_3280081;
            this.tsAddUrl.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsAddUrl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsAddUrl.Name = "tsAddUrl";
            this.tsAddUrl.Size = new System.Drawing.Size(75, 75);
            this.tsAddUrl.Text = "Add Url";
            this.tsAddUrl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsAddUrl.Click += new System.EventHandler(this.tsAddUrl_Click);
            // 
            // tsRemove
            // 
            this.tsRemove.AutoSize = false;
            this.tsRemove.Image = global::xDownloader.Properties.Resources.if_basket_1814090;
            this.tsRemove.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsRemove.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRemove.Name = "tsRemove";
            this.tsRemove.Size = new System.Drawing.Size(75, 75);
            this.tsRemove.Text = "Remove";
            this.tsRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsRemove.Click += new System.EventHandler(this.tsRemove_Click);
            // 
            // tsSetting
            // 
            this.tsSetting.AutoSize = false;
            this.tsSetting.Image = global::xDownloader.Properties.Resources.if_Streamline_75_185095;
            this.tsSetting.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsSetting.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsSetting.Name = "tsSetting";
            this.tsSetting.Size = new System.Drawing.Size(75, 75);
            this.tsSetting.Text = "Settings";
            this.tsSetting.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsSetting.Click += new System.EventHandler(this.tsSetting_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Url";
            this.columnHeader2.Width = 350;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "File Name";
            this.columnHeader3.Width = 106;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Size";
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Date Time";
            this.columnHeader5.Width = 79;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 639);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmMain";
            this.Text = "xDownloader";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsAddUrl;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsRemove;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsSetting;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
    }
}

