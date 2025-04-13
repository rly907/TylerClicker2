namespace TylerClicker2
{
    partial class Form2
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
            label1 = new Label();
            PrestigeTokens = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(192, 9);
            label1.Name = "label1";
            label1.Size = new Size(417, 38);
            label1.TabIndex = 0;
            label1.Text = "Welcome to the prestige shop !";
            // 
            // PrestigeTokens
            // 
            PrestigeTokens.AutoSize = true;
            PrestigeTokens.Font = new Font("Segoe UI", 14F);
            PrestigeTokens.Location = new Point(344, 55);
            PrestigeTokens.Name = "PrestigeTokens";
            PrestigeTokens.Size = new Size(113, 32);
            PrestigeTokens.TabIndex = 1;
            PrestigeTokens.Text = "Tokens: 0";
            PrestigeTokens.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PrestigeTokens);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label PrestigeTokens;
    }
}