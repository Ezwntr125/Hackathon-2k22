
namespace Calendrier
{
    partial class EventForm
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
            this.tbDate = new System.Windows.Forms.TextBox();
            this.tbTache = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bEnregistrer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbDate
            // 
            this.tbDate.Location = new System.Drawing.Point(63, 48);
            this.tbDate.Name = "tbDate";
            this.tbDate.Size = new System.Drawing.Size(226, 22);
            this.tbDate.TabIndex = 0;
            // 
            // tbTache
            // 
            this.tbTache.Location = new System.Drawing.Point(63, 109);
            this.tbTache.Name = "tbTache";
            this.tbTache.Size = new System.Drawing.Size(226, 22);
            this.tbTache.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(68, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tâche :";
            // 
            // bEnregistrer
            // 
            this.bEnregistrer.Location = new System.Drawing.Point(201, 150);
            this.bEnregistrer.Name = "bEnregistrer";
            this.bEnregistrer.Size = new System.Drawing.Size(88, 34);
            this.bEnregistrer.TabIndex = 4;
            this.bEnregistrer.Text = "Enregistrer";
            this.bEnregistrer.UseVisualStyleBackColor = true;
            this.bEnregistrer.Click += new System.EventHandler(this.bEnregistrer_Click);
            // 
            // EventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 196);
            this.Controls.Add(this.bEnregistrer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbTache);
            this.Controls.Add(this.tbDate);
            this.Name = "EventForm";
            this.Text = "EventForm";
            this.Load += new System.EventHandler(this.EventForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbDate;
        private System.Windows.Forms.TextBox tbTache;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bEnregistrer;
    }
}