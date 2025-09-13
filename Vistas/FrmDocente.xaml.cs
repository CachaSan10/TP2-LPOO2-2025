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
using ClasesBase;

namespace Vistas
{
    /// <summary>
    /// Interaction logic for FrmDocente.xaml
    /// </summary>
    public partial class FrmDocente : Window
    {
        public FrmDocente()
        {
            InitializeComponent();
        }

        private void Limpiar_Campos() {

            txtDNI.Clear();
            txtApellido.Clear();
            txtNombre.Clear();
            txtEmail.Clear();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("¿Desea guardar el Docente?", "Confrimar", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes)
            {
                if (txtDNI.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" && txtEmail.Text != "")
                {
                    Docente oDocente = new Docente();
                    oDocente.Doc_DNI = txtDNI.Text;
                    oDocente.Doc_Apellido = txtApellido.Text;
                    oDocente.Doc_Nombre = txtNombre.Text;
                    oDocente.Doc_Email = txtEmail.Text;


                    MessageBox.Show(

                        "Docente cargado: \n" +
                        "DNI: " + oDocente.Doc_DNI + "\n" +
                        "Apellido: " + oDocente.Doc_Apellido + "\n" +
                        "Nombre: " + oDocente.Doc_Nombre + "\n" +
                        "Email: " + oDocente.Doc_Email

                        );
                    Limpiar_Campos();
                }
                else
                {
                    MessageBox.Show("No se permiten campos vacios");
                }

                
            }
        }
    }
}
