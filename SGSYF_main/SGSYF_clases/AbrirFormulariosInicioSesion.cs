using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGSYF_clases
{
    public class AbrirFormulariosInicioSesion
    {
        public void AbrirFormulario(Form form, Form parentForm)
        {
            form.StartPosition = FormStartPosition.Manual;
            form.Location = parentForm.Location;

            form.FormClosed += (s, args) => parentForm.Close();
            parentForm.Hide();
            form.ShowDialog();
            parentForm.Close(); 
        }

        
        

    public class FormManager
        {
            private Form formActivo = null;
            private Panel contenedor;

            public FormManager(Panel contenedor)
            {
                this.contenedor = contenedor;
            }

            public void AbrirFormHijo(Form formHijo)
            {
                if (formActivo != null)
                {
                    formActivo.Close();
                }
                formActivo = formHijo;

                // Configura el formulario hijo
                formHijo.TopLevel = false;
                formHijo.FormBorderStyle = FormBorderStyle.None;
                formHijo.Dock = DockStyle.Fill;

                // Añade el formulario hijo al panel padre
                contenedor.Controls.Add(formHijo);
                contenedor.Tag = formHijo;

                // Muestra el formulario hijo
                formHijo.BringToFront();
                formHijo.Show();
            }
        }

    }
}
