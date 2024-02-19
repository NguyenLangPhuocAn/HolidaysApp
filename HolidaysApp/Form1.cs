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
    public partial class FrmHolidays : Form
    {
        private HolidaysBUS HdBUS = new HolidaysBUS();
        private HolidaysDTO Hld = new HolidaysDTO();
        public FrmHolidays(string Updated_ByUserName)
        {
            InitializeComponent();
            LoadAll();
        }
        private void LoadAll()
        {
            Dgv_Holiday.DataSource = HdBUS.ReadData();
        }
        private void Btn_Add_Click(object sender, EventArgs e)
        {
            if (Txt_NameGroup.Text.Length == 0)
            {
                MessageBox.Show("Vui Lòng Nhập Namegroup", "Thông Báo");
            }
            else
            {
                if (Txt_NameEn.Text.Length == 0)
                {
                    MessageBox.Show("Vui Lòng Nhập NameEn", "Thông Báo");

                }
                else
                {
                    if (Txt_NameVi.Text.Length == 0)
                    {
                        MessageBox.Show("Vui Lòng Nhập NameVI", "Thông Báo");
                    }
                    else
                    {
                        if (Txt_Remark.Text.Length == 0)
                        {
                            MessageBox.Show("Vui Lòng Nhập Remark", "Thông Báo");
                        }
                        else
                        {
                            DateTime parsedDate = DateTime.ParseExact(Dtp_Date.Text, "dddd, d MMMM yyyy", System.Globalization.CultureInfo.InvariantCulture);
                            Hld.Holiday_date1 = parsedDate.ToString("yyyy-MM-dd");
                            Hld.Holiday_name_group1 = Txt_NameGroup.Text;
                            Hld.Holiday_name_en1 = Txt_NameEn.Text;
                            Hld.Holiday_name_vi1 = Txt_NameVi.Text;
                            Hld.Remark1 = Txt_Remark.Text;
                            int count = HdBUS.InsertData(Hld);
                            if (count > 0)
                            {
                                MessageBox.Show("Insert Thành Công " + count + " Dòng Vào Hệ Thống", "Thông Báo");
                                LoadAll();
                            }
                            else
                                MessageBox.Show("Insert Không Thành Công", "Thông Báo");
                        }
                    }

                }
            }

        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            if (Txt_ID.Text.Length == 0)
            {
                MessageBox.Show("Vui Lòng Nhập ID", "Thông Báo");
            }
            else
            {
                if (Dgv_Holiday.SelectedRows.Count > 1)
                {
                    List<HolidaysDTO> HolidayList = new List<HolidaysDTO>();
                    foreach(DataGridViewRow row in Dgv_Holiday.SelectedRows)
                    {
                        HolidaysDTO hdd = new HolidaysDTO();
                        hdd.Holiday_name_group1=row.Cells["holiday_name_group"].Value.ToString();
                        HolidayList.Add(hdd);
                    }
                    int count = HdBUS.DeleteList(HolidayList);
                    if (count > 0)
                    {
                        MessageBox.Show("Delete Thành Công " + count + " Dòng Trong Hệ Thống", "Thông Báo");
                        LoadAll();
                    }
                    else
                        MessageBox.Show("Delete Không Thành Công", "Thông Báo");

                }
                else
                {
                    Hld.ID1 = Convert.ToInt32(Txt_ID.Text);
                    if (HdBUS.FindDuplicate(Hld).Rows.Count > 0)
                    {
                        int count = HdBUS.DeleteData(Hld);
                        if (count > 0)
                        {
                            MessageBox.Show("Delete Thành Công " + count + " Dòng Trong Hệ Thống", "Thông Báo");
                            LoadAll();
                        }
                        else
                            MessageBox.Show("Delete Không Thành Công", "Thông Báo");
                    }
                    else
                    {
                        MessageBox.Show("Không Tồn Tại ID Này Trong Hệ Thống", "Thông Báo");
                    }
                }
            }
        }

        private void Btn_Modify_Click(object sender, EventArgs e)
        {
            if (Txt_ID.Text.Length == 0)
            {
                MessageBox.Show("Vui Lòng Nhập ID", "Thông Báo");
            }
            else
            {
                Hld.ID1 = Convert.ToInt32(Txt_ID.Text);
                if (HdBUS.FindDuplicate(Hld).Rows.Count > 0)
                {
                    if (Txt_NameGroup.Text.Length == 0)
                    {
                        MessageBox.Show("Vui Lòng Nhập Namegroup", "Thông Báo");
                    }
                    else
                    {
                        if (Txt_NameEn.Text.Length == 0)
                        {
                            MessageBox.Show("Vui Lòng Nhập NameEn", "Thông Báo");

                        }
                        else
                        {
                            if (Txt_NameVi.Text.Length == 0)
                            {
                                MessageBox.Show("Vui Lòng Nhập NameVI", "Thông Báo");
                            }
                            else
                            {
                                if (Txt_Remark.Text.Length == 0)
                                {
                                    MessageBox.Show("Vui Lòng Nhập Remark", "Thông Báo");
                                }
                                else
                                {
                                    Hld.Updated_date1 = DateTime.Now;
                                    Hld.Holiday_name_group1 = Txt_NameGroup.Text;
                                    Hld.Holiday_name_en1 = Txt_NameEn.Text;
                                    Hld.Holiday_name_vi1 = Txt_NameVi.Text;
                                    Hld.Remark1 = Txt_Remark.Text;
                                    int count = HdBUS.ModifyData(Hld);
                                    if (count > 0)
                                    {
                                        MessageBox.Show("Modify Thành Công " + count + " Dòng Trong Hệ Thống", "Thông Báo");
                                        LoadAll();
                                    }
                                    else
                                        MessageBox.Show("Modify Không Thành Công", "Thông Báo");
                                }
                            }
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Không Tồn Tại ID Này Trong Hệ Thống", "Thông Báo");
                }
            }
        }

        private void Btn_Search_Click(object sender, EventArgs e)
        {
            if (Btn_Search.Text == "Search")
            {
                Btn_Search.Text = "Done";
                DateTime parsedDate = DateTime.ParseExact(Dtp_Date.Text, "dddd, d MMMM yyyy", System.Globalization.CultureInfo.InvariantCulture);
                Hld.Holiday_date1 = parsedDate.ToString("yyyy-MM-dd");
                DataTable dt = HdBUS.FindData(Hld);
                if (dt.Rows.Count > 0)
                    Dgv_Holiday.DataSource = dt;
                else
                {
                    MessageBox.Show("Không Tồn Tại Ngày Lễ Này Trong Hệ Thống", "Thông Báo");
                    LoadAll();
                }
            }
            else
            {
                LoadAll();
                Btn_Search.Text = "Search";
            }
        }

        private void Btn_Close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Dgv_Holiday_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in Dgv_Holiday.SelectedRows)
            {
                Txt_ID.Text = row.Cells["ID"].Value.ToString();
                Dtp_Date.Value = Convert.ToDateTime(row.Cells["holiday_date"].Value.ToString());
                Txt_NameGroup.Text = row.Cells["holiday_name_group"].Value.ToString();
                Txt_NameEn.Text = row.Cells["holiday_name_en"].Value.ToString();
                Txt_NameVi.Text = row.Cells["holiday_name_vi"].Value.ToString();
                Txt_Remark.Text = row.Cells["remark"].Value.ToString();
            }
        }

        private void Txt_ID_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
            if (Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar)||Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui Lòng Không Nhập Ký Tự Đặc Biệt Và Chữ", "Thông Báo");
            }
        }
        private void Txt_Name_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = false;
            if (Char.IsPunctuation(e.KeyChar) || Char.IsSymbol(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui Lòng Không Nhập Ký Tự Đặc Biệt", "Thông Báo");
            }
        }
    }
}
