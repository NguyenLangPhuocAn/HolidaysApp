using BUS;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HolidaysApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Btn_Quit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Btn_Login_Click(object sender, EventArgs e)
        {
            AccountBUS Acc = new AccountBUS();
            AccountDTO AccDTO = new AccountDTO();
            if (Txt_Username.Text.Length == 0)
                MessageBox.Show("Vui Lòng Nhập UserName", "Thông Báo");
            else
            {
                if(Txt_Password.Text.Length==0)
                    MessageBox.Show("Vui Lòng Nhập Password", "Thông Báo");
                else
                {
                    AccDTO.Username1= Txt_Username.Text;
                    AccDTO.Password1= Txt_Password.Text;
                    if(Acc.CheckAccount(AccDTO)==true)
                    {
                        Form Frm = new FrmHolidays(AccDTO.Username1);
                        Frm.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Account Không Tồn Tại", "Thông Báo");
                    }
                }
            }
        }
    }
}
