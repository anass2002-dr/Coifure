using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
namespace Coiffure
{
    public partial class inscrire : Form
    {
        public inscrire()
        {
            
            InitializeComponent();
            //[DllImport("gdi32.dll")];
            // IntPtr CreateRoundRectRgn(int x1, int y1, int x2, int y2,
            //   int cx, int cy);
        }

        private void inscrire_Load(object sender, EventArgs e)
        {
            //panel3.Region = Region.FromHrgn();
            panel3.BackColor = Color.FromArgb(100, 0, 0, 0);
            //btn_inscrir.BackColor = System.Drawing.Color.Transparent;
            btn_left.BackColor = System.Drawing.Color.Transparent;

            lb_nom.BackColor = System.Drawing.Color.Transparent;
            lb_confirmer.BackColor = System.Drawing.Color.Transparent;
            lb_email.BackColor = System.Drawing.Color.Transparent;
            lb_password.BackColor = System.Drawing.Color.Transparent;
            lb_prenom.BackColor = System.Drawing.Color.Transparent;
            lb_ville.BackColor = System.Drawing.Color.Transparent;

            //txt_confirmer.BackColor = System.Drawing.Color.Transparent;
            //txt_email.BackColor = System.Drawing.Color.Transparent;
            //txt_password.BackColor = System.Drawing.Color.Transparent;
            //txt_prenom.BackColor = System.Drawing.Color.Transparent;
            //cb_ville.BackColor = System.Drawing.Color.Transparent;

        }

        private void btn_left_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }
    }
}
