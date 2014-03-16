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
    public partial class efosCheck : CheckBox
    {
        public efosCheck()
        {
            InitializeComponent();
            controlTextBotonEstado();
        }

        #region Propiedades
            public string CampoBD { get; set; }
        #endregion

        private void controlTextBotonEstado()
        {
            if (this.Checked)
            {
                this.Text = "Desactivar";
                this.ForeColor = Color.Red;
            }
            else
            {
                this.Text = "Activar";
                this.ForeColor = Color.Blue;
            }
        }
        private void efosCheck_Click(object sender, EventArgs e)
        {
            controlTextBotonEstado();
        }

        private void efosCheck_CheckedChanged(object sender, EventArgs e)
        {
            controlTextBotonEstado();
        }
    }
}
