namespace M6_FUNDACIO.FORMS
{
    partial class FrmValoracio
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
            this.nUdReseña = new System.Windows.Forms.NumericUpDown();
            this.tbDescripcio = new System.Windows.Forms.TextBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAceptar = new System.Windows.Forms.Button();
            this.cbFundacions = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.nUdReseña)).BeginInit();
            this.SuspendLayout();
            // 
            // nUdReseña
            // 
            this.nUdReseña.Location = new System.Drawing.Point(333, 324);
            this.nUdReseña.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.nUdReseña.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nUdReseña.Name = "nUdReseña";
            this.nUdReseña.ReadOnly = true;
            this.nUdReseña.Size = new System.Drawing.Size(120, 22);
            this.nUdReseña.TabIndex = 0;
            this.nUdReseña.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbDescripcio
            // 
            this.tbDescripcio.Location = new System.Drawing.Point(163, 135);
            this.tbDescripcio.Multiline = true;
            this.tbDescripcio.Name = "tbDescripcio";
            this.tbDescripcio.Size = new System.Drawing.Size(472, 155);
            this.tbDescripcio.TabIndex = 1;
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.Crimson;
            this.btCancelar.Location = new System.Drawing.Point(509, 370);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(85, 40);
            this.btCancelar.TabIndex = 11;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            this.btCancelar.Click += new System.EventHandler(this.btCancelar_Click);
            // 
            // btAceptar
            // 
            this.btAceptar.BackColor = System.Drawing.Color.LightGreen;
            this.btAceptar.Location = new System.Drawing.Point(214, 370);
            this.btAceptar.Name = "btAceptar";
            this.btAceptar.Size = new System.Drawing.Size(85, 40);
            this.btAceptar.TabIndex = 10;
            this.btAceptar.Text = "Aceptar";
            this.btAceptar.UseVisualStyleBackColor = false;
            this.btAceptar.Click += new System.EventHandler(this.btAceptar_Click);
            // 
            // cbFundacions
            // 
            this.cbFundacions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFundacions.FormattingEnabled = true;
            this.cbFundacions.Location = new System.Drawing.Point(214, 67);
            this.cbFundacions.Name = "cbFundacions";
            this.cbFundacions.Size = new System.Drawing.Size(380, 24);
            this.cbFundacions.TabIndex = 29;
            // 
            // FrmValoracio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbFundacions);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAceptar);
            this.Controls.Add(this.tbDescripcio);
            this.Controls.Add(this.nUdReseña);
            this.Name = "FrmValoracio";
            this.Text = "FrmValoracio";
            this.Load += new System.EventHandler(this.FrmValoracio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nUdReseña)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nUdReseña;
        private System.Windows.Forms.TextBox tbDescripcio;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAceptar;
        private System.Windows.Forms.ComboBox cbFundacions;
    }
}