using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;

namespace pryNeptuno
{
    internal class ClassManejoBD
    {
        OleDbConnection conectarDB;
        OleDbCommand comandoDB;
        OleDbDataReader dataReaderDB;

        public void conectarBASE()
        {
            try
            {
                conectarDB = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=NEPTUNO.accdb");
                comandoDB = new OleDbCommand();
                conectarDB.Open();

                comandoDB.Connection = conectarDB;
                comandoDB.CommandType = CommandType.TableDirect;
                comandoDB.CommandText = "Clientes";

                dataReaderDB = comandoDB.ExecuteReader();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        public void cargarGrilla(DataGridView grilla)
        {
            conectarBASE();
            //MessageBox.Show("Conexion a Tabla: " + comandoDB.CommandText);
            grilla.Rows.Clear();
            while (dataReaderDB.Read())
            {
                grilla.Rows.Add(dataReaderDB[1], dataReaderDB[2], dataReaderDB[3], dataReaderDB[4], dataReaderDB[7], dataReaderDB[8], dataReaderDB[10]);

            }
        }

        public void cargarComboCargos(ComboBox cargo, ComboBox ciudad)
        {
            conectarBASE();
            bool encontrarCargo = false;
            bool encontrarCiudad = false;
            while (dataReaderDB.Read())
            {
                for (int i = 0; i < cargo.Items.Count; i++)
                {
                    if (cargo.Items[i].ToString() == dataReaderDB[3].ToString())
                    {
                        encontrarCargo = true;
                    }
                }
                if (encontrarCargo == false )
                {
                    cargo.Items.Add(dataReaderDB[3].ToString());
                }
                encontrarCargo = false;

                for (int i = 0; i < ciudad.Items.Count; i++)
                {
                    if (ciudad.Items[i].ToString() == dataReaderDB[8].ToString())
                    {
                        encontrarCiudad = true;
                    }
                }
                if (encontrarCiudad == false)
                {
                    ciudad.Items.Add(dataReaderDB[8].ToString());
                }
                encontrarCiudad = false;

            }

        }

        public void filtarGrillaCargo(ComboBox mostrarCargo, ComboBox mostrarCiudad, DataGridView grilla)
        {
            conectarBASE();
            grilla.Rows.Clear();
            mostrarCiudad.SelectedIndex = -1;
            while (dataReaderDB.Read())
            {
                if (dataReaderDB[3].ToString() == mostrarCargo.Text)
                {
                    grilla.Rows.Add(dataReaderDB[1], dataReaderDB[2], dataReaderDB[3], dataReaderDB[4], dataReaderDB[7], dataReaderDB[8], dataReaderDB[10]);
                }
            }

        }

        public void filtarGrillaCiudad(ComboBox mostrarCargo, ComboBox mostrarCiudad, DataGridView grilla)
        {
            conectarBASE();
            grilla.Rows.Clear();
            mostrarCargo.SelectedIndex = -1;
            while (dataReaderDB.Read())
            {
                if (dataReaderDB[8].ToString() == mostrarCiudad.Text)
                {
                    grilla.Rows.Add(dataReaderDB[1], dataReaderDB[2], dataReaderDB[3], dataReaderDB[4], dataReaderDB[7], dataReaderDB[8], dataReaderDB[10]);
                }
            }

        }


    }
}
