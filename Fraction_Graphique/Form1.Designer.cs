namespace Fraction_Graphique
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupFrac1 = new System.Windows.Forms.GroupBox();
            this.frac1Den = new System.Windows.Forms.TextBox();
            this.frac1Num = new System.Windows.Forms.TextBox();
            this.groupFrac2 = new System.Windows.Forms.GroupBox();
            this.frac2Den = new System.Windows.Forms.TextBox();
            this.frac2Num = new System.Windows.Forms.TextBox();
            this.groupFrac3 = new System.Windows.Forms.GroupBox();
            this.frac3Den = new System.Windows.Forms.TextBox();
            this.frac3Num = new System.Windows.Forms.TextBox();
            this.groupFrac4 = new System.Windows.Forms.GroupBox();
            this.frac4Num = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupFrac1.SuspendLayout();
            this.groupFrac2.SuspendLayout();
            this.groupFrac3.SuspendLayout();
            this.groupFrac4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupFrac1
            // 
            this.groupFrac1.Controls.Add(this.frac1Den);
            this.groupFrac1.Controls.Add(this.frac1Num);
            this.groupFrac1.Location = new System.Drawing.Point(54, 41);
            this.groupFrac1.Name = "groupFrac1";
            this.groupFrac1.Size = new System.Drawing.Size(150, 95);
            this.groupFrac1.TabIndex = 0;
            this.groupFrac1.TabStop = false;
            this.groupFrac1.Text = "frac1";
            this.groupFrac1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // frac1Den
            // 
            this.frac1Den.Location = new System.Drawing.Point(30, 61);
            this.frac1Den.Name = "frac1Den";
            this.frac1Den.Size = new System.Drawing.Size(90, 20);
            this.frac1Den.TabIndex = 1;
            // 
            // frac1Num
            // 
            this.frac1Num.Location = new System.Drawing.Point(30, 19);
            this.frac1Num.Name = "frac1Num";
            this.frac1Num.Size = new System.Drawing.Size(90, 20);
            this.frac1Num.TabIndex = 0;
            this.frac1Num.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupFrac2
            // 
            this.groupFrac2.Controls.Add(this.frac2Den);
            this.groupFrac2.Controls.Add(this.frac2Num);
            this.groupFrac2.Location = new System.Drawing.Point(229, 41);
            this.groupFrac2.Name = "groupFrac2";
            this.groupFrac2.Size = new System.Drawing.Size(150, 95);
            this.groupFrac2.TabIndex = 1;
            this.groupFrac2.TabStop = false;
            this.groupFrac2.Text = "frac2";
            this.groupFrac2.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // frac2Den
            // 
            this.frac2Den.Location = new System.Drawing.Point(30, 61);
            this.frac2Den.Name = "frac2Den";
            this.frac2Den.Size = new System.Drawing.Size(90, 20);
            this.frac2Den.TabIndex = 1;
            // 
            // frac2Num
            // 
            this.frac2Num.Location = new System.Drawing.Point(30, 19);
            this.frac2Num.Name = "frac2Num";
            this.frac2Num.Size = new System.Drawing.Size(90, 20);
            this.frac2Num.TabIndex = 0;
            // 
            // groupFrac3
            // 
            this.groupFrac3.Controls.Add(this.frac3Den);
            this.groupFrac3.Controls.Add(this.frac3Num);
            this.groupFrac3.Location = new System.Drawing.Point(411, 41);
            this.groupFrac3.Name = "groupFrac3";
            this.groupFrac3.Size = new System.Drawing.Size(150, 95);
            this.groupFrac3.TabIndex = 2;
            this.groupFrac3.TabStop = false;
            this.groupFrac3.Text = "frac3";
            // 
            // frac3Den
            // 
            this.frac3Den.Location = new System.Drawing.Point(30, 61);
            this.frac3Den.Name = "frac3Den";
            this.frac3Den.Size = new System.Drawing.Size(90, 20);
            this.frac3Den.TabIndex = 1;
            // 
            // frac3Num
            // 
            this.frac3Num.Location = new System.Drawing.Point(30, 19);
            this.frac3Num.Name = "frac3Num";
            this.frac3Num.Size = new System.Drawing.Size(90, 20);
            this.frac3Num.TabIndex = 0;
            // 
            // groupFrac4
            // 
            this.groupFrac4.Controls.Add(this.frac4Num);
            this.groupFrac4.Location = new System.Drawing.Point(597, 41);
            this.groupFrac4.Name = "groupFrac4";
            this.groupFrac4.Size = new System.Drawing.Size(150, 95);
            this.groupFrac4.TabIndex = 3;
            this.groupFrac4.TabStop = false;
            this.groupFrac4.Text = "frac4";
            // 
            // frac4Num
            // 
            this.frac4Num.Location = new System.Drawing.Point(32, 40);
            this.frac4Num.Name = "frac4Num";
            this.frac4Num.Size = new System.Drawing.Size(90, 20);
            this.frac4Num.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(131, 398);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupFrac4);
            this.Controls.Add(this.groupFrac3);
            this.Controls.Add(this.groupFrac2);
            this.Controls.Add(this.groupFrac1);
            this.Name = "Form1";
            this.Text = "Fraction";
            this.groupFrac1.ResumeLayout(false);
            this.groupFrac1.PerformLayout();
            this.groupFrac2.ResumeLayout(false);
            this.groupFrac2.PerformLayout();
            this.groupFrac3.ResumeLayout(false);
            this.groupFrac3.PerformLayout();
            this.groupFrac4.ResumeLayout(false);
            this.groupFrac4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupFrac1;
        private System.Windows.Forms.TextBox frac1Den;
        private System.Windows.Forms.TextBox frac1Num;
        private System.Windows.Forms.GroupBox groupFrac2;
        private System.Windows.Forms.TextBox frac2Den;
        private System.Windows.Forms.TextBox frac2Num;
        private System.Windows.Forms.GroupBox groupFrac3;
        private System.Windows.Forms.TextBox frac3Den;
        private System.Windows.Forms.TextBox frac3Num;
        private System.Windows.Forms.GroupBox groupFrac4;
        private System.Windows.Forms.TextBox frac4Num;
        private System.Windows.Forms.Button button1;
    }
}

