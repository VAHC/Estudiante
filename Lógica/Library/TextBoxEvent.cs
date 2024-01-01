﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lógica.Library
{
    public class TextBoxEvent
    {
        public void textKeyPress(KeyPressEventArgs e)
        {
            // Condición que solo nos permite ingresar datos de tipo texto
            if(char.IsLetter(e.KeyChar)) { e.Handled = false; }
            // Condición que permite no dar salto de linea cuando se oprime Enter
            else if(e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }
            // Condicíón que nos permite utilizar la tecla backspace
            else if(char.IsControl(e.KeyChar)) { e.Handled = false; }
            // Condición que nos permite utiliar la tecla espacio
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }
        public void numberKeyPress(KeyPressEventArgs e)
        {
            // Condición que solo nos permite ingresar datos de tipo numérico
            if (char.IsDigit(e.KeyChar)) { e.Handled = false; }
            // Condición que permite no dar salto de linea cuando se oprime Enter
            else if (e.KeyChar == Convert.ToChar(Keys.Enter)) { e.Handled = true; }
            // Condición que permite inresar datos de tipo texto
            else if (char.IsLetter(e.KeyChar)) { e.Handled = true; }
            // Condicíón que nos permite utilizar la tecla backspace
            else if (char.IsControl(e.KeyChar)) { e.Handled = false; }
            // Condición que nos permite utiliar la tecla espacio
            else if (char.IsSeparator(e.KeyChar)) { e.Handled = false; }
            else { e.Handled = true; }
        }
        public bool comprobarFormatoEmail(string email)
        {
            return new EmailAddressAttribute().IsValid(email);
        }
    }
}
