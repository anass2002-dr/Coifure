using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coiffure
{
    public partial class Reserver : Form
    {
        public Reserver()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            typecoiffure f=new typecoiffure();
            f.ShowDialog();
        }
    }
}
