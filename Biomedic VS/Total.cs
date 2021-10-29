using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Biomedic_VS
{
    public partial class Total : Form
    {
        Medicamento medBorrar = new Medicamento();
        public Total()
        {
            InitializeComponent();
        }
        private void Total_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SQLiteDataAdapter da = new SQLiteDataAdapter("select * from medicamentos", Conexion.instanciaDb());
            da.Fill(dt);
            foreach (DataRow r in dt.Rows)
            {
                string nombre = r["nombre"].ToString();
                string lote = r["lote"].ToString();
                DateTime fecha = Convert.ToDateTime(r["vencimiento"]);
                Medicamento med = new Medicamento();
                med.Nombre = nombre;
                med.Lote = lote;
                med.Fecha = fecha;
                ListTest.lista.Add(med);
            }
            actualizarTabla();
        }
        private void controlBotones()
        {
            if (textBoxLote.Text != string.Empty)
            {
                if(ListTest.lista.Exists(x => x.Lote == textBoxLote.Text))
                {
                    buttonBorrarMedicamento.Enabled = true;
                    buttonBuscarMedicamento.Enabled = true;
                    errorProvider1.SetError(textBoxNombre, "");
                    errorProvider1.SetError(textBoxLote, "");
                }
                else
                {
                    buttonBorrarMedicamento.Enabled = false;
                    buttonBuscarMedicamento.Enabled = false;
                }
                if(textBoxNombre.Text != string.Empty && !(ListTest.lista.Exists(x => x.Lote == textBoxLote.Text)))
                {
                    buttonCargarMedicamento.Enabled = true;
                    errorProvider1.SetError(textBoxNombre, "");
                    errorProvider1.SetError(textBoxLote, "");
                }
                else
                {
                    buttonCargarMedicamento.Enabled = false;
                }
            }
            else
            {
                if (textBoxLote.Text.Trim() == string.Empty)
                {
                    errorProvider1.SetError(textBoxLote, "El espacio esta vacío");
                }
                else
                {
                    errorProvider1.SetError(textBoxLote, "");
                }
                buttonCargarMedicamento.Enabled = false;
                buttonBorrarMedicamento.Enabled = false;
                buttonBuscarMedicamento.Enabled = false;
            }
        }
        private void textBoxNombre_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }
        private void textBoxLote_TextChanged(object sender, EventArgs e)
        {
            controlBotones();
        }

        private void buttonCargarMedicamento_Click(object sender, EventArgs e)
        {
            char[] delimit = new char[] { '/', ' ' };
            DateTime fecha = monthCalendar1.SelectionStart;
            string l = fecha.ToString();
            string[] nuevafecha = l.Split(delimit);
            string nombre = textBoxNombre.Text;
            string lote = textBoxLote.Text;
            buttonCancelarCarga.Visible = true;
            label4.Visible = true;
            buttonConfirmarCarga.Visible = true;
            textBoxNombre.Enabled = false;
            textBoxLote.Enabled = false;
            monthCalendar1.Enabled = false;
            buttonCargarMedicamento.Enabled = false;
            buttonBorrarMedicamento.Enabled = false;
            buttonBuscarMedicamento.Enabled = false;
            int dia = Int16.Parse(nuevafecha[0]);
            int mes = Int16.Parse(nuevafecha[1]);
            int ano = Int16.Parse(nuevafecha[2]);
            label4.Text = "Medicamento : " + nombre + "\nLote : " + lote + "\nVencimiento : " + dia + " / " + mes + " / " + ano + "\n¿Desea guardarlo? ";
        }

        private void buttonConfirmarCarga_Click(object sender, EventArgs e)
        {
            Medicamento med = new Medicamento();
            DateTime fecha = monthCalendar1.SelectionStart;
            med.Fecha = fecha;
            med.Nombre = textBoxNombre.Text;
            med.Lote = textBoxLote.Text;
            ListTest.lista.Add(med);
            var query = "insert into medicamentos (nombre, lote, vencimiento) values (@nombre, @lote, @vencimiento)";
            SQLiteCommand myCommand = new SQLiteCommand(query, Conexion.instanciaDb());
            myCommand.Parameters.Add(new SQLiteParameter("@nombre", textBoxNombre.Text));
            myCommand.Parameters.Add(new SQLiteParameter("@lote", textBoxLote.Text));
            myCommand.Parameters.Add(new SQLiteParameter("@vencimiento", fecha.ToString()));
            myCommand.ExecuteNonQuery();
            buttonCancelarCarga.Visible = false;
            label4.Visible = false;
            buttonConfirmarCarga.Visible = false;
            textBoxNombre.Enabled = true;
            textBoxLote.Enabled = true;
            monthCalendar1.Enabled = true;
            textBoxLote.Clear();
            textBoxNombre.Clear();
            actualizarTabla();
        }

        private void buttonCancelarCarga_Click(object sender, EventArgs e)
        {
            buttonCancelarCarga.Visible = false;
            label4.Visible = false;
            buttonConfirmarCarga.Visible = false;
            textBoxNombre.Enabled = true;
            textBoxLote.Enabled = true;
            monthCalendar1.Enabled = true;
            textBoxLote.Clear();
            textBoxNombre.Clear();
        }
        private void buttonBorrarMedicamento_Click(object sender, EventArgs e)
        {
            buttonBorrarMedicamento.Enabled = false;
            label4.Visible = true;
            textBoxNombre.Enabled = false;
            textBoxLote.Enabled = false;
            monthCalendar1.Enabled = false;
            buttonCargarMedicamento.Enabled = false;
            buttonBuscarMedicamento.Enabled = false;
            buttonConfirmarBorrar.Visible = true;
            buttonCancelarBorrar.Visible = true;

            foreach (Medicamento med in ListTest.lista)
            {
                if (med.Lote == textBoxLote.Text)
                {
                    medBorrar = med;
                }
            }
            char[] delimit = new char[] { '/', ' ' };
            string l = medBorrar.Fecha.ToString();
            string[] nuevafecha = l.Split(delimit); //Divido la fecha [0]: Día | [1]: Mes | [2]: Año
            int dia = Int16.Parse(nuevafecha[0]);
            int mes = Int16.Parse(nuevafecha[1]);
            int ano = Int16.Parse(nuevafecha[2]);
            label4.Text = "Medicamento : " + medBorrar.Nombre + "\nLote : " + medBorrar.Lote + "\nVencimiento : " + dia + " / " + mes + " / " + ano + "\n¿Quiere eliminarlo?";
        }
        private void buttonConfirmarBorrar_Click(object sender, EventArgs e)
        {
            ListTest.lista.Remove(medBorrar);
            SQLiteCommand myCommand = new SQLiteCommand("delete from medicamentos where lote ='"+ medBorrar.Lote+"'", Conexion.instanciaDb());
            myCommand.ExecuteNonQuery();
            actualizarTabla();
            buttonCancelarBorrar.Visible = false;
            label4.Visible = false;
            buttonConfirmarBorrar.Visible = false;
            textBoxNombre.Enabled = true;
            textBoxLote.Enabled = true;
            monthCalendar1.Enabled = true;
            textBoxLote.Clear();
            textBoxNombre.Clear();
        }

        private void buttonCancelarBorrar_Click(object sender, EventArgs e)
        {
            buttonCancelarBorrar.Visible = false;
            label4.Visible = false;
            buttonConfirmarBorrar.Visible = false;
            textBoxNombre.Enabled = true;
            textBoxLote.Enabled = true;
            monthCalendar1.Enabled = true;
            textBoxLote.Clear();
            textBoxNombre.Clear();
        }

        private void buttonBuscarMedicamento_Click(object sender, EventArgs e)
        {
            Medicamento medBuscado = new Medicamento();
            foreach (Medicamento med in ListTest.lista)
            {
                if (med.Lote == textBoxLote.Text)
                {
                    medBuscado = med;
                }
            }
            char[] delimit = new char[] { '/', ' ' };
            string l = medBuscado.Fecha.ToString();
            string[] nuevafecha = l.Split(delimit); //Divido la fecha [0]: Día | [1]: Mes | [2]: Año
            int dia = Int16.Parse(nuevafecha[0]);
            int mes = Int16.Parse(nuevafecha[1]);
            int ano = Int16.Parse(nuevafecha[2]);
            MessageBox.Show("Medicamento : " + medBuscado.Nombre + "\nLote : " + medBuscado.Lote + "\nVencimiento : " + dia + " / " + mes + " / " + ano);
            textBoxLote.Clear();
            textBoxNombre.Clear();
        }

        public void actualizarTabla()
        {
            DataTable dt = new DataTable();
            SQLiteCommand command = new SQLiteCommand("select * from medicamentos", Conexion.instanciaDb());
            SQLiteDataAdapter da = new SQLiteDataAdapter(command);
            da.Fill(dt);
            dgv.DataSource = null;
            dgv.DataSource = dt;
            dgv.DataSource = ListTest.lista.OrderBy(x => x.Fecha).ToList();
            {
                foreach (DataGridViewRow rowp in dgv.Rows)
                {
                    int line = rowp.Index;
                    int dia = (int)((Convert.ToDateTime(rowp.Cells[2].Value.ToString()) - DateTime.Today).TotalDays);
                    if (dia < 90)
                    {
                        dgv.Rows[line].DefaultCellStyle.BackColor = Color.LightSalmon;
                    }
                    else
                    {
                        if (dia < 180)
                        {
                            dgv.Rows[line].DefaultCellStyle.BackColor = Color.LightYellow;
                        }
                        else
                        {
                            dgv.Rows[line].DefaultCellStyle.BackColor = Color.LightGreen;
                        }
                    }
                }
            }
        }
    }
}
