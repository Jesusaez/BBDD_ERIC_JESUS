namespace M6_FUNDACIO.FORMS
{
    partial class FrmABMDades
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
            this.lbNom = new System.Windows.Forms.Label();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.tbDireccio = new System.Windows.Forms.TextBox();
            this.lbDireccio = new System.Windows.Forms.Label();
            this.cbContinent = new System.Windows.Forms.ComboBox();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.lbContinent = new System.Windows.Forms.Label();
            this.lbPais = new System.Windows.Forms.Label();
            this.lbCiutat = new System.Windows.Forms.Label();
            this.cbCiutat = new System.Windows.Forms.ComboBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.tbWeb = new System.Windows.Forms.TextBox();
            this.lbWeb = new System.Windows.Forms.Label();
            this.tbTelefon = new System.Windows.Forms.TextBox();
            this.lbTelefon = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.tbHorari = new System.Windows.Forms.TextBox();
            this.lbHorari = new System.Windows.Forms.Label();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbNom
            // 
            this.lbNom.AutoSize = true;
            this.lbNom.Location = new System.Drawing.Point(76, 58);
            this.lbNom.Name = "lbNom";
            this.lbNom.Size = new System.Drawing.Size(95, 16);
            this.lbNom.TabIndex = 0;
            this.lbNom.Text = "Nom Fundacio";
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(79, 92);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(174, 22);
            this.tbNom.TabIndex = 1;
            // 
            // tbDireccio
            // 
            this.tbDireccio.Location = new System.Drawing.Point(79, 175);
            this.tbDireccio.Name = "tbDireccio";
            this.tbDireccio.Size = new System.Drawing.Size(174, 22);
            this.tbDireccio.TabIndex = 3;
            // 
            // lbDireccio
            // 
            this.lbDireccio.AutoSize = true;
            this.lbDireccio.Location = new System.Drawing.Point(76, 141);
            this.lbDireccio.Name = "lbDireccio";
            this.lbDireccio.Size = new System.Drawing.Size(57, 16);
            this.lbDireccio.TabIndex = 2;
            this.lbDireccio.Text = "Direccio";
            // 
            // cbContinent
            // 
            this.cbContinent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContinent.Location = new System.Drawing.Point(307, 90);
            this.cbContinent.Name = "cbContinent";
            this.cbContinent.Size = new System.Drawing.Size(201, 24);
            this.cbContinent.TabIndex = 4;
            this.cbContinent.SelectedIndexChanged += new System.EventHandler(this.cbContinent_SelectedIndexChanged);
            // 
            // cbPais
            // 
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.Location = new System.Drawing.Point(307, 173);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(201, 24);
            this.cbPais.TabIndex = 5;
            this.cbPais.SelectedIndexChanged += new System.EventHandler(this.cbPais_SelectedIndexChanged);
            // 
            // lbContinent
            // 
            this.lbContinent.AutoSize = true;
            this.lbContinent.Location = new System.Drawing.Point(304, 58);
            this.lbContinent.Name = "lbContinent";
            this.lbContinent.Size = new System.Drawing.Size(62, 16);
            this.lbContinent.TabIndex = 6;
            this.lbContinent.Text = "Continent";
            // 
            // lbPais
            // 
            this.lbPais.AutoSize = true;
            this.lbPais.Location = new System.Drawing.Point(304, 141);
            this.lbPais.Name = "lbPais";
            this.lbPais.Size = new System.Drawing.Size(34, 16);
            this.lbPais.TabIndex = 7;
            this.lbPais.Text = "Pais";
            // 
            // lbCiutat
            // 
            this.lbCiutat.AutoSize = true;
            this.lbCiutat.Location = new System.Drawing.Point(304, 223);
            this.lbCiutat.Name = "lbCiutat";
            this.lbCiutat.Size = new System.Drawing.Size(40, 16);
            this.lbCiutat.TabIndex = 9;
            this.lbCiutat.Text = "Ciutat";
            // 
            // cbCiutat
            // 
            this.cbCiutat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCiutat.Location = new System.Drawing.Point(307, 255);
            this.cbCiutat.Name = "cbCiutat";
            this.cbCiutat.Size = new System.Drawing.Size(201, 24);
            this.cbCiutat.TabIndex = 8;
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // tbWeb
            // 
            this.tbWeb.Location = new System.Drawing.Point(79, 255);
            this.tbWeb.Name = "tbWeb";
            this.tbWeb.Size = new System.Drawing.Size(174, 22);
            this.tbWeb.TabIndex = 11;
            // 
            // lbWeb
            // 
            this.lbWeb.AutoSize = true;
            this.lbWeb.Location = new System.Drawing.Point(76, 221);
            this.lbWeb.Name = "lbWeb";
            this.lbWeb.Size = new System.Drawing.Size(36, 16);
            this.lbWeb.TabIndex = 10;
            this.lbWeb.Text = "Web";
            // 
            // tbTelefon
            // 
            this.tbTelefon.Location = new System.Drawing.Point(557, 92);
            this.tbTelefon.Name = "tbTelefon";
            this.tbTelefon.Size = new System.Drawing.Size(174, 22);
            this.tbTelefon.TabIndex = 13;
            this.tbTelefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefon_KeyPress);
            // 
            // lbTelefon
            // 
            this.lbTelefon.AutoSize = true;
            this.lbTelefon.Location = new System.Drawing.Point(554, 58);
            this.lbTelefon.Name = "lbTelefon";
            this.lbTelefon.Size = new System.Drawing.Size(53, 16);
            this.lbTelefon.TabIndex = 12;
            this.lbTelefon.Text = "Telefon";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(557, 175);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(174, 22);
            this.tbEmail.TabIndex = 15;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(554, 141);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(41, 16);
            this.lbEmail.TabIndex = 14;
            this.lbEmail.Text = "Email";
            // 
            // tbHorari
            // 
            this.tbHorari.Location = new System.Drawing.Point(557, 255);
            this.tbHorari.Name = "tbHorari";
            this.tbHorari.Size = new System.Drawing.Size(174, 22);
            this.tbHorari.TabIndex = 17;
            // 
            // lbHorari
            // 
            this.lbHorari.AutoSize = true;
            this.lbHorari.Location = new System.Drawing.Point(554, 221);
            this.lbHorari.Name = "lbHorari";
            this.lbHorari.Size = new System.Drawing.Size(44, 16);
            this.lbHorari.TabIndex = 16;
            this.lbHorari.Text = "Horari";
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btCancelar.Location = new System.Drawing.Point(494, 330);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(85, 40);
            this.btCancelar.TabIndex = 19;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.Color.LightGreen;
            this.btAceptar.Location = new System.Drawing.Point(214, 330);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(85, 40);
            this.btAceptar.TabIndex = 18;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = false;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // FrmABMDades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.tbHorari);
            this.Controls.Add(this.lbHorari);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.tbTelefon);
            this.Controls.Add(this.lbTelefon);
            this.Controls.Add(this.tbWeb);
            this.Controls.Add(this.lbWeb);
            this.Controls.Add(this.lbCiutat);
            this.Controls.Add(this.cbCiutat);
            this.Controls.Add(this.lbPais);
            this.Controls.Add(this.lbContinent);
            this.Controls.Add(this.cbPais);
            this.Controls.Add(this.cbContinent);
            this.Controls.Add(this.tbDireccio);
            this.Controls.Add(this.lbDireccio);
            this.Controls.Add(this.tbNom);
            this.Controls.Add(this.lbNom);
            this.Name = "FrmABMDades";
            this.Text = "FrmABMDades";
            this.Load += new System.EventHandler(this.FrmABMDades_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNom;
        private System.Windows.Forms.TextBox tbNom;
        private System.Windows.Forms.TextBox tbDireccio;
        private System.Windows.Forms.Label lbDireccio;
        private System.Windows.Forms.ComboBox cbContinent;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.Label lbContinent;
        private System.Windows.Forms.Label lbPais;
        private System.Windows.Forms.Label lbCiutat;
        private System.Windows.Forms.ComboBox cbCiutat;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.TextBox tbWeb;
        private System.Windows.Forms.Label lbWeb;
        private System.Windows.Forms.TextBox tbTelefon;
        private System.Windows.Forms.Label lbTelefon;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox tbHorari;
        private System.Windows.Forms.Label lbHorari;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
    }
}