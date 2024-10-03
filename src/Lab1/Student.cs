namespace Lab1
{
    public class Student : IPerson
    {
        public string Name { get; set; }
        public IReadOnlyCollection<Course> Courses { get; private set; }

        private readonly List<Course> _courses = new List<Course>();

        public Student(string name)
        {
            Name = name;
            Courses = _courses.AsReadOnly();
        }

        public void EnrollInCourse(Course course)
        {
            _courses.Add(course);
            course.AddStudent(this); // Добавляем студента в курс
        }
    }
}