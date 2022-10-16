namespace OrelUniverEmbeddedAPI;

// Для метода employee.getList
public class Employee
{
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
    public string? ParentName { get; set; }
    public string? TitleDivision { get; set; }
    public string? NamePosition { get; set; }
    public string? Webid { get; set; }
    public string? Empid { get; set; }
}
// Для метода employee.get
public class EmployeeMax : Employee
{
    public string? NameScienceLevel { get; set; }
    public string? NameScienceRank { get; set; }
    public string? Gender { get; set; }
    public string? NameEducation { get; set; }
    public string? Qualification { get; set; }
    public string? QualificationUp { get; set; }
    public string? Education { get; set; }
    public string? Experience { get; set; }
    public string? SpecialityExperience { get; set; }
    public string? ContactAddress { get; set; }
    public string? ContactPhone { get; set; }
    public string? ContactEmail { get; set; }
    public string? PhotoLink { get; set; }
    public string? Text { get; set; }
    public string? Subjects { get; set; }
}
