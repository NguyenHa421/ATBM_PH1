using ATBM_PhanHe1.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DAO
{
    public class AssignmentDAO
    {
        private static AssignmentDAO instance;
        public static AssignmentDAO Instance
        {
            get { if (instance == null) instance = new AssignmentDAO(); return AssignmentDAO.instance; }
            private set { AssignmentDAO.instance = value; }
        }
        private AssignmentDAO() { }
        private void FillAssignmentDTO(AssignmentDTO sample)
        {
            
        }
    }
}
