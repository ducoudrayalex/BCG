namespace BCG
{
    partial class Aide
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
            this.rtbAide = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // rtbAide
            // 
            this.rtbAide.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.rtbAide.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbAide.Location = new System.Drawing.Point(13, 13);
            this.rtbAide.Name = "rtbAide";
            this.rtbAide.ReadOnly = true;
            this.rtbAide.Size = new System.Drawing.Size(759, 536);
            this.rtbAide.TabIndex = 0;
            this.rtbAide.Text = "";
            // 
            // Aide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.rtbAide);
            this.Name = "Aide";
            this.Text = "Aide";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbAide;
    }
}