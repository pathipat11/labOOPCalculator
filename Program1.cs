// See https://aka.ms/new-console-template for more information
using labOOP00B;

Student student1 = new Student();
student1.name = "Pathipat Mattra";
student1.weight = 60.0f;

Student student2 = new Student();
student2.name = "Thanachok Suwan";
student2.weight = 75.0f;

Student student3 = new Student();
student3.name = "Worachot Thonglert";
student3.weight = 83.8f;

Student student4 = new Student();
student4.name = "Worachit Thonglert";
student4.weight = 82.5f;

Student student5 = new Student();
student5.name = "Naphat Suyoungkul";
student5.weight = 140.0f;

float avgWeight = (student1.weight + student2.weight + student3.weight + student4.weight + student5.weight) / 5;
Console.WriteLine("Weight avg of Student : " + avgWeight);
Console.WriteLine("Weight Max of Student : Naphat Suyoungkul");
Console.WriteLine("Weight Min of Student : Pathipat Mattra");
Console.WriteLine("Name Pathipat Mattra ID : 653450293-2");