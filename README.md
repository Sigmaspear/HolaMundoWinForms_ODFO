# Formulario de Validación de Contraseña con WinForms

## Universidad de Guadalajara - CUCEI  
**Materia:** Ciberinfraestructura 2025-B  
**Profesor(a):** Ma. Inés Calderón Zetter  
**Alumno:** Oscar David Flores Ortega  

---

## Actividad
**Warm up:** Crear un formulario simple con WinForms.  

---

## Descripción del Proyecto
Se creó un formulario en **C# WinForms** que valida contraseñas con los siguientes requisitos:

- Al menos una letra mayúscula.  
- Al menos una letra minúscula.  
- Al menos un número.  
- Al menos un símbolo especial.  
- Coincidencia exacta entre los dos campos de texto.  

---
## Evidencias

Aquí se muestran las capturas del formulario y su funcionamiento:

<img width="743" height="490" alt="Contraseña_validada png" src="https://github.com/user-attachments/assets/9ff59bc9-42d1-4748-9419-1a2fd1a512ae" />
<img width="897" height="492" alt="Contraseña_norequisitos png" src="https://github.com/user-attachments/assets/d1514d7f-1e79-48e6-b5f3-6a71ea248a05" />
<img width="747" height="493" alt="Contraseña_nocoincide png" src="https://github.com/user-attachments/assets/fadc1602-c8e2-4ea3-84fb-5166eac1881a" />

## Código Principal
```csharp
using System;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace HolaMundo._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BotonValidar_Click(object sender, EventArgs e)
        {
            string Contraseña1 = txtContraseña1.Text;
            string Contraseña2 = txtContraseña2.Text;

            string patron = @"^(?=.*[A-Z])(?=.*[a-z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).+$";

            if (!Regex.IsMatch(Contraseña1, patron))
            {
                MessageBox.Show("La contraseña no cumple con los requisitos:\n" +
                                "Debe contener mayúscula, minúscula, número y símbolo.");
                return;
            }

            if (Contraseña1 != Contraseña2)
            {
                MessageBox.Show("Las contraseñas no coinciden.");
                return;
            }

            MessageBox.Show("La contraseña ha sido validada");
        }
    }
}
