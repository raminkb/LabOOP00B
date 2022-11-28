// See https://aka.ms/new-console-template for more information
//Data type 
using LabOOP00B;

Student student1 = new Student();
student1.name = "ramin";
student1.weight = 60.0;

Student student2 = new Student();
student2.name = "onpreeya";
student2.weight = 54.0;

Student student3 = new Student();
student3.name = "thanaporn";
student3.weight = 85.0;

Student student4 = new Student();
student4.name = "siriporn";
student4.weight = 45.0;

double avgWeight = (student1.weight + student2.weight + student3.weight + student4.weight) /4;
Console.WriteLine("Weight avg of student : " + avgWeight);
Console.WriteLine("Weight max of student : " + student3.name + student3.weight);
Console.WriteLine("Weight min of student : " + student4.name + student4.weight);
Console.WriteLine("รามิล ไกยบุตร 653450297-4");
