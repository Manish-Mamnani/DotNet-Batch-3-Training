using System;
namespace StudentManagementSystemApp;

public class Student
{
    int rollNo;
    string name;
    string address;
    int phy;
    int chem;
    int math;
    int total;
    // float perc;

    //CLR Properties
    public int RollNo
    {
        set
        {
            rollNo = value;
        }
        get
        {
            return rollNo;
        }
    }

    //Auto-Implicit Properties
    public string Name{ get; set; }
    public string Address{ get; set; }
    public int Total
    {
        set
        {
            total = value;
        }
        get
        {
            return total;
        }
    }
    public float Perc{get; set;}

    public int Phy
    {
        set
        {
            if(value>=0 && value <= 100)
            {
                phy = value;
            }
            else
            {
                throw new InvalidMarksException("Invalid Marks.");
            }
        }
        get
        {
            return phy;
        }
    }
    public int Chem
    {
        set
        {
            if(value>=0 && value <= 100)
            {
                phy = value;
            }
            else
            {
                throw new InvalidMarksException("Invalid Marks.");
            }
        }
        get
        {
            return chem;
        }
    }
    public int Math
    {
        set
        {
            if(value>=0 && value <= 100)
            {
                phy = value;
            }
            else
            {
                throw new InvalidMarksException("Invalid Marks.");
            }
        }
        get
        {
            return math;
        }
    }




}

[Serializable]
internal class InvalidMarksException : Exception
{
    public InvalidMarksException()
    {
    }

    public InvalidMarksException(string? message) : base(message)
    {
    }

    public InvalidMarksException(string? message, Exception? innerException) : base(message, innerException)
    {
    }
}