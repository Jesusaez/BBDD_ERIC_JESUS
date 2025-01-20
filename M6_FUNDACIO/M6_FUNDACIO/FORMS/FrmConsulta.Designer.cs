namespace M6_FUNDACIO.FORMS
{
    partial class FrmConsulta
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbRegio = new System.Windows.Forms.Label();
            this.lbDades = new System.Windows.Forms.Label();
            this.dgDades = new System.Windows.Forms.DataGridView();
            this.cbPais = new System.Windows.Forms.ComboBox();
            this.cbContinent = new System.Windows.Forms.ComboBox();
            this.cbCategoria = new System.Windows.Forms.ComboBox();
            this.rbContinent = new System.Windows.Forms.RadioButton();
            this.rbPais = new System.Windows.Forms.RadioButton();
            this.rbCategoria = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRegio
            // 
            this.lbRegio.AutoSize = true;
            this.lbRegio.BackColor = System.Drawing.Color.Tan;
            this.lbRegio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRegio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegio.ForeColor = System.Drawing.Color.Black;
            this.lbRegio.Location = new System.Drawing.Point(273, -76);
            this.lbRegio.MinimumSize = new System.Drawing.Size(100, 2);
            this.lbRegio.Name = "lbRegio";
            this.lbRegio.Padding = new System.Windows.Forms.Padding(3);
            this.lbRegio.Size = new System.Drawing.Size(259, 40);
            this.lbRegio.TabIndex = 31;
            this.lbRegio.Text = "Dades Fundacions";
            // 
            // lbDades
            // 
            this.lbDades.AutoSize = true;
            this.lbDades.BackColor = System.Drawing.Color.Tan;
            this.lbDades.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbDades.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDades.ForeColor = System.Drawing.Color.Black;
            this.lbDades.Location = new System.Drawing.Point(412, 36);
            this.lbDades.MinimumSize = new System.Drawing.Size(100, 2);
            this.lbDades.Name = "lbDades";
            this.lbDades.Padding = new System.Windows.Forms.Padding(3);
            this.lbDades.Size = new System.Drawing.Size(259, 40);
            this.lbDades.TabIndex = 33;
            this.lbDades.Text = "Dades Fundacions";
            // 
            // dgDades
            // 
            this.dgDades.AllowUserToAddRows = false;
            this.dgDades.AllowUserToDeleteRows = false;
            this.dgDades.AllowUserToOrderColumns = true;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dgDades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgDades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDades.Location = new System.Drawing.Point(-3, 161);
            this.dgDades.Name = "dgDades";
            this.dgDades.ReadOnly = true;
            this.dgDades.RowHeadersVisible = false;
            this.dgDades.RowHeadersWidth = 51;
            this.dgDades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDades.Size = new System.Drawing.Size(1089, 523);
            this.dgDades.TabIndex = 32;
            // 
            // cbPais
            // 
            this.cbPais.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPais.FormattingEnabled = true;
            this.cbPais.Location = new System.Drawing.Point(412, 102);
            this.cbPais.Name = "cbPais";
            this.cbPais.Size = new System.Drawing.Size(259, 24);
            this.cbPais.TabIndex = 34;
            this.cbPais.SelectedIndexChanged += new System.EventHandler(this.cbPais_SelectedIndexChanged);
            // 
            // cbContinent
            // 
            this.cbContinent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContinent.FormattingEnabled = true;
            this.cbContinent.Location = new System.Drawing.Point(60, 102);
            this.cbContinent.Name = "cbContinent";
            this.cbContinent.Size = new System.Drawing.Size(259, 24);
            this.cbContinent.TabIndex = 35;
            this.cbContinent.SelectedIndexChanged += new System.EventHandler(this.cbContinent_SelectedIndexChanged);
            // 
            // cbCategoria
            // 
            this.cbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCategoria.FormattingEnabled = true;
            this.cbCategoria.Location = new System.Drawing.Point(755, 102);
            this.cbCategoria.Name = "cbCategoria";
            this.cbCategoria.Size = new System.Drawing.Size(259, 24);
            this.cbCategoria.TabIndex = 36;
            this.cbCategoria.SelectedIndexChanged += new System.EventHandler(this.cbCategoria_SelectedIndexChanged);
            // 
            // rbContinent
            // 
            this.rbContinent.AutoSize = true;
            this.rbContinent.Checked = true;
            this.rbContinent.Location = new System.Drawing.Point(134, 132);
            this.rbContinent.Name = "rbContinent";
            this.rbContinent.Size = new System.Drawing.Size(83, 20);
            this.rbContinent.TabIndex = 40;
            this.rbContinent.TabStop = true;
            this.rbContinent.Text = "Continent";
            this.rbContinent.UseVisualStyleBackColor = true;
            this.rbContinent.CheckedChanged += new System.EventHandler(this.rbContinent_CheckedChanged);
            // 
            // rbPais
            // 
            this.rbPais.AutoSize = true;
            this.rbPais.Location = new System.Drawing.Point(500, 132);
            this.rbPais.Name = "rbPais";
            this.rbPais.Size = new System.Drawing.Size(55, 20);
            this.rbPais.TabIndex = 41;
            this.rbPais.TabStop = true;
            this.rbPais.Text = "Pais";
            this.rbPais.UseVisualStyleBackColor = true;
            this.rbPais.CheckedChanged += new System.EventHandler(this.rbPais_CheckedChanged);
            // 
            // rbCategoria
            // 
            this.rbCategoria.AutoSize = true;
            this.rbCategoria.Location = new System.Drawing.Point(844, 132);
            this.rbCategoria.Name = "rbCategoria";
            this.rbCategoria.Size = new System.Drawing.Size(87, 20);
            this.rbCategoria.TabIndex = 42;
            this.rbCategoria.TabStop = true;
            this.rbCategoria.Text = "Categoria";
            this.rbCategoria.UseVisualStyleBackColor = true;
            this.rbCategoria.CheckedChanged += new System.EventHandler(this.rbCategoria_CheckedChanged);
            // 
            // FrmConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1081, 682);
            this.Controls.Add(this.rbCategoria);
            this.Controls.Add(this.rbPais);
            this.Controls.Add(this.rbContinent);
            this.Controls.Add(this.cbCategoria);
            this.Controls.Add(this.cbContinent);
            this.Controls.Add(this.cbPais);
            this.Controls.Add(this.lbDades);
            this.Controls.Add(this.dgDades);
            this.Controls.Add(this.lbRegio);
            this.Name = "FrmConsulta";
            this.Text = "FrmConsulta";
            this.Load += new System.EventHandler(this.FrmConsulta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRegio;
        private System.Windows.Forms.Label lbDades;
        private System.Windows.Forms.DataGridView dgDades;
        private System.Windows.Forms.ComboBox cbPais;
        private System.Windows.Forms.ComboBox cbContinent;
        private System.Windows.Forms.ComboBox cbCategoria;
        private System.Windows.Forms.RadioButton rbContinent;
        private System.Windows.Forms.RadioButton rbPais;
        private System.Windows.Forms.RadioButton rbCategoria;
    }
}