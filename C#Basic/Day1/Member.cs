using System;

public class Member
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public bool Gender { get; set; }
    public DateTime Dob { get; set; }
    public string PhoneNumber { get; set; }
    public string BirthPlace { get; set; }
    public bool IsGraduated { get; set; }

    public Member(string firstName, string lastName, bool gender, DateTime dob, string phone, string birthPlace, bool isGraduated)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Gender = gender;
        this.Dob = dob;
        this.PhoneNumber = phone;
        this.BirthPlace = birthPlace;
        this.IsGraduated = isGraduated;
    }

    public int Age
    {
        get
        {
            return DateTime.Now.Year - this.Dob.Year;
        }
    }

    public string FullName
    {
        get
        {
            // return this.lastName + " " + this.firstName;
            return string.Format("{0} {1}", this.LastName, this.FirstName);
        }
    }

    public string FullInfo
    {
        get
        {
            return string.Format(
                "FirstName:{0}\r\n"
                + "LastName:{1}\r\n"
                + "Gender:{2}\r\n"
                + "Dob:{3}\r\n"
                + "Phone:{4}\r\n"
                + "BirthPlace:{5}\r\n"
                + "Age:{6}\r\n"
                + "Graduated:{7}\r\n",
                this.FirstName,
                this.LastName,
                this.Gender,
                this.Dob,
                this.PhoneNumber,
                this.BirthPlace,
                this.Age,
                this.IsGraduated);
        }
    }
}