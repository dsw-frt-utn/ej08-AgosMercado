using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    internal class Product
    {
        private string _description;
        public void ModificarDescripcion(string d)
        {
            _description = d;
        }
        public string GetDescription()
        {
            return _description;
        }
    }
}
