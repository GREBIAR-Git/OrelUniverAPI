namespace OrelUniverEmbeddedAPI;

//Для метода schedule.getEmployees
public class EmployeeMin
{
    public int Id { get; set; }
    public string? LastName { get; set; }
    public string? FirstName { get; set; }
    public string? ParentName { get; set; }
}

//Для метода schedule.getExamens
public class Exam
{
    public string? Ts { get; set; }
    public string? Data { get; set; }
    public string? GroupTitle { get; set; }
    public string? LessonTitle { get; set; }
    public string? LessonType { get; set; }
    public string? Cabinet { get; set; }
    public string? LessonNumber { get; set; }
    public string? Weekday { get; set; }
    public string? EmployeeLastName { get; set; }
    public string? EmployeeFirstName { get; set; }
    public string? EmployeeParentName { get; set; }
}

//Для метода schedule.getGroups
public class Group
{
    public int Id { get; set; }
    public string? Title { get; set; }
}

//Для метода schedule.getSubdivisions
public class Subdivision
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? ShortTitle { get; set; }
}

//Для метода schedule.get
public class Schedule
{
    public string? GroupId { get; set; }
    public string? SubgroupId { get; set; }
    public string? LessonTitle { get; set; }
    public string? LessonType { get; set; }
    public string? Course { get; set; }
    public string? LessonNumber { get; set; }
    public string? Weekday { get; set; }
    public string? Building { get; set; }
    public string? Cabinet { get; set; }
    public string? Special { get; set; }
    public string? GroupTitle { get; set; }
    public string? EmployeeId { get; set; }
    public string? EmployeeLastName { get; set; }
    public string? EmployeeFirstName { get; set; }
    public string? EmployeeParentName { get; set; }
}

//Для метода schedule.getBuildings
public class Building
{
    public string? Build { get; set; }
}

//Для метода schedule.getCabinets
public class Cabinets
{
    public string? Cabinet { get; set; }
}

//Для метода schedule.getCourse
public class Cours
{
    public string? Course { get; set; }
}

//Для метода schedule.getDivisionsForEmployees
//Для метода schedule.getDivisionsForStudents
public class Division
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? ShortTitle { get; set; }
}
