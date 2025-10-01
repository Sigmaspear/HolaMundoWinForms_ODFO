using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//estas son las librerias que se necesitan para que el formulario funcione
namespace HolaMundo._1
{
    public partial class Form1 : Form //esta es la clase principal del formulario
    {
        public Form1()
        {
            InitializeComponent();
        }
        //este es el boton que valida la contraseña
        private void BotonValidar_Click(object sender, EventArgs e)
        {
            string Contraseña1 = txtContraseña1.Text;
            string Contraseña2 = txtContraseña2.Text;//estas son las variables que almacenan las contraseñas ingresadas para compararlas depués

            string patron = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).+$";//este es el patrón que debe cumplir la contraseña

            if (!System.Text.RegularExpressions.Regex.IsMatch(Contraseña1, patron))//esta es la validación de la contraseña con el patrón
            {
                MessageBox.Show("La contraseña no cumple con los requisitos:\n" +
                                "Debe contener mayúscula, minúscula, número y símbolo.");
                return;
            } //si no cumple con el patrón, muestra un mensaje de error

            if (Contraseña1 != Contraseña2)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            } //si las contraseñas no coinciden, muestra un mensaje de error

            MessageBox.Show("La contraseña ha sido validada");
        } //si las contraseñas coinciden y cumplen con el patrón, muestra un mensaje de éxito

    }
}

