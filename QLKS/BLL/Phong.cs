using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;
using System.Data;

namespace BLL
{
    public class Phong
    {
        Data da = new Data();
        public DataTable ShowPhong()
        {
            string sql = "select * from Phong";
            DataTable dt = new DataTable();
            dt = da.GetTable(sql);
            return dt;
        }
    }
}
