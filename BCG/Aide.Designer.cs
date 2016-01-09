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
            this.rtbPresentation = new System.Windows.Forms.RichTextBox();
            this.tabAide = new System.Windows.Forms.TabControl();
            this.tabPagePres = new System.Windows.Forms.TabPage();
            this.tabPageModedemploi = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabAide.SuspendLayout();
            this.tabPagePres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // rtbPresentation
            // 
            this.rtbPresentation.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rtbPresentation.Location = new System.Drawing.Point(3, 6);
            this.rtbPresentation.Name = "rtbPresentation";
            this.rtbPresentation.ReadOnly = true;
            this.rtbPresentation.Size = new System.Drawing.Size(467, 518);
            this.rtbPresentation.TabIndex = 0;
            this.rtbPresentation.Text = "";
            this.rtbPresentation.TextChanged += new System.EventHandler(this.rtbPresentation_TextChanged);
            // 
            // tabAide
            // 
            this.tabAide.Controls.Add(this.tabPagePres);
            this.tabAide.Controls.Add(this.tabPageModedemploi);
            this.tabAide.Location = new System.Drawing.Point(3, 12);
            this.tabAide.Name = "tabAide";
            this.tabAide.SelectedIndex = 0;
            this.tabAide.Size = new System.Drawing.Size(769, 600);
            this.tabAide.TabIndex = 2;
            // 
            // tabPagePres
            // 
            this.tabPagePres.Controls.Add(this.pictureBox1);
            this.tabPagePres.Controls.Add(this.rtbPresentation);
            this.tabPagePres.Location = new System.Drawing.Point(4, 22);
            this.tabPagePres.Name = "tabPagePres";
            this.tabPagePres.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePres.Size = new System.Drawing.Size(761, 574);
            this.tabPagePres.TabIndex = 0;
            this.tabPagePres.Text = "Présentation";
            this.tabPagePres.UseVisualStyleBackColor = true;
            // 
            // tabPageModedemploi
            // 
            this.tabPageModedemploi.Location = new System.Drawing.Point(4, 22);
            this.tabPageModedemploi.Name = "tabPageModedemploi";
            this.tabPageModedemploi.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageModedemploi.Size = new System.Drawing.Size(761, 574);
            this.tabPageModedemploi.TabIndex = 1;
            this.tabPageModedemploi.Text = "Mode d\'emploi";
            this.tabPageModedemploi.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BCG.Properties.Resources.matriceBCG;
            this.pictureBox1.Location = new System.Drawing.Point(476, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 219);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Aide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.tabAide);
            this.Name = "Aide";
            this.Text = "Aide";
            this.tabAide.ResumeLayout(false);
            this.tabPagePres.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbPresentation;
        private System.Windows.Forms.TabControl tabAide;
        private System.Windows.Forms.TabPage tabPagePres;
        private System.Windows.Forms.TabPage tabPageModedemploi;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}