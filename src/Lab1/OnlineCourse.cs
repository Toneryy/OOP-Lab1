namespace Lab1
{
    public class OnlineCourse : Course
    {
        public string Url { get; set; }

        public OnlineCourse(string title, string url) : base(title)
        {
            Url = url;
        }
    }
}