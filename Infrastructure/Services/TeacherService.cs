using Domain.Models;
namespace Infrastructure.Services;

public class TeacherService
{
    public TeacherService() {}
    List<Teacher> _teacher = new List<Teacher>();

    public List<Teacher> GetTeacher(){
        return _teacher;
    }
    public void AddTeacher(Teacher teacher){
        _teacher.Add(teacher);
    }
    public string UpdateInfoOfTeacher(Teacher UpdatedTeacher){
        foreach (var teacher in _teacher)
        {
            if (teacher.Id == UpdatedTeacher.Id)
            {
                teacher.Fistname = UpdatedTeacher.Fistname;
                teacher.Lastname = UpdatedTeacher.Lastname;
                teacher.Position = UpdatedTeacher.Position;
                teacher.ExperienceAmount = UpdatedTeacher.ExperienceAmount;
                return "Teacher's info is updated";
            }
        }
        return "Teacher not found";
    }
    public string DeleteTeacher(int id){
    foreach (var teacher in _teacher)
        {
            if (teacher .Id == id)
            {
                _teacher.Remove(teacher);
                return "Teacher deleted";
            }
        }
        return "Teacher not found";
    }
}
