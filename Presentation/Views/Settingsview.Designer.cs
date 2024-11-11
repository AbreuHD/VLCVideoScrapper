namespace Presentation
{
    partial class Settingsview
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
            cbRCP = new CheckBox();
            label1 = new Label();
            tbApiKey = new TextBox();
            cbSearchAllow = new CheckBox();
            label2 = new Label();
            textBox1 = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            label3 = new Label();
            cbLanguague = new ComboBox();
            button1 = new Button();
            label4 = new Label();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // cbRCP
            // 
            cbRCP.AutoSize = true;
            cbRCP.Location = new Point(12, 23);
            cbRCP.Name = "cbRCP";
            cbRCP.Size = new Size(175, 19);
            cbRCP.TabIndex = 0;
            cbRCP.Text = "Allow Discord Rich Presence";
            cbRCP.UseVisualStyleBackColor = true;
            cbRCP.CheckedChanged += cbRCP_CheckedChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 151);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 1;
            label1.Text = "TMDB Api Key";
            // 
            // tbApiKey
            // 
            tbApiKey.Location = new Point(12, 169);
            tbApiKey.Name = "tbApiKey";
            tbApiKey.Size = new Size(207, 23);
            tbApiKey.TabIndex = 2;
            tbApiKey.TextChanged += tbApiKey_TextChanged;
            // 
            // cbSearchAllow
            // 
            cbSearchAllow.AutoSize = true;
            cbSearchAllow.Location = new Point(12, 59);
            cbSearchAllow.Name = "cbSearchAllow";
            cbSearchAllow.Size = new Size(165, 19);
            cbSearchAllow.TabIndex = 3;
            cbSearchAllow.Text = "Allow Movie/Series Search";
            cbSearchAllow.UseVisualStyleBackColor = true;
            cbSearchAllow.CheckedChanged += cbSearchAllow_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 94);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 5;
            label2.Text = "VLC Path";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 112);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(165, 23);
            textBox1.TabIndex = 4;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 255);
            label3.Name = "label3";
            label3.Size = new Size(66, 15);
            label3.TabIndex = 6;
            label3.Text = "Languague";
            // 
            // cbLanguague
            // 
            cbLanguague.FormattingEnabled = true;
            cbLanguague.Location = new Point(12, 273);
            cbLanguague.Name = "cbLanguague";
            cbLanguague.Size = new Size(207, 23);
            cbLanguague.TabIndex = 7;
            cbLanguague.SelectedIndexChanged += cbLanguague_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.Location = new Point(183, 112);
            button1.Name = "button1";
            button1.Size = new Size(36, 23);
            button1.TabIndex = 8;
            button1.Text = "...";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 205);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 9;
            label4.Text = "VLC Password";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 223);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(207, 23);
            textBox2.TabIndex = 10;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // Settingsview
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(231, 308);
            Controls.Add(textBox2);
            Controls.Add(label4);
            Controls.Add(button1);
            Controls.Add(cbLanguague);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(cbSearchAllow);
            Controls.Add(tbApiKey);
            Controls.Add(label1);
            Controls.Add(cbRCP);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Settingsview";
            Text = "Settings";
            Load += Settings_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox cbRCP;
        private Label label1;
        private TextBox tbApiKey;
        private CheckBox cbSearchAllow;
        private Label label2;
        private TextBox textBox1;
        private OpenFileDialog openFileDialog1;
        private Label label3;
        private ComboBox cbLanguague;
        private Button button1;
        private Label label4;
        private TextBox textBox2;
    }
}