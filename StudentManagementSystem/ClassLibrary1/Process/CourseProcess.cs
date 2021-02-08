using SMS.Database.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Database.Process
{
    public class CourseProcess
    {
        StudentMSEntities1 entity = new StudentMSEntities1();
        public List<COURSEType> GetCourse()
        {
            return entity.COURSEs.Select(x => new COURSEType()
            {
                ID = x.ID,
                NAME = x.NAME,
                FEES = x.FEES,
                DURATION = x.DURATION
            }).ToList();
        }
        public void InsertUserCourse(USER_COURSE user_course)
        {
            entity.USER_COURSE.Add(user_course);
            entity.SaveChanges();
        }
        public void InsertCourse(COURSE course)
        {
            entity.COURSEs.Add(course);
            entity.SaveChanges();
        }
        public void InsertCourseDetail(TEACHER_COURSE_DETAIL course)
        {
            entity.TEACHER_COURSE_DETAIL.Add(course);
            entity.SaveChanges();
        }
        public List<GetCourseUserDetail_Result> GetCourseUserDetail(Guid? CourseId)
        {
            return entity.GetCourseUserDetail(CourseId).ToList();
        }
        public List<GetCourseContent_Result> GetCourseContent(Guid? CourseId)
        {
            return entity.GetCourseContent(CourseId).ToList();
        }
    }

    public class COURSEType
    {
        public System.Guid ID { get; set; }
        public string NAME { get; set; }
        public int? FEES { get; set; }
        public string DURATION { get; set; }
    }

}
