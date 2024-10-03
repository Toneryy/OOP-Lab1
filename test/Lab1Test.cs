using Xunit;

namespace Lab1
{
    public class AllTests
    {
        [Fact]
        public void OnlineCourse_Creation_ShouldSetProperties()
        {
            // Arrange & Act
            var onlineCourse = new OnlineCourse("Online Course", "http://online.com");

            // Assert
            Assert.Equal("Online Course", onlineCourse.Title);
            Assert.Equal("http://online.com", onlineCourse.Url);
        }

        [Fact]
        public void OfflineCourse_Creation_ShouldSetProperties()
        {
            // Arrange & Act
            var offlineCourse = new OfflineCourse("Offline Course", "Room 101");

            // Assert
            Assert.Equal("Offline Course", offlineCourse.Title);
            Assert.Equal("Room 101", offlineCourse.Classroom);
        }

        [Fact]
        public void Course_AddStudent_ShouldAddStudentToCourse()
        {
            // Arrange
            var course = new OfflineCourse("Offline Course", "Room 101");
            var student = new Student("Jane Smith");

            // Act
            course.AddStudent(student);

            // Assert
            Assert.Contains(student, course.Students);
        }

        [Fact]
        public void Student_Creation_ShouldSetProperties()
        {
            // Arrange & Act
            var student = new Student("Jane Smith");

            // Assert
            Assert.Equal("Jane Smith", student.Name);
        }

        [Fact]
        public void Teacher_Creation_ShouldSetProperties()
        {
            // Arrange & Act
            var teacher = new Teacher("John Doe");

            // Assert
            Assert.Equal("John Doe", teacher.Name);
        }

        [Fact]
        public void CourseManager_AddCourse_ShouldAddCourseCorrectly()
        {
            // Arrange
            var courseManager = new CourseManager();
            var course = new OnlineCourse("Test Course", "http://test.com");

            // Act
            courseManager.AddCourse(course);

            // Assert
            Assert.Contains(course, courseManager.Courses);
        }

        [Fact]
        public void CourseManager_GetCoursesByTeacher_ShouldReturnCorrectCourses()
        {
            // Arrange
            var courseManager = new CourseManager();
            var teacher = new Teacher("http://test.com");
            var course = new OnlineCourse("Test Course", "http://test.com");
            courseManager.AddCourse(course);

            // Act
            var result = courseManager.GetCoursesByTeacher(teacher);

            // Assert
            Assert.Contains(course, result);
        }

        [Fact]
        public void CourseManager_GetCoursesByTeacher_ShouldReturnEmptyIfNoMatch()
        {
            // Arrange
            var courseManager = new CourseManager();
            var teacher = new Teacher("Nonexistent Teacher");
            var course = new OnlineCourse("Test Course", "http://test.com");
            courseManager.AddCourse(course);

            // Act
            var result = courseManager.GetCoursesByTeacher(teacher);

            // Assert
            Assert.Empty(result);
        }

        [Fact]
        public void Student_EnrollInCourse_ShouldAddCourseToStudent()
        {
            // Arrange
            var student = new Student("Jane Smith");
            var course = new OfflineCourse("Offline Course", "Room 101");

            // Act
            student.EnrollInCourse(course);

            // Assert
            Assert.Contains(course, student.Courses);
        }

        [Fact]
        public void Teacher_AddCourse_ShouldAddCourseToTeacher()
        {
            // Arrange
            var teacher = new Teacher("John Doe");
            var course = new OfflineCourse("Course 101", "Room 101");

            // Act
            teacher.AddCourse(course);

            // Assert
            Assert.Contains(course, teacher.Courses);
        }
    }
}
