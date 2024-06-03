using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATBM_PhanHe1.DTO
{
    public class UnitDTO
    {
        public string unitID {  get; set; }
        public string unitName { get; set; }
        public string unitChief {  get; set; }
        public UnitDTO(string unitID, string unitName, string unitChief)
        {
            this.unitID = unitID;
            this.unitName = unitName;
            this.unitChief = unitChief;
        }
        public UnitDTO(DataRow row)
        {
            this.unitID = row["MADV"].ToString();
            this.unitName = row["TENDV"].ToString();
            this.unitChief = row["TRGDV"].ToString();
        }
    }
}
