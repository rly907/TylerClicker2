namespace TylerClicker2
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            scoreLbl = new Label();
            pictureBox1 = new PictureBox();
            timer1 = new System.Windows.Forms.Timer(components);
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            AutoLabel = new Label();
            BonusLabel = new Label();
            AutoBtn = new Button();
            BonusBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // scoreLbl
            // 
            scoreLbl.AutoSize = true;
            scoreLbl.Font = new Font("Segoe UI", 30F, FontStyle.Bold);
            scoreLbl.Location = new Point(274, 9);
            scoreLbl.Name = "scoreLbl";
            scoreLbl.Size = new Size(216, 67);
            scoreLbl.TabIndex = 0;
            scoreLbl.Text = "Score: 0";
            scoreLbl.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.zen_baATz79bHd;
            pictureBox1.Location = new Point(12, 9);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(256, 256);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.MouseDown += pictureBox1_MouseDown;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.IMG_4553;
            pictureBox2.Location = new Point(12, 271);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(64, 64);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.IMG_3932;
            pictureBox3.Location = new Point(12, 341);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(64, 64);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // AutoLabel
            // 
            AutoLabel.AutoSize = true;
            AutoLabel.Font = new Font("Segoe UI", 12F);
            AutoLabel.Location = new Point(82, 291);
            AutoLabel.Name = "AutoLabel";
            AutoLabel.Size = new Size(114, 28);
            AutoLabel.TabIndex = 4;
            AutoLabel.Text = "Issac Cats: 0";
            // 
            // BonusLabel
            // 
            BonusLabel.AutoSize = true;
            BonusLabel.Font = new Font("Segoe UI", 12F);
            BonusLabel.Location = new Point(82, 356);
            BonusLabel.Name = "BonusLabel";
            BonusLabel.Size = new Size(113, 28);
            BonusLabel.TabIndex = 5;
            BonusLabel.Text = "Lucy Cats: 0";
            // 
            // AutoBtn
            // 
            AutoBtn.Location = new Point(274, 79);
            AutoBtn.Name = "AutoBtn";
            AutoBtn.Size = new Size(166, 29);
            AutoBtn.TabIndex = 6;
            AutoBtn.Text = "+1 Issac Cat (Auto)";
            AutoBtn.UseVisualStyleBackColor = true;
            AutoBtn.Click += AutoBtn_Click;
            // 
            // BonusBtn
            // 
            BonusBtn.Location = new Point(274, 114);
            BonusBtn.Name = "BonusBtn";
            BonusBtn.Size = new Size(166, 29);
            BonusBtn.TabIndex = 7;
            BonusBtn.Text = "+1 Lucy Cat (Click)";
            BonusBtn.UseVisualStyleBackColor = true;
            BonusBtn.Click += BonusBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(917, 446);
            Controls.Add(BonusBtn);
            Controls.Add(AutoBtn);
            Controls.Add(BonusLabel);
            Controls.Add(AutoLabel);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(scoreLbl);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label scoreLbl;
        private PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private Label AutoLabel;
        private Label BonusLabel;
        private Button AutoBtn;
        private Button BonusBtn;
    }
}
