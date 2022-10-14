namespace OrelUniverEmbeddedAPI;

//Для метода schedule.getEmployees
public class EmployeeMin
{
    public int id;
    public string? lastName;
    public string? firstName;
    public string? parentName;
}

//Для метода schedule.getExamens
public class Exam
{
    public string? ts;
    public string? data;
    public string? groupTitle;
    public string? lessonTitle;
    public string? lessonType;
    public string? cabinet;
    public string? lessonNumber;
    public string? weekday;
    public string? employeeLastName;
    public string? employeeFirstName;
    public string? employeeParentName;
}

//Для метода schedule.getGroups
public class Group
{
    public int id;
    public string? title;
}

//Для метода schedule.getSubdivisions
public class Subdivision
{
    public int id;
    public string? title;
    public string? shortTitle;
}

//Для метода schedule.get
public class Schedule
{
    public string? groupId;
    public string? subgroupId;
    public string? lessonTitle;
    public string? lessonType;
    public string? course;
    public string? lessonNumber;
    public string? weekday;
    public string? building;
    public string? cabinet;
    public string? special;
    public string? groupTitle;
    public string? employeeId;
    public string? employeeLastName;
    public string? employeeFirstName;
    public string? employeeParentName;
}

//Для метода schedule.getBuildings
public class Building
{
    public string? building;
}

//Для метода schedule.getCabinets
public class Cabinet
{
    public string? cabinet;
}

//Для метода schedule.getCourse
public class Cours
{
    public string? course;
}

//Для метода schedule.getDivisionsForEmployees
//Для метода schedule.getDivisionsForStudents
public class Division
{
    public int id;
    public string? title;
    public string? shortTitle;
}
