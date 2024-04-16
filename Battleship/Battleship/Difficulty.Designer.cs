namespace Battleship
{
    partial class Difficulty
    {
        
        private System.ComponentModel.IContainer components = null;

        name="disposing"
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
            this.ezBtn = new System.Windows.Forms.Button();
            this.mdBtn = new System.Windows.Forms.Button();
            this.hdBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ezBtn
            // 
            this.ezBtn.Location = new System.Drawing.Point(29, 42);
            this.ezBtn.Margin = new System.Windows.Forms.Padding(4);
            this.ezBtn.Name = "ezBtn";
            this.ezBtn.Size = new System.Drawing.Size(379, 47);
            this.ezBtn.TabIndex = 1;
            this.ezBtn.Text = "Facil";
            this.ezBtn.UseVisualStyleBackColor = true;
            this.ezBtn.Click += new System.EventHandler(this.ezBtn_Click);
            // 
            // mdBtn
            // 
            this.mdBtn.Location = new System.Drawing.Point(29, 123);
            this.mdBtn.Margin = new System.Windows.Forms.Padding(4);
            this.mdBtn.Name = "mdBtn";
            this.mdBtn.Size = new System.Drawing.Size(379, 47);
            this.mdBtn.TabIndex = 1;
            this.mdBtn.Text = "Medio";
            this.mdBtn.UseVisualStyleBackColor = true;
            this.mdBtn.Click += new System.EventHandler(this.mdBtn_Click);
            // 
            // hdBtn
            // 
            this.hdBtn.Location = new System.Drawing.Point(29, 210);
            this.hdBtn.Margin = new System.Windows.Forms.Padding(4);
            this.hdBtn.Name = "hdBtn";
            this.hdBtn.Size = new System.Drawing.Size(379, 47);
            this.hdBtn.TabIndex = 1;
            this.hdBtn.Text = "Dificil";
            this.hdBtn.UseVisualStyleBackColor = true;
            this.hdBtn.Click += new System.EventHandler(this.hdBtn_Click);
            // 
            // Difficulty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 306);
            this.Controls.Add(this.hdBtn);
            this.Controls.Add(this.mdBtn);
            this.Controls.Add(this.ezBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Difficulty";
            this.Text = "Dificultad";
            this.Load += new System.EventHandler(this.Difficulty_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ezBtn;
        private System.Windows.Forms.Button mdBtn;
        private System.Windows.Forms.Button hdBtn;
    }
}