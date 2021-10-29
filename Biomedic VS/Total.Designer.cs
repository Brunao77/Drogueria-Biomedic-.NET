
namespace Biomedic_VS
{
    partial class Total
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
            this.components = new System.ComponentModel.Container();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.buttonCargarMedicamento = new System.Windows.Forms.Button();
            this.buttonBorrarMedicamento = new System.Windows.Forms.Button();
            this.buttonBuscarMedicamento = new System.Windows.Forms.Button();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.textBoxLote = new System.Windows.Forms.TextBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.buttonConfirmarCarga = new System.Windows.Forms.Button();
            this.buttonCancelarCarga = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonConfirmarBorrar = new System.Windows.Forms.Button();
            this.buttonCancelarBorrar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv
            // 
            this.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(318, 12);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.Size = new System.Drawing.Size(430, 396);
            this.dgv.TabIndex = 0;
            // 
            // buttonCargarMedicamento
            // 
            this.buttonCargarMedicamento.Enabled = false;
            this.buttonCargarMedicamento.Location = new System.Drawing.Point(28, 12);
            this.buttonCargarMedicamento.Name = "buttonCargarMedicamento";
            this.buttonCargarMedicamento.Size = new System.Drawing.Size(248, 57);
            this.buttonCargarMedicamento.TabIndex = 1;
            this.buttonCargarMedicamento.Text = "Añadir";
            this.buttonCargarMedicamento.UseVisualStyleBackColor = true;
            this.buttonCargarMedicamento.Click += new System.EventHandler(this.buttonCargarMedicamento_Click);
            // 
            // buttonBorrarMedicamento
            // 
            this.buttonBorrarMedicamento.Enabled = false;
            this.buttonBorrarMedicamento.Location = new System.Drawing.Point(28, 84);
            this.buttonBorrarMedicamento.Name = "buttonBorrarMedicamento";
            this.buttonBorrarMedicamento.Size = new System.Drawing.Size(248, 57);
            this.buttonBorrarMedicamento.TabIndex = 2;
            this.buttonBorrarMedicamento.Text = "Eliminar";
            this.buttonBorrarMedicamento.UseVisualStyleBackColor = true;
            this.buttonBorrarMedicamento.Click += new System.EventHandler(this.buttonBorrarMedicamento_Click);
            // 
            // buttonBuscarMedicamento
            // 
            this.buttonBuscarMedicamento.Enabled = false;
            this.buttonBuscarMedicamento.Location = new System.Drawing.Point(28, 158);
            this.buttonBuscarMedicamento.Name = "buttonBuscarMedicamento";
            this.buttonBuscarMedicamento.Size = new System.Drawing.Size(248, 57);
            this.buttonBuscarMedicamento.TabIndex = 3;
            this.buttonBuscarMedicamento.Text = "Buscar";
            this.buttonBuscarMedicamento.UseVisualStyleBackColor = true;
            this.buttonBuscarMedicamento.Click += new System.EventHandler(this.buttonBuscarMedicamento_Click);
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(28, 248);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(248, 20);
            this.textBoxNombre.TabIndex = 4;
            this.textBoxNombre.TextChanged += new System.EventHandler(this.textBoxNombre_TextChanged);
            // 
            // textBoxLote
            // 
            this.textBoxLote.Location = new System.Drawing.Point(28, 287);
            this.textBoxLote.Name = "textBoxLote";
            this.textBoxLote.Size = new System.Drawing.Size(248, 20);
            this.textBoxLote.TabIndex = 5;
            this.textBoxLote.TextChanged += new System.EventHandler(this.textBoxLote_TextChanged);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.monthCalendar1.Location = new System.Drawing.Point(28, 332);
            this.monthCalendar1.MaxSelectionCount = 1;
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowTodayCircle = false;
            this.monthCalendar1.TabIndex = 8;
            this.monthCalendar1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 232);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Nombre :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Lote :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Vencimiento :";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // buttonConfirmarCarga
            // 
            this.buttonConfirmarCarga.Location = new System.Drawing.Point(594, 468);
            this.buttonConfirmarCarga.Name = "buttonConfirmarCarga";
            this.buttonConfirmarCarga.Size = new System.Drawing.Size(95, 25);
            this.buttonConfirmarCarga.TabIndex = 12;
            this.buttonConfirmarCarga.Text = "Confirmar";
            this.buttonConfirmarCarga.UseVisualStyleBackColor = true;
            this.buttonConfirmarCarga.Visible = false;
            this.buttonConfirmarCarga.Click += new System.EventHandler(this.buttonConfirmarCarga_Click);
            // 
            // buttonCancelarCarga
            // 
            this.buttonCancelarCarga.Location = new System.Drawing.Point(695, 468);
            this.buttonCancelarCarga.Name = "buttonCancelarCarga";
            this.buttonCancelarCarga.Size = new System.Drawing.Size(94, 25);
            this.buttonCancelarCarga.TabIndex = 13;
            this.buttonCancelarCarga.Text = "Cancelar";
            this.buttonCancelarCarga.UseVisualStyleBackColor = true;
            this.buttonCancelarCarga.Visible = false;
            this.buttonCancelarCarga.Click += new System.EventHandler(this.buttonCancelarCarga_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(324, 448);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // buttonConfirmarBorrar
            // 
            this.buttonConfirmarBorrar.Location = new System.Drawing.Point(594, 468);
            this.buttonConfirmarBorrar.Name = "buttonConfirmarBorrar";
            this.buttonConfirmarBorrar.Size = new System.Drawing.Size(95, 25);
            this.buttonConfirmarBorrar.TabIndex = 15;
            this.buttonConfirmarBorrar.Text = "Confirmar";
            this.buttonConfirmarBorrar.UseVisualStyleBackColor = true;
            this.buttonConfirmarBorrar.Visible = false;
            this.buttonConfirmarBorrar.Click += new System.EventHandler(this.buttonConfirmarBorrar_Click);
            // 
            // buttonCancelarBorrar
            // 
            this.buttonCancelarBorrar.Location = new System.Drawing.Point(695, 469);
            this.buttonCancelarBorrar.Name = "buttonCancelarBorrar";
            this.buttonCancelarBorrar.Size = new System.Drawing.Size(94, 25);
            this.buttonCancelarBorrar.TabIndex = 16;
            this.buttonCancelarBorrar.Text = "Cancelar";
            this.buttonCancelarBorrar.UseVisualStyleBackColor = true;
            this.buttonCancelarBorrar.Visible = false;
            this.buttonCancelarBorrar.Click += new System.EventHandler(this.buttonCancelarBorrar_Click);
            // 
            // Total
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 511);
            this.Controls.Add(this.buttonCancelarBorrar);
            this.Controls.Add(this.buttonConfirmarBorrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonCancelarCarga);
            this.Controls.Add(this.buttonConfirmarCarga);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.textBoxLote);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.buttonBuscarMedicamento);
            this.Controls.Add(this.buttonBorrarMedicamento);
            this.Controls.Add(this.buttonCargarMedicamento);
            this.Controls.Add(this.dgv);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Total";
            this.Text = "Biomedic";
            this.Load += new System.EventHandler(this.Total_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button buttonCargarMedicamento;
        private System.Windows.Forms.Button buttonBorrarMedicamento;
        private System.Windows.Forms.Button buttonBuscarMedicamento;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.TextBox textBoxLote;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button buttonConfirmarCarga;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonCancelarCarga;
        private System.Windows.Forms.Button buttonCancelarBorrar;
        private System.Windows.Forms.Button buttonConfirmarBorrar;
    }
}