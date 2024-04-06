using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DTO
{
    public class UserPrivsDTO
    {
        public string grantee { get; set; }
        public string tableName { get; set; }
        public string colName {  get; set; }
        public string priv {  get; set; }
        public string grantable { get; set; }
        public UserPrivsDTO(string grantee, string tableName, string priv, string grantable)
        {
            this.grantee = grantee;
            this.tableName = tableName;
            this.priv = priv;
            this.colName = "";
            this.grantable = grantable;
        }
        public UserPrivsDTO(DataRow row)
        {
            this.grantee = row["GRANTEE"].ToString();
            this.tableName = row["TABLE_NAME"].ToString();
            this.priv = row["PRIVILEGE"].ToString();
            if (row.Table.Columns.Contains("COLUMN_NAME"))
                this.colName = row["COLUMN_NAME"].ToString();
            else
                this.colName = "";
            this.grantable = row["GRANTABLE"].ToString();
        }
    }
}
