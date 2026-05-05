using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace Dsw2026Ej8
{
    internal class RetailSale : Sale
    {
      public override decimal CalculateTotal() {
            return Amount;
        }
    }
}
