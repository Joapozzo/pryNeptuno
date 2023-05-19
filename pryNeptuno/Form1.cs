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
        public frmNeptuno()
        {
            InitializeComponent();
        }
        //public void agregarCiudad()
        //{
        //    conectarBASE();
        //    while (dataReaderDB.Read())
        //    { 
        //        cmbMostrarCiudad.Items.Add(dataReaderDB[5]);
        //    }
        //}

        //public void agregarCargos()
        //{
        //    conectarBASE();
        //    while (dataReaderDB.Read())
        //    {
        //        cmbCargos.Items.Add(dataReaderDB[3]);
        //    }
        //}

        private void Form1_Load(object sender, EventArgs e)
        {
            //agregarCargos();
            //agregarCiudad();
        }

        private void btnMostrarTodos_Click(object sender, EventArgs e)
        {
            ClassManejoBD objManejoDB = new ClassManejoBD();
            objManejoDB.cargarGrilla(dgvClientes);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvClientes.Rows.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ClassManejoBD objDbCargo = new ClassManejoBD();
            objDbCargo.cargarComboCargos(cmbCargos);
        }
    }
}
