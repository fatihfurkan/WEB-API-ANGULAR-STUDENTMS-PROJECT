using SMS.Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Database.Process
{
    public class RoleProcess
    {
        StudentMSEntities1 entity = new StudentMSEntities1();
        public List<ROLEType> GetRoles()
        {
            return entity.ROLEs.Select(x => new ROLEType()
            {
                ID = x.ID,
                ROLENAME = x.ROLENAME,
                ROLECODE = x.ROLECODE
            }).ToList();
        }
    }
    public class ROLEType
    {
        public System.Guid ID { get; set; }
        public string ROLENAME { get; set; }
        public string ROLECODE { get; set; }
    }
}
