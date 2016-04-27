namespace TP1_Multi_Threads_V2
{
    partial class formHorloge
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
            this.btnQuitter = new System.Windows.Forms.Button();
            this.rbtnHeure = new System.Windows.Forms.RadioButton();
            this.rbtnDate = new System.Windows.Forms.RadioButton();
            this.rbtnDateHeure = new System.Windows.Forms.RadioButton();
            this.lblDateHeure = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(145, 288);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 10;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // rbtnHeure
            // 
            this.rbtnHeure.AutoSize = true;
            this.rbtnHeure.Location = new System.Drawing.Point(164, 167);
            this.rbtnHeure.Name = "rbtnHeure";
            this.rbtnHeure.Size = new System.Drawing.Size(54, 17);
            this.rbtnHeure.TabIndex = 9;
            this.rbtnHeure.TabStop = true;
            this.rbtnHeure.Text = "Heure";
            this.rbtnHeure.UseVisualStyleBackColor = true;
            this.rbtnHeure.Click += new System.EventHandler(this.rbtnDateHeure_Click);
            // 
            // rbtnDate
            // 
            this.rbtnDate.AutoSize = true;
            this.rbtnDate.Location = new System.Drawing.Point(110, 167);
            this.rbtnDate.Name = "rbtnDate";
            this.rbtnDate.Size = new System.Drawing.Size(48, 17);
            this.rbtnDate.TabIndex = 8;
            this.rbtnDate.TabStop = true;
            this.rbtnDate.Text = "Date";
            this.rbtnDate.UseVisualStyleBackColor = true;
            this.rbtnDate.Click += new System.EventHandler(this.rbtnDateHeure_Click);
            // 
            // rbtnDateHeure
            // 
            this.rbtnDateHeure.AutoSize = true;
            this.rbtnDateHeure.Location = new System.Drawing.Point(12, 167);
            this.rbtnDateHeure.Name = "rbtnDateHeure";
            this.rbtnDateHeure.Size = new System.Drawing.Size(92, 17);
            this.rbtnDateHeure.TabIndex = 7;
            this.rbtnDateHeure.TabStop = true;
            this.rbtnDateHeure.Text = "Date et Heure";
            this.rbtnDateHeure.UseVisualStyleBackColor = true;
            this.rbtnDateHeure.Click += new System.EventHandler(this.rbtnDateHeure_Click);
            // 
            // lblDateHeure
            // 
            this.lblDateHeure.AutoSize = true;
            this.lblDateHeure.Location = new System.Drawing.Point(12, 9);
            this.lblDateHeure.Name = "lblDateHeure";
            this.lblDateHeure.Size = new System.Drawing.Size(138, 13);
            this.lblDateHeure.TabIndex = 6;
            this.lblDateHeure.Text = "jj / mm / aaa  -  hh : mm : ss";
            this.lblDateHeure.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // formHorloge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 324);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.rbtnHeure);
            this.Controls.Add(this.rbtnDate);
            this.Controls.Add(this.rbtnDateHeure);
            this.Controls.Add(this.lblDateHeure);
            this.Name = "formHorloge";
            this.Text = "Horloge";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.formHorloge_FormClosing);
            this.Load += new System.EventHandler(this.formHorloge_Load);
            this.Click += new System.EventHandler(this.rbtnDateHeure_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.RadioButton rbtnHeure;
        private System.Windows.Forms.RadioButton rbtnDate;
        private System.Windows.Forms.RadioButton rbtnDateHeure;
        private System.Windows.Forms.Label lblDateHeure;
    }
}

