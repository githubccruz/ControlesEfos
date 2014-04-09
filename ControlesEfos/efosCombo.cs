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
    public partial class efosCombo : ComboBox
    {
        public efosCombo()
        {
            InitializeComponent();
        }
        public string CampoBD { set; get; }
        public bool NoLimpiar { get; set; }
    }
}
