using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiKiemTra
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBang_Click(object sender, EventArgs e)
        {        
               double tien = double.Parse(txtTien.Text);
               double laisuat = double.Parse(txtLaisuat.Text); 
               double gui = double.Parse(txtGui.Text);
            double sodu = tien;
            double lai = (laisuat / 12) / 100;
               double tong = 0;
            for (int i = 1; i <= gui; i++) {
                tong = tien * lai;
                tien += tong;
                
            }            
            double laitong = tien - sodu;
            txtLai.Text = Math.Round(laitong , 2).ToString();
            txtDu.Text = Math.Round(tien , 2).ToString();
            
        }
    }
}
