using Domain.Models;
namespace Infrastructure.Services;

public class StudentService
{
    public StudentService() {}
    List<Student> _students = new List<Student>();

    public List<Student> GetStudent(){
        return _students;
    }
    public void AddStudent(Student student){
        _students.Add(student);
    }
    public string UpdateInfoOfStudent(Student UpdatedStudent){
        foreach (var student in _students)
        {
            if (student.Id == UpdatedStudent.Id)
            {
                student.Fistname = UpdatedStudent.Fistname;
                student.Lastname = UpdatedStudent.Lastname;
                student.BirthDate = UpdatedStudent.BirthDate;
                student.Adress = UpdatedStudent.Adress;
                return "Student's info is updated";
            }
        }
        return "Student not found";
    }
    public string DeleteStudent(int id){
        foreach (var student in _students)
        {
            if (student .Id == id)
            {
                _students.Remove(student);
                return "Student deleted";
            }
        }
        return "Student not found";
    }
}
