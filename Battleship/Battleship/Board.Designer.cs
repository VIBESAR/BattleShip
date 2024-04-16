namespace Battleship
{
    partial class SETP
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
            this.horizontal = new System.Windows.Forms.RadioButton();
            this.vertical = new System.Windows.Forms.RadioButton();
            this.radioGroup = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Intentos = new System.Windows.Forms.Label();
            this.radioGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // horizontal
            // 
            this.horizontal.AutoSize = true;
            this.horizontal.Checked = true;
            this.horizontal.Location = new System.Drawing.Point(24, 37);
            this.horizontal.Margin = new System.Windows.Forms.Padding(4);
            this.horizontal.Name = "horizontal";
            this.horizontal.Size = new System.Drawing.Size(88, 20);
            this.horizontal.TabIndex = 0;
            this.horizontal.TabStop = true;
            this.horizontal.Text = "Horizontal";
            this.horizontal.UseVisualStyleBackColor = true;
            // 
            // vertical
            // 
            this.vertical.AutoSize = true;
            this.vertical.Location = new System.Drawing.Point(24, 65);
            this.vertical.Margin = new System.Windows.Forms.Padding(4);
            this.vertical.Name = "vertical";
            this.vertical.Size = new System.Drawing.Size(73, 20);
            this.vertical.TabIndex = 1;
            this.vertical.Text = "Vertical";
            this.vertical.UseVisualStyleBackColor = true;
            // 
            // radioGroup
            // 
            this.radioGroup.Controls.Add(this.vertical);
            this.radioGroup.Controls.Add(this.horizontal);
            this.radioGroup.Location = new System.Drawing.Point(663, 496);
            this.radioGroup.Margin = new System.Windows.Forms.Padding(4);
            this.radioGroup.Name = "radioGroup";
            this.radioGroup.Padding = new System.Windows.Forms.Padding(4);
            this.radioGroup.Size = new System.Drawing.Size(147, 103);
            this.radioGroup.TabIndex = 2;
            this.radioGroup.TabStop = false;
            this.radioGroup.Text = "Fomma";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Red;
            this.panel1.Location = new System.Drawing.Point(681, 197);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(53, 123);
            this.panel1.TabIndex = 3;
            // 
            // Intentos
            // 
            this.Intentos.AutoSize = true;
            this.Intentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Intentos.Location = new System.Drawing.Point(659, 343);
            this.Intentos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Intentos.Name = "Intentos";
            this.Intentos.Size = new System.Drawing.Size(83, 24);
            this.Intentos.TabIndex = 4;
            this.Intentos.Text = "Intentos";
            // 
            // SETP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 628);
            this.Controls.Add(this.Intentos);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.radioGroup);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SETP";
            this.Text = "BARCO";
            this.Load += new System.EventHandler(this.SetupBoard_Load);
            this.radioGroup.ResumeLayout(false);
            this.radioGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton horizontal;
        private System.Windows.Forms.RadioButton vertical;
        private System.Windows.Forms.GroupBox radioGroup;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label Intentos;

    }
}