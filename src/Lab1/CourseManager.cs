namespace Lab1
{
    public class CourseManager
    {
        public IReadOnlyCollection<Course> Courses { get; private set; }

        private readonly List<Course> _courses = new List<Course>();

        public CourseManager()
        {
            Courses = _courses.AsReadOnly();
        }

        public void AddCourse(Course course)
        {
            _courses.Add(course);
        }

        public IReadOnlyCollection<Course> GetCoursesByTeacher(Teacher teacher)
        {
            var coursesByTeacher = new List<Course>();

            foreach (Course course in _courses)
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
