namespace M6_FUNDACIO.FORMS
{
    partial class FrmCategoria
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbEstudiants = new System.Windows.Forms.ComboBox();
            this.dgNoMatriculat = new System.Windows.Forms.DataGridView();
            this.lbRegio = new System.Windows.Forms.Label();
            this.dgMatriculat = new System.Windows.Forms.DataGridView();
            this.pbDel = new System.Windows.Forms.PictureBox();
            this.pbAdd = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgNoMatriculat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatriculat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // cbEstudiants
            // 
            this.cbEstudiants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEstudiants.FormattingEnabled = true;
            this.cbEstudiants.Location = new System.Drawing.Point(14, 61);
            this.cbEstudiants.Name = "cbEstudiants";
            this.cbEstudiants.Size = new System.Drawing.Size(745, 24);
            this.cbEstudiants.TabIndex = 28;
            this.cbEstudiants.SelectedIndexChanged += new System.EventHandler(this.cbEstudiants_SelectedIndexChanged);
            // 
            // dgNoMatriculat
            // 
            this.dgNoMatriculat.AllowUserToAddRows = false;
            this.dgNoMatriculat.AllowUserToDeleteRows = false;
            this.dgNoMatriculat.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgNoMatriculat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgNoMatriculat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgNoMatriculat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgNoMatriculat.Location = new System.Drawing.Point(401, 109);
            this.dgNoMatriculat.Name = "dgNoMatriculat";
            this.dgNoMatriculat.ReadOnly = true;
            this.dgNoMatriculat.RowHeadersVisible = false;
            this.dgNoMatriculat.RowHeadersWidth = 51;
            this.dgNoMatriculat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgNoMatriculat.Size = new System.Drawing.Size(358, 486);
            this.dgNoMatriculat.TabIndex = 27;
            // 
            // lbRegio
            // 
            this.lbRegio.AutoSize = true;
            this.lbRegio.BackColor = System.Drawing.Color.Tan;
            this.lbRegio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbRegio.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRegio.ForeColor = System.Drawing.Color.Black;
            this.lbRegio.Location = new System.Drawing.Point(323, 7);
            this.lbRegio.MinimumSize = new System.Drawing.Size(100, 2);
            this.lbRegio.Name = "lbRegio";
            this.lbRegio.Padding = new System.Windows.Forms.Padding(3);
            this.lbRegio.Size = new System.Drawing.Size(160, 40);
            this.lbRegio.TabIndex = 26;
            this.lbRegio.Text = "Categories";
            // 
            // dgMatriculat
            // 
            this.dgMatriculat.AllowUserToAddRows = false;
            this.dgMatriculat.AllowUserToDeleteRows = false;
            this.dgMatriculat.AllowUserToOrderColumns = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dgMatriculat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dgMatriculat.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgMatriculat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMatriculat.Location = new System.Drawing.Point(14, 109);
            this.dgMatriculat.Name = "dgMatriculat";
            this.dgMatriculat.ReadOnly = true;
            this.dgMatriculat.RowHeadersVisible = false;
            this.dgMatriculat.RowHeadersWidth = 51;
            this.dgMatriculat.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgMatriculat.Size = new System.Drawing.Size(358, 486);
            this.dgMatriculat.TabIndex = 23;
            // 
            // pbDel
            // 
            this.pbDel.Image = global::M6_FUNDACIO.Properties.Resources.cancel50;
            this.pbDel.Location = new System.Drawing.Point(14, 601);
            this.pbDel.Name = "pbDel";
            this.pbDel.Size = new System.Drawing.Size(71, 72);
            this.pbDel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbDel.TabIndex = 25;
            this.pbDel.TabStop = false;
            this.pbDel.Click += new System.EventHandler(this.pbDel_Click);
            // 
            // pbAdd
            // 
            this.pbAdd.Image = global::M6_FUNDACIO.Properties.Resources.add50;
            this.pbAdd.Location = new System.Drawing.Point(688, 601);
            this.pbAdd.Name = "pbAdd";
            this.pbAdd.Size = new System.Drawing.Size(71, 72);
            this.pbAdd.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdd.TabIndex = 24;
            this.pbAdd.TabStop = false;
            this.pbAdd.Click += new System.EventHandler(this.pbAdd_Click);
            // 
            // FrmCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 694);
            this.Controls.Add(this.cbEstudiants);
            this.Controls.Add(this.dgNoMatriculat);
            this.Controls.Add(this.lbRegio);
            this.Controls.Add(this.pbDel);
            this.Controls.Add(this.pbAdd);
            this.Controls.Add(this.dgMatriculat);
            this.Name = "FrmCategoria";
            this.Text = "FrmCategoria";
            this.Load += new System.EventHandler(this.FrmCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgNoMatriculat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatriculat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbEstudiants;
        private System.Windows.Forms.DataGridView dgNoMatriculat;
        private System.Windows.Forms.Label lbRegio;
        private System.Windows.Forms.PictureBox pbDel;
        private System.Windows.Forms.PictureBox pbAdd;
        private System.Windows.Forms.DataGridView dgMatriculat;
    }
}