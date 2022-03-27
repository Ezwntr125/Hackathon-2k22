
namespace Calendrier
{
    partial class Calendrier
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
            this.bSuivant = new System.Windows.Forms.Button();
            this.bPrecedent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.daycontainer = new System.Windows.Forms.FlowLayoutPanel();
            this.ltitre = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bSuivant
            // 
            this.bSuivant.Location = new System.Drawing.Point(484, 654);
            this.bSuivant.Name = "bSuivant";
            this.bSuivant.Size = new System.Drawing.Size(91, 33);
            this.bSuivant.TabIndex = 1;
            this.bSuivant.Text = "Suivant";
            this.bSuivant.UseVisualStyleBackColor = true;
            this.bSuivant.Click += new System.EventHandler(this.bSuivant_Click);
            // 
            // bPrecedent
            // 
            this.bPrecedent.Location = new System.Drawing.Point(381, 654);
            this.bPrecedent.Name = "bPrecedent";
            this.bPrecedent.Size = new System.Drawing.Size(97, 33);
            this.bPrecedent.TabIndex = 2;
            this.bPrecedent.Text = "Précédent";
            this.bPrecedent.UseVisualStyleBackColor = true;
            this.bPrecedent.Click += new System.EventHandler(this.bPrecedent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 17);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.label1.Size = new System.Drawing.Size(123, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Lundi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(139, 17);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mardi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(265, 17);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.label3.Size = new System.Drawing.Size(143, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Mercredi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(406, 17);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.label4.Size = new System.Drawing.Size(122, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Jeudi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(516, 17);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(40, 0, 40, 0);
            this.label5.Size = new System.Drawing.Size(145, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Vendredi";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(664, 17);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(40, 0, 80, 0);
            this.label6.Size = new System.Drawing.Size(175, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Samedi";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(16, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(932, 37);
            this.panel1.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(797, 17);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(40, 0, 20, 0);
            this.label8.Size = new System.Drawing.Size(131, 17);
            this.label8.TabIndex = 9;
            this.label8.Text = "Dimanche";
            // 
            // daycontainer
            // 
            this.daycontainer.Location = new System.Drawing.Point(12, 92);
            this.daycontainer.Name = "daycontainer";
            this.daycontainer.Size = new System.Drawing.Size(933, 556);
            this.daycontainer.TabIndex = 0;
            // 
            // ltitre
            // 
            this.ltitre.Font = new System.Drawing.Font("Bowlby One SC", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ltitre.Location = new System.Drawing.Point(338, 9);
            this.ltitre.Name = "ltitre";
            this.ltitre.Size = new System.Drawing.Size(297, 37);
            this.ltitre.TabIndex = 11;
            // 
            // Calendrier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 699);
            this.Controls.Add(this.ltitre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bPrecedent);
            this.Controls.Add(this.bSuivant);
            this.Controls.Add(this.daycontainer);
            this.Name = "Calendrier";
            this.Text = "Calendrier";
            this.Load += new System.EventHandler(this.Calendrier_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bSuivant;
        private System.Windows.Forms.Button bPrecedent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.FlowLayoutPanel daycontainer;
        private System.Windows.Forms.Label ltitre;
    }
}

