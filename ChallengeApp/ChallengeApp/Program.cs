using ChallengeApp;


Employee employee1 = new Employee(" Jarosław ", " Jareczek",45);
Employee employee2 = new Employee("Marysia", "Ktosiowa", 23);
Employee employee3 = new Employee("Dionizy", "Izydor", 63);

employee1.AddScore(4);
employee1.AddScore(8);
employee1.AddScore(3);
employee1.AddScore(9);
employee1.AddScore(1);

employee2.AddScore(1);
employee2.AddScore(4);
employee2.AddScore(9);
employee2.AddScore(10);
employee2.AddScore(4);

employee3.AddScore(0);
employee3.AddScore(9);
employee3.AddScore(5);
employee3.AddScore(10);
employee3.AddScore(4);

  var employyes = new List<Employee> { employee1, employee2, employee3 };

int maxResult = -1;
Employee employeeWhithmaxResult = null;

 foreach (var employee in employyes)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        employeeWhithmaxResult = employee;
    }
    
}

Console.WriteLine("Osoba Wygrywająca Konkurs (Best Employye)");
Console.WriteLine(employeeWhithmaxResult.Name);
Console.WriteLine(employeeWhithmaxResult.Surname);
Console.WriteLine(employeeWhithmaxResult.Age + "" + "lata");
Console.WriteLine("Ilość zdobytych punktów");
Console.WriteLine(maxResult);

Console.ReadKey();









