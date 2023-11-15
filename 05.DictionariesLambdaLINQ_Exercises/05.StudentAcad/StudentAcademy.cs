Dictionary<string, List<double>> students = new();

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string studentName = Console.ReadLine();
    double grade = double.Parse(Console.ReadLine());

    if (!students.ContainsKey(studentName))
    {
        students.Add(studentName, new List<double>());
    }

    students[studentName].Add(grade);   
}

var excellent = students.Where(s => s.Value.Average() >= 4.50); // 's' -> students / This is dictionary

foreach (var currentStudent in excellent)
{
    Console.WriteLine($"{currentStudent.Key} -> {currentStudent.Value.Average():f2}");
}