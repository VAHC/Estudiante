using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lógica;
using Lógica.Library;

namespace Estudiante
{
    public partial class Form1 : Form
    {
        private LEstudiante estudiante;
        //private Librarys librarys;
        public Form1()
        {
            InitializeComponent();
            //librarys = new Librarys();
            var listTextBox = new List<TextBox>();
            listTextBox.Add(TextBoxNid);
            listTextBox.Add(TextBoxNombre);    
            listTextBox.Add(TextBoxApellido);
            listTextBox.Add(TextBoxEmail);
            var listLabel = new List<Label>();
            listLabel.Add(labelNid);
            listLabel.Add(labelNombre);
            listLabel.Add(labelApellido);
            listLabel.Add(labelEmail);
            Object[] objetos = { pictureBoxImage };

            estudiante = new LEstudiante(listTextBox, listLabel, objetos);
        }

        private void pictureBoxImage_Click(object sender, EventArgs e)
        {
            estudiante.uploadimage.CargarImagen(pictureBoxImage);
        }

        private void TextBoxNid_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxNid.Text.Equals(""))
            {
                labelNid.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelNid.ForeColor = Color.Green;
                labelNid.Text = "Nid";
            }
        }

        private void TextBoxNid_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.textBoxEvent.numberKeyPress(e);
        }

        private void TextBoxNombre_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxNombre.Text.Equals(""))
            {
                labelNombre.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelNombre.ForeColor = Color.Green;
                labelNombre.Text = "Nombre";
            }
        }

        private void TextBoxNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.textBoxEvent.textKeyPress(e);
        }

        private void TextBoxApellido_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxApellido.Text.Equals(""))
            {
                labelApellido.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelApellido.ForeColor = Color.Green;
                labelApellido.Text = "Apellido";
            }
        }

        private void TextBoxApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            estudiante.textBoxEvent.textKeyPress(e);
        }

        private void TextBoxEmail_TextChanged(object sender, EventArgs e)
        {
            if (TextBoxEmail.Text.Equals(""))
            {
                labelEmail.ForeColor = Color.LightSlateGray;
            }
            else
            {
                labelEmail.ForeColor = Color.Green;
                labelEmail.Text = "Email";
            }
        }

        
        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            estudiante.Registrar();
        }
    }
}
