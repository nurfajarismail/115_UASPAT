using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UASPAT_115_Client
{
    public partial class ListKaryawan_Manager : Form
    {
        public ListKaryawan_Manager()
        {
            InitializeComponent();
        }

        private void buttonKembali_Click(object sender, EventArgs e)
        {
            FormLogin formLogin = new FormLogin();
            this.Hide();
            formLogin.Show();
        }

        private void buttonkeIDAdmin_Click(object sender, EventArgs e)
        {
            List_Admistrasi_Manager admistrasi_Manager = new List_Admistrasi_Manager();
            this.Hide();
            admistrasi_Manager.Show();
        }
    }
}
