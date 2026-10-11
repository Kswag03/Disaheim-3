using System;
using System.Collections.Generic;
using System.Text;

namespace Disaheim1
{
    public abstract class Merchandise
    {
        public string ItemId;

        public override string ToString()
        {
            return $"ItemId: {ItemId}"; 
        }
    }
}
