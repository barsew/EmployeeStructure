using EmployeeStructure;

var results = new List<int?>();
var expectedResults = new List<int?> { 1, null, 2, 1, 1, null};

//-------Test 1-----
Employee e1 = new Employee(1, "Jan", null);
Employee e2 = new Employee(2, "Kamil", 1);
Employee e3 = new Employee(3, "Anna", 1);
Employee e4 = new Employee(4, "Andrzej", 2);
e2.Superior = e1;e3.Superior = e1;e4.Superior = e2;

List<Employee> employees = [e1, e2, e3, e4];
Functions f = new Functions();
f.FillEmployeesStructure(employees);

results.Add(f.GetSuperiorRowOfEmployee(2, 1));
results.Add(f.GetSuperiorRowOfEmployee(4, 3));
results.Add(f.GetSuperiorRowOfEmployee(4, 1));

//-------Test 2-----
Employee ee1 = new Employee(1, "Jan", null);
Employee ee2 = new Employee(2, "Kamil", 1);
Employee ee3 = new Employee(3, "Anna", 4);
Employee ee4 = new Employee(4, "Andrzej", null);
ee2.Superior = ee1; ee3.Superior = ee4;

List<Employee> employees2 = [ee1, ee2, ee3, ee4];
Functions f2 = new Functions();
f2.FillEmployeesStructure(employees2);

results.Add(f2.GetSuperiorRowOfEmployee(2, 1));
results.Add(f2.GetSuperiorRowOfEmployee(3, 4));
results.Add(f2.GetSuperiorRowOfEmployee(2, 4));

for (int i = 0; i < results.Count; i++)
{
    string s = "Expected: " + (expectedResults[i] == null ? "null" : expectedResults[i]) + ", got: " + (results[i] == null ? "null" : results[i]);
    if (results[i] == expectedResults[i])
        Console.WriteLine(s + ", passed");
    else
        Console.WriteLine(s + ", failed");
}

