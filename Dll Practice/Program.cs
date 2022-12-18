#region Person -Name,Surname,Age
using Dll_Practice;

//Person person1 = new Person()
//{
//    Name = "Mirza",
//    Surname = "Beshirzade",
//    Age = 26,

//};



//Person person2 = new Person()
//{
//    Name = "Hemze",
//    Surname = "Elizade",
//    Age = 25,

//};


//Person person3 = new Person()
//{
//    Name = "Hemid",
//    Surname = "Heyderzade",
//    Age = 29,

//};

//Person person4 = new Person()
//{
//    Name = "Heyder",
//    Surname = "Eliyev",
//    Age = 30,

//};

//Person[] people = { person1, person2, person3, person4 };




//GetPersonsByAge(people);

//static void GetPersonsByAge(Person[] people)
//{
//    foreach (var item in people)
//    {
//        Console.WriteLine($"{item.Name}-{item.Surname}-{item.Age}");
//    }

//};
#endregion


#region Students List

//Student[] Students = GetStudents();


//Search(Students);

//static void Search(Student[] students)
//{
//    string searchText = "M";

//    foreach (var item in students)
//    {
//        if (item.Name.ToLower().Contains(searchText.ToLower()) || item.Surname.ToLower().Contains(searchText.ToLower()))
//        {
//            Console.WriteLine(item.Name + " " + item.Surname);
//        }
//    }


//}


//static Student[] GetStudents()
//{


//    Student stu1 = new Student()
//    {
//        Name = "Mirze",
//        Surname = "Besirzade",
//        Adress = "BulBule",
//        Age = 26
//    };

//    Student stu2 = new Student()
//    {
//        Name = "Hemze",
//        Surname = "Elizade",
//        Adress = "BulBule",
//        Age = 25
//    };


//    Student stu3 = new Student()
//    {
//        Name = "Hemid",
//        Surname = "Heyderzade",
//        Adress = "BulBule",
//        Age = 29
//    };


//    Student stu4 = new Student()
//    {
//        Name = "Heyder",
//        Surname = "Eliyev",
//        Adress = "Montin",
//        Age = 30
//    };

//    Student[] students = { stu1, stu2, stu3, stu4 };

//    return students;



//}
#endregion

#region Calculator
//Calculator calculator = new Calculator();
//calculator.Calculation(14, 7);
#endregion


#region Employer


//Employee employee1 = new Employee()
//{
//    Name = "Mirze",
//    Surname = "Besirzade",
//    Age = 26,
//    Salary = 1200,

//};



//Employee employee2 = new Employee()
//{
//    Name = "Hemze",
//    Surname = "Elizade",
//    Age = 25,
//    Salary = 1050,

//};


//Employee employee3 = new Employee()
//{
//    Name = "Ferid",
//    Surname = "Abdullayev",
//    Age = 17,
//    Salary = 1200,

//};


//Employee employee4 = new Employee()
//{
//    Name = "Hemid",
//    Surname = "Heyderzade",
//    Age = 29,
//    Salary = 900,

//};



//Employee employee5 = new Employee()
//{
//    Name = "Heyder",
//    Surname = "Eliyev",
//    Age = 30,
//    Salary = 500,

//};


//Employee[] employe = { employee1, employee2, employee3, employee4, employee5 };

//Employess(employe, 1000, 2000);
//static void Employess(Employee[] employe, int t, int m)
//{
//    foreach (var item in employe)
//    {
//        if (item.Salary < m && item.Salary > t)
//        {
//            Console.WriteLine($"{item.Name} - {item.Surname} - {item.Age} - {item.Salary}");
//        }

//    }
//}
#endregion


#region Doctors

//Doctor doctor1 = new()
//{
//    Name = "Nurane",
//    Surname = "Mehdiyeva",
//    Adress = "Naxcivan",
//    Birthday = new DateTime(1995, 02, 03),

//};


//Doctor doctor2 = new Doctor()
//{
//    Name = "Celal",
//    Surname = "Haciyev",
//    Adress = "Celilabad",
//    Birthday = new DateTime(1997, 04, 10),

//};


//Doctor doctor3 = new Doctor()
//{
//    Name = "Lale",
//    Surname = "Abbasova",
//    Adress = "Baki",
//    Birthday = new DateTime(2000, 04, 21),

//};


//Doctor doctor4 = new Doctor()
//{
//    Name = "Eli",
//    Surname = "Kazimov",
//    Adress = "Baki",
//    Birthday = new DateTime(1994, 03, 02),

//};


//Doctor doctor5 = new Doctor()
//{
//    Name = "Leyla",
//    Surname = "Mecnunlu",
//    Adress = "Saxara",
//    Birthday = new DateTime(1990, 01, 15),

//};



//Doctor doctor6 = new Doctor()
//{
//    Name = "Sahib",
//    Surname = "Memmedov",
//    Adress = "Baki",
//    Birthday = new DateTime(1992, 01, 31),

//};



//Doctor doctor7 = new Doctor()
//{
//    Name = "Aysel",
//    Surname = "Medetova",
//    Adress = "Aqdash",
//    Birthday = new DateTime(2002, 08, 15),

//};



//Doctor doctor8 = new Doctor()
//{
//    Name = "Guler",
//    Surname = "Ilyasov",
//    Adress = "Turkan",
//    Birthday = new DateTime(2003, 12, 11),

//};

//DateTime minimum = new DateTime(1993, 05, 25);
//DateTime maximum = new DateTime(2002, 12, 15);

//Doctor[] doctors = { doctor2, doctor3, doctor4, doctor5, doctor6, doctor7, doctor8 };


//Doktor(doctors, minimum, maximum);



//static void Doktor(Doctor[] doctors, DateTime minimum, DateTime maximum)
//{
//    foreach (var item in doctors)
//    {
//        if (item.Birthday > minimum && item.Birthday < maximum)
//        {
//            Console.WriteLine($"{item.Name}-{item.Surname}-{item.Adress}-{item.Birthday}");
//        }



//    }


//}


#endregion


