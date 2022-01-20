
namespace RechteckForm1
{
    partial class Form1
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
            this.txtHoehe = new System.Windows.Forms.TextBox();
            this.txtFlaeche = new System.Windows.Forms.TextBox();
            this.txtBreite = new System.Windows.Forms.TextBox();
            this.labelHoehe = new System.Windows.Forms.Label();
            this.labelBreite = new System.Windows.Forms.Label();
            this.labelFlaeche = new System.Windows.Forms.Label();
            this.btnAusrechnen = new System.Windows.Forms.Button();
            this.btnBeenden = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHoehe
            // 
            this.txtHoehe.Location = new System.Drawing.Point(177, 61);
            this.txtHoehe.Name = "txtHoehe";
            this.txtHoehe.Size = new System.Drawing.Size(169, 20);
            this.txtHoehe.TabIndex = 0;
            // 
            // txtFlaeche
            // 
            this.txtFlaeche.Location = new System.Drawing.Point(177, 236);
            this.txtFlaeche.Name = "txtFlaeche";
            this.txtFlaeche.Size = new System.Drawing.Size(169, 20);
            this.txtFlaeche.TabIndex = 1;
            // 
            // txtBreite
            // 
            this.txtBreite.Location = new System.Drawing.Point(177, 122);
            this.txtBreite.Name = "txtBreite";
            this.txtBreite.Size = new System.Drawing.Size(169, 20);
            this.txtBreite.TabIndex = 2;
            // 
            // labelHoehe
            // 
            this.labelHoehe.AutoSize = true;
            this.labelHoehe.Location = new System.Drawing.Point(41, 61);
            this.labelHoehe.Name = "labelHoehe";
            this.labelHoehe.Size = new System.Drawing.Size(33, 13);
            this.labelHoehe.TabIndex = 3;
            this.labelHoehe.Text = "Höhe";
            // 
            // labelBreite
            // 
            this.labelBreite.AutoSize = true;
            this.labelBreite.Location = new System.Drawing.Point(41, 129);
            this.labelBreite.Name = "labelBreite";
            this.labelBreite.Size = new System.Drawing.Size(34, 13);
            this.labelBreite.TabIndex = 4;
            this.labelBreite.Text = "Breite";
            // 
            // labelFlaeche
            // 
            this.labelFlaeche.AutoSize = true;
            this.labelFlaeche.Location = new System.Drawing.Point(41, 239);
            this.labelFlaeche.Name = "labelFlaeche";
            this.labelFlaeche.Size = new System.Drawing.Size(39, 13);
            this.labelFlaeche.TabIndex = 5;
            this.labelFlaeche.Text = "Fläche";
            // 
            // btnAusrechnen
            // 
            this.btnAusrechnen.Location = new System.Drawing.Point(500, 50);
            this.btnAusrechnen.Name = "btnAusrechnen";
            this.btnAusrechnen.Size = new System.Drawing.Size(208, 48);
            this.btnAusrechnen.TabIndex = 6;
            this.btnAusrechnen.Text = "Ausrechnen";
            this.btnAusrechnen.UseVisualStyleBackColor = true;
            this.btnAusrechnen.Click += new System.EventHandler(this.btnAusrechnen_Click);
            // 
            // btnBeenden
            // 
            this.btnBeenden.Location = new System.Drawing.Point(500, 204);
            this.btnBeenden.Name = "btnBeenden";
            this.btnBeenden.Size = new System.Drawing.Size(208, 48);
            this.btnBeenden.TabIndex = 7;
            this.btnBeenden.Text = "Beenden";
            this.btnBeenden.UseVisualStyleBackColor = true;
            this.btnBeenden.Click += new System.EventHandler(this.btnBeenden_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBeenden);
            this.Controls.Add(this.btnAusrechnen);
            this.Controls.Add(this.labelFlaeche);
            this.Controls.Add(this.labelBreite);
            this.Controls.Add(this.labelHoehe);
            this.Controls.Add(this.txtBreite);
            this.Controls.Add(this.txtFlaeche);
            this.Controls.Add(this.txtHoehe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHoehe;
        private System.Windows.Forms.TextBox txtFlaeche;
        private System.Windows.Forms.TextBox txtBreite;
        private System.Windows.Forms.Label labelHoehe;
        private System.Windows.Forms.Label labelBreite;
        private System.Windows.Forms.Label labelFlaeche;
        private System.Windows.Forms.Button btnAusrechnen;
        private System.Windows.Forms.Button btnBeenden;
    }
}