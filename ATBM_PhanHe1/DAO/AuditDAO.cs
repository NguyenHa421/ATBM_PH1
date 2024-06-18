using ATBM_PhanHe1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DAO
{
    public class AuditDAO
    {
        private static AuditDAO instance;
        public static AuditDAO Instance
        {
            get { if (instance == null) instance = new AuditDAO(); return AuditDAO.instance; }
            private set { AuditDAO.instance = value; }
        }
        private AuditDAO() { }
        public List<AuditDTO> GetAuditList()
        {
            List<AuditDTO> list = new List<AuditDTO>();
            string query = "select * from DBA_AUDIT_TRAIL";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                AuditDTO Audit = new AuditDTO(row);
                list.Add(Audit);
            }
            query = "select timestamp, db_user as username, object_schema as owner, object_name as obj_name, statement_type as action from DBA_FGA_AUDIT_TRAIL";
            data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                AuditDTO Audit = new AuditDTO(row);
                list.Add(Audit);
            }
            return list;
        }
        public List<AuditDTO> SearchAudit(string searchKey1, string searchKey2)
        {
            List<AuditDTO> result = new List<AuditDTO>();
            string query = string.Format("select * from DBA_AUDIT_TRAIL where lower(obj_name) like lower('%{0}%') and lower(username) like lower('%{1}%')", searchKey1, searchKey2);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                AuditDTO Audit = new AuditDTO(row);
                result.Add(Audit);
            }
            query = string.Format("select timestamp, db_user as username, object_schema as owner, object_name as obj_name, statement_type as action from DBA_FGA_AUDIT_TRAIL where lower(obj_name) like lower('%{0}%') and lower(username) like lower('%{1}%')", searchKey1, searchKey2);
            data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                AuditDTO Audit = new AuditDTO(row);
                result.Add(Audit);
            }
            return result;
        }
    }
}
