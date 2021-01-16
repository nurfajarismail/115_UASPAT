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
    public partial class KeteranganInterview : Form
    {
        public KeteranganInterview()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List_Admistrasi_Manager admistrasi_Manager = new List_Admistrasi_Manager();
                this.Hide();
            admistrasi_Manager.Show();
        }
    }
}
