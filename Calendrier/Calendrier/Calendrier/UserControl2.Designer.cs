
namespace Calendrier
{
    partial class UserControl2
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

        #region Code généré par le Concepteur de composants

        /// <summary> 
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas 
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lDay = new System.Windows.Forms.Label();
            this.lTache = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lDay
            // 
            this.lDay.AutoSize = true;
            this.lDay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lDay.Location = new System.Drawing.Point(16, 11);
            this.lDay.Name = "lDay";
            this.lDay.Size = new System.Drawing.Size(36, 25);
            this.lDay.TabIndex = 0;
            this.lDay.Text = "00";
            this.lDay.Click += new System.EventHandler(this.lDay_Click);
            // 
            // lTache
            // 
            this.lTache.Location = new System.Drawing.Point(9, 51);
            this.lTache.Name = "lTache";
            this.lTache.Size = new System.Drawing.Size(115, 32);
            this.lTache.TabIndex = 1;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lTache);
            this.Controls.Add(this.lDay);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(127, 100);
            this.Load += new System.EventHandler(this.UserControl2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lDay;
        private System.Windows.Forms.Label lTache;
        private System.Windows.Forms.Timer timer1;
    }
}
