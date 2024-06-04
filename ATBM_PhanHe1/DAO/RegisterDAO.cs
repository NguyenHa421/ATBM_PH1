using ATBM_PhanHe1.DTO;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DAO
{
    public class RegisterDAO
    {
        private static RegisterDAO instance;
        public static RegisterDAO Instance
        {
            get { if (instance == null) instance = new RegisterDAO(); return RegisterDAO.instance; }
            private set { RegisterDAO.instance = value; }
        }
        private RegisterDAO() { }
        /*public List<RegisterDTO> GetRegisterList()
        {
            List<RegisterDTO> list = new List<RegisterDTO>();
            string query = "select * from tb_dangky";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                RegisterDTO register = new RegisterDTO(row);
                list.Add(register);
            }
            return list;
        }*/
        /*public List<RegisterDTO> SearchRegister(string searchKey)
        {
            List<RegisterDTO> result = new List<RegisterDTO>();
            string query = string.Format("select * from tb_dangky where lower(HOTEN) like lower('%{0}%')", searchKey);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                PersonelDTO register = new RegisterDTO(row);
                result.Add(register);
            }
            return result;
        }*/
        public void DeleteRegisterByID(string id)
        {
            string query = string.Format("begin delete from tb_nhansu where MANV = {0}; end;", id);
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public PersonelDTO GetPersonelByID(string personelID)
        {
            string query = string.Format("select * from tb_nhansu where lower(MANV) like lower('%{0}%')", personelID);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            PersonelDTO result = new PersonelDTO(data.Rows[0]);
            return result;
        }
    }
}
