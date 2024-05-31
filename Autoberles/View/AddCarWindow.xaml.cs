using Autoberles.Model;
using Autoberles.MySQL;
using Autoberles.ViewModel;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Tls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Autoberles.View
{
    /// <summary>
    /// Interaction logic for AddCarWindow.xaml
    /// </summary>
    public partial class AddCarWindow : Window
    {
        AddCarViewModel viewModel;
        public AddCarWindow()
        {
            InitializeComponent();

        }

        private void btnAddCancel_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnAddCar_Click(object sender, RoutedEventArgs e)
        {
            if (tbCarBrand.Text != "" && tbCarPrice.Text != "" && tbCarType.Text != "" && tbCarYear.Text != "")
            {
                MySqlConnection conn = new MySqlConnection(MySQLConnection.connection);
                try
                {
                    conn.Open();
                    MySqlCommand cmd = new MySqlCommand(MySQLCommands.carAdd, conn);
                    //cmd.Parameters.AddWithValue("@carId", int.Parse(tbCarID.Text));
                    cmd.Parameters.AddWithValue("@brand", tbCarBrand.Text);
                    cmd.Parameters.AddWithValue("@type", tbCarType.Text);
                    cmd.Parameters.AddWithValue("@year",int.Parse(tbCarYear.Text));
                    cmd.Parameters.AddWithValue("@price",int.Parse(tbCarPrice.Text));

                    cmd.ExecuteNonQuery();
                    Close();
                    MessageBox.Show("Sikeresen hozzáadás!");

                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
                finally { conn.Close(); }

            }
            else
            {
                MessageBox.Show("Minden mezőt ki kell tölteni!");
            }
        }
    }
}
