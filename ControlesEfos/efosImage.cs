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
    public partial class efosImage : PictureBox
    {
        public efosImage()
        {
            InitializeComponent();
        }
        #region Propiedades Control
            public string RutaImagen { get; set; }
        #endregion
    }
}
