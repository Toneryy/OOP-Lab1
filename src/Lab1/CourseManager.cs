namespace Lab1
{
    public class CourseManager : IManageCourses
    {
        private readonly List<ICourse> _courses = new List<ICourse>();

        public IReadOnlyCollection<ICourse> Courses => _courses.AsReadOnly();

        public void AddCourse(ICourse course)
        {
            _courses.Add(course);
        }

        public IReadOnlyCollection<ICourse> GetCoursesByTeacher(Teacher teacher)
        {
            var coursesByTeacher = new List<ICourse>();

            foreach (ICourse course in _courses)
            {
                if (course is OnlineCourse onlineCourse && onlineCourse.Url == teacher.Name)
                {
                    coursesByTeacher.Add(course);
                }
                else if (course is OfflineCourse offlineCourse && offlineCourse.Classroom == teacher.Name)
                {
                    coursesByTeacher.Add(course);
                }
            }

            return coursesByTeacher.AsReadOnly();
        }
    }
}