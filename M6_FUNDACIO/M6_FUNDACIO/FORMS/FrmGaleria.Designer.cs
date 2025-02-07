﻿namespace M6_FUNDACIO.FORMS
{
    partial class FrmGaleria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbContinents = new System.Windows.Forms.ComboBox();
            this.lbRegio = new System.Windows.Forms.Label();
            this.pbDel = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            this.dgDades = new System.Windows.Forms.DataGridView();
            this.pbImatge = new System.Windows.Forms.PictureBox();
            this.tbDesc = new System.Windows.Forms.TextBox();
            this.lbDesc = new System.Windows.Forms.Label();
            this.btAccept = new System.Windows.Forms.Button();
            this.btCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImatge)).BeginInit();
            this.SuspendLayout();
            // 
            // cbContinents
            // 
            this.cbContinents.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbContinents.FormattingEnabled = true;
            this.cbContinents.Location = new System.Drawing.Point(12, 85);
            this.cbContinents.Name = "cbContinents";
            this.cbContinents.Size = new System.Drawing.Size(776, 24);
            this.cbContinents.TabIndex = 26;
            this.cbContinents.SelectedIndexChanged += new System.EventHandler(this.cbContinents_SelectedIndexChanged);
            // 
            // lbRegio
            // 
            this.lbRegio.AutoSize = true;
            this.lbRegio.BackColor = System.Drawing.Color.Tan;
            this.lbRegio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRegio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegio.ForeColor = System.Drawing.Color.Black;
            this.lbRegio.Location = new System.Drawing.Point(252, 22);
            this.lbRegio.MinimumSize = new System.Drawing.Size(100, 2);
            this.lbRegio.Name = "lbRegio";
            this.lbRegio.Padding = new System.Windows.Forms.Padding(3);
            this.lbRegio.Size = new System.Drawing.Size(243, 40);
            this.lbRegio.TabIndex = 25;
            this.lbRegio.Text = "Galeria d\'Imatges";
            // 
            // pbDel
            // 
            this.pbDel.Image = global::M6_FUNDACIO.Properties.Resources.cancel50;
            this.pbDel.Location = new System.Drawing.Point(513, 624);
            this.pbDel.Name = "pbDel";
            this.pbDel.Size = new System.Drawing.Size(71, 72);
            this.pbDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDel.TabIndex = 24;
            this.pbDel.TabStop = false;
            this.pbDel.Click += new System.EventHandler(this.pbDel_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.Image = global::M6_FUNDACIO.Properties.Resources.add50;
            this.pbAdd.Location = new System.Drawing.Point(185, 624);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(71, 72);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 23;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // dgDades
            // 
            this.dgDades.AllowUserToAddRows = false;
            this.dgDades.AllowUserToDeleteRows = false;
            this.dgDades.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgDades.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgDades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgDades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDades.Location = new System.Drawing.Point(12, 136);
            this.dgDades.Name = "dgDades";
            this.dgDades.ReadOnly = true;
            this.dgDades.RowHeadersVisible = false;
            this.dgDades.RowHeadersWidth = 51;
            this.dgDades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgDades.Size = new System.Drawing.Size(776, 483);
            this.dgDades.TabIndex = 22;
            this.dgDades.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDades_CellClick);
            // 
            // pbImatge
            // 
            this.pbImatge.Location = new System.Drawing.Point(822, 136);
            this.pbImatge.Name = "pbImatge";
            this.pbImatge.Size = new System.Drawing.Size(379, 327);
            this.pbImatge.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbImatge.TabIndex = 0;
            this.pbImatge.TabStop = false;
            // 
            // tbDesc
            // 
            this.tbDesc.Location = new System.Drawing.Point(822, 506);
            this.tbDesc.Name = "tbDesc";
            this.tbDesc.Size = new System.Drawing.Size(379, 22);
            this.tbDesc.TabIndex = 27;
            // 
            // lbDesc
            // 
            this.lbDesc.AutoSize = true;
            this.lbDesc.Location = new System.Drawing.Point(822, 480);
            this.lbDesc.Name = "lbDesc";
            this.lbDesc.Size = new System.Drawing.Size(72, 16);
            this.lbDesc.TabIndex = 28;
            this.lbDesc.Text = "Descripcio";
            // 
            // btAccept
            // 
            this.btAccept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btAccept.Location = new System.Drawing.Point(1090, 562);
            this.btAccept.Name = "btAccept";
            this.btAccept.Size = new System.Drawing.Size(90, 42);
            this.btAccept.TabIndex = 29;
            this.btAccept.Text = "Aceptar";
            this.btAccept.UseVisualStyleBackColor = false;
            this.btAccept.Click += new System.EventHandler(this.btAccept_Click);
            // 
            // btCancelar
            // 
            this.btCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btCancelar.Location = new System.Drawing.Point(868, 562);
            this.btCancelar.Name = "btCancelar";
            this.btCancelar.Size = new System.Drawing.Size(90, 42);
            this.btCancelar.TabIndex = 30;
            this.btCancelar.Text = "Cancelar";
            this.btCancelar.UseVisualStyleBackColor = false;
            // 
            // FrmGaleria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1222, 708);
            this.Controls.Add(this.btCancelar);
            this.Controls.Add(this.btAccept);
            this.Controls.Add(this.lbDesc);
            this.Controls.Add(this.tbDesc);
            this.Controls.Add(this.pbImatge);
            this.Controls.Add(this.cbContinents);
            this.Controls.Add(this.lbRegio);
            this.Controls.Add(this.pbDel);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.dgDades);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "FrmGaleria";
            this.Text = "FrmGaleria";
            this.Load += new System.EventHandler(this.FrmGaleria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgDades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbImatge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbContinents;
        private System.Windows.Forms.Label lbRegio;
        private System.Windows.Forms.PictureBox pbDel;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.DataGridView dgDades;
        private System.Windows.Forms.PictureBox pbImatge;
        private System.Windows.Forms.TextBox tbDesc;
        private System.Windows.Forms.Label lbDesc;
        private System.Windows.Forms.Button btAccept;
        private System.Windows.Forms.Button btCancelar;
    }
}