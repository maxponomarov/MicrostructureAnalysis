namespace MetalographicsProject.Filters.Forms {
    partial class ExtractChannelForm {
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
            this.modeListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.applyChannelButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // modeListBox
            // 
            this.modeListBox.FormattingEnabled = true;
            this.modeListBox.Location = new System.Drawing.Point(15, 25);
            this.modeListBox.Name = "modeListBox";
            this.modeListBox.Size = new System.Drawing.Size(170, 95);
            this.modeListBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Канал";
            // 
            // applyChannelButton
            // 
            this.applyChannelButton.Location = new System.Drawing.Point(62, 126);
            this.applyChannelButton.Name = "applyChannelButton";
            this.applyChannelButton.Size = new System.Drawing.Size(75, 23);
            this.applyChannelButton.TabIndex = 2;
            this.applyChannelButton.Text = "Применить";
            this.applyChannelButton.UseVisualStyleBackColor = true;
            this.applyChannelButton.Click += new System.EventHandler(this.applyChannelButton_Click);
            // 
            // ExtractChannelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 164);
            this.Controls.Add(this.applyChannelButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.modeListBox);
            this.Name = "ExtractChannelForm";
            this.Text = "ExtractChannelForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox modeListBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button applyChannelButton;
    }
}