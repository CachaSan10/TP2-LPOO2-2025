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

        private void btnCancelar_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Limpiar_Campos()
        {

            altaAlumno.txtDNI.Clear();
            altaAlumno.txtApellido.Clear();
            altaAlumno.txtNombre.Clear();
            altaAlumno.txtEmail.Clear();
        } 
        private void btnGuardar_Click(object sender, RoutedEventArgs e)
        {
            var confirmacion = new MessageBoxConfirm("¿Desea guardar el Alumno?", "Atención");
            bool? resultado = confirmacion.ShowDialog();
            if (resultado == true)
            {

                if (altaAlumno.txtDNI.Text != "" && altaAlumno.txtNombre.Text != "" && altaAlumno.txtApellido.Text != "" && altaAlumno.txtEmail.Text != "")
                {
                    Alumno oAlumno = new Alumno();
                    oAlumno.Alu_DNI = altaAlumno.txtDNI.Text;
                    oAlumno.Alu_Apellido = altaAlumno.txtApellido.Text;
                    oAlumno.Alu_Nombre = altaAlumno.txtNombre.Text;
                    oAlumno.Alu_Email = altaAlumno.txtEmail.Text;


                    MessageBoxCustom.ShowSuccess(

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
                    MessageBoxCustom.ShowWarning("No se permiten campos vacios");
                }
            }
        }

       
    }
}
