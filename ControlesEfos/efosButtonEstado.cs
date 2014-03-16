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
    public partial class efosButtonEstado : efosButton
    {
        private bool Estado { set; get; }
        
        public efosButtonEstado()
        {
            InitializeComponent();
        }        

        private void efosButtonEstado_Click(object sender, EventArgs e)
        {
            switch (this.Estado)
            {
                case true:
                    this.ForeColor = Color.Red;
                    break;
                case false:
                    this.ForeColor = Color.Blue;
                    break;
                default:
                    this.ForeColor = Color.Black;
                    break;

            }            
        }


    }
}
