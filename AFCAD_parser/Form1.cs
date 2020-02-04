using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFCAD_parser
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // test path
            string path = @"C:\Users\Cabinet\Downloads\AFX_LFPN_RS.bgl\AFX_LFPN_RS.bgl.xml";

            FSData data = new FSData();
            data.Load(path);
        }
    }


    





}
