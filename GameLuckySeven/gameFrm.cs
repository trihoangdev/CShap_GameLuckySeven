using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameLuckySeven
{
    public partial class gameFrm : Form
    {
        public gameFrm()
        {
            InitializeComponent();
            CenterToScreen();
        }
        int tienMay = 100;
        int tienNguoi = 100;
        Random rd = new Random();
        int count = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int so1 = rd.Next(9);
            int so2 = rd.Next(10);
            int so3 = rd.Next(11);
            lbl1.Text = so1 + "";
            lbl2.Text = so2 + "";
            lbl3.Text = so3 + "";

            if (count > 10)
            {
                if (so1 == 7)
                {
                    tienNguoi += 100 + (tienMay / 2);
                    tienMay = tienMay / 2;
                }
                if (so2 == 7)
                {
                    tienNguoi += 30 + (tienMay / 2);
                    tienMay = tienMay / 2;
                }
                if (so3 == 7)
                {
                    tienNguoi += 10;
                }
                lblTienMay.Text = tienMay + "";
                lblTienNguoiChoi.Text = tienNguoi + "";
                timer1.Stop();
            }
            count++;
        }

        private void btnQuaySo_Click(object sender, EventArgs e)
        {
            if (tienNguoi < 30)
            {
                MessageBox.Show("Bạn lỗ sặc máu rồi, nạp thêm đi rồi chơi!");
                return;
            }
            tienNguoi = tienNguoi - 30;
            tienMay = tienMay + 30;
            count = 0;
            timer1.Start();
        }

        private void btnGameMoi_Click(object sender, EventArgs e)
        {
            tienMay = 100;
            tienNguoi = 100;
            lblTienNguoiChoi.Text = 100 + "";
            lblTienMay.Text = 100 + "";
            MessageBox.Show("Bắt đầu chơi lại!", "Thông báo", MessageBoxButtons.OK);
        }

        private void btnKetThuc_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
