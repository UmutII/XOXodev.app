
namespace Deneme
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.AIaction = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // b1
            // 
            this.b1.Location = new System.Drawing.Point(12, 12);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(93, 56);
            this.b1.TabIndex = 0;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.HumanPlayer);
            // 
            // b2
            // 
            this.b2.Location = new System.Drawing.Point(111, 12);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(93, 56);
            this.b2.TabIndex = 1;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.HumanPlayer);
            // 
            // b3
            // 
            this.b3.Location = new System.Drawing.Point(210, 12);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(93, 56);
            this.b3.TabIndex = 2;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.HumanPlayer);
            // 
            // b4
            // 
            this.b4.Location = new System.Drawing.Point(12, 74);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(93, 56);
            this.b4.TabIndex = 3;
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.HumanPlayer);
            // 
            // b5
            // 
            this.b5.Location = new System.Drawing.Point(111, 74);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(93, 56);
            this.b5.TabIndex = 4;
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.HumanPlayer);
            // 
            // b6
            // 
            this.b6.Location = new System.Drawing.Point(210, 74);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(93, 56);
            this.b6.TabIndex = 5;
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.HumanPlayer);
            // 
            // b7
            // 
            this.b7.Location = new System.Drawing.Point(12, 136);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(93, 56);
            this.b7.TabIndex = 6;
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.HumanPlayer);
            // 
            // b8
            // 
            this.b8.Location = new System.Drawing.Point(111, 136);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(93, 56);
            this.b8.TabIndex = 7;
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.HumanPlayer);
            // 
            // b9
            // 
            this.b9.Location = new System.Drawing.Point(210, 136);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(93, 56);
            this.b9.TabIndex = 8;
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.HumanPlayer);
            // 
            // AIaction
            // 
            this.AIaction.Interval = 500;
            this.AIaction.Tick += new System.EventHandler(this.AI);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 225);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Timer AIaction;
    }
}

