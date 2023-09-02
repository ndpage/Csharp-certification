// See https://aka.ms/new-console-template for more information

// Grades
int[] Sophia = {93, 87, 98, 95, 100};
int[] Nicholas = {80, 83, 82, 88, 85};
int[] Zahirah = {84, 96, 73, 85, 79};
int[] Jeong = {90, 92, 98, 100, 97};

// Averages
int SophiaAvg = (int)Sophia.Average();
int NicholasAvg = (int)Nicholas.Average();
int ZahirahAvg = (int)Nicholas.Average();
int JeongAvg = (int)Nicholas.Average();

/* Letter Grade Scale
97 - 100    A+
93 - 96     A
90 - 92     A-
87 - 89     B+
83 - 86     B
*/

Console.WriteLine(@"Student Grade");
Console.WriteLine($@"Sophia: {SophiaAvg} A
Nicholas: {NicholasAvg} B
Zahirah: {ZahirahAvg} B
Jeong: {JeongAvg} A"); 


