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

        private void Form1_Load(object sender, EventArgs e)
        {
            ClassManejoBD objDbCargo = new ClassManejoBD();
            objDbCargo.cargarComboCargos(cmbCargos, cmbMostrarCiudad);
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

        private void cmbMostrarCiudad_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassManejoBD objMostarCiudad = new ClassManejoBD();
            objMostarCiudad.filtarGrillaCiudad(cmbCargos, cmbMostrarCiudad, dgvClientes);
        }

        private void cmbCargos_SelectedIndexChanged(object sender, EventArgs e)
        {
            ClassManejoBD objMostarCargo = new ClassManejoBD();
            objMostarCargo.filtarGrillaCargo(cmbCargos, cmbMostrarCiudad, dgvClientes);
        }
    }
}
