using ATBM_PhanHe1.DTO;
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
            string query = "select * from admin.tb_nhansu";
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
            string query = string.Format("select * from admin.tb_nhansu where lower(HOTEN) like lower('%{0}%')", searchKey);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach (DataRow row in data.Rows)
            {
                PersonelDTO personel = new PersonelDTO(row);
                result.Add(personel);
            }
            return result;
        }
        
        public bool DeletePersonelByID(string id)
        {
            string query = $"Delete from admin.tb_nhansu where MANV = ('{id}')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }

        public PersonelDTO GetPersonelByID(string personelID)
        {
            string query = string.Format("select * from ADMIN.UV_NVXEMTHONGTIN where lower(MANV) like lower('%{0}%')", personelID);
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            PersonelDTO result = new PersonelDTO(data.Rows[0]);
            return result;
        }
        public List<PersonelDTO> GetListLecturer()
        {
            List<PersonelDTO> list = new List<PersonelDTO>();
            string query = "SELECT * FROM ADMIN.UV_XEMGIANGVIEN";
            DataTable data = DataProvider.Instance.ExecuteQuery(query);
            foreach(DataRow row in data.Rows)
            {
                PersonelDTO personel = new PersonelDTO(row);
                list.Add(personel);
            }
            return list;
        }
       
        public string GetGenderStaff(string id)
        {
            string query = $"SELECT PHAI FROM ADMIN.UV_NVXEMTHONGTIN WHERE MANV = ('{id}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
        public string GetBirthStaff(string id)
        {
            string query = $"SELECT TO_CHAR(NGSINH, 'DD/MM/YYYY') FROM ADMIN.UV_NVXEMTHONGTIN WHERE MANV = ('{id}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
        public string GetBirthStaff2(string id)
        {
            string query = $"SELECT NGSINH FROM ADMIN.UV_NVXEMTHONGTIN WHERE MANV = ('{id}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
        public string GetPhoneStaff(string id)
        {
            string query = $"SELECT DT FROM ADMIN.UV_NVXEMTHONGTIN WHERE MANV = ('{id}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
        public string GetAllowanceStaff(string id)
        {
            string query = $"SELECT PHUCAP FROM ADMIN.UV_NVXEMTHONGTIN WHERE MANV = ('{id}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
        public string GetRoleStaff(string id)
        {
            string query = $"SELECT VAITRO FROM ADMIN.UV_NVXEMTHONGTIN WHERE MANV = ('{id}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
        public string GetIDUnitStaff(string id)
        {
            string query = $"SELECT MADV FROM ADMIN.UV_NVXEMTHONGTIN WHERE MANV = ('{id}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
        public string GetUnitStaff(string id)
        {
            string query = $"SELECT n.TENDV FROM ADMIN.UV_NVXEMTHONGTIN nv JOIN ADMIN.TB_DONVI n ON nv.MADV = n.MADV WHERE nv.MANV = ('{id}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
        public bool Update_SelfStaff(string phone)
        {
            string query = $"BEGIN ADMIN.USP_CHINHSODT('{phone}');END;";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public string GetIDAuto()
        {
            string query = $"SELECT ADMIN.CREATE_IDSTAFF FROM DUAL";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { });
            return result.ToString();
        }
        public bool Add_Staff(string id, string name, string gender, DateTime birth, int allowance, string phone, string role, string unit)
        {
            string query = $"INSERT INTO ADMIN.TB_NHANSU (MANV, HOTEN, PHAI, NGSINH, PHUCAP, DT, VAITRO, MADV) VALUES ('{id}', '{name}', '{gender}', TO_DATE('{birth.ToString("yyyy-MM-dd")}', 'YYYY-MM-DD'), '{allowance}', '{phone}', '{role}', '{unit}')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public bool Update_Staff(string id, string name, string gender, DateTime birth, int allowance, string phone, string role, string unit)
        {
            string query = $"UPDATE ADMIN.TB_NHANSU SET HOTEN = ('{name}'), PHAI = ('{gender}'), NGSINH = TO_DATE('{birth.ToString("yyyy-MM-dd")}', 'YYYY-MM-DD'), PHUCAP = ('{allowance}'), DT = ('{phone}'), VAITRO = ('{role}'), MADV = ('{unit}') WHERE MANV = ('{id}')";
            int result = DataProvider.Instance.ExecuteNonQuery(query);
            return result > 0;
        }
        public string HeadGetNameStaff(string id)
        {
            string query = $"SELECT HOTEN FROM ADMIN.TB_NHANSU WHERE MANV = ('{id}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
        public string HeadGetGenderStaff(string id)
        {
            string query = $"SELECT PHAI FROM ADMIN.TB_NHANSU WHERE MANV = ('{id}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
        public string HeadGetBirthStaff(string id)
        {
            string query = $"SELECT TO_CHAR(NGSINH, 'DD/MM/YYYY') FROM ADMIN.TB_NHANSU WHERE MANV = ('{id}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
        public string HeadGetBirthStaff2(string id)
        {
            string query = $"SELECT NGSINH FROM ADMIN.TB_NHANSU WHERE MANV = ('{id}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
        public string HeadGetPhoneStaff(string id)
        {
            string query = $"SELECT DT FROM ADMIN.TB_NHANSU WHERE MANV = ('{id}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
        public string HeadGetAllowanceStaff(string id)
        {
            string query = $"SELECT PHUCAP FROM ADMIN.TB_NHANSU WHERE MANV = ('{id}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
        public string HeadGetRoleStaff(string id)
        {
            string query = $"SELECT VAITRO FROM ADMIN.TB_NHANSU WHERE MANV = ('{id}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
        public string HeadGetIDUnitStaff(string id)
        {
            string query = $"SELECT MADV FROM ADMIN.TB_NHANSU WHERE MANV = ('{id}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
        public string HeadGetUnitStaff(string id)
        {
            string query = $"SELECT n.TENDV FROM ADMIN.TB_NHANSU nv JOIN ADMIN.TB_DONVI n ON nv.MADV = n.MADV WHERE nv.MANV = ('{id}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id });
            return result.ToString();
        }
        public DataTable GetListBecomeHead()
        {
            return DataProvider.Instance.ExecuteQuery(string.Format("SELECT * FROM ADMIN.UV_XEMGIANGVIEN"));
        }
        public string GetNameHeadByIDHead(string id_head)
        {
            string query = $"SELECT HOTEN FROM ADMIN.UV_XEMGIANGVIEN WHERE MANV = ('{id_head}')";
            object result = DataProvider.Instance.ExecuteScalar(query, new object[] { id_head });
            return result != null ? result.ToString() : null;
        }
    }
}
