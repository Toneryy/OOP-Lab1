namespace Lab1
{

    public class OfflineCourse : Course
    {
        public string Classroom { get; set; }

        public OfflineCourse(string title, string classroom) : base(title)
        {
            Classroom = classroom;
        }
    }
}

