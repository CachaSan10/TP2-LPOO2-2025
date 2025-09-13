using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for Principal.xaml
    /// </summary>
    public partial class Principal : Window
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            
        }

        private void MenuSalir_Click(object sender, RoutedEventArgs e)
        {
            this.Close(); // cerrar aplicación
        }

        private void AltaCurso_Click(object sender, RoutedEventArgs e)
        {
            FrmCurso oFrmCurso = new FrmCurso();
            oFrmCurso.Show();
        }

        private void AltaDocente_Click(object sender, RoutedEventArgs e)
        {
            FrmDocente oFrmDocente = new FrmDocente();
            oFrmDocente.Show();
        }

        private void AltaAlumno_Click(object sender, RoutedEventArgs e)
        {
            FrmAlumno oFrmAlumno = new FrmAlumno();
            oFrmAlumno.Show();
        }

    }
}
