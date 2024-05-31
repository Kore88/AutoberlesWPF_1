using Autoberles.Model;
using Autoberles.MySQL;
using Autoberles.View;
using MySql.Data.MySqlClient;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Autoberles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Car> cars = new List<Car>();
        //Car nc = new Car(1, "Ford", "Mondeo", 2001, 1000);
        //Car nc1 = new Car(2, "Suzuki", "Swift", 2014, 1001);
        public MainWindow()
        {
            InitializeComponent();
            DataOnLoad();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void btnNewCar_Click(object sender, RoutedEventArgs e)
        {
            AddCarWindow acw = new AddCarWindow();
            acw.Show();
        }

        private void DataOnLoad()
        {
            MySqlConnection conn = new MySqlConnection(MySQLConnection.connection);
            try
            {
                conn.Open();
                MySqlCommand cmd = new MySqlCommand(MySQLCommands.carAll,conn);
                MySqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    int i = dr.GetInt32(0);
                    string b = dr.GetString(1);
                    string t = dr.GetString(2);
                    int y = dr.GetInt32(3);
                    int p = dr.GetInt32(4);

                    Car newCar = new Car(i,b,t,y,p);
                    cars.Add(newCar);
                    dgCars.ItemsSource = cars;

                }


            }
            catch (Exception ex) {MessageBox.Show(ex.Message); }
            finally {conn.Close();}
        }
    }
}