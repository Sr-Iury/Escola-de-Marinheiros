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

namespace Aula_02
{
    /// <summary>
    /// Lógica interna para CadastroUser.xaml
    /// </summary>
    public partial class CadastroUser : Window
    {
        public CadastroUser()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var MainWindow = new MainWindow();
            if (MainWindow.ShowDialog() == true)
            {
                // Se o login for bem-sucedido, mostra a janela principal
                this.Show();
            }
            else
            {
                // Se o login não for bem-sucedido, fecha a aplicação
                this.Close();
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var Dashboard = new Dashboard();
            if (Dashboard.ShowDialog() == true)
            {
                // Se o login for bem-sucedido, mostra a janela principal
                this.Show();
            }
            else
            {
                // Se o login não for bem-sucedido, fecha a aplicação
                this.Close();
            }
        }
    }
}
