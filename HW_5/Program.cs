// See https://aka.ms/new-console-template for more information
using HW_5;

Console.WriteLine("====== HW-5 ======");
Console.WriteLine("====== Doctor ======");
var doctor = new Doctor("Phatsakorn", "Doctor", 83500.75m, 8);
var doctorGetWhoAmI = doctor.WhoAmI();
var doctorGetTax = doctor.GetTax();
Console.WriteLine(doctorGetWhoAmI);
Console.WriteLine($"Get Tax : {doctorGetTax}");

Console.WriteLine("====== Police ======");
var police = new Police("Phatsakorn", "Police", 83500.75m, 8);
var policeGetWhoAmI = police.WhoAmI();
var policeGetTax = police.GetTax();
Console.WriteLine(policeGetWhoAmI);
Console.WriteLine($"Get Tax : {policeGetTax}");

Console.WriteLine("====== Teacher ======");
var teacher = new Teacher("Phatsakorn", "Teacher", 83500.75m, 8);
var teacherGetWhoAmI = teacher.WhoAmI();
var teacherGetTax = teacher.GetTax();
Console.WriteLine(teacherGetWhoAmI);
Console.WriteLine($"Get Tax : {teacherGetTax}");