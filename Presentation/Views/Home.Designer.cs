namespace Presentation
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tbLink = new TextBox();
            label1 = new Label();
            btnSubmit = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tbLink
            // 
            tbLink.BorderStyle = BorderStyle.FixedSingle;
            tbLink.Cursor = Cursors.IBeam;
            tbLink.Location = new Point(12, 58);
            tbLink.Name = "tbLink";
            tbLink.Size = new Size(344, 23);
            tbLink.TabIndex = 0;
            tbLink.KeyDown += tbLink_KeyDown;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 40);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 1;
            label1.Text = "Video Link";
            // 
            // btnSubmit
            // 
            btnSubmit.Cursor = Cursors.Hand;
            btnSubmit.Location = new Point(144, 108);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(75, 23);
            btnSubmit.TabIndex = 4;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Cursor = Cursors.Hand;
            pictureBox1.Image = Properties.Resources.configuration;
            pictureBox1.Location = new Point(324, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(32, 31);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 171);
            Controls.Add(pictureBox1);
            Controls.Add(btnSubmit);
            Controls.Add(label1);
            Controls.Add(tbLink);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Home";
            Text = "Video Scrapper";
            FormClosed += Home_FormClosed_1;
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbLink;
        private Label label1;
        private Button btnSubmit;
        private PictureBox pictureBox1;
    }
}
