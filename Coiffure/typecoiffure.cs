using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coiffure
{
    public partial class typecoiffure : Form
    {
       
        public typecoiffure()
        {
            InitializeComponent();
        }

        private void typecoiffure_Load(object sender, EventArgs e)
        {
        
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reserver f=new Reserver();
            f.ShowDialog(); 
        }
    }
}
