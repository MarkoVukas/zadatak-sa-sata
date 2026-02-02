using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;  

namespace WindowsFormsApp1
{
    public partial class Prikaz_knjiga : Form
    {
        public Prikaz_knjiga()
        {
            InitializeComponent();
        }

        private void btnZatvori_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Prikaz_knjiga_Load(object sender, EventArgs e)
        {
        }
        private void btnPretrazi_Click(object sender, EventArgs e)
        {
            lstKnjige.Items.Clear();
            string kriterijum = txtKriterijum.Text;
            List<string> rezultatPretrage = Admin.SearchAsStrings(kriterijum);
            foreach (string knjiga in rezultatPretrage)
            {
                lstKnjige.Items.Add(knjiga);
            }
        }
        private void btnPrikaziSve_Click(object sender, EventArgs e)
        {
            lstKnjige.Items.Clear();
            List<string> sveKnjige = Admin.GetAllAsStrings();
            foreach (string knjiga in sveKnjige)
            {
                lstKnjige.Items.Add(knjiga);
            }
        }
    }
}
