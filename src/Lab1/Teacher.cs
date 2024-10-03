namespace Lab1
{

    public class Teacher
    {
        public string Name { get; set; }

        public IReadOnlyCollection<Course> Courses { get; private set; }

        private readonly List<Course> _courses = new List<Course>();

        public Teacher(string name)
        {
            Name = name;
            Courses = _courses.AsReadOnly();
        }

        public void AddCourse(Course course)
        {
            _courses.Add(course);
        }
    }
}

