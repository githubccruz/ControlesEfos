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
    public partial class efosCampo : TextBox
    {
        public efosCampo()
        {
            InitializeComponent();
            this.Limpiar = true;
        }
        public string CampoBD { set; get; }
        public bool Limpiar { set; get; }
        public bool SoloLectura { set; get; }
    }
}
