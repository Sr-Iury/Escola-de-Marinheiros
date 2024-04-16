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
    /// Lógica interna para CadastroAluno.xaml
    /// </summary>
    public partial class CadastroAluno : Window
    {
        public CadastroAluno()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var CadastroTurma = new CadastroTurma();
            if (CadastroTurma.ShowDialog() == true)
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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var CadastroAluno = new CadastroAluno();
            if (CadastroAluno.ShowDialog() == true)
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

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var CadastroCurso = new CadastroCurso();
            if (CadastroCurso.ShowDialog() == true)
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

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var VisualizarAluno = new VisualizarAluno();
            if (VisualizarAluno.ShowDialog() == true)
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

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var VisualizarCurso = new VisualizarCurso();
            if (VisualizarCurso.ShowDialog() == true)
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

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            var VisualizarTurma = new VisualizarTurma();
            if (VisualizarTurma.ShowDialog() == true)
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

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            var VisualizarEscola = new VisualizarEscola();
            if (VisualizarEscola.ShowDialog() == true)
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

        private void Button_Click()
        {

        }
    }
}
