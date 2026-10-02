class Customer
{
    public string Name = "";
    public string Phone = "";
    public string Email = "";
    public string Address = "";

    public string Buy()
    {
        string result = "";
        result = "Customer is buying";
        return result;
    }

    public string Select()
    {
        string result = "";
        result = "Customer is selecting";
        return result;
    }

    public string Return()
    {
        string result = "";
        result = "Customer is returning";
        return result;
    }
}


class Student
{
    public string Name = "";
    public int StudentNumber;
    public string NationalNumber = "";
    public string Major = "";

    public string TakeExam()
    {
        string result = "";
        result = "Student is taking exam";
        return result;
    }

    public string PayTuition()
    {
        string result = "";
        result = "Student is paying tuition";
        return result;
    }

    public string SelectCourses()
    {
        string result = "";
        result = "Student is selecting courses";
        return result;
    }
}


class Teacher
{
    public string Name = "";
    public int TeacherNumber;
    public string Field = "";
    public string PhoneNumber = "";

    public string Teach()
    {
        string result = "";
        result = "Teacher is teaching";
        return result;
    }

    public string GiveExam()
    {
        string result = "";
        result = "Teacher is giving exam";
        return result;
    }

    public string GradeStudents()
    {
        string result = "";
        result = "Teacher is grading students";
        return result;
    }
}


class Employee
{
    public string Name = "";
    public int EmployeeID;
    public string Department = "";
    public int Salary;

    public string Work()
    {
        string result = "";
        result = "Employee is working";
        return result;
    }

    public string TakeLeave()
    {
        string result = "";
        result = "Employee is taking leave";
        return result;
    }

    public string AttendMeeting()
    {
        string result = "";
        result = "Employee is attending meeting";
        return result;
    }
}


class Rectangle
{
    public int Length;
    public int Width;
    public int Area;
    public int Perimeter;

    public int CalculateArea()
    {
        int result = 0;
        result = Length * Width;
        return result;
    }

    public int CalculatePerimeter()
    {
        int result = 0;
        result = 2 * (Length + Width);
        return result;
    }
}


class Square
{
    public string Color = "";
    public int Perimeter;
    public int Area;
    public int Side;

    public int CalculateArea()
    {
        int result = 0;
        result = Side * Side;
        return result;
    }

    public int CalculatePerimeter()
    {
        int result = 0;
        result = 4 * Side;
        return result;
    }
}


class Dog
{
    public string Name = "";
    public int Age;
    public string Breed = "";
    public string Color = "";

    public string Bark()
    {
        string result = "";
        result = "Dog is barking";
        return result;
    }

    public string MakePeopleHappy()
    {
        string result = "";
        result = "Dog makes people happy";
        return result;
    }
}


class Cat
{
    public string Name = "";
    public string Breed = "";
    public int Age;
    public string Gender = "";

    public string Meowing()
    {
        string result = "";
        result = "Cat is meowing";
        return result;
    }

    public string CommandHuman()
    {
        string result = "";
        result = "Cat is commanding human";
        return result;
    }
}