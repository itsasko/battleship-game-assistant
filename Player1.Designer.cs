namespace Battleship
{
    partial class Player1
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
            this.tabControlPlayer1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabControlPlayer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlPlayer1
            // 
            this.tabControlPlayer1.Alignment = System.Windows.Forms.TabAlignment.Left;
            this.tabControlPlayer1.Controls.Add(this.tabPage1);
            this.tabControlPlayer1.Controls.Add(this.tabPage2);
            this.tabControlPlayer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlPlayer1.Location = new System.Drawing.Point(0, 0);
            this.tabControlPlayer1.Multiline = true;
            this.tabControlPlayer1.Name = "tabControlPlayer1";
            this.tabControlPlayer1.SelectedIndex = 0;
            this.tabControlPlayer1.Size = new System.Drawing.Size(927, 908);
            this.tabControlPlayer1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(23, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(900, 900);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "You";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(23, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(900, 900);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Opponent";
            this.tabPage2.UseVisualStyleBackColor = true;
            this.tabPage2.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // Player1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(927, 908);
            this.Controls.Add(this.tabControlPlayer1);
            this.Name = "Player1";
            this.Text = "Player1";
            this.tabControlPlayer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlPlayer1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}