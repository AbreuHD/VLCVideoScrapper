namespace Presentation.Views
{
    partial class ItemSelector
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
            flowLayoutPanel1 = new FlowLayoutPanel();
            tbSearch = new TextBox();
            button1 = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Location = new Point(12, 34);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(326, 570);
            flowLayoutPanel1.TabIndex = 1;
            // 
            // tbSearch
            // 
            tbSearch.Location = new Point(3, 5);
            tbSearch.Name = "tbSearch";
            tbSearch.Size = new Size(236, 23);
            tbSearch.TabIndex = 2;
            tbSearch.KeyDown += tbSearch_KeyDown;
            // 
            // button1
            // 
            button1.Location = new Point(245, 5);
            button1.Name = "button1";
            button1.Size = new Size(52, 23);
            button1.TabIndex = 3;
            button1.Text = "Search";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkBox1
            // 
            checkBox1.Appearance = Appearance.Button;
            checkBox1.AutoSize = true;
            checkBox1.Cursor = Cursors.Hand;
            checkBox1.Location = new Point(296, 4);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(50, 25);
            checkBox1.TabIndex = 0;
            checkBox1.Text = "Movie";
            checkBox1.UseVisualStyleBackColor = true;
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // ItemSelector
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(350, 616);
            Controls.Add(checkBox1);
            Controls.Add(button1);
            Controls.Add(tbSearch);
            Controls.Add(flowLayoutPanel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ItemSelector";
            Text = "ItemSelector";
            Load += ItemSelector_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private FlowLayoutPanel flowLayoutPanel1;
        private TextBox tbSearch;
        private Button button1;
        private CheckBox checkBox1;
    }
}