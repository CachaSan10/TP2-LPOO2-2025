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
    /// Interaction logic for FrmAlumno.xaml
    /// </summary>
    public partial class FrmAlumno : Window
    {
        public FrmAlumno()
        {
            InitializeComponent();
        }

        private void Limpiar_Campos()
        {

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
            if (MessageBox.Show("¿Desea guardar el Alumno?", "Confrimar", MessageBoxButton.YesNo, MessageBoxImage.Question) == MessageBoxResult.Yes) {

                if (txtDNI.Text != "" && txtNombre.Text != "" && txtApellido.Text != "" && txtEmail.Text != "")
                {
                    Alumno oAlumno = new Alumno();
                    oAlumno.Alu_DNI = txtDNI.Text;
                    oAlumno.Alu_Apellido = txtApellido.Text;
                    oAlumno.Alu_Nombre = txtNombre.Text;
                    oAlumno.Alu_Email = txtEmail.Text;


                    MessageBox.Show(

                        "Alumno cargado: \n" +
                        "DNI: " + oAlumno.Alu_DNI + "\n" +
                        "Apellido: " + oAlumno.Alu_Apellido + "\n" +
                        "Nombre: " + oAlumno.Alu_Nombre + "\n" +
                        "Email: " + oAlumno.Alu_Email

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
