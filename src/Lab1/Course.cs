namespace Lab1
{
    public abstract class Course
    {
        public string Title { get; set; }

        public IReadOnlyCollection<Student> Students { get; private set; }

        private readonly List<Student> _students = new List<Student>();

        protected Course(string title)
        {
            Title = title;
            Students = _students.AsReadOnly();
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }
    }
}

