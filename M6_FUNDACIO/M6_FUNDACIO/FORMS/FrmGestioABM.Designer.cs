namespace M6_FUNDACIO.FORMS
{
    partial class FrmGestioABM
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
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.dtData = new System.Windows.Forms.DateTimePicker();
            this.tbCognom = new System.Windows.Forms.TextBox();
            this.tbNom = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btCancelar.Location = new System.Drawing.Point(388, 213);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(85, 40);
            this.btCancelar.TabIndex = 9;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.Color.LightGreen;
            this.btAceptar.Location = new System.Drawing.Point(108, 213);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(85, 40);
            this.btAceptar.TabIndex = 8;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = false;
            // 
            // dtData
            // 
            this.dtData.Location = new System.Drawing.Point(64, 155);
            this.dtData.Name = "dtData";
            this.dtData.Size = new System.Drawing.Size(268, 22);
            this.dtData.TabIndex = 7;
            // 
            // tbCognom
            // 
            this.tbCognom.Location = new System.Drawing.Point(64, 111);
            this.tbCognom.Name = "tbCognom";
            this.tbCognom.Size = new System.Drawing.Size(251, 22);
            this.tbCognom.TabIndex = 6;
            // 
            // tbNom
            // 
            this.tbNom.Location = new System.Drawing.Point(64, 64);
            this.tbNom.Name = "tbNom";
            this.tbNom.Size = new System.Drawing.Size(219, 22);
            this.tbNom.TabIndex = 5;
            // 
            // FrmGestioABM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(573, 307);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.dtData);
            this.Controls.Add(this.tbCognom);
            this.Controls.Add(this.tbNom);
            this.Name = "FrmGestioABM";
            this.Text = "FrmGestioABM";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.DateTimePicker dtData;
        private System.Windows.Forms.TextBox tbCognom;
        private System.Windows.Forms.TextBox tbNom;
    }
}