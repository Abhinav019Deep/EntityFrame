using BussinessObject.Models;

namespace BussinessAccessLayer
{
    public class BAL
    {
        DataAccessLayer.DAL dal = new DataAccessLayer.DAL();
        public List<Course> GetAllCourses()
        {
            return dal.GetAllCourses();
        }

        public void AddCourse(Course course)
        {

            dal.AddCourse(course);
        }

        public Course GetCourseById(int id)
        {
          return  dal.GetCourseById(id);
        }

        public void DeleteCourse(int id)
        {
            dal.DeleteCourse(id);
        }

        public void EditCourse(int id, Course course)
        {
            dal.EditCourse( id, course);
        }
    }
}
