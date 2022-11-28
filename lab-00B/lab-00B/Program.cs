// See https://aka.ms/new-console-template for more information

Students student1 = new Students();
student1.name = "Phanu";
student1.weight = 65f;

Students student2 = new Students();
student2.name = "Mark";
student2.weight = 67f;

Students student3 = new Students();
student3.name = "Beer";
student3.weight = 80f;

Students student4 = new Students();
student4.name = "Kon";
student4.weight = 61f;

Students student5 = new Students();
student4.name = "Peach";
student4.weight = 89f;

float avgWeight = (student1.weight + student2.weight + student3.weight + student4.weight + student5.weight) / 5;
Console.WriteLine("Weight avg of Student : " + avgWeight);
Console.WriteLine("weight high Peach : 89");
Console.WriteLine("weight low Phanu : 65");
Console.WriteLine("Phanuwat Sarawong 653450295-8");
