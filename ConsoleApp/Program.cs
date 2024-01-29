using System.Dynamic;
using Domain.Models;
using Infrastructure.Services;
System.Console.WriteLine("--------------------------------------------------------------------------------------------------SoftClub-----------------------------------------------------------------------------------------------");
System.Console.WriteLine();
while (true)
{
    System.Console.WriteLine("Student 👦🏼");
    System.Console.WriteLine("Teacher 👴🏼");
    System.Console.WriteLine("Cource 📒");
    System.Console.WriteLine("Post 📧");
    System.Console.WriteLine("Exit 🚪");
    string theFComand = Console.ReadLine();
    if (theFComand == "Student" || theFComand == "student" || theFComand == "STUDENT")
    {
        StudentService studentService = new StudentService();
        while (true)
        {
            System.Console.WriteLine("list");
            System.Console.WriteLine("add");
            System.Console.WriteLine("edit");
            System.Console.WriteLine("delete");
            System.Console.WriteLine("exit");
            string comand = Console.ReadLine();
            if (comand == "add")
            {
                Student AStudent = new Student();
                System.Console.WriteLine("Id: ");
                AStudent.Id = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("FirstName: ");
                AStudent.Fistname = Console.ReadLine();
                System.Console.WriteLine("LastName: ");
                AStudent.Lastname = Console.ReadLine();
                System.Console.WriteLine("Birth date: ");
                AStudent.BirthDate = Convert.ToDateTime(Console.ReadLine());
                System.Console.WriteLine("Adress: ");
                AStudent.Adress = Console.ReadLine();
                studentService.AddStudent(AStudent);
            }
            else if (comand == "list")
            {
                foreach (var i in studentService.GetStudent())
                {
                    System.Console.WriteLine("Id: " + i.Id);
                    System.Console.WriteLine("FirstName: " + i.Fistname);
                    System.Console.WriteLine("LastName: " + i.Lastname);
                    System.Console.WriteLine("BithDate: " + i.BirthDate);
                    System.Console.WriteLine("Adress: " + i.Adress);
                    System.Console.WriteLine("______________________________");
                }
            }
            else if (comand == "edit")
            {
                Student AStudent = new Student();
                AStudent.Id = Convert.ToInt32(Console.ReadLine());
                AStudent.Fistname = Console.ReadLine();
                AStudent.Lastname = Console.ReadLine();
                AStudent.BirthDate = Convert.ToDateTime(Console.ReadLine());
                AStudent.Adress = Console.ReadLine();
                System.Console.WriteLine(studentService.UpdateInfoOfStudent(AStudent));

            }
            else if (comand == "delete")
            {
                int id = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine(studentService.DeleteStudent(id));
            }
            else if (comand == "Exit" || comand == "EXIT" || comand == "exit") break;
            else System.Console.WriteLine("!!!WRONG COMMAND (write carefully!)!!!");
        }
    }
    else if (theFComand == "Teacher" || theFComand == "teacher" || theFComand == "TEACHER")
    {
        TeacherService teacherService = new TeacherService();
        while (true)
        {
            System.Console.WriteLine("list");
            System.Console.WriteLine("add");
            System.Console.WriteLine("edit");
            System.Console.WriteLine("delete");
            System.Console.WriteLine("exit");
            string comand = Console.ReadLine();
            if (comand == "add")
            {
                Teacher ATeacher = new Teacher();
                System.Console.WriteLine("Id: ");
                ATeacher.Id = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("FirstName: ");
                ATeacher.Fistname = Console.ReadLine();
                System.Console.WriteLine("LastName: ");
                ATeacher.Lastname = Console.ReadLine();
                System.Console.WriteLine("Position: ");
                ATeacher.Position = Console.ReadLine();
                System.Console.WriteLine("experience years:");
                ATeacher.ExperienceAmount = Convert.ToInt32(Console.ReadLine());
                teacherService.AddTeacher(ATeacher);
            }
            else if (comand == "list")
            {
                foreach (var i in teacherService.GetTeacher())
                {
                    System.Console.WriteLine(i.Id);
                    System.Console.WriteLine(i.Fistname);
                    System.Console.WriteLine(i.Lastname);
                    System.Console.WriteLine(i.Position);
                    System.Console.WriteLine(i.ExperienceAmount);
                    System.Console.WriteLine("______________________________");
                }
            }
            else if (comand == "edit")
            {
                Teacher ATeacher = new Teacher();
                ATeacher.Id = Convert.ToInt32(Console.ReadLine());
                ATeacher.Fistname = Console.ReadLine();
                ATeacher.Lastname = Console.ReadLine();
                ATeacher.Position = Console.ReadLine();
                ATeacher.ExperienceAmount = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine(teacherService.UpdateInfoOfTeacher(ATeacher));

            }
            else if (comand == "delete")
            {
                int id = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine(teacherService.DeleteTeacher(id));
            }
            else if (comand == "Exit" || comand == "EXIT" || comand == "exit") break;
            else System.Console.WriteLine("!!!WRONG COMMAND (write carefully!)!!!");
        }
    }
    else if (theFComand == "Cource" || theFComand == "cource" || theFComand == "COURCE")
    {
        CourceService courceService = new CourceService();
        while (true)
        {
            System.Console.WriteLine("list");
            System.Console.WriteLine("add");
            System.Console.WriteLine("edit");
            System.Console.WriteLine("delete");
            System.Console.WriteLine("exit");
            string comand = Console.ReadLine();
            if (comand == "add")
            {
                Cource ACource = new Cource();
                System.Console.WriteLine("Id: ");
                ACource.Id = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine("Title: ");
                ACource.Title = Console.ReadLine();
                ACource.Description = Console.ReadLine();
                ACource.Fee = Convert.ToDecimal(Console.ReadLine());
                ACource.HasDiscount = Convert.ToBoolean(Console.ReadLine());
                courceService.AddCource(ACource);
            }
            else if (comand == "list")
            {
                foreach (var i in courceService.GetCource())
                {
                    System.Console.WriteLine(i.Id);
                    System.Console.WriteLine(i.Title);
                    System.Console.WriteLine(i.Description);
                    System.Console.WriteLine(i.Fee);
                    System.Console.WriteLine(i.HasDiscount);
                    System.Console.WriteLine("______________________________");
                }
            }
            else if (comand == "edit")
            {
                Cource ACource = new Cource();
                ACource.Id = Convert.ToInt32(Console.ReadLine());
                ACource.Title = Console.ReadLine();
                ACource.Description = Console.ReadLine();
                ACource.Fee = Convert.ToDecimal(Console.ReadLine());
                ACource.HasDiscount = Convert.ToBoolean(Console.ReadLine());
                System.Console.WriteLine(courceService.UpdateInfoOfCource(ACource));

            }
            else if (comand == "delete")
            {
                int id = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine(courceService.DeleteCource(id));
            }
            else if (comand == "Exit" || comand == "EXIT" || comand == "exit") break;
            else System.Console.WriteLine("!!!WRONG COMMAND (write carefully!)!!!");
        }
    }
    else if (theFComand == "Post" || theFComand == "POST" || theFComand == "post")
    {
        PostService postService = new PostService();
        while (true)
        {
            System.Console.WriteLine("list");
            System.Console.WriteLine("add");
            System.Console.WriteLine("edit");
            System.Console.WriteLine("delete");
            System.Console.WriteLine("exit");
            // we should
            string comand = Console.ReadLine();
            if (comand == "add")
            {
                Post APost = new Post();
                APost.Id = Convert.ToInt32(Console.ReadLine());
                APost.Title = Console.ReadLine();
                APost.Description = Console.ReadLine();
                APost.VoteAmount = Convert.ToInt32(Console.ReadLine());
                APost.CreateAI = Convert.ToDateTime(Console.ReadLine());
                postService.AddPost(APost);
            }
            else if (comand == "list")
            {
                foreach (var i in postService.GetPost())
                {
                    System.Console.WriteLine(i.Id);
                    System.Console.WriteLine(i.Title);
                    System.Console.WriteLine(i.Description);
                    System.Console.WriteLine(i.VoteAmount);
                    System.Console.WriteLine(i.CreateAI);
                    System.Console.WriteLine("______________________________");
                }
            }
            else if (comand == "edit")
            {
                Post APost = new Post();
                APost.Id = Convert.ToInt32(Console.ReadLine());
                APost.Title = Console.ReadLine();
                APost.Description = Console.ReadLine();
                APost.VoteAmount = Convert.ToInt32(Console.ReadLine());
                APost.CreateAI = Convert.ToDateTime(Console.ReadLine());
                System.Console.WriteLine(postService.UpdateInfoOfPost(APost));

            }
            else if (comand == "delete")
            {
                int id = Convert.ToInt32(Console.ReadLine());
                System.Console.WriteLine(postService.DeletePost(id));
            }
            else if (comand == "Exit" || comand == "EXIT" || comand == "exit") break;
            else System.Console.WriteLine("!!!WRONG COMMAND (write carefully!)!!!");
        }

    }
    else if (theFComand == "Exit" || theFComand == "EXIT" || theFComand == "exit") break;
    else System.Console.WriteLine("!!!WRONG COMMAND (write carefully!)!!!");
}