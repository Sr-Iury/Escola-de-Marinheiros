using Aula_02.Telas;
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
using LiveCharts;
using LiveCharts.Defaults;
using LiveCharts.Wpf;

namespace Aula_02
{
    /// <summary>
    /// Lógica interna para Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            var CadastroTurma = new CadastroTurma();
            this.Close();
            CadastroTurma.Show();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            var CadastroAluno = new CadastroAluno();
            this.Show();
            CadastroAluno.ShowDialog();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            var CadastroCurso = new CadastroCurso();
            this.Show();
            CadastroCurso.ShowDialog();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            var VisualizarAluno = new VisualizarAluno();
            this.Show();
            VisualizarAluno.ShowDialog();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            var VisualizarCurso = new VisualizarCurso();
            this.Show();
            VisualizarCurso.ShowDialog();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            var VisualizarTurma = new VisualizarTurma();
            this.Show();
            VisualizarTurma.ShowDialog();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            var VisualizarEscola = new VisualizarEscola();
            this.Close();
            VisualizarEscola.ShowDialog();
        }
    }
}
