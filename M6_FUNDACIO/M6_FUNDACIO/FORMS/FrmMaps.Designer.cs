namespace M6_FUNDACIO.FORMS
{
    partial class FrmMaps
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbRegio = new System.Windows.Forms.Label();
            this.dgDades = new System.Windows.Forms.DataGridView();
            this.pbDel = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.cbContinents = new System.Windows.Forms.ComboBox();
            this.btCancelar = new System.Windows.Forms.Button();
            this.btAccept = new System.Windows.Forms.Button();
            this.lbLink = new System.Windows.Forms.Label();
            this.tbLink = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // lbRegio
            // 
            this.lbRegio.AutoSize = true;
            this.lbRegio.BackColor = System.Drawing.Color.Tan;
            this.lbRegio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRegio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegio.ForeColor = System.Drawing.Color.Black;
            this.lbRegio.Location = new System.Drawing.Point(418, 7);
            this.lbRegio.MinimumSize = new System.Drawing.Size(100, 2);
            this.lbRegio.Name = "lbRegio";
            this.lbRegio.Padding = new System.Windows.Forms.Padding(3);
            this.lbRegio.Size = new System.Drawing.Size(259, 40);
            this.lbRegio.TabIndex = 33;
            this.lbRegio.Text = "Dades Fundacions";
            // 
            // dgDades
            // 
            this.dgDades.AllowUserToAddRows = false;
            this.dgDades.AllowUserToDeleteRows = false;
            this.dgDades.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgDades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgDades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDades.Location = new System.Drawing.Point(12, 122);
            this.dgDades.Name = "dgDades";
            this.dgDades.ReadOnly = true;
            this.dgDades.RowHeadersVisible = false;
            this.dgDades.RowHeadersWidth = 51;
            this.dgDades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDades.Size = new System.Drawing.Size(1066, 424);
            this.dgDades.TabIndex = 30;
            // 
            // pbDel
            // 
            this.pbDel.Image = global::M6_FUNDACIO.Properties.Resources.cancel50;
            this.pbDel.Location = new System.Drawing.Point(208, 573);
            this.pbDel.Name = "pbDel";
            this.pbDel.Size = new System.Drawing.Size(71, 72);
            this.pbDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDel.TabIndex = 32;
            this.pbDel.TabStop = false;
            // 
            // pbAdd
            // 
            this.pbAdd.Image = global::M6_FUNDACIO.Properties.Resources.add50;
            this.pbAdd.Location = new System.Drawing.Point(37, 573);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(71, 72);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 31;
            this.pbAdd.TabStop = false;
            // 
            // cbContinents
            // 
            this.cbContinents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContinents.FormattingEnabled = true;
            this.cbContinents.Location = new System.Drawing.Point(12, 72);
            this.cbContinents.Name = "cbContinents";
            this.cbContinents.Size = new System.Drawing.Size(1066, 24);
            this.cbContinents.TabIndex = 34;
            this.cbContinents.SelectedIndexChanged += new System.EventHandler(this.cbContinents_SelectedIndexChanged);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCancelar.Location = new System.Drawing.Point(445, 649);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(90, 42);
            this.btCancelar.TabIndex = 38;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            // 
            // btAccept
            // 
            this.btAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btAccept.Location = new System.Drawing.Point(667, 649);
            this.btAccept.Name = "btAccept";
            this.btAccept.Size = new System.Drawing.Size(90, 42);
            this.btAccept.TabIndex = 37;
            this.btAccept.Text = "Aceptar";
            this.btAccept.UseVisualStyleBackColor = false;
            // 
            // lbLink
            // 
            this.lbLink.AutoSize = true;
            this.lbLink.Location = new System.Drawing.Point(399, 567);
            this.lbLink.Name = "lbLink";
            this.lbLink.Size = new System.Drawing.Size(68, 16);
            this.lbLink.TabIndex = 36;
            this.lbLink.Text = "Link Maps";
            // 
            // tbLink
            // 
            this.tbLink.Location = new System.Drawing.Point(399, 593);
            this.tbLink.Name = "tbLink";
            this.tbLink.Size = new System.Drawing.Size(379, 22);
            this.tbLink.TabIndex = 35;
            // 
            // FrmMaps
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 722);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAccept);
            this.Controls.Add(this.lbLink);
            this.Controls.Add(this.tbLink);
            this.Controls.Add(this.cbContinents);
            this.Controls.Add(this.lbRegio);
            this.Controls.Add(this.pbDel);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.dgDades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmMaps";
            this.Text = "FrmMaps";
            this.Load += new System.EventHandler(this.FrmMaps_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbRegio;
        private System.Windows.Forms.PictureBox pbDel;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.DataGridView dgDades;
        private System.Windows.Forms.ComboBox cbContinents;
        private System.Windows.Forms.Button btCancelar;
        private System.Windows.Forms.Button btAccept;
        private System.Windows.Forms.Label lbLink;
        private System.Windows.Forms.TextBox tbLink;
    }
}