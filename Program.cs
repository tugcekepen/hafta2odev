using hafta2odev;

var employee = new Employee();
employee.Add(new Employee(1, "Tuğçe Kepen"));
employee.Add(new Employee(2, "Alper Başal"));
employee.Add(new Employee(3, "İrem Kepen"));

employee.Remove(2);

var list = employee.GetEmployees();
Console.WriteLine("Çalışan Listesi");
foreach (var item in list)
{
    Console.WriteLine("Çalışan Id: " + item.Id + "   Çalışan ad-soyad: " + item.FullName);
}
