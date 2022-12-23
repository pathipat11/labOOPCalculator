// See https://aka.ms/new-console-template for more information
// print string to commanline
using LABOOP00A;

Console.WriteLine("Pathipat Mattra");

// id
Console.WriteLine("653450293-2");

// email
Console.WriteLine("pathipat.m@kkumail.com");

// Data type
string name = "pppp"; //ตัวอักษร
int age = 52; //ตัวเลขจำนวนเต็ม
double weight = 10.50; //ตัวเลขทศนิยม
bool isMan = true; //ตรรกะศาสตร์

int studentNum = 5;

string name1 = "A";
string name2 = "B";
string name3 = "C";
string name4 = "D";
string name5 = "E";

float weight1 = 10.2f;
float weight2 = 12.0f;
float weight3 = 40.2f;
float weight4 = 20.2f;
float weight5 = 22.7f;

Student student1 = new Student();
student1.name = "Micky";
student1.weight = 20.8f;

Student student2 = new Student();
student2.name = "Minnie";
student2.weight = 18.2f;

float avgWeight = (student1.weight + student2.weight) / 2;
Console.WriteLine("Weinght avg of Student:" + avgWeight);