
namespace _00Comenzando
{
    partial class Form1
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
            this.boxPersonas = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDistancia = new System.Windows.Forms.Label();
            this.labelTransporte = new System.Windows.Forms.Label();
            this.labelTransporteContent = new System.Windows.Forms.Label();
            this.labelDistanciaContent = new System.Windows.Forms.Label();
            this.labelNombreContent = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtDistancia = new System.Windows.Forms.TextBox();
            this.bntAdd = new System.Windows.Forms.Button();
            this.txtResultado = new System.Windows.Forms.Label();
            this.cmbTransporte = new System.Windows.Forms.ComboBox();
            this.txtBorrar = new System.Windows.Forms.TextBox();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.lblResultadoBorrar = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // boxPersonas
            // 
            this.boxPersonas.FormattingEnabled = true;
            this.boxPersonas.Location = new System.Drawing.Point(125, 35);
            this.boxPersonas.Name = "boxPersonas";
            this.boxPersonas.Size = new System.Drawing.Size(232, 21);
            this.boxPersonas.TabIndex = 0;
            this.boxPersonas.SelectedIndexChanged += new System.EventHandler(this.On);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Personas";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(57, 86);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 2;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDistancia
            // 
            this.labelDistancia.AutoSize = true;
            this.labelDistancia.Location = new System.Drawing.Point(57, 122);
            this.labelDistancia.Name = "labelDistancia";
            this.labelDistancia.Size = new System.Drawing.Size(51, 13);
            this.labelDistancia.TabIndex = 3;
            this.labelDistancia.Text = "Distancia";
            // 
            // labelTransporte
            // 
            this.labelTransporte.AutoSize = true;
            this.labelTransporte.Location = new System.Drawing.Point(57, 159);
            this.labelTransporte.Name = "labelTransporte";
            this.labelTransporte.Size = new System.Drawing.Size(58, 13);
            this.labelTransporte.TabIndex = 4;
            this.labelTransporte.Text = "Transporte";
            // 
            // labelTransporteContent
            // 
            this.labelTransporteContent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelTransporteContent.Location = new System.Drawing.Point(122, 159);
            this.labelTransporteContent.Name = "labelTransporteContent";
            this.labelTransporteContent.Size = new System.Drawing.Size(272, 13);
            this.labelTransporteContent.TabIndex = 7;
            this.labelTransporteContent.Text = "Transporte";
            // 
            // labelDistanciaContent
            // 
            this.labelDistanciaContent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelDistanciaContent.Location = new System.Drawing.Point(122, 122);
            this.labelDistanciaContent.Name = "labelDistanciaContent";
            this.labelDistanciaContent.Size = new System.Drawing.Size(272, 13);
            this.labelDistanciaContent.TabIndex = 6;
            this.labelDistanciaContent.Text = "Distancia";
            // 
            // labelNombreContent
            // 
            this.labelNombreContent.BackColor = System.Drawing.SystemColors.ControlDark;
            this.labelNombreContent.Location = new System.Drawing.Point(122, 86);
            this.labelNombreContent.Name = "labelNombreContent";
            this.labelNombreContent.Size = new System.Drawing.Size(272, 13);
            this.labelNombreContent.TabIndex = 5;
            this.labelNombreContent.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(420, 83);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(160, 20);
            this.txtNombre.TabIndex = 8;
            // 
            // txtDistancia
            // 
            this.txtDistancia.Location = new System.Drawing.Point(420, 119);
            this.txtDistancia.Name = "txtDistancia";
            this.txtDistancia.Size = new System.Drawing.Size(160, 20);
            this.txtDistancia.TabIndex = 9;
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(420, 183);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 23);
            this.bntAdd.TabIndex = 11;
            this.bntAdd.Text = "Añadr";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.BntAdd_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.AutoSize = true;
            this.txtResultado.Location = new System.Drawing.Point(417, 218);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(55, 13);
            this.txtResultado.TabIndex = 12;
            this.txtResultado.Text = "Resultado";
            // 
            // cmbTransporte
            // 
            this.cmbTransporte.FormattingEnabled = true;
            this.cmbTransporte.Location = new System.Drawing.Point(420, 156);
            this.cmbTransporte.Name = "cmbTransporte";
            this.cmbTransporte.Size = new System.Drawing.Size(160, 21);
            this.cmbTransporte.TabIndex = 13;
            // 
            // txtBorrar
            // 
            this.txtBorrar.Location = new System.Drawing.Point(420, 245);
            this.txtBorrar.Name = "txtBorrar";
            this.txtBorrar.Size = new System.Drawing.Size(160, 20);
            this.txtBorrar.TabIndex = 14;
            // 
            // btnBorrar
            // 
            this.btnBorrar.Location = new System.Drawing.Point(420, 271);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(75, 23);
            this.btnBorrar.TabIndex = 15;
            this.btnBorrar.Text = "Borrar";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // lblResultadoBorrar
            // 
            this.lblResultadoBorrar.AutoSize = true;
            this.lblResultadoBorrar.Location = new System.Drawing.Point(417, 309);
            this.lblResultadoBorrar.Name = "lblResultadoBorrar";
            this.lblResultadoBorrar.Size = new System.Drawing.Size(55, 13);
            this.lblResultadoBorrar.TabIndex = 16;
            this.lblResultadoBorrar.Text = "Resultado";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblResultadoBorrar);
            this.Controls.Add(this.btnBorrar);
            this.Controls.Add(this.txtBorrar);
            this.Controls.Add(this.cmbTransporte);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.txtDistancia);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.labelTransporteContent);
            this.Controls.Add(this.labelDistanciaContent);
            this.Controls.Add(this.labelNombreContent);
            this.Controls.Add(this.labelTransporte);
            this.Controls.Add(this.labelDistancia);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boxPersonas);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox boxPersonas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDistancia;
        private System.Windows.Forms.Label labelTransporte;
        private System.Windows.Forms.Label labelTransporteContent;
        private System.Windows.Forms.Label labelDistanciaContent;
        private System.Windows.Forms.Label labelNombreContent;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtDistancia;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Label txtResultado;
        private System.Windows.Forms.ComboBox cmbTransporte;
        private System.Windows.Forms.TextBox txtBorrar;
        private System.Windows.Forms.Button btnBorrar;
        private System.Windows.Forms.Label lblResultadoBorrar;
    }
}

