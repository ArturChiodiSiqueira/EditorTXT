namespace EditorTXT
{
    partial class FormImage
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
            picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)picBox).BeginInit();
            SuspendLayout();
            // 
            // picBox
            // 
            picBox.Location = new System.Drawing.Point(0, 0);
            picBox.Name = "picBox";
            picBox.Size = new System.Drawing.Size(780, 550);
            picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            picBox.TabIndex = 1;
            picBox.TabStop = false;
            picBox.Click += picBox_Click;
            // 
            // FormImage
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new System.Drawing.Size(782, 553);
            Controls.Add(picBox);
            Name = "FormImage";
            Text = "Imagem";
            ((System.ComponentModel.ISupportInitialize)picBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox picBox;
    }
}