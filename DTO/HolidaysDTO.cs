using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class HolidaysDTO
    {
        private int ID;
        private string Holiday_date;
        private string Holiday_name_group;
        private string Holiday_name_en;
        private string Holiday_name_vi;
        private string Remark;
        private string Updated_By;
        private DateTime Updated_date;
        public HolidaysDTO()
        {
        }


public HolidaysDTO(int iD, string holiday_date, string holiday_name_group, string holiday_name_en, string holiday_name_vi, string remark, string updated_By, DateTime updated_date)
        {
            ID = iD;
            Holiday_date = holiday_date;
            Holiday_name_group = holiday_name_group;
            Holiday_name_en = holiday_name_en;
            Holiday_name_vi = holiday_name_vi;
            Remark = remark;
            Updated_By = updated_By;
            Updated_date = updated_date;
        }

        public int ID1 { get => ID; set => ID = value; }
        public string Holiday_date1 { get => Holiday_date; set => Holiday_date = value; }
        public string Holiday_name_group1 { get => Holiday_name_group; set => Holiday_name_group = value; }
        public string Holiday_name_en1 { get => Holiday_name_en; set => Holiday_name_en = value; }
        public string Holiday_name_vi1 { get => Holiday_name_vi; set => Holiday_name_vi = value; }
        public string Remark1 { get => Remark; set => Remark = value; }
        public string Updated_By1 { get => Updated_By; set => Updated_By = value; }
        public DateTime Updated_date1 { get => Updated_date; set => Updated_date = value; }
    }
}
