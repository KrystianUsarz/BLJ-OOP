
namespace ReisedauerZumMond
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
            this.components = new System.ComponentModel.Container();
            this.radiobtnStunden = new System.Windows.Forms.RadioButton();
            this.radioButtonTage = new System.Windows.Forms.RadioButton();
            this.labelTitle = new System.Windows.Forms.Label();
            this.labelGeschwindigkeit = new System.Windows.Forms.Label();
            this.txtGeschwindigkeit = new System.Windows.Forms.TextBox();
            this.labelReisedauer = new System.Windows.Forms.Label();
            this.btnBerechnen = new System.Windows.Forms.Button();
            this.txtResultat = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // radiobtnStunden
            // 
            this.radiobtnStunden.AutoSize = true;
            this.radiobtnStunden.Location = new System.Drawing.Point(227, 91);
            this.radiobtnStunden.Name = "radiobtnStunden";
            this.radiobtnStunden.Size = new System.Drawing.Size(76, 17);
            this.radiobtnStunden.TabIndex = 0;
            this.radiobtnStunden.TabStop = true;
            this.radiobtnStunden.Text = "in Stunden";
            this.radiobtnStunden.UseVisualStyleBackColor = true;
            // 
            // radioButtonTage
            // 
            this.radioButtonTage.AutoSize = true;
            this.radioButtonTage.Location = new System.Drawing.Point(366, 91);
            this.radioButtonTage.Name = "radioButtonTage";
            this.radioButtonTage.Size = new System.Drawing.Size(67, 17);
            this.radioButtonTage.TabIndex = 1;
            this.radioButtonTage.TabStop = true;
            this.radioButtonTage.Text = "in Tagen";
            this.radioButtonTage.UseVisualStyleBackColor = true;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Location = new System.Drawing.Point(224, 53);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(113, 13);
            this.labelTitle.TabIndex = 2;
            this.labelTitle.Text = "Reisedauer zum Mond";
            // 
            // labelGeschwindigkeit
            // 
            this.labelGeschwindigkeit.AutoSize = true;
            this.labelGeschwindigkeit.Location = new System.Drawing.Point(224, 154);
            this.labelGeschwindigkeit.Name = "labelGeschwindigkeit";
            this.labelGeschwindigkeit.Size = new System.Drawing.Size(113, 13);
            this.labelGeschwindigkeit.TabIndex = 3;
            this.labelGeschwindigkeit.Text = "Geschwindigkeit km/h";
            // 
            // txtGeschwindigkeit
            // 
            this.txtGeschwindigkeit.Location = new System.Drawing.Point(343, 147);
            this.txtGeschwindigkeit.Name = "txtGeschwindigkeit";
            this.txtGeschwindigkeit.Size = new System.Drawing.Size(105, 20);
            this.txtGeschwindigkeit.TabIndex = 4;
            // 
            // labelReisedauer
            // 
            this.labelReisedauer.AutoSize = true;
            this.labelReisedauer.Location = new System.Drawing.Point(253, 253);
            this.labelReisedauer.Name = "labelReisedauer";
            this.labelReisedauer.Size = new System.Drawing.Size(64, 13);
            this.labelReisedauer.TabIndex = 5;
            this.labelReisedauer.Text = "Reisedauer:";
            // 
            // btnBerechnen
            // 
            this.btnBerechnen.Location = new System.Drawing.Point(282, 202);
            this.btnBerechnen.Name = "btnBerechnen";
            this.btnBerechnen.Size = new System.Drawing.Size(129, 23);
            this.btnBerechnen.TabIndex = 6;
            this.btnBerechnen.Text = "Reisezeit berechnen";
            this.btnBerechnen.UseVisualStyleBackColor = true;
            this.btnBerechnen.Click += new System.EventHandler(this.btnBerechnen_Click);
            // 
            // txtResultat
            // 
            this.txtResultat.Location = new System.Drawing.Point(324, 253);
            this.txtResultat.Name = "txtResultat";
            this.txtResultat.Size = new System.Drawing.Size(100, 20);
            this.txtResultat.TabIndex = 7;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 26);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResultat);
            this.Controls.Add(this.btnBerechnen);
            this.Controls.Add(this.labelReisedauer);
            this.Controls.Add(this.txtGeschwindigkeit);
            this.Controls.Add(this.labelGeschwindigkeit);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.radioButtonTage);
            this.Controls.Add(this.radiobtnStunden);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radiobtnStunden;
        private System.Windows.Forms.RadioButton radioButtonTage;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelGeschwindigkeit;
        private System.Windows.Forms.TextBox txtGeschwindigkeit;
        private System.Windows.Forms.Label labelReisedauer;
        private System.Windows.Forms.Button btnBerechnen;
        private System.Windows.Forms.TextBox txtResultat;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}

