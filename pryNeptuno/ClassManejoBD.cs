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
                conectarDB = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/NEPTUNO.accdb");
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
            MessageBox.Show("Conexion a Tabla: " + comandoDB.CommandText);
            while (dataReaderDB.Read())
            {
                grilla.Rows.Add(dataReaderDB[1], dataReaderDB[2], dataReaderDB[3], dataReaderDB[4], dataReaderDB[7], dataReaderDB[8], dataReaderDB[10]);

                //string auxCargos = dataReaderDB[3].ToString();
                //if (cargo.Items.Count > 0)
                //{
                //    int indice = 0;
                //    while (indice < cargo.Items.Count)
                //    {
                //        cargo.SelectedIndex = indice;
                //        if (dataReaderDB[3].ToString() == cargo.SelectedValue.ToString())
                //        {

                //        }

                //        cargo.Items.Add(dataReaderDB[3]);
                //    }
                //}
                //else
                //{
                //    cargo.Items.Add(dataReaderDB[3]);
                //}
            }
        }

        public void cargarComboCargos(ComboBox cargo)
        {
            conectarBASE();
            string[] vecCargo = new string[91];
            while (dataReaderDB.Read())
            {
                for (int i = 0; i < 91; i++)
                {
                    vecCargo[i] = dataReaderDB[3].ToString();
                    dataReaderDB.Read();
                }
                HashSet<string> cargoSinRepetir = new HashSet<string>(vecCargo);
                cargo.Items.Add(cargoSinRepetir.ToString());
            }

        }

    }
}
