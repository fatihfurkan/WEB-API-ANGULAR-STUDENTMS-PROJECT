using SMS.Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Database.Process
{
    public class UserProcess
    {
        StudentMSEntities1 entity = new StudentMSEntities1();

        public List<USERType> GetUserAll()
        {
            return entity.USERs.Select(x => new USERType()
            {
                ID = x.ID
            }).ToList();
        }
        public List<GetUserInfo_Result> GetUserByEmail(string email, string password)
        {
            return entity.GetUserInfo(email, password).ToList();
        }

        public void InsertUser(USER student)
        {
            entity.USERs.Add(student);
            entity.SaveChanges();
        }
    }
    public class USERType
    {
        public System.Guid ID { get; set; }
    }
}
