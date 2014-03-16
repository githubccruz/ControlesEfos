using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesEfos
{
    public partial class efosList : ListBox
    {
        public efosList()
        {
            InitializeComponent();
        }

        #region Propiedades
            public string tablaBD { set; get; }
            public string campoCodigo { set; get; }
            public string campoDescripcion { set; get; }
        #endregion
    }
}
