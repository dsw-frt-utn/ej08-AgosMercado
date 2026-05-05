        using System;
using System.Collections.Generic;
using System.Text;

namespace Dsw2026Ej8
{
    public partial class ProductHelper
    {
        //private long _code;
        //private string _description;
        //private decimal _price;
        public string ObtenerEtiquetaProducto (long code, string description, decimal price){
            return $"[{code}] {description} - {price.ToString(FormatoMoneda)}";

        }
}
}