namespace Presentation.Views
{
    partial class Item
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
            Img = new PictureBox();
            Tittle = new Label();
            Description = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)Img).BeginInit();
            SuspendLayout();
            // 
            // Img
            // 
            Img.Location = new Point(3, 9);
            Img.Name = "Img";
            Img.Size = new Size(121, 172);
            Img.SizeMode = PictureBoxSizeMode.StretchImage;
            Img.TabIndex = 0;
            Img.TabStop = false;
            Img.Click += Img_Click;
            // 
            // Tittle
            // 
            Tittle.Font = new Font("Times New Roman", 13F, FontStyle.Bold);
            Tittle.Location = new Point(130, 0);
            Tittle.Name = "Tittle";
            Tittle.Size = new Size(170, 40);
            Tittle.TabIndex = 1;
            Tittle.Text = "Avengers";
            Tittle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Description
            // 
            Description.Location = new Point(130, 37);
            Description.Name = "Description";
            Description.ReadOnly = true;
            Description.Size = new Size(170, 144);
            Description.TabIndex = 2;
            Description.Text = "";
            Description.Click += Description_Click;
            // 
            // Item
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.AliceBlue;
            Controls.Add(Description);
            Controls.Add(Tittle);
            Controls.Add(Img);
            Cursor = Cursors.Hand;
            Name = "Item";
            Size = new Size(305, 187);
            Load += Item_Load;
            Click += Item_Click;
            MouseEnter += Item_MouseEnter;
            MouseLeave += Item_MouseLeave;
            ((System.ComponentModel.ISupportInitialize)Img).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox Img;
        private Label Tittle;
        private RichTextBox Description;
    }
}
