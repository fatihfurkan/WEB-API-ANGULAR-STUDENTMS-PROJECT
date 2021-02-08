using SMS.Database.Model;
using SMS.Database.Process;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace SMS.API.Controllers
{
    public class CourseController : ApiController
    {
        CourseProcess courseProcess = new CourseProcess();
        [System.Web.Http.HttpGet]
        public List<COURSEType> GetCourse()
        {
            return courseProcess.GetCourse();
        }

        [System.Web.Http.HttpGet]
        public List<GetCourseUserDetail_Result> GetCourseUserDetail(Guid? COURSEID)
        {
            return courseProcess.GetCourseUserDetail(COURSEID);
        }

        [System.Web.Http.HttpGet]
        public List<GetCourseContent_Result> GetCourseContent(Guid? COURSEID)
        {
            return courseProcess.GetCourseContent(COURSEID);
        }
        [System.Web.Http.HttpPost]
        public HttpResponseMessage InsertUserCourse(USER_COURSE usercourseRecord)
        {
            if (usercourseRecord == null)
            {
                return null;
            }
            else if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            try
            {
                usercourseRecord.ID = Guid.NewGuid();
                courseProcess.InsertUserCourse(usercourseRecord);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return Request.CreateResponse(HttpStatusCode.Created, usercourseRecord); ;
        }
        [System.Web.Http.HttpPost]
        public HttpResponseMessage InsertCourse(COURSE courseRecord)
        {
            if (courseRecord == null)
            {
                return null;
            }
            else if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            try
            {
                courseRecord.ID = Guid.NewGuid();
                courseProcess.InsertCourse(courseRecord);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return Request.CreateResponse(HttpStatusCode.Created, courseRecord); ;
        }
        [System.Web.Http.HttpPost]
        public HttpResponseMessage InsertCourseDetail(TEACHER_COURSE_DETAIL courseDetail)
        {
            if (courseDetail == null)
            {
                return null;
            }
            else if (!ModelState.IsValid)
            {
                return Request.CreateErrorResponse(HttpStatusCode.BadRequest, ModelState);
            }

            try
            {
                courseDetail.ID = Guid.NewGuid();
                courseProcess.InsertCourseDetail(courseDetail);
            }
            catch (DbUpdateConcurrencyException)
            {
                throw;
            }

            return Request.CreateResponse(HttpStatusCode.Created, courseDetail); ;
        }
    }
}