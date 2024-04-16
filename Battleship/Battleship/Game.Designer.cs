namespace Battleship
{
    partial class Game
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
            this.switchBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // switchBtn
            // 
            this.switchBtn.Location = new System.Drawing.Point(551, 625);
            this.switchBtn.Margin = new System.Windows.Forms.Padding(4);
            this.switchBtn.Name = "switchBtn";
            this.switchBtn.Size = new System.Drawing.Size(107, 38);
            this.switchBtn.TabIndex = 0;
            this.switchBtn.Text = "Cambio";
            this.switchBtn.UseVisualStyleBackColor = true;
            this.switchBtn.Visible = false;
            this.switchBtn.Click += new System.EventHandler(this.switchBtn_Click);
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 678);
            this.Controls.Add(this.switchBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Game";
            this.Text = "JUEGO";
            this.Load += new System.EventHandler(this.Game_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button switchBtn;
    }
}