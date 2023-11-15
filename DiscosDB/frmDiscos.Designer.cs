
namespace DiscosDB
{
    partial class frmDiscos
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDiscos = new System.Windows.Forms.DataGridView();
            this.pbDiscos = new System.Windows.Forms.PictureBox();
            this.dgvEstilos = new System.Windows.Forms.DataGridView();
            this.btnAgregarDisco = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminarFisicamente = new System.Windows.Forms.Button();
            this.btnFiltroAvanzado = new System.Windows.Forms.Button();
            this.txtbFiltrar = new System.Windows.Forms.TextBox();
            this.lblFiltro = new System.Windows.Forms.Label();
            this.cbCampo = new System.Windows.Forms.ComboBox();
            this.cbCriterio = new System.Windows.Forms.ComboBox();
            this.lblCampo = new System.Windows.Forms.Label();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.lblFiltroAvanzado = new System.Windows.Forms.Label();
            this.txtbFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.dtpFiltro = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstilos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDiscos
            // 
            this.dgvDiscos.AllowUserToDeleteRows = false;
            this.dgvDiscos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgvDiscos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            this.dgvDiscos.ColumnHeadersHeight = 25;
            this.dgvDiscos.Location = new System.Drawing.Point(7, 58);
            this.dgvDiscos.MultiSelect = false;
            this.dgvDiscos.Name = "dgvDiscos";
            this.dgvDiscos.ReadOnly = true;
            this.dgvDiscos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDiscos.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDiscos.Size = new System.Drawing.Size(586, 156);
            this.dgvDiscos.TabIndex = 0;
            this.dgvDiscos.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // pbDiscos
            // 
            this.pbDiscos.Location = new System.Drawing.Point(599, 58);
            this.pbDiscos.Name = "pbDiscos";
            this.pbDiscos.Size = new System.Drawing.Size(201, 156);
            this.pbDiscos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDiscos.TabIndex = 1;
            this.pbDiscos.TabStop = false;
            // 
            // dgvEstilos
            // 
            this.dgvEstilos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstilos.Location = new System.Drawing.Point(649, 220);
            this.dgvEstilos.Name = "dgvEstilos";
            this.dgvEstilos.Size = new System.Drawing.Size(23, 10);
            this.dgvEstilos.TabIndex = 2;
            // 
            // btnAgregarDisco
            // 
            this.btnAgregarDisco.Location = new System.Drawing.Point(12, 220);
            this.btnAgregarDisco.Name = "btnAgregarDisco";
            this.btnAgregarDisco.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarDisco.TabIndex = 3;
            this.btnAgregarDisco.Text = "Agregar";
            this.btnAgregarDisco.UseVisualStyleBackColor = true;
            this.btnAgregarDisco.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(93, 220);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 4;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminarFisicamente
            // 
            this.btnEliminarFisicamente.Location = new System.Drawing.Point(174, 220);
            this.btnEliminarFisicamente.Name = "btnEliminarFisicamente";
            this.btnEliminarFisicamente.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarFisicamente.TabIndex = 5;
            this.btnEliminarFisicamente.Text = "Eliminar";
            this.btnEliminarFisicamente.UseVisualStyleBackColor = true;
            this.btnEliminarFisicamente.Click += new System.EventHandler(this.btnEliminarFisicamente_Click);
            // 
            // btnFiltroAvanzado
            // 
            this.btnFiltroAvanzado.Location = new System.Drawing.Point(556, 265);
            this.btnFiltroAvanzado.Name = "btnFiltroAvanzado";
            this.btnFiltroAvanzado.Size = new System.Drawing.Size(75, 23);
            this.btnFiltroAvanzado.TabIndex = 6;
            this.btnFiltroAvanzado.Text = "Buscar";
            this.btnFiltroAvanzado.UseVisualStyleBackColor = true;
            this.btnFiltroAvanzado.Click += new System.EventHandler(this.btnFiltroAvanzado_Click);
            // 
            // txtbFiltrar
            // 
            this.txtbFiltrar.Location = new System.Drawing.Point(152, 31);
            this.txtbFiltrar.Name = "txtbFiltrar";
            this.txtbFiltrar.Size = new System.Drawing.Size(100, 20);
            this.txtbFiltrar.TabIndex = 7;
            this.txtbFiltrar.TextChanged += new System.EventHandler(this.txtbFiltrar_TextChanged);
            // 
            // lblFiltro
            // 
            this.lblFiltro.AutoSize = true;
            this.lblFiltro.Location = new System.Drawing.Point(12, 34);
            this.lblFiltro.Name = "lblFiltro";
            this.lblFiltro.Size = new System.Drawing.Size(139, 13);
            this.lblFiltro.TabIndex = 8;
            this.lblFiltro.Text = "Filtrar por nombre o por año:";
            // 
            // cbCampo
            // 
            this.cbCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCampo.FormattingEnabled = true;
            this.cbCampo.Location = new System.Drawing.Point(60, 267);
            this.cbCampo.Name = "cbCampo";
            this.cbCampo.Size = new System.Drawing.Size(144, 21);
            this.cbCampo.TabIndex = 9;
            this.cbCampo.SelectedIndexChanged += new System.EventHandler(this.cbCampo_SelectedIndexChanged);
            // 
            // cbCriterio
            // 
            this.cbCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCriterio.FormattingEnabled = true;
            this.cbCriterio.Location = new System.Drawing.Point(258, 267);
            this.cbCriterio.Name = "cbCriterio";
            this.cbCriterio.Size = new System.Drawing.Size(143, 21);
            this.cbCriterio.TabIndex = 10;
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(11, 270);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(43, 13);
            this.lblCampo.TabIndex = 11;
            this.lblCampo.Text = "Campo:";
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(210, 270);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(42, 13);
            this.lblCriterio.TabIndex = 12;
            this.lblCriterio.Text = "Criterio:";
            // 
            // lblFiltroAvanzado
            // 
            this.lblFiltroAvanzado.AutoSize = true;
            this.lblFiltroAvanzado.Location = new System.Drawing.Point(407, 270);
            this.lblFiltroAvanzado.Name = "lblFiltroAvanzado";
            this.lblFiltroAvanzado.Size = new System.Drawing.Size(32, 13);
            this.lblFiltroAvanzado.TabIndex = 13;
            this.lblFiltroAvanzado.Text = "Filtro:";
            // 
            // txtbFiltroAvanzado
            // 
            this.txtbFiltroAvanzado.Location = new System.Drawing.Point(445, 267);
            this.txtbFiltroAvanzado.Name = "txtbFiltroAvanzado";
            this.txtbFiltroAvanzado.Size = new System.Drawing.Size(100, 20);
            this.txtbFiltroAvanzado.TabIndex = 14;
            // 
            // dtpFiltro
            // 
            this.dtpFiltro.Location = new System.Drawing.Point(445, 267);
            this.dtpFiltro.Name = "dtpFiltro";
            this.dtpFiltro.Size = new System.Drawing.Size(100, 20);
            this.dtpFiltro.TabIndex = 15;
            // 
            // frmDiscos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 320);
            this.Controls.Add(this.dtpFiltro);
            this.Controls.Add(this.txtbFiltroAvanzado);
            this.Controls.Add(this.lblFiltroAvanzado);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.cbCriterio);
            this.Controls.Add(this.cbCampo);
            this.Controls.Add(this.lblFiltro);
            this.Controls.Add(this.txtbFiltrar);
            this.Controls.Add(this.btnFiltroAvanzado);
            this.Controls.Add(this.btnEliminarFisicamente);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregarDisco);
            this.Controls.Add(this.dgvEstilos);
            this.Controls.Add(this.pbDiscos);
            this.Controls.Add(this.dgvDiscos);
            this.Name = "frmDiscos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstilos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDiscos;
        private System.Windows.Forms.PictureBox pbDiscos;
        private System.Windows.Forms.DataGridView dgvEstilos;
        private System.Windows.Forms.Button btnAgregarDisco;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminarFisicamente;
        private System.Windows.Forms.Button btnFiltroAvanzado;
        private System.Windows.Forms.TextBox txtbFiltrar;
        private System.Windows.Forms.Label lblFiltro;
        private System.Windows.Forms.ComboBox cbCampo;
        private System.Windows.Forms.ComboBox cbCriterio;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.Label lblFiltroAvanzado;
        private System.Windows.Forms.TextBox txtbFiltroAvanzado;
        private System.Windows.Forms.DateTimePicker dtpFiltro;
    }
}

