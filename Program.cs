//EMPLOYEES

// List<Employee> employees = new List<Employee>
// {   
//     new Employee
//     {
//         Id = 1,
//         FirstName = "Ali",
//         LastName = "Talbakov",
//         Age = 15,
//         Salary = 2000,
//         Experience = 2
//     },

//     new Employee
//     {
//         Id = 2,
//         FirstName = "Ahmad",
//         LastName = "Mahmudov",
//         Age = 21,
//         Salary = 3444,
//         Experience = 4
//     },
// };

//1
// var ems = employees.Select(x => x.Salary);
// foreach (var item in ems)
// {
//     System.Console.WriteLine(item);
// }

// var ems = from e in employees
//         select e.Salary;

// foreach (var item in ems)
// {
//     System.Console.WriteLine(item);
// }


//2
// var ems = employees.Where(x => x.FirstName.Length > 6);
// foreach (var item in ems)
// {
//     System.Console.WriteLine(item);
// }

// var ems = from e in employees
//         where e.FirstName.Length > 6
//         select e.FirstName;
// foreach (var item in ems)
// {
//     System.Console.WriteLine(item);
// }

//3
// var ems = employees.Where(x => x.Age > employees[0].Age).Select(x => x.FirstName);

// foreach (var item in ems)
// {
//     System.Console.WriteLine(item);
// }

// var ems = from e in employees
//         where e.Age > employees[0].Age
//         select e.FirstName;

// foreach (var item in ems)
// {
//     System.Console.WriteLine(item);
// }


//4
// var ems = employees.Where(x => x.Age / 2 == x.Experience).Select(x => x.FirstName);
// foreach (var item in ems)
// {
//     System.Console.WriteLine(item);
// }

// var ems = from e in employees
//         where e.Age == e.Experience * 2
//         select e.FirstName;

// foreach (var item in ems)
// {
//     System.Console.WriteLine(item);
// }

//5
// var topEmployees = employees
//     .Where(e => e.Salary > 5000)
//     .OrderByDescending(e => e.Experience)
//     .Take(3);

// foreach (var employee in topEmployees)
// {
//     Console.WriteLine($"Name: {employee.FirstName}, Experience: {employee.Experience}, Salary: {employee.Salary}");
// }

// var ems = (from e in employees
//         where e.Salary > 5000
//         orderby e.Experience descending
//         select e).Take(3);
// foreach (var e in ems)
// {
//     Console.WriteLine($"{e.FirstName} - {e.Experience} - {e.Salary}");
// }


//STUDENTS


// List<Student> students = new List<Student>
// {
//     new Student
//     {
//         Id = 1,
//         FirstName = "Ali",
//         LastName = "Karimov",
//         Age = 18,
//         Gender = "Male",
//         Status = "Active",
//         DateOfStart = new DateTime(2024, 9, 1),
//         DateOfFinish = new DateTime(2027, 6, 1)
//     },
//     new Student
//     {
//         Id = 2,
//         FirstName = "Sofia",
//         LastName = "Rahimova",
//         Age = 20,
//         Gender = "Female",
//         Status = "Active",
//         DateOfStart = new DateTime(2023, 9, 1),
//         DateOfFinish = new DateTime(2026, 6, 1)
//     },
//     new Student
//     {
//         Id = 3,
//         FirstName = "Muhammad",
//         LastName = "Saidov",
//         Age = 17,
//         Gender = "Male",
//         Status = "Inactive",
//         DateOfStart = new DateTime(2025, 1, 15),
//         DateOfFinish = new DateTime(2028, 1, 15)
//     },
//     new Student
//     {
//         Id = 4,
//         FirstName = "Madina",
//         LastName = "Sharifova",
//         Age = 19,
//         Gender = "Female",
//         Status = "Active",
//         DateOfStart = new DateTime(2024, 2, 1),
//         DateOfFinish = new DateTime(2027, 2, 1)
//     }
// };

//1
// var stu = students.Where(x => x.Gender == "Male").Select(x => x.FirstName);
// foreach (var item in stu)
// {
//     System.Console.WriteLine(item);
// }

// var stu = from s in students
//         where s.Gender == "Male"
//         select s.FirstName;

// foreach (var item in stu)
// {
//     System.Console.WriteLine(item);
// }


//2
// var result = students.Where(s => s.Status == "Inactive");

// foreach (var s in result)
// {
//     Console.WriteLine(s.FirstName);
// }

// var result = from s in students
//              where s.Status == "Inactive"
//              select s;

// foreach (var s in result)
// {
//     Console.WriteLine(s.FirstName);
// }


//3
// var result = students.Where(s => s.DateOfStart.Year > 2000);

// foreach (var s in result)
// {
//     Console.WriteLine(s.FirstName);
// }

// var result = from s in students
//             where s.DateOfStart.Year > 2000
//             select s;
// foreach (var s in result)
// {
//     Console.WriteLine(s.FirstName);
// }


//4
// var result = students.Where(s => s.Status == "Active" && s.Age > 20);
// foreach (var s in result)
// {
//     Console.WriteLine(s.FirstName);
// }

// var result = from s in students
//             where s.Status == "Active" && s.Age > 20
//             select s;
// foreach (var s in result)
// {
//     Console.WriteLine(s.FirstName);
// }


//5
// var result = students.Where(s =>
//     s.DateOfStart.Year - s.DateOfFinish.Year == 16);
// foreach (var s in result)
// {
//     Console.WriteLine(s.FirstName);
// }

// var result = from s in students
//             where s.DateOfStart.Year - s.DateOfFinish.Year == 16
//             select s;
// foreach (var s in result)
// {
//     Console.WriteLine(s.FirstName);
// }


//6
// var result = students.Where(s =>
//     s.DateOfStart.Year - s.DateOfFinish.Year >= 18);
// foreach (var s in result)
// {
//     Console.WriteLine(s.FirstName);
// }

// var result = from s in students
//             where s.DateOfStart.Year - s.DateOfFinish.Year >= 18
//             select s;

// foreach (var s in result)
// {
//     Console.WriteLine(s.FirstName);
// }


//7
// var result = students.Where(s =>
//     s.FirstName.StartsWith("A") ||
//     s.FirstName.StartsWith("I"));
// foreach (var s in result)
// {
//     Console.WriteLine(s.FirstName);
// }

// var result = from s in students
//             where s.FirstName.StartsWith("A") ||
//             s.FirstName.StartsWith("I")
//             select s;
// foreach (var s in result)
// {
//     Console.WriteLine(s.FirstName);
// }


//8
// var result = students.Where(s =>
//     s.FirstName[0] == s.LastName[0]);

// foreach (var s in result)
// {
//     Console.WriteLine($"{s.FirstName} {s.LastName}");
// }

// var result = from s in students
//             where s.FirstName[0] == s.LastName[0]
//             select s;
// foreach (var s in result)
// {
//     Console.WriteLine($"{s.FirstName} {s.LastName}");
// }


//9
// var result = students.Where(s =>
//     s.DateOfFinish.AddYears(18) >= s.DateOfStart &&
//     s.DateOfFinish.AddYears(18) <= s.DateOfFinish);
// foreach (var s in result)
// {
//     Console.WriteLine(s.FirstName);
// }

// var result = from s in students
//             where s.DateOfFinish.AddYears(18) >= s.DateOfStart &&
//             s.DateOfFinish.AddYears(18) <= s.DateOfFinish
//             select s;

// foreach (var s in result)
// {
//     Console.WriteLine(s.FirstName);
// }


//10
// var result = students.Where(s =>
//     s.Gender != "Female" &&
//     s.Status == "Active" &&
//     (DateTime.Now - s.DateOfStart).TotalDays > 730 &&
//     s.Age < 16);

// foreach (var s in result)
// {
//     Console.WriteLine($"{s.FirstName} {s.LastName}");
// }

// var result = from s in students
//             where s.Gender != "Female" &&
//             s.Status == "Active" &&
//             (DateTime.Now - s.DateOfStart).TotalDays > 730 &&
//             s.Age < 16
//             select s;
// foreach (var s in result)
// {
//     Console.WriteLine($"{s.FirstName} {s.LastName}");
// }


//PEOPLE AND CITIES (ClassTask)

// List<City> cities = new List<City>
// {
//     new City { Id = 1, Name = "Dushanbe" },
//     new City { Id = 2, Name = "Khujand" },
//     new City { Id = 3, Name = "Kulob" },
//     new City { Id = 4, Name = "Bokhtar" },
//     new City { Id = 5, Name = "Ayni" },
//     new City { Id = 6, Name = "Asht" }
// };

// List<Person> people = new List<Person>
// {
//     new Person { Id = 1, Name = "Ali", Age = 30, CityId = 1 },
//     new Person { Id = 2, Name = "Sofia", Age = 24, CityId = 2 },
//     new Person { Id = 3, Name = "Madina", Age = 28, CityId = 1 },
//     new Person { Id = 4, Name = "Alisher", Age = 5, CityId = 5 },
//     new Person { Id = 5, Name = "Umed", Age = 3, CityId = 5 },
//     new Person { Id = 6, Name = "Zarina", Age = 6, CityId = 6 },
//     new Person { Id = 7, Name = "Ibrohim", Age = 40, CityId = 3 },
//     new Person { Id = 8, Name = "Olim", Age = 28, CityId = 1 },
//     new Person { Id = 9, Name = "Amina", Age = 7, CityId = 1 },
//     new Person { Id = 10, Name = "Eldor", Age = 25, CityId = 4 }
// };

//1
// var result = people.Where(p => p.Age > 25).Select(p => new { p.Name, p.Age });
// foreach (var p in result)
// {
//     Console.WriteLine($"{p.Name} {p.Age}");
// }

// var result = from p in people
//              where p.Age > 25
//              select new { p.Name, p.Age };
// foreach (var p in result)
// {
//     Console.WriteLine($"{p.Name} {p.Age}");
// }


//2
// var result = people.OrderBy(p => p.Age).ThenBy(p => p.Name);
// foreach (var p in result)
// {
//     Console.WriteLine($"{p.Age} {p.Name}");
// }

// var result = from p in people
//              orderby p.Age, p.Name
//              select p;
// foreach (var p in result)
// {
//     Console.WriteLine($"{p.Age} {p.Name}");
// }


//3
// var result = people.GroupBy(p => p.Name[0]);
// foreach (var g in result)
// {
//     Console.WriteLine(g.Key);
//     foreach (var p in g)
//     {
//         Console.WriteLine($"  {p.Name}");
//     }
// }

// var result = from p in people
//              group p by p.Name[0] into g
//              select g;
// foreach (var g in result)
// {
//     Console.WriteLine(g.Key);
//     foreach (var p in g)
//     {
//         Console.WriteLine($"  {p.Name}");
//     }
// }


//4
// var result = people.Join(cities,
//     p => p.CityId,
//     c => c.Id,
//     (p, c) => new { PersonName = p.Name, CityName = c.Name });
// foreach (var r in result)
// {
//     Console.WriteLine($"{r.PersonName} - {r.CityName}");
// }

// var result = from p in people
//              join c in cities on p.CityId equals c.Id
//              select new { PersonName = p.Name, CityName = c.Name };
// foreach (var r in result)
// {
//     Console.WriteLine($"{r.PersonName} - {r.CityName}");
// }


//5
// var total = people.Where(p => "AEIOU".Contains(p.Name[0])).Sum(p => p.Age);
// Console.WriteLine(total);

// var total = (from p in people
//              where "AEIOU".Contains(p.Name[0])
//              select p.Age).Sum();
// Console.WriteLine(total);


//6
// var result = people.GroupBy(p => p.Name[0])
//     .Select(g => new { Letter = g.Key, Count = g.Count() });
// foreach (var r in result)
// {
//     Console.WriteLine($"{r.Letter} - {r.Count}");
// }

// var result = from p in people
//              group p by p.Name[0] into g
//              select new { Letter = g.Key, Count = g.Count() };
// foreach (var r in result)
// {
//     Console.WriteLine($"{r.Letter} - {r.Count}");
// }


//7
// var top = people.GroupBy(p => p.CityId)
//     .OrderByDescending(g => g.Count())
//     .First();
// var city = cities.First(c => c.Id == top.Key);
// Console.WriteLine($"{city.Name} - {top.Count()}");

// var top = (from p in people
//            group p by p.CityId into g
//            orderby g.Count() descending
//            select g).First();
// var city = (from c in cities
//             where c.Id == top.Key
//             select c).First();
// Console.WriteLine($"{city.Name} - {top.Count()}");


//8
// var result = people.Join(cities,
//         p => p.CityId,
//         c => c.Id,
//         (p, c) => new { p, c })
//     .Where(x => x.p.Age >= 2 && x.p.Age <= 7 && x.c.Name.ToLower().StartsWith("a"))
//     .Select(x => new { x.p.Name, x.p.Age, City = x.c.Name });
// foreach (var r in result)
// {
//     Console.WriteLine($"{r.Name} {r.Age} {r.City}");
// }

// var result = from p in people
//              join c in cities on p.CityId equals c.Id
//              where p.Age >= 2 && p.Age <= 7 && c.Name.ToLower().StartsWith("a")
//              select new { p.Name, p.Age, City = c.Name };
// foreach (var r in result)
// {
//     Console.WriteLine($"{r.Name} {r.Age} {r.City}");
// }



//STUDENTS, COURSES, ENROLLMENTS (HomeTask)

List<Student> students = new List<Student>
{
    new Student { StudentId = 1, Name = "Alice", DateOfBirth = new DateTime(2000, 5, 15) },
    new Student { StudentId = 2, Name = "Bob", DateOfBirth = new DateTime(1999, 8, 25) },
    new Student { StudentId = 3, Name = "Charlie", DateOfBirth = new DateTime(2001, 3, 10) },
    new Student { StudentId = 4, Name = "Diana", DateOfBirth = new DateTime(1995, 11, 2) },
    new Student { StudentId = 5, Name = "Eve", DateOfBirth = new DateTime(2003, 7, 19) },
    new Student { StudentId = 6, Name = "Frank", DateOfBirth = new DateTime(2005, 1, 30) }
};

List<Course> courses = new List<Course>
{
    new Course { CourseId = 101, Title = "Mathematics", Credits = 4 },
    new Course { CourseId = 102, Title = "Computer Science", Credits = 3 },
    new Course { CourseId = 103, Title = "Physics", Credits = 4 }
};

List<Enrollment> enrollments = new List<Enrollment>
{
    new Enrollment { EnrollmentId = 1, StudentId = 1, CourseId = 101, EnrollmentDate = new DateTime(2023, 1, 15) },
    new Enrollment { EnrollmentId = 2, StudentId = 1, CourseId = 102, EnrollmentDate = new DateTime(2023, 1, 20) },
    new Enrollment { EnrollmentId = 3, StudentId = 2, CourseId = 101, EnrollmentDate = new DateTime(2023, 1, 18) },
    new Enrollment { EnrollmentId = 4, StudentId = 3, CourseId = 103, EnrollmentDate = new DateTime(2023, 1, 22) },
    new Enrollment { EnrollmentId = 5, StudentId = 3, CourseId = 101, EnrollmentDate = new DateTime(2023, 1, 25) },
    new Enrollment { EnrollmentId = 6, StudentId = 3, CourseId = 102, EnrollmentDate = new DateTime(2023, 1, 30) },
    new Enrollment { EnrollmentId = 7, StudentId = 4, CourseId = 101, EnrollmentDate = new DateTime(2023, 2, 1) },
    new Enrollment { EnrollmentId = 8, StudentId = 4, CourseId = 103, EnrollmentDate = new DateTime(2023, 2, 2) },
    new Enrollment { EnrollmentId = 9, StudentId = 5, CourseId = 102, EnrollmentDate = new DateTime(2023, 2, 5) },
    new Enrollment { EnrollmentId = 10, StudentId = 6, CourseId = 102, EnrollmentDate = new DateTime(2023, 2, 7) }
};

//1
// var result = students
//     .Join(enrollments, s => s.StudentId, e => e.StudentId, (s, e) => new { s, e })
//     .Join(courses, x => x.e.CourseId, c => c.CourseId, (x, c) => new { x.s, x.e, c })
//     .Where(x => x.c.Title == "Mathematics")
//     .Select(x => x.s.Name);
// foreach (var name in result)
// {
//     Console.WriteLine(name);
// }

// var result = from s in students
//              join e in enrollments on s.StudentId equals e.StudentId
//              join c in courses on e.CourseId equals c.CourseId
//              where c.Title == "Mathematics"
//              select s.Name;
// foreach (var name in result)
// {
//     Console.WriteLine(name);
// }


//2
// var result = students
//     .Join(enrollments, s => s.StudentId, e => e.StudentId, (s, e) => new { s, e })
//     .Join(courses, x => x.e.CourseId, c => c.CourseId, (x, c) => new { x.s, x.e, c })
//     .Where(x => x.s.Name == "Charlie")
//     .Select(x => x.c.Title);
// foreach (var title in result)
// {
//     Console.WriteLine(title);
// }

// var result = from s in students
//              join e in enrollments on s.StudentId equals e.StudentId
//              join c in courses on e.CourseId equals c.CourseId
//              where s.Name == "Charlie"
//              select c.Title;
// foreach (var title in result)
// {
//     Console.WriteLine(title);
// }


//3
// var result = enrollments
//     .GroupBy(e => e.StudentId)
//     .Where(g => g.Count() > 1)
//     .SelectMany(g => students.Where(s => s.StudentId == g.Key))
//     .Select(s => s.Name);
// foreach (var name in result)
// {
//     Console.WriteLine(name);
// }

// var result = from g in (from e in enrollments
//                         group e by e.StudentId into g
//                         where g.Count() > 1
//                         select g)
//              from s in students
//              where s.StudentId == g.Key
//              select s.Name;
// foreach (var name in result)
// {
//     Console.WriteLine(name);
// }


//4
// var result = students
//     .Join(enrollments, s => s.StudentId, e => e.StudentId, (s, e) => new { s, e })
//     .Join(courses, x => x.e.CourseId, c => c.CourseId, (x, c) => new { x.s, x.e, c })
//     .GroupBy(x => new { Range = (DateTime.Now.Year - x.s.DateOfBirth.Year) / 10 * 10, x.c.Title })
//     .Select(g => new
//     {
//         g.Key.Range,
//         g.Key.Title,
//         Average = g.Average(x => DateTime.Now.Year - x.s.DateOfBirth.Year)
//     });
// foreach (var r in result)
// {
//     Console.WriteLine($"{r.Range}-{r.Range + 9} | {r.Title} | {r.Average}");
// }

// var result = from s in students
//              join e in enrollments on s.StudentId equals e.StudentId
//              join c in courses on e.CourseId equals c.CourseId
//              group s by new { Range = (DateTime.Now.Year - s.DateOfBirth.Year) / 10 * 10, c.Title } into g
//              select new
//              {
//                  g.Key.Range,
//                  g.Key.Title,
//                  Average = g.Average(s => DateTime.Now.Year - s.DateOfBirth.Year)
//              };
// foreach (var r in result)
// {
//     Console.WriteLine($"{r.Range}-{r.Range + 9} | {r.Title} | {r.Average}");
// }


//5
// var result = students
//     .Join(enrollments, s => s.StudentId, e => e.StudentId, (s, e) => new { s, e })
//     .Join(courses, x => x.e.CourseId, c => c.CourseId, (x, c) => new { x.s, x.e, c })
//     .Where(x => x.e.EnrollmentDate > new DateTime(2023, 1, 20) && x.c.Credits >= 4)
//     .Select(x => new { x.s.Name, x.c.Title, x.c.Credits, x.e.EnrollmentDate });
// foreach (var r in result)
// {
//     Console.WriteLine($"{r.Name} {r.Title} {r.Credits} {r.EnrollmentDate}");
// }

// var result = from s in students
//              join e in enrollments on s.StudentId equals e.StudentId
//              join c in courses on e.CourseId equals c.CourseId
//              where e.EnrollmentDate > new DateTime(2023, 1, 20) && c.Credits >= 4
//              select new { s.Name, c.Title, c.Credits, e.EnrollmentDate };
// foreach (var r in result)
// {
//     Console.WriteLine($"{r.Name} {r.Title} {r.Credits} {r.EnrollmentDate}");
// }


//6
// var result = students
//     .Join(enrollments, s => s.StudentId, e => e.StudentId, (s, e) => new { s, e })
//     .Join(courses, x => x.e.CourseId, c => c.CourseId, (x, c) => new { x.s, x.e, c })
//     .GroupBy(x => x.s.Name)
//     .Select(g => new { Name = g.Key, Total = g.Sum(x => x.c.Credits) });
// foreach (var r in result)
// {
//     Console.WriteLine($"{r.Name} - {r.Total}");
// }

// var result = from s in students
//              join e in enrollments on s.StudentId equals e.StudentId
//              join c in courses on e.CourseId equals c.CourseId
//              group c by s.Name into g
//              select new { Name = g.Key, Total = g.Sum(c => c.Credits) };
// foreach (var r in result)
// {
//     Console.WriteLine($"{r.Name} - {r.Total}");
// }


//7
// var result = courses.Select(c => new
// {
//     c.Title,
//     Count = enrollments.Count(e => e.CourseId == c.CourseId)
// });
// foreach (var r in result)
// {
//     Console.WriteLine($"{r.Title} - {r.Count}");
// }

// var result = from c in courses
//              select new
//              {
//                  c.Title,
//                  Count = enrollments.Count(e => e.CourseId == c.CourseId)
//              };
// foreach (var r in result)
// {
//     Console.WriteLine($"{r.Title} - {r.Count}");
// }


//8
// var bob = students.First(s => s.Name == "Bob");
// var result = courses
//     .Where(c => !enrollments.Any(e => e.StudentId == bob.StudentId && e.CourseId == c.CourseId))
//     .Select(c => c.Title);
// foreach (var title in result)
// {
//     Console.WriteLine(title);
// }

// var bob = students.First(s => s.Name == "Bob");
// var result = from c in courses
//              where !enrollments.Any(e => e.StudentId == bob.StudentId && e.CourseId == c.CourseId)
//              select c.Title;
// foreach (var title in result)
// {
//     Console.WriteLine(title);
// }


//1
// var prs = people.Where(x => x.Age > 30).Select(x => x.Name);
// foreach (var item in prs)
// {
//     System.Console.WriteLine(item);
// }


//2
// var prs = people.GroupBy(x => x.Age).Select(g => new{Age = g.Key , Count = g.Count()}).OrderBy(x => x.Age).ToList();
// foreach (var item in prs)
// {
//     System.Console.WriteLine(item);
// }


//3
// var prs = people.OrderByDescending(x => x.Age).Select(g =>g.Name).Take(5);
// foreach (var item in prs)
// {
//     System.Console.WriteLine(item);
// }


//4
// List<int> ints = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
// var tt = ints.AsParallel().AsOrdered().Where(IsPrime).ToList();

// foreach (var item in tt)
// {
//     Console.WriteLine(item);
// }

// static bool IsPrime(int n)
// {
//     int cnt = 0;
//     for (int i = 1; i <= n; i++)
//     {
//         if (n % i == 0)
//         {
//             cnt++;
//         }
//     }
//     return cnt == 2;
// }


//5
// var cars = new List<Car>
// {
//     new Car { Brand = "Toyota", Model = "Camry", Year = 2020 },
//     new Car { Brand = "BMW", Model = "X5", Year = 2021 },
//     new Car { Brand = "Kia", Model = "Rio", Year = 2020 },
//     new Car { Brand = "Audi", Model = "A6", Year = 2021 }
// };
// var result = cars
//     .AsParallel()
//     .GroupBy(car => car.Year)
//     .Select(g => new { Year = g.Key, Count = g.Count() })
//     .OrderBy(x => x.Year);

// foreach (var item in result)
// {
//     Console.WriteLine($"{item.Year}: {item.Count} авто");
// }


//LINQ & PLINQ HOMETASK


//1
var nums1 = new List<int> { 3, 1, 4, 1, 5, 9, 2, 6 };
var sorted1 = nums1.OrderBy(x => x).ToList();
int cnt1 = sorted1.Count();
double median1;
if (cnt1 % 2 == 0)
{
    median1 = new List<int> { sorted1.ElementAt(cnt1 / 2 - 1), sorted1.ElementAt(cnt1 / 2) }.Average();
}
else
{
    median1 = sorted1.ElementAt(cnt1 / 2);
}
System.Console.WriteLine(median1);


//2
var a2 = new List<int> { 1, 2, 3, 4 };
var b2 = new List<int> { 2, 3, 5, 6 };
var c2 = new List<int> { 2, 3, 7, 8 };
var common2 = a2.Intersect(b2).Intersect(c2);
foreach (var item in common2)
{
    System.Console.WriteLine(item);
}


//3
var nums3 = new List<int> { 1, 2, 3, 1, 2, 5, 6 };
var runs3 = nums3.Aggregate(new List<List<int>>(), (acc, x) =>
{
    if (acc.Count > 0 && acc[^1][^1] < x)
    {
        acc[^1].Add(x);
    }
    else
    {
        acc.Add(new List<int> { x });
    }
    return acc;
});
var best3 = runs3.OrderByDescending(r => r.Count).First();
System.Console.WriteLine(best3.Sum());


//4
var items4 = new List<string> { "a", "b", "a", "c", "b", "a" };
int n4 = 2;
var top4 = items4
    .AsParallel()
    .GroupBy(x => x)
    .OrderByDescending(g => g.Count())
    .ThenBy(g => g.Key)
    .Take(n4)
    .Select(g => new { g.Key, Count = g.Count() });
foreach (var t in top4)
{
    System.Console.WriteLine($"{t.Key} (x{t.Count})");
}


//5
var books5 = new List<Book>
{
    new Book { Title = "C#", Author = "Albahari" },
    new Book { Title = "C#", Author = "Albahari" },
    new Book { Title = "LINQ", Author = "Rattz" }
};
var unique5 = books5
    .GroupBy(b => new { b.Title, b.Author })
    .Select(g => g.First());
foreach (var bk in unique5)
{
    System.Console.WriteLine($"{bk.Title} - {bk.Author}");
}


//6
var nums6 = new List<int> { 1, 5, 12, 7, 3, 9 };
int min6 = 4;
int max6 = 10;
var result6 = nums6.Where(x => x >= min6 && x <= max6);
foreach (var item in result6)
{
    System.Console.WriteLine(item);
}


//7
int threshold7 = 25;
var split7 = students
    .Select(s => new { s.Name, Age = DateTime.Now.Year - s.DateOfBirth.Year })
    .ToLookup(x => x.Age > threshold7);
System.Console.WriteLine("Older:");
foreach (var item in split7[true])
{
    System.Console.WriteLine($"{item.Name} {item.Age}");
}
System.Console.WriteLine($"<= {threshold7}:");
foreach (var item in split7[false])
{
    System.Console.WriteLine($"{item.Name} {item.Age}");
}


//8
var nums8 = new List<int> { 1, 2, 2, 3, 3, 3, 4 };
int n8 = 2;
var result8 = nums8
    .GroupBy(x => x)
    .Where(g => g.Count() == n8)
    .Select(g => g.Key);
foreach (var item in result8)
{
    System.Console.WriteLine(item);
}


//9
var words9 = new List<string> { "cat", "elephant", "ox", "dog" };
var longest9 = words9.OrderByDescending(w => w.Length).First();
System.Console.WriteLine(longest9);


//10
var nums10 = new List<int> { 199, 200, 155, 1999 };
var best10 = nums10
    .AsParallel()
    .Select(x => new { Number = x, Sum = x.ToString().Sum(ch => ch - '0') })
    .OrderByDescending(x => x.Sum)
    .First();
System.Console.WriteLine($"{best10.Number} - {best10.Sum}");
