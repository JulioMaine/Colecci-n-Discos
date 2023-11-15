
namespace DiscosDB
{
    partial class frmAgregarDisco
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblCantidadCanc = new System.Windows.Forms.Label();
            this.txtbTitulo = new System.Windows.Forms.TextBox();
            this.txtbCantidadCanciones = new System.Windows.Forms.TextBox();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.dtpFechaLanzamiento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbEstilo = new System.Windows.Forms.ComboBox();
            this.cbTipoEdicion = new System.Windows.Forms.ComboBox();
            this.lblAgregarImagen = new System.Windows.Forms.Label();
            this.txtbUrlImagen = new System.Windows.Forms.TextBox();
            this.pbDiscos = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Location = new System.Drawing.Point(100, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(38, 13);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Título:";
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(24, 48);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(114, 13);
            this.lblFecha.TabIndex = 1;
            this.lblFecha.Text = "Fecha de lanzamiento:";
            // 
            // lblCantidadCanc
            // 
            this.lblCantidadCanc.AutoSize = true;
            this.lblCantidadCanc.Location = new System.Drawing.Point(18, 79);
            this.lblCantidadCanc.Name = "lblCantidadCanc";
            this.lblCantidadCanc.Size = new System.Drawing.Size(120, 13);
            this.lblCantidadCanc.TabIndex = 2;
            this.lblCantidadCanc.Text = "Cantidad de Canciones:";
            // 
            // txtbTitulo
            // 
            this.txtbTitulo.Location = new System.Drawing.Point(142, 12);
            this.txtbTitulo.Name = "txtbTitulo";
            this.txtbTitulo.Size = new System.Drawing.Size(200, 20);
            this.txtbTitulo.TabIndex = 4;
            // 
            // txtbCantidadCanciones
            // 
            this.txtbCantidadCanciones.Location = new System.Drawing.Point(142, 76);
            this.txtbCantidadCanciones.Name = "txtbCantidadCanciones";
            this.txtbCantidadCanciones.Size = new System.Drawing.Size(200, 20);
            this.txtbCantidadCanciones.TabIndex = 6;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(63, 190);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 7;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(267, 190);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // dtpFechaLanzamiento
            // 
            this.dtpFechaLanzamiento.Location = new System.Drawing.Point(142, 42);
            this.dtpFechaLanzamiento.Name = "dtpFechaLanzamiento";
            this.dtpFechaLanzamiento.Size = new System.Drawing.Size(200, 20);
            this.dtpFechaLanzamiento.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(103, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Estilo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 167);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tipo de Edición:";
            // 
            // cbEstilo
            // 
            this.cbEstilo.FormattingEnabled = true;
            this.cbEstilo.Location = new System.Drawing.Point(142, 136);
            this.cbEstilo.Name = "cbEstilo";
            this.cbEstilo.Size = new System.Drawing.Size(200, 21);
            this.cbEstilo.TabIndex = 12;
            // 
            // cbTipoEdicion
            // 
            this.cbTipoEdicion.FormattingEnabled = true;
            this.cbTipoEdicion.Location = new System.Drawing.Point(142, 163);
            this.cbTipoEdicion.Name = "cbTipoEdicion";
            this.cbTipoEdicion.Size = new System.Drawing.Size(200, 21);
            this.cbTipoEdicion.TabIndex = 13;
            // 
            // lblAgregarImagen
            // 
            this.lblAgregarImagen.AutoSize = true;
            this.lblAgregarImagen.Location = new System.Drawing.Point(80, 108);
            this.lblAgregarImagen.Name = "lblAgregarImagen";
            this.lblAgregarImagen.Size = new System.Drawing.Size(58, 13);
            this.lblAgregarImagen.TabIndex = 14;
            this.lblAgregarImagen.Text = "UrlImagen:";
            // 
            // txtbUrlImagen
            // 
            this.txtbUrlImagen.Location = new System.Drawing.Point(142, 105);
            this.txtbUrlImagen.Name = "txtbUrlImagen";
            this.txtbUrlImagen.Size = new System.Drawing.Size(200, 20);
            this.txtbUrlImagen.TabIndex = 15;
            this.txtbUrlImagen.Leave += new System.EventHandler(this.txtbUrlImagen_Leave);
            // 
            // pbDiscos
            // 
            this.pbDiscos.Location = new System.Drawing.Point(348, 12);
            this.pbDiscos.Name = "pbDiscos";
            this.pbDiscos.Size = new System.Drawing.Size(192, 172);
            this.pbDiscos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbDiscos.TabIndex = 16;
            this.pbDiscos.TabStop = false;
            // 
            // frmAgregarDisco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 224);
            this.Controls.Add(this.pbDiscos);
            this.Controls.Add(this.txtbUrlImagen);
            this.Controls.Add(this.lblAgregarImagen);
            this.Controls.Add(this.cbTipoEdicion);
            this.Controls.Add(this.cbEstilo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpFechaLanzamiento);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.txtbCantidadCanciones);
            this.Controls.Add(this.txtbTitulo);
            this.Controls.Add(this.lblCantidadCanc);
            this.Controls.Add(this.lblFecha);
            this.Controls.Add(this.lblTitulo);
            this.Name = "frmAgregarDisco";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAgregarDisco";
            this.Load += new System.EventHandler(this.frmAgregarDisco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbDiscos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblCantidadCanc;
        private System.Windows.Forms.TextBox txtbTitulo;
        private System.Windows.Forms.TextBox txtbCantidadCanciones;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dtpFechaLanzamiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbEstilo;
        private System.Windows.Forms.ComboBox cbTipoEdicion;
        private System.Windows.Forms.Label lblAgregarImagen;
        private System.Windows.Forms.TextBox txtbUrlImagen;
        private System.Windows.Forms.PictureBox pbDiscos;
    }
}