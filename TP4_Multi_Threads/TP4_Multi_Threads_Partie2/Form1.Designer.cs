﻿namespace TP4_Multi_Threads_Partie2
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
            this.txtTaille = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnInitialiser = new System.Windows.Forms.Button();
            this.btnTrier = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.lstValeursNonTriees = new System.Windows.Forms.ListBox();
            this.lstValeurstriees = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtTaille
            // 
            this.txtTaille.Location = new System.Drawing.Point(1263, 12);
            this.txtTaille.Name = "txtTaille";
            this.txtTaille.Size = new System.Drawing.Size(100, 20);
            this.txtTaille.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1172, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Taille du tableau";
            // 
            // btnInitialiser
            // 
            this.btnInitialiser.Location = new System.Drawing.Point(487, 38);
            this.btnInitialiser.Name = "btnInitialiser";
            this.btnInitialiser.Size = new System.Drawing.Size(393, 117);
            this.btnInitialiser.TabIndex = 4;
            this.btnInitialiser.Text = "Initialiser";
            this.btnInitialiser.UseVisualStyleBackColor = true;
            this.btnInitialiser.Click += new System.EventHandler(this.btnInitialiser_Click);
            // 
            // btnTrier
            // 
            this.btnTrier.Location = new System.Drawing.Point(487, 161);
            this.btnTrier.Name = "btnTrier";
            this.btnTrier.Size = new System.Drawing.Size(393, 117);
            this.btnTrier.TabIndex = 5;
            this.btnTrier.Text = "Trier";
            this.btnTrier.UseVisualStyleBackColor = true;
            this.btnTrier.Click += new System.EventHandler(this.btnTrier_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(487, 516);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(393, 117);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // lstValeursNonTriees
            // 
            this.lstValeursNonTriees.FormattingEnabled = true;
            this.lstValeursNonTriees.Location = new System.Drawing.Point(4, 38);
            this.lstValeursNonTriees.Name = "lstValeursNonTriees";
            this.lstValeursNonTriees.Size = new System.Drawing.Size(477, 602);
            this.lstValeursNonTriees.TabIndex = 7;
            // 
            // lstValeurstriees
            // 
            this.lstValeurstriees.FormattingEnabled = true;
            this.lstValeurstriees.Location = new System.Drawing.Point(886, 38);
            this.lstValeurstriees.Name = "lstValeurstriees";
            this.lstValeurstriees.Size = new System.Drawing.Size(477, 602);
            this.lstValeurstriees.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1375, 645);
            this.Controls.Add(this.lstValeurstriees);
            this.Controls.Add(this.lstValeursNonTriees);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.btnTrier);
            this.Controls.Add(this.btnInitialiser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTaille);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTaille;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnInitialiser;
        private System.Windows.Forms.Button btnTrier;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.ListBox lstValeursNonTriees;
        private System.Windows.Forms.ListBox lstValeurstriees;
    }
}

