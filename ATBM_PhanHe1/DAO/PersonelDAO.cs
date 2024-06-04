﻿using ATBM_PhanHe1.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DAO
{
    public class PersonelDAO
    {
        private static PersonelDAO instance;
        public static PersonelDAO Instance
        {
            get { if (instance == null) instance = new PersonelDAO(); return PersonelDAO.instance; }
            private set { PersonelDAO.instance = value; }
        }
        private PersonelDAO() { }
        public List<PersonelDTO> GetPersonelList()
        {
            List<PersonelDTO> list = new List<PersonelDTO>();
            string query = "select * from tb_nhansu";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                PersonelDTO personel = new PersonelDTO(row);
                list.Add(personel);
            }
            return list;
        }
        public List<PersonelDTO> SearchPersonel(string searchKey)
        {
            List<PersonelDTO> result = new List<PersonelDTO>();
            string query = string.Format("select * from tb_nhansu where lower(HOTEN) like lower('%{0}%')", searchKey);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                PersonelDTO personel = new PersonelDTO(row);
                result.Add(personel);
            }
            return result;
        }
        public void DeletePersonelByID(string id)
        {
            string query = string.Format("begin delete from admin.tb_nhansu where MANV = {0}; end;", id);
            DataProvider.Instance.ExecuteNonQuery(query);
        }

        public PersonelDTO GetPersonelByID(string personelID)
        {
            string query = string.Format("select * from admin.tb_nhansu where lower(MANV) like lower('%{0}%')", personelID);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            PersonelDTO result = new PersonelDTO(data.Rows[0]);
            return result;
        }
    }
}
