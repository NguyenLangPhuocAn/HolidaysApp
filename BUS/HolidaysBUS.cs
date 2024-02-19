using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS
{
    public class HolidaysBUS
    {
        Holidays Hd=new Holidays();
        public DataTable ReadData()
        {
            return Hd.ReadData();
        }
        public DataTable FindData(HolidaysDTO Hld)
        {
            return Hd.FindData(Hld);
        }
        public DataTable FindDuplicate(HolidaysDTO Hld)
        {
            return Hd.FindDuplicate(Hld);
        }
        public int DeleteData(HolidaysDTO Hld)
        {
            return Hd.Delete(Hld);
        }
        public int DeleteList(List<HolidaysDTO> HolidayList)
        {
            return Hd.DeleteList(HolidayList);
        }
        public int ModifyData(HolidaysDTO Hld)
        {
            return Hd.Modify(Hld);
        }
        public int InsertData(HolidaysDTO Hld)
        {
            return Hd.Create(Hld);
        }
    }
}
