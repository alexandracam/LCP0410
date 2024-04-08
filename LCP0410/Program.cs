// MIS 3013 001
// April 10, 2024
// Alexandra Camarena
// 113568154

// array namespace

using a;// go to folder a to find the definition of Student

Console.WriteLine("namespace");

// Student array 30 student
Student[] stuArr;// 

stuArr = new Student[30];// how many students do we have in the computer RAM?

stuArr[0] = new Student();

stuArr[0].Name = "Tom";
stuArr[0].ID = "S101";
stuArr[0].Grade = 96.6;

Console.WriteLine($"Name: {stuArr[0].Name} Grade: {stuArr[0].Grade:F2}");