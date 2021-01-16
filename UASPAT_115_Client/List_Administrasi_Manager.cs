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
    public partial class List_Admistrasi_Manager : Form
    {
        public List_Admistrasi_Manager()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TambahKeteranganInterview keteranganInterview = new TambahKeteranganInterview();
            this.Hide();
            keteranganInterview.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ListKaryawan_Manager karyawan_Manager = new ListKaryawan_Manager();
            this.Hide();
            karyawan_Manager.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            KeteranganInterview keteranganInterview = new KeteranganInterview();
            this.Hide();
            keteranganInterview.Show();
        }
    }
}
