using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ERP_ANDERSON.ViewModel
{
    public class TesteViewModel
    {
        public IList<string> Tabuada;

        public TesteViewModel(IList<string> _tabuada)
        {
            Tabuada = _tabuada;
        }
    }
}