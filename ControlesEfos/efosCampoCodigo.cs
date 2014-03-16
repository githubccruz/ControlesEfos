using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace ControlesEfos
{
    public partial class efosCampoCodigo : efosCampo
    {
        public efosCampoCodigo()
        {
            InitializeComponent();
        }

        ////private void efosCampoCodigo_TextChanged(object sender, EventArgs e)
        ////{
        ////    /*	string input = "/content/alternate-1.aspx";

        ////        // Here we call Regex.Match.
        ////        Match match = Regex.Match(input, @"content/([A-Za-z0-9\-]+)\.aspx$",
        ////            RegexOptions.IgnoreCase);

        ////        // Here we check the Match instance.
        ////        if (match.Success)
        ////        {
        ////            // Finally, we get the Group value and display it.
        ////            string key = match.Groups[1].Value;
        ////            Console.WriteLine(key);
        ////        }
             
        ////    MessageBox.Show(this.Text.Substring(0,this.Text.Length-1)+"");
        ////    if (this.Text.Length > 0){
        ////        Match match = Regex.Match(this.Text, @"(?<=\s|^)\d+(?=\s|$)",RegexOptions.IgnoreCase);
        ////        if (!match.Success){
        ////            this.Text = this.Text.Substring(0, this.Text.Length - 1);
        ////        }
        ////    }*/
        ////}

        ////private void efosCampoCodigo_KeyDown(object sender, KeyEventArgs e)
        ////{
        ////    if (this.Text.Length > 0)
        ////    {
        ////        Match match = Regex.Match(this.Text, @"(?<=\s|^)\d+(?=\s|$)", RegexOptions.IgnoreCase);
        ////        if (!match.Success)
        ////        {
        ////            this.Text = this.Text.Substring(0, this.Text.Length - 1);
        ////        }
        ////    }
        ////}
    }
}
