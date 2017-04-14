using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace versie_0._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
         webBrowser1.Navigate("https://www.google.com/maps/d/u/1/embed?mid=1P6BJGFZP986wDk9oDaw7GJXiR6Y");
        }

        private void Zoeken_Click(object sender, EventArgs e)
        {
            string zoekstr = textbalk.Text;
            if (zoekstr == "delfshaven")
            {
                webBrowser1.Navigate("https://www.google.com/maps/d/u/1/embed?mid=1P6BJGFZP986wDk9oDaw7GJXiR6Y&ll=51.911415772522254%2C4.439815050000107&z=14");
            }
        }
    }
}

