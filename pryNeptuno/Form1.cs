using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryNeptuno
{
    public partial class frmNeptuno : Form
    {
        OleDbConnection conectarDB;
        OleDbCommand comandoDB;
        OleDbDataReader dataReaderDB;


        public frmNeptuno()
        {
            InitializeComponent();
        }
        public void conectarBASE()
        {
            try
            {
                conectarDB = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/NEPTUNO.accdb");
                comandoDB = new OleDbCommand();
                conectarDB.Open();

                comandoDB.Connection = conectarDB;
                comandoDB.CommandType = CommandType.TableDirect;
                comandoDB.CommandText = "Clientes";

                MessageBox.Show("Conexion a Tabla: " + comandoDB.CommandText);

                dataReaderDB = comandoDB.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conectarBASE();
            while (dataReaderDB.Read())
            {
                cmbCargos.Items.Add(dataReaderDB[3]);
            }
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            conectarBASE();
            while (dataReaderDB.Read())
            {
                dgvClientes.Rows.Add(dataReaderDB[1], dataReaderDB[2], dataReaderDB[3], dataReaderDB[4], dataReaderDB[7], dataReaderDB[8], dataReaderDB[10]);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear();
        }
    }
}
