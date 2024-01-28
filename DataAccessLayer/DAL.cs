using BussinessObject.Models;
using DataAccessLayer.Context;

namespace DataAccessLayer
{
    public class DAL
    {
        AppDbContext db = new AppDbContext();
        public List<Course> GetAllCourses()
        {
            return db.Courses.ToList();
        }

        public void AddCourse(Course course)
        {
            db.Courses.Add(course);
            db.SaveChanges();
        }

        public Course GetCourseById (int id)
        {
            return db.Courses.SingleOrDefault(x => x.CourseId == id);
        }

        public void DeleteCourse(int id)
        {
            var obj = db.Courses.SingleOrDefault(x=>x.CourseId==id);
            db.Courses.Remove(obj);
            db.SaveChanges();
        }

        public void EditCourse(int id, Course course)
        {
            var obj = db.Courses.ToList().Where(x=>x.CourseId==id).FirstOrDefault();
            if(obj != null)
            {
                foreach(Course c in db.Courses.ToList()) 
                {
                    if (c.CourseId == obj.CourseId)
                    {
                        c.Module = course.Module;
                        c.Description = course.Description;
                        c.Name= course.Name;
                        break;

                    }
                }
                db.SaveChanges ();
                
            }
            //else
            //{
            //    return "No course found";
            //}
        }
    }
}

