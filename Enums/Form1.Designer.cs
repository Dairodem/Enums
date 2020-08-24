namespace Enums
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
            this.cbNamen = new System.Windows.Forms.ComboBox();
            this.lblSalary = new System.Windows.Forms.Label();
            this.lblCountry = new System.Windows.Forms.Label();
            this.lblNet = new System.Windows.Forms.Label();
            this.lblBtw = new System.Windows.Forms.Label();
            this.cbBedrijven = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnRemove = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbNamen
            // 
            this.cbNamen.FormattingEnabled = true;
            this.cbNamen.Location = new System.Drawing.Point(251, 32);
            this.cbNamen.Name = "cbNamen";
            this.cbNamen.Size = new System.Drawing.Size(213, 21);
            this.cbNamen.TabIndex = 2;
            this.cbNamen.SelectedIndexChanged += new System.EventHandler(this.cbNamen_SelectedIndexChanged);
            // 
            // lblSalary
            // 
            this.lblSalary.AutoSize = true;
            this.lblSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalary.Location = new System.Drawing.Point(250, 69);
            this.lblSalary.Name = "lblSalary";
            this.lblSalary.Size = new System.Drawing.Size(55, 17);
            this.lblSalary.TabIndex = 0;
            this.lblSalary.Text = "Salaris:";
            // 
            // lblCountry
            // 
            this.lblCountry.AutoSize = true;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.Location = new System.Drawing.Point(250, 134);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(48, 17);
            this.lblCountry.TabIndex = 0;
            this.lblCountry.Text = "Land: ";
            // 
            // lblNet
            // 
            this.lblNet.AutoSize = true;
            this.lblNet.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNet.Location = new System.Drawing.Point(250, 97);
            this.lblNet.Name = "lblNet";
            this.lblNet.Size = new System.Drawing.Size(46, 17);
            this.lblNet.TabIndex = 0;
            this.lblNet.Text = "Netto:";
            // 
            // lblBtw
            // 
            this.lblBtw.AutoSize = true;
            this.lblBtw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBtw.Location = new System.Drawing.Point(11, 69);
            this.lblBtw.Name = "lblBtw";
            this.lblBtw.Size = new System.Drawing.Size(65, 17);
            this.lblBtw.TabIndex = 0;
            this.lblBtw.Text = "BTW-nr.:";
            // 
            // cbBedrijven
            // 
            this.cbBedrijven.FormattingEnabled = true;
            this.cbBedrijven.ItemHeight = 13;
            this.cbBedrijven.Location = new System.Drawing.Point(12, 32);
            this.cbBedrijven.Name = "cbBedrijven";
            this.cbBedrijven.Size = new System.Drawing.Size(213, 21);
            this.cbBedrijven.TabIndex = 4;
            this.cbBedrijven.SelectedIndexChanged += new System.EventHandler(this.cbBedrijven_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 17);
            this.label3.TabIndex = 0;
            this.label3.Text = "Bedrijf:";
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(253, 166);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(211, 31);
            this.btnRemove.TabIndex = 4;
            this.btnRemove.Text = "Verwijder werknemer";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 166);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(213, 31);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Voeg werknemer toe";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(491, 209);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblBtw);
            this.Controls.Add(this.cbBedrijven);
            this.Controls.Add(this.lblNet);
            this.Controls.Add(this.lblCountry);
            this.Controls.Add(this.lblSalary);
            this.Controls.Add(this.cbNamen);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbNamen;
        private System.Windows.Forms.Label lblSalary;
        private System.Windows.Forms.Label lblCountry;
        private System.Windows.Forms.Label lblNet;
        private System.Windows.Forms.Label lblBtw;
        private System.Windows.Forms.ComboBox cbBedrijven;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.Button btnAdd;
    }
}

