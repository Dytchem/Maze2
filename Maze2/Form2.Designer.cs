namespace Maze2
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
            this.ScoreofRed = new System.Windows.Forms.ListBox();
            this.ScoreofBlue = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ScoreofRed
            // 
            this.ScoreofRed.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreofRed.FormattingEnabled = true;
            this.ScoreofRed.ItemHeight = 29;
            this.ScoreofRed.Location = new System.Drawing.Point(12, 42);
            this.ScoreofRed.Name = "ScoreofRed";
            this.ScoreofRed.Size = new System.Drawing.Size(381, 381);
            this.ScoreofRed.TabIndex = 0;
            // 
            // ScoreofBlue
            // 
            this.ScoreofBlue.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ScoreofBlue.FormattingEnabled = true;
            this.ScoreofBlue.ItemHeight = 29;
            this.ScoreofBlue.Location = new System.Drawing.Point(407, 42);
            this.ScoreofBlue.Name = "ScoreofBlue";
            this.ScoreofBlue.Size = new System.Drawing.Size(381, 381);
            this.ScoreofBlue.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(12, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(33, 33);
            this.button1.TabIndex = 2;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Blue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(407, 6);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 33);
            this.button2.TabIndex = 3;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ScoreofBlue);
            this.Controls.Add(this.ScoreofRed);
            this.Name = "Form2";
            this.Text = "记录";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.ListBox ScoreofRed;
        public System.Windows.Forms.ListBox ScoreofBlue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}