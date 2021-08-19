using System;
using System.Collections.Generic;

namespace ProjectPhase1
{
    class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }

    }
    class TeacherBO
    {
        public List<Teacher> teachers { get; set; }
        public TeacherBO()
        {
            teachers = new List<Teacher>() { };

        }
        public List<Teacher> GetAllTeachers() { return teachers; }
        public Teacher GetTeacherById(int id) { return teachers.Find(x => x.Id == id); }
        public void AddTeacher(Teacher o) { teachers.Add(o); }
        public void EditTeacher(Teacher o) { int index = teachers.FindIndex(x => x.Id == o.Id); teachers[index] = o; }
        public void DeleteTeacher(int id) { int index = teachers.FindIndex(x => x.Id == id); teachers.RemoveAt(index); }
    }
    class Program
    {

        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            List<Teacher> teachers = new List<Teacher>();

            TeacherBO obj = new TeacherBO();
            Teacher t1 = new Teacher();
            t1.Id = 1;
            t1.Name = "Asha";
            t1.Class = "cse1";
            obj.teachers.Add(t1);
            int choice = 0;
            while (choice != 6)
            {
                Console.WriteLine("--------------Menu--------------");
                Console.WriteLine("1. Display list of All Teacher" + "\n" +
                                   "2. Display Teacher by ID" + "\n" +
                                   "3. Add Teacher" + "\n" +
                                   "4. Edit Teacher" + "\n" +
                                   "5. Delete Teacher" + "\n" +
                                   "6. Exit" + "\n"
                    );
                Console.WriteLine("Enter Choice");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {

                    case 1:
                        teachers = obj.GetAllTeachers();
                        Console.WriteLine("ID" + "\t" + "Name" + "\t" + "Class");
                        foreach (Teacher t in teachers)
                        {
                            
                            Console.WriteLine(t.Id + "\t" + t.Name + "\t" + t.Class);
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter ID");
                        int id;
                        id = Convert.ToInt32(Console.ReadLine());
                        t1 = obj.GetTeacherById(id);
                        Console.WriteLine("ID" + "\t" + "Name" + "\t" + "Class");
                        Console.WriteLine(t1.Id + "\t" + t1.Name + "\t" + t1.Class);
                        break;
                    case 3:
                        Console.WriteLine("Enter ID of Teacher");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        Teacher tnew = new Teacher();
                        tnew.Id = id1;
                        Console.WriteLine("Enter Name of Teacher");
                        string name = Console.ReadLine();
                        tnew.Name = name;
                        Console.WriteLine("Enter Class of Teacher");
                        string classN = Console.ReadLine();
                        tnew.Class = classN;
                        obj.AddTeacher(tnew);
                        Console.WriteLine("Addition Successful !!!!");
                        break;
                    case 4:
                        Console.WriteLine("Enter ID of Teacher");
                        int id4 = Convert.ToInt32(Console.ReadLine());
                        Teacher tnew4 = new Teacher();
                        tnew4.Id = id4;
                        Console.WriteLine("Enter Name of Teacher");
                        string name4 = Console.ReadLine();
                        tnew4.Name = name4;
                        Console.WriteLine("Enter Class of Teacher");
                        string classN4 = Console.ReadLine();
                        tnew4.Class = classN4;
                        obj.EditTeacher(tnew4);
                        Console.WriteLine("Edit Successful !!!!");
                        break;
                    case 5:
                        Console.WriteLine("Enter Id of teacher to delete");
                        int id5 = Convert.ToInt32(Console.ReadLine());
                        obj.DeleteTeacher(id5);
                        Console.WriteLine("Deletion Successful !!!!");
                        break;
                }
            }

        }
    }
}
