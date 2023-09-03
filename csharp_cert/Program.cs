// See https://aka.ms/new-console-template for more information

namespace csharp_cert{
  class csharp_cert {
    public static void Main(String[] args){
      // Grades
      int[] Sophia = {93, 87, 98, 95, 100};
      int[] Nicholas = {80, 83, 82, 88, 85};
      int[] Zahirah = {84, 96, 73, 85, 79};
      int[] Jeong = {90, 92, 98, 100, 97};

      // Averages
      int SophiaAvg = (int)Sophia.Average();
      int NicholasAvg = (int)Nicholas.Average();
      int ZahirahAvg = (int)Zahirah.Average();
      int JeongAvg = (int)Jeong.Average();

      /* Letter Grade Scale
      97 - 100    A+
      93 - 96     A
      90 - 92     A-
      87 - 89     B+
      83 - 86     B
      */

      Console.WriteLine(@"Student Grade");
      Console.WriteLine($"Sophia:\t\t{SophiaAvg}\tA");
      Console.WriteLine($"Nicholas:\t{NicholasAvg}\tB");
      Console.WriteLine($"Zahirah:\t{ZahirahAvg}\tB");
      Console.WriteLine($"Jeong:\t\t{JeongAvg}\tA"); 
      Console.WriteLine("Student\tGrade");
    }
  }
}