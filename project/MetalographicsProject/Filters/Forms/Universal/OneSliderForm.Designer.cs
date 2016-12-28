namespace MetalographicsProject.Filters.Forms.Universal {
    partial class OneSliderForm {
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
            this.valueTrackBar = new System.Windows.Forms.TrackBar();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.applyButton = new System.Windows.Forms.Button();
            this.infoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.valueTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // valueTrackBar
            // 
            this.valueTrackBar.LargeChange = 10;
            this.valueTrackBar.Location = new System.Drawing.Point(12, 25);
            this.valueTrackBar.Maximum = 100;
            this.valueTrackBar.Minimum = -100;
            this.valueTrackBar.Name = "valueTrackBar";
            this.valueTrackBar.Size = new System.Drawing.Size(274, 45);
            this.valueTrackBar.TabIndex = 0;
            this.valueTrackBar.Scroll += new System.EventHandler(this.valueTrackBar_Scroll);
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(239, 6);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.ReadOnly = true;
            this.valueTextBox.Size = new System.Drawing.Size(39, 20);
            this.valueTextBox.TabIndex = 1;
            // 
            // applyButton
            // 
            this.applyButton.Location = new System.Drawing.Point(110, 58);
            this.applyButton.Name = "applyButton";
            this.applyButton.Size = new System.Drawing.Size(75, 23);
            this.applyButton.TabIndex = 2;
            this.applyButton.Text = "Применить";
            this.applyButton.UseVisualStyleBackColor = true;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.Location = new System.Drawing.Point(12, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(35, 13);
            this.infoLabel.TabIndex = 3;
            this.infoLabel.Text = "label1";
            // 
            // OneSliderForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(301, 93);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.valueTrackBar);
            this.Name = "OneSliderForm";
            this.Text = "ValueForm";
            ((System.ComponentModel.ISupportInitialize)(this.valueTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar valueTrackBar;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Button applyButton;
        private System.Windows.Forms.Label infoLabel;
    }
}