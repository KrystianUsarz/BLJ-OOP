
namespace Tannenbaum
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtHoeheBaumkrone = new System.Windows.Forms.TextBox();
            this.txtStammbreite = new System.Windows.Forms.TextBox();
            this.txtStammhoehe = new System.Windows.Forms.TextBox();
            this.txtTanne = new System.Windows.Forms.TextBox();
            this.labelhoechebk = new System.Windows.Forms.Label();
            this.labelStammbreite = new System.Windows.Forms.Label();
            this.labelStammhoeche = new System.Windows.Forms.Label();
            this.btnDraw = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtHoeheBaumkrone
            // 
            this.txtHoeheBaumkrone.Location = new System.Drawing.Point(102, 43);
            this.txtHoeheBaumkrone.Name = "txtHoeheBaumkrone";
            this.txtHoeheBaumkrone.Size = new System.Drawing.Size(100, 20);
            this.txtHoeheBaumkrone.TabIndex = 0;
            // 
            // txtStammbreite
            // 
            this.txtStammbreite.Location = new System.Drawing.Point(102, 82);
            this.txtStammbreite.Name = "txtStammbreite";
            this.txtStammbreite.Size = new System.Drawing.Size(100, 20);
            this.txtStammbreite.TabIndex = 1;
            // 
            // txtStammhoehe
            // 
            this.txtStammhoehe.Location = new System.Drawing.Point(102, 126);
            this.txtStammhoehe.Name = "txtStammhoehe";
            this.txtStammhoehe.Size = new System.Drawing.Size(100, 20);
            this.txtStammhoehe.TabIndex = 2;
            // 
            // txtTanne
            // 
            this.txtTanne.Location = new System.Drawing.Point(261, 43);
            this.txtTanne.Multiline = true;
            this.txtTanne.Name = "txtTanne";
            this.txtTanne.Size = new System.Drawing.Size(513, 379);
            this.txtTanne.TabIndex = 3;
            // 
            // labelhoechebk
            // 
            this.labelhoechebk.AutoSize = true;
            this.labelhoechebk.Location = new System.Drawing.Point(8, 46);
            this.labelhoechebk.Name = "labelhoechebk";
            this.labelhoechebk.Size = new System.Drawing.Size(88, 13);
            this.labelhoechebk.TabIndex = 4;
            this.labelhoechebk.Text = "höhe Baumkrone";
            // 
            // labelStammbreite
            // 
            this.labelStammbreite.AutoSize = true;
            this.labelStammbreite.Location = new System.Drawing.Point(13, 85);
            this.labelStammbreite.Name = "labelStammbreite";
            this.labelStammbreite.Size = new System.Drawing.Size(65, 13);
            this.labelStammbreite.TabIndex = 5;
            this.labelStammbreite.Text = "Stammbreite";
            // 
            // labelStammhoeche
            // 
            this.labelStammhoeche.AutoSize = true;
            this.labelStammhoeche.Location = new System.Drawing.Point(15, 129);
            this.labelStammhoeche.Name = "labelStammhoeche";
            this.labelStammhoeche.Size = new System.Drawing.Size(63, 13);
            this.labelStammhoeche.TabIndex = 6;
            this.labelStammhoeche.Text = "Stammhöhe";
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(40, 216);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(134, 43);
            this.btnDraw.TabIndex = 7;
            this.btnDraw.Text = "Tanne zeichnen";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.labelStammhoeche);
            this.Controls.Add(this.labelStammbreite);
            this.Controls.Add(this.labelhoechebk);
            this.Controls.Add(this.txtTanne);
            this.Controls.Add(this.txtStammhoehe);
            this.Controls.Add(this.txtStammbreite);
            this.Controls.Add(this.txtHoeheBaumkrone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtHoeheBaumkrone;
        private System.Windows.Forms.TextBox txtStammbreite;
        private System.Windows.Forms.TextBox txtStammhoehe;
        private System.Windows.Forms.TextBox txtTanne;
        private System.Windows.Forms.Label labelhoechebk;
        private System.Windows.Forms.Label labelStammbreite;
        private System.Windows.Forms.Label labelStammhoeche;
        private System.Windows.Forms.Button btnDraw;
    }
}

