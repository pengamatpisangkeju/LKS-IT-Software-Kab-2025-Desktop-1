using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal class NavigationHelper
    {
        public static void OpenForm<T>(Form currentForm) where T : Form, new()
        {
            var newForm = new T();
            newForm.Show();
            currentForm.Hide();
        }
    }
}
