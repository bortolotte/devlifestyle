namespace Jenios
{
    partial class FormGame
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.arquivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.buttonGreen = new System.Windows.Forms.Button();
            this.buttonRed = new System.Windows.Forms.Button();
            this.buttonYellow = new System.Windows.Forms.Button();
            this.buttonBlue = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonRepeat = new System.Windows.Forms.Button();
            this.trackBarSpeed = new System.Windows.Forms.TrackBar();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).BeginInit();
            this.SuspendLayout();
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.arquivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(893, 28);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // arquivoToolStripMenuItem
            // 
            this.arquivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sairToolStripMenuItem});
            this.arquivoToolStripMenuItem.Name = "arquivoToolStripMenuItem";
            this.arquivoToolStripMenuItem.Size = new System.Drawing.Size(75, 24);
            this.arquivoToolStripMenuItem.Text = "Arquivo";
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(117, 26);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // buttonGreen
            // 
            this.buttonGreen.BackColor = System.Drawing.Color.DarkGreen;
            this.buttonGreen.Location = new System.Drawing.Point(100, 70);
            this.buttonGreen.Name = "buttonGreen";
            this.buttonGreen.Size = new System.Drawing.Size(150, 150);
            this.buttonGreen.TabIndex = 1;
            this.buttonGreen.TabStop = false;
            this.buttonGreen.UseVisualStyleBackColor = false;
            this.buttonGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonColor_MouseDown);
            this.buttonGreen.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonColor_MouseUp);
            // 
            // buttonRed
            // 
            this.buttonRed.BackColor = System.Drawing.Color.Maroon;
            this.buttonRed.Location = new System.Drawing.Point(350, 70);
            this.buttonRed.Name = "buttonRed";
            this.buttonRed.Size = new System.Drawing.Size(150, 150);
            this.buttonRed.TabIndex = 3;
            this.buttonRed.TabStop = false;
            this.buttonRed.UseVisualStyleBackColor = false;
            this.buttonRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonColor_MouseDown);
            this.buttonRed.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonColor_MouseUp);
            // 
            // buttonYellow
            // 
            this.buttonYellow.BackColor = System.Drawing.Color.DarkGoldenrod;
            this.buttonYellow.Location = new System.Drawing.Point(100, 320);
            this.buttonYellow.Name = "buttonYellow";
            this.buttonYellow.Size = new System.Drawing.Size(150, 150);
            this.buttonYellow.TabIndex = 2;
            this.buttonYellow.TabStop = false;
            this.buttonYellow.UseVisualStyleBackColor = false;
            this.buttonYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonColor_MouseDown);
            this.buttonYellow.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonColor_MouseUp);
            // 
            // buttonBlue
            // 
            this.buttonBlue.BackColor = System.Drawing.Color.MediumBlue;
            this.buttonBlue.Location = new System.Drawing.Point(350, 320);
            this.buttonBlue.Name = "buttonBlue";
            this.buttonBlue.Size = new System.Drawing.Size(150, 150);
            this.buttonBlue.TabIndex = 4;
            this.buttonBlue.TabStop = false;
            this.buttonBlue.UseVisualStyleBackColor = false;
            this.buttonBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonColor_MouseDown);
            this.buttonBlue.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonColor_MouseUp);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(616, 89);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(106, 44);
            this.buttonStart.TabIndex = 1;
            this.buttonStart.Text = "Início";
            this.buttonStart.UseVisualStyleBackColor = true;
            // 
            // buttonRepeat
            // 
            this.buttonRepeat.Location = new System.Drawing.Point(616, 270);
            this.buttonRepeat.Name = "buttonRepeat";
            this.buttonRepeat.Size = new System.Drawing.Size(106, 44);
            this.buttonRepeat.TabIndex = 3;
            this.buttonRepeat.Text = "Repete";
            this.buttonRepeat.UseVisualStyleBackColor = true;
            // 
            // trackBarSpeed
            // 
            this.trackBarSpeed.Location = new System.Drawing.Point(594, 164);
            this.trackBarSpeed.Name = "trackBarSpeed";
            this.trackBarSpeed.Size = new System.Drawing.Size(149, 56);
            this.trackBarSpeed.TabIndex = 2;
            this.trackBarSpeed.Value = 5;
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(628, 200);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(77, 16);
            this.labelSpeed.TabIndex = 9;
            this.labelSpeed.Text = "Velocidade";
            // 
            // FormExemplo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 660);
            this.Controls.Add(this.labelSpeed);
            this.Controls.Add(this.trackBarSpeed);
            this.Controls.Add(this.buttonRepeat);
            this.Controls.Add(this.buttonStart);
            this.Controls.Add(this.buttonBlue);
            this.Controls.Add(this.buttonRed);
            this.Controls.Add(this.buttonYellow);
            this.Controls.Add(this.buttonGreen);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormExemplo";
            this.Text = "JENIOS";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarSpeed)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem arquivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.Button buttonGreen;
        private System.Windows.Forms.Button buttonRed;
        private System.Windows.Forms.Button buttonYellow;
        private System.Windows.Forms.Button buttonBlue;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Button buttonRepeat;
        private System.Windows.Forms.TrackBar trackBarSpeed;
        private System.Windows.Forms.Label labelSpeed;
    }
}

