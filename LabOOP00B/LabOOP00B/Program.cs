﻿// See https://aka.ms/new-console-template for more information
//Data type 
using LabOOP00B;

Student student1 = new Student();
student1.name = "ramin";
student1.weight = 60.0;

Student student2 = new Student();
student2.name = "onpreeya";
student2.weight = 20.0;

Student student3 = new Student();
student3.name = "thanaporn";
student3.weight = 85.0;

Student student4 = new Student();
student4.name = "siriporn";
student4.weight = 45.0;

double avgWeight = (student1.weight + student2.weight + student3.weight + student4.weight) /4;
Console.WriteLine("Weight avg of student : " + avgWeight);