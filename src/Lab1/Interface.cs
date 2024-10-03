namespace Lab1
{
    public interface ICourse
    {
        string Title { get; }
        IReadOnlyCollection<Student> Students { get; }
        void AddStudent(Student student);
    }

    public interface IManageCourses
    {
        void AddCourse(ICourse course);
        IReadOnlyCollection<ICourse> GetCoursesByTeacher(Teacher teacher);
    }

    public interface IPerson
    {
        string Name { get; }
    }
}