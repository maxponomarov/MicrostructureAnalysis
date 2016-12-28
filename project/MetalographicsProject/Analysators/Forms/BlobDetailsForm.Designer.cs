namespace MetalographicsProject.Analysators.Forms {
    partial class BlobDetailsForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.blobsDGV = new System.Windows.Forms.DataGridView();
            this.ImageColumn = new System.Windows.Forms.DataGridViewImageColumn();
            this.PixelAreaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.blobsDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // blobsDGV
            // 
            this.blobsDGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.blobsDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.blobsDGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ImageColumn,
            this.PixelAreaColumn});
            this.blobsDGV.Location = new System.Drawing.Point(12, 12);
            this.blobsDGV.Name = "blobsDGV";
            this.blobsDGV.Size = new System.Drawing.Size(299, 456);
            this.blobsDGV.TabIndex = 0;
            this.blobsDGV.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.blobsDGV_CellClick);
            // 
            // ImageColumn
            // 
            this.ImageColumn.HeaderText = "Image";
            this.ImageColumn.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.ImageColumn.Name = "ImageColumn";
            // 
            // PixelAreaColumn
            // 
            this.PixelAreaColumn.HeaderText = "PixelArea";
            this.PixelAreaColumn.Name = "PixelAreaColumn";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(384, 9);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(55, 13);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "linkLabel1";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // BlobDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 479);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.blobsDGV);
            this.Name = "BlobDetailsForm";
            this.Text = "BlobDetailsForm";
            ((System.ComponentModel.ISupportInitialize)(this.blobsDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView blobsDGV;
        private System.Windows.Forms.DataGridViewImageColumn ImageColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PixelAreaColumn;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}