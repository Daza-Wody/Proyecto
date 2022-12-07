namespace CapaPresentacion
{
    partial class FormTrabajadorTrajes
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnReservar = new System.Windows.Forms.Button();
            this.btnregistrarcliente = new System.Windows.Forms.Button();
            this.VistaDatos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscarTraje = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.VistaDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnCancelar.Location = new System.Drawing.Point(590, 397);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(94, 37);
            this.btnCancelar.TabIndex = 0;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnReservar
            // 
            this.btnReservar.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnReservar.Location = new System.Drawing.Point(210, 397);
            this.btnReservar.Name = "btnReservar";
            this.btnReservar.Size = new System.Drawing.Size(94, 37);
            this.btnReservar.TabIndex = 1;
            this.btnReservar.Text = "Reservar";
            this.btnReservar.UseVisualStyleBackColor = true;
            // 
            // btnregistrarcliente
            // 
            this.btnregistrarcliente.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnregistrarcliente.Location = new System.Drawing.Point(41, 397);
            this.btnregistrarcliente.Name = "btnregistrarcliente";
            this.btnregistrarcliente.Size = new System.Drawing.Size(141, 37);
            this.btnregistrarcliente.TabIndex = 2;
            this.btnregistrarcliente.Text = "Registrar cliente";
            this.btnregistrarcliente.UseVisualStyleBackColor = true;
            // 
            // VistaDatos
            // 
            this.VistaDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VistaDatos.Location = new System.Drawing.Point(29, 89);
            this.VistaDatos.Name = "VistaDatos";
            this.VistaDatos.RowHeadersWidth = 51;
            this.VistaDatos.RowTemplate.Height = 29;
            this.VistaDatos.Size = new System.Drawing.Size(655, 261);
            this.VistaDatos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(29, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar";
            // 
            // txtBuscarTraje
            // 
            this.txtBuscarTraje.Location = new System.Drawing.Point(101, 48);
            this.txtBuscarTraje.Name = "txtBuscarTraje";
            this.txtBuscarTraje.Size = new System.Drawing.Size(315, 27);
            this.txtBuscarTraje.TabIndex = 5;
            // 
            // FormTrabajadorTrajes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Navy;
            this.ClientSize = new System.Drawing.Size(720, 475);
            this.Controls.Add(this.txtBuscarTraje);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.VistaDatos);
            this.Controls.Add(this.btnregistrarcliente);
            this.Controls.Add(this.btnReservar);
            this.Controls.Add(this.btnCancelar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormTrabajadorTrajes";
            this.Text = "FormTrabajador";
            this.Load += new System.EventHandler(this.FormTrabajadorTrajes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.VistaDatos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnCancelar;
        private Button btnReservar;
        private Button btnregistrarcliente;
        private DataGridView VistaDatos;
        private Label label1;
        private TextBox txtBuscarTraje;
    }
}