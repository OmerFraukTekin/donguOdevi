using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void btnHesapla_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            int baslangic ,bitis, bolen1, bolen2;
            baslangic = Convert.ToInt32(txbxBaslangic.Text);
            bitis = Convert.ToInt32(txbxBitis.Text);
            bolen1 = Convert.ToInt32(txbx1Bolen.Text);
            bolen2 = Convert.ToInt32(txbx2Bolen.Text);
            for (int i = baslangic; i <= bitis; i++)
            {
                if (i % bolen1 == 0)
                {
                    listBox1.Items.Add(i);
                }
                if (i % bolen2 == 0)
                {
                    listBox2.Items.Add(i);
                }
                if(i % bolen1 == 0 && i% bolen2== 0)
                {

                    listBox3.Items.Add(i);                   

                }
            }
        }

       
    }
}
