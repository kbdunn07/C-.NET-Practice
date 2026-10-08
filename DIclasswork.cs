using Microsoft.Extensions.DependencyInjection;

namespace DIclasswork
{
    public interface IStudentRepository
    {
        void AddStudent(Student student);
        List<Student> GetAllStudents();
        Student GetStudentById(int id);

    }

    public class Student
    {
        public int id {  get; set; }
        public string name { get; set; }
        public string major {  get; set; }

        public Student(int id, string name, string major)
        {
            this.id = id;
            this.name = name;
            this.major = major;
        }

    }

    public class IStudentRepositoryService : IStudentRepository
    {
        private List<Student> students;

        public IStudentRepositoryService(List<Student> students)
        {
            this.students = students;
        }

        public void AddStudent(Student student)
        {
            students.Add(student);
        }

        public List<Student> GetAllStudents()
        {
            return students;
        }

        public Student GetStudentById(int id)
        {
            return students.FirstOrDefault(s => s.id == id);
        }
    }

    public class StudentClient
    {
        private readonly IStudentRepository _repository;

        public StudentClient(IStudentRepository repository)
        {
            _repository = repository;
        }

        public void DisplayAllStudents()
        {
            Console.WriteLine("All Students:");

            foreach (Student student in _repository.GetAllStudents()) {
                Console.WriteLine($"ID: {student.id}, Name: {student.name}, Major: {student.major}");
            }
        }

        public void FindStudent(int id)
        {
            Console.WriteLine($"\nSearch for Student with ID = {id}:");

            Student student = _repository.GetStudentById(id);

            if (student != null) {
                Console.WriteLine($"Found: {student.name} - {student.major}");
            }
            else {
                Console.WriteLine("Student not found.");
            }
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>();
            students.Add(new Student(1, "Alice", "Computer Science"));
            students.Add(new Student(2, "Bob", "Engineering"));

            ServiceCollection services = new ServiceCollection();

            services.AddSingleton<IStudentRepository>(
                new IStudentRepositoryService(students));

            services.AddTransient<StudentClient>();

            ServiceProvider serviceProvider = services.BuildServiceProvider();

            StudentClient client =
                serviceProvider.GetRequiredService<StudentClient>();

            client.DisplayAllStudents();
            client.FindStudent(1);
        }
    }

}
