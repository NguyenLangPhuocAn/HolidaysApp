using DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class Holidays
    {
        string Table = "holidays";
        string Values = "holiday_date,holiday_name_group,holiday_name_en,holiday_name_vi,remark,updated_by";
        DbAccess db=new DbAccess();
        public DataTable ReadData()
        {
            string sql = "select * from " + Table + " order by updated_date DESC";
            try
            {
                return db.ExecuteDataTable(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable FindData(HolidaysDTO Hld)
        {
            string sql = "select * from " + Table + " Where holiday_date='" + Hld.Holiday_date1 + "' order by updated_date DESC ";
            try
            {
                return db.ExecuteDataTable(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public DataTable FindDuplicate(HolidaysDTO Hld)
        {
            string sql = "select * from " + Table + " Where ID=" + Hld.ID1 + " order by updated_date DESC ";
            try
            {
                return db.ExecuteDataTable(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Create(HolidaysDTO Hld)
        {
            string query = "INSERT INTO "+Table+"("+Values+") VALUES('" + Hld.Holiday_date1 + "','" + Hld.Holiday_name_group1 + "','" + Hld.Holiday_name_en1 + "',N'" + Hld.Holiday_name_vi1 + "',N'" + Hld.Remark1 + "','"+Hld.Updated_By1+"');   ";
            try
            {
                int rowsAffected = db.ExecuteNonQuery(query);
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Delete(HolidaysDTO Hld)
        {
            string query = "Delete From " + Table + " Where Id=" + Hld.ID1;
            try
            {
                int rowsAffected = db.ExecuteNonQuery(query);
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int DeleteList(List<HolidaysDTO> HolidayList)
        {
            string query = "DELETE FROM " + Table + " WHERE holiday_name_group IN (";
            for (int i = 0; i < HolidayList.Count; i++)
            {
                query += "'" + HolidayList[i].Holiday_name_group1 + "'";
                if (i < HolidayList.Count - 1)
                    query += ",";
            }
            query += ");";
            try
            {
                int rowsAffected = db.ExecuteNonQuery(query);
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public int Modify(HolidaysDTO Hld)
        {
            string query = "Update " + Table + " Set holiday_name_group='"+Hld.Holiday_name_group1+ "',holiday_name_en='"+Hld.Holiday_name_en1+ "',holiday_name_vi=N'"+Hld.Holiday_name_vi1+"',remark=N'"+Hld.Remark1+ "',updated_date='"+Hld.Updated_date1+"',updated_by='"+Hld.Updated_By1+"' Where ID="+Hld.ID1;
            try
            {
                int rowsAffected = db.ExecuteNonQuery(query);
                return rowsAffected;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}                       
