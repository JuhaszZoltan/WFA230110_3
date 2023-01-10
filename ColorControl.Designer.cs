namespace WFA230110_3
{
    partial class ColorControl
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
            this.lblRed = new System.Windows.Forms.Label();
            this.tbRed = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGreen = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.tbBlue = new System.Windows.Forms.TrackBar();
            this.btnApply = new System.Windows.Forms.Button();
            this.pbColorPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRed
            // 
            this.lblRed.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblRed.ForeColor = System.Drawing.Color.Red;
            this.lblRed.Location = new System.Drawing.Point(3, 16);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(106, 56);
            this.lblRed.TabIndex = 0;
            this.lblRed.Text = "RED:";
            this.lblRed.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbRed
            // 
            this.tbRed.Location = new System.Drawing.Point(115, 16);
            this.tbRed.Maximum = 255;
            this.tbRed.Name = "tbRed";
            this.tbRed.Size = new System.Drawing.Size(322, 56);
            this.tbRed.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(3, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "GREEN:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbGreen
            // 
            this.tbGreen.Location = new System.Drawing.Point(115, 78);
            this.tbGreen.Maximum = 255;
            this.tbGreen.Name = "tbGreen";
            this.tbGreen.Size = new System.Drawing.Size(322, 56);
            this.tbGreen.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(3, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 56);
            this.label2.TabIndex = 0;
            this.label2.Text = "BLUE:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tbBlue
            // 
            this.tbBlue.Location = new System.Drawing.Point(115, 140);
            this.tbBlue.Maximum = 255;
            this.tbBlue.Name = "tbBlue";
            this.tbBlue.Size = new System.Drawing.Size(322, 56);
            this.tbBlue.TabIndex = 1;
            // 
            // btnApply
            // 
            this.btnApply.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnApply.Location = new System.Drawing.Point(3, 202);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(583, 88);
            this.btnApply.TabIndex = 2;
            this.btnApply.Text = "Apply";
            this.btnApply.UseVisualStyleBackColor = true;
            // 
            // pbColorPreview
            // 
            this.pbColorPreview.BackColor = System.Drawing.Color.White;
            this.pbColorPreview.Location = new System.Drawing.Point(443, 16);
            this.pbColorPreview.Name = "pbColorPreview";
            this.pbColorPreview.Size = new System.Drawing.Size(134, 180);
            this.pbColorPreview.TabIndex = 3;
            this.pbColorPreview.TabStop = false;
            // 
            // ColorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pbColorPreview);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.tbBlue);
            this.Controls.Add(this.tbGreen);
            this.Controls.Add(this.tbRed);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblRed);
            this.Name = "ColorControl";
            this.Size = new System.Drawing.Size(589, 293);
            ((System.ComponentModel.ISupportInitialize)(this.tbRed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbGreen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbBlue)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbColorPreview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblRed;
        private TrackBar tbRed;
        private Label label1;
        private TrackBar tbGreen;
        private Label label2;
        private TrackBar tbBlue;
        private Button btnApply;
        private PictureBox pbColorPreview;
    }
}
