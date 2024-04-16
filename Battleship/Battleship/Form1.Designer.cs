namespace Battleship
{
    partial class BattleShip
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
            this.pvcBtn = new System.Windows.Forms.Button();
            this.pvpBtn = new System.Windows.Forms.Button();
            this.creditBtn = new System.Windows.Forms.Button();
            this.rulesBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pvcBtn
            // 
            this.pvcBtn.Location = new System.Drawing.Point(31, 89);
            this.pvcBtn.Margin = new System.Windows.Forms.Padding(4);
            this.pvcBtn.Name = "pvcBtn";
            this.pvcBtn.Size = new System.Drawing.Size(379, 47);
            this.pvcBtn.TabIndex = 0;
            this.pvcBtn.Text = "Jugador Vs Computadora";
            this.pvcBtn.UseVisualStyleBackColor = true;
            this.pvcBtn.Click += new System.EventHandler(this.pvcBtn_Click);
            // 
            // pvpBtn
            // 
            this.pvpBtn.Location = new System.Drawing.Point(31, 17);
            this.pvpBtn.Margin = new System.Windows.Forms.Padding(4);
            this.pvpBtn.Name = "pvpBtn";
            this.pvpBtn.Size = new System.Drawing.Size(379, 47);
            this.pvpBtn.TabIndex = 0;
            this.pvpBtn.Text = "Jugador Vs Jugador";
            this.pvpBtn.UseVisualStyleBackColor = true;
            this.pvpBtn.Click += new System.EventHandler(this.pvpBtn_Click);
            // 
            // creditBtn
            // 
            this.creditBtn.Location = new System.Drawing.Point(309, 166);
            this.creditBtn.Margin = new System.Windows.Forms.Padding(4);
            this.creditBtn.Name = "creditBtn";
            this.creditBtn.Size = new System.Drawing.Size(100, 28);
            this.creditBtn.TabIndex = 1;
            this.creditBtn.Text = "Creditos";
            this.creditBtn.UseVisualStyleBackColor = true;
            this.creditBtn.Click += new System.EventHandler(this.creditBtn_Click);
            // 
            // rulesBtn
            // 
            this.rulesBtn.Location = new System.Drawing.Point(31, 166);
            this.rulesBtn.Margin = new System.Windows.Forms.Padding(4);
            this.rulesBtn.Name = "rulesBtn";
            this.rulesBtn.Size = new System.Drawing.Size(100, 28);
            this.rulesBtn.TabIndex = 1;
            this.rulesBtn.Text = "Reglas";
            this.rulesBtn.UseVisualStyleBackColor = true;
            this.rulesBtn.Click += new System.EventHandler(this.rulesBtn_Click);
            // 
            // BattleShip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 209);
            this.Controls.Add(this.rulesBtn);
            this.Controls.Add(this.creditBtn);
            this.Controls.Add(this.pvpBtn);
            this.Controls.Add(this.pvcBtn);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "BattleShip";
            this.Text = "BattleShip";
            this.Load += new System.EventHandler(this.BattleShip_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button pvcBtn;
        private System.Windows.Forms.Button pvpBtn;
        private System.Windows.Forms.Button creditBtn;
        private System.Windows.Forms.Button rulesBtn;

    }
}

