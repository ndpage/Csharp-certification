// See https://aka.ms/new-console-template for more information

using System.Security.Cryptography;

namespace csharp_cert{

  class Course {
    private int _id;
    private string _name;
    private string _professor;
    private int _credithours;
    private int _grade;

    public int Id { get {
      return _id; 
    } set {
      _id = value;
    }}
    public string Name { 
      get {
      return _name;
    } 
      set {
        _name = value;
      }
    }
    public string Professor { 
      get {
        return _professor;
      }
      set {
        _professor = value; 
      }
      }
    public int CreditHours { 
      get {
        return _credithours;
      } 
      set {
        _credithours = value; 
      }
    }

    public int Grade { 
      get {
        return _grade;
      } 
      set {
        _grade = value; 
      }
    }

    public Course(string name, int id, string prof, int credit_hrs) {
      _id = id;
      _name = name;
      _professor = prof;
      _credithours = credit_hrs;
      _grade = 0;
    }
  }
  class Student {
    private string _name;
    private int _id;
    private Course[] _courses;
    private decimal _gpa;
    private int _total_gp;
    private int _credit_hrs;

    public Student(){
      _name = "";
      _id = 0;
      _courses = new Course[1];
      _gpa = 0;
    }
    public string Name { 
      get {
        return _name;
      }
      set {
        _name = value;
       }
      }
    public int Id { 
      get {return _id;} 
      set {
        _id = value;
      }
    }
    public Course[] Courses { 
      get {
        return _courses;
      }
      set {
        _courses = value;
      }
    }
    public decimal GPA { 
      get {
        _gpa = UpdateGPA();
        return _gpa;
      }
    }
    private decimal UpdateGPA(){
      for(int i = 0; i < _courses.Length; i++)
      {
        _credit_hrs += _courses[i].CreditHours; // Total credit hours
        _total_gp += _courses[i].CreditHours * _courses[i].Grade; // Total grade points
      }
      return (decimal)_total_gp / _credit_hrs;
    }
  }

  class Csharp_cert {
    public static void Main(String[] args){
      // All available courses
      Course course1 = new Course("English 101", 0, "Sally", 3);
      Course course2 = new Course("Algebra 101", 1, "Bill", 3);
      Course course3 = new Course("Biology 101", 2, "Alfred", 4);
      Course course4 = new Course("Computer Science I", 3, "Jerry", 4);
      Course course5 = new Course("Psycology 101", 4, "Mildred", 3);

      // Create student object
      Student student1 = new Student();
      student1.Name = "Sophia Johnson";
      student1.Id = 0;

      // Add courses to student object
      student1.Courses = new Course[] {course1, course2, course3, course4, course5};



      // Update grades
      student1.Courses.ElementAt(0).Grade = 4;
      student1.Courses[1].Grade = 3;
      student1.Courses[2].Grade = 3;
      student1.Courses[3].Grade = 3;
      student1.Courses[4].Grade = 4;
      
      // Output
      Console.WriteLine($"Student: {student1.Name}\n");
      Console.WriteLine("Course\t\t\t\tGrade\tCredit Hours");
      // Print all courses in student object
      for(int i = 0; i < student1.Courses.Length; i++){
        if(student1.Courses[i].Name.Length <= 11){
          Console.WriteLine($"{student1.Courses[i].Name}\t\t\t{student1.Courses[i].Grade}\t\t{student1.Courses[i].CreditHours}");
        } else if(student1.Courses[i].Name.Length > 11 && student1.Courses[i].Name.Length < 17){
          Console.WriteLine($"{student1.Courses[i].Name}\t\t\t{student1.Courses[i].Grade}\t\t{student1.Courses[i].CreditHours}");
        } else if(student1.Courses[i].Name.Length >= 17) {
          Console.WriteLine($"{student1.Courses[i].Name}\t\t{student1.Courses[i].Grade}\t\t{student1.Courses[i].CreditHours}");
        } else {
          Console.WriteLine($"{student1.Courses[i].Name}\t{student1.Courses[i].Grade}\t\t{student1.Courses[i].CreditHours}");
        }
      }
      Console.WriteLine("\nFinal GPA:\t\t\t{0:0.00}",student1.GPA);
      
      // // Grades
      // int[] Sophia = {93, 87, 98, 95, 100};
      // int[] Nicholas = {80, 83, 82, 88, 85};
      // int[] Zahirah = {84, 96, 73, 85, 79};
      // int[] Jeong = {90, 92, 98, 100, 97};

      // // Averages
      // int SophiaAvg = (int)Sophia.Average();
      // int NicholasAvg = (int)Nicholas.Average();
      // int ZahirahAvg = (int)Zahirah.Average();
      // int JeongAvg = (int)Jeong.Average();

      // /* Letter Grade Scale
      // 97 - 100    A+
      // 93 - 96     A
      // 90 - 92     A-
      // 87 - 89     B+
      // 83 - 86     B
      // */

      // Console.WriteLine(@"Student Grade");
      // Console.WriteLine($"Sophia:\t\t{SophiaAvg}\tA");
      // Console.WriteLine($"Nicholas:\t{NicholasAvg}\tB");
      // Console.WriteLine($"Zahirah:\t{ZahirahAvg}\tB");
      // Console.WriteLine($"Jeong:\t\t{JeongAvg}\tA"); 
      // Console.WriteLine("Student\tGrade");
    }
  }
}