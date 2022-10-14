using Newtonsoft.Json;
using System.Net;
using System.Text;

namespace OrelUniverEmbeddedAPI;
public class OrelUniverAPI
{
    //const string method = "POST";

    const string userAgent = "EmbedAPIEng/1.0.0";

    const string pathUniver = "http://embedapi.oreluniver.ru/";

    const string contentType = "application/x-www-form-urlencoded";

    public class Result<T>
    {
        public int code;
        public List<T>? response;
    }

    static Result<T>? Request<T>(string pathMethod, string? parameters = null)
    {
        using HttpClient client = new();
        client.BaseAddress = new Uri(pathUniver);
        using HttpRequestMessage httpRequestMessage = new(HttpMethod.Post, pathMethod);
        httpRequestMessage.Headers.Add("User-Agent", userAgent);

        if (!string.IsNullOrEmpty(parameters))
        {
            httpRequestMessage.Content = new StringContent(parameters, Encoding.UTF8, contentType);
        }

        using HttpResponseMessage httpResponse = client.Send(httpRequestMessage);
        using Stream sr = httpResponse.Content.ReadAsStream();
        byte[] bytes = new byte[sr.Length];
        if (sr.Read(bytes) > 0)
        {
            string? content = Encoding.UTF8.GetString(bytes);
            if (content != null)
            {
                return JsonConvert.DeserializeObject<Result<T>>(content);
            }
        }
        return null;
    }

    static async Task<Result<T>?> RequestAsync<T>(string pathMethod, string? parameters = null)
    {
        return await Task.Run(() => Request<T>(pathMethod, parameters));
    }

    public static Result<Employee>? EmployeeGetList()
    {
        return Request<Employee>("employee.getList");
    }

    public static Task<Result<Employee>?> EmployeeGetListAsync()
    {
        return RequestAsync<Employee>("employee.getList");
    }

    public static Result<EmployeeMax>? EmployeeGet(string id)
    {
        string parameters = "id=" + id;
        return Request<EmployeeMax>("employee.get", parameters);
    }

    public static Task<Result<EmployeeMax>?> EmployeeGetAsync(string id)
    {
        string parameters = "id=" + id;
        return RequestAsync<EmployeeMax>("employee.get", parameters);
    }

    public static Result<Schedule>? ScheduleGetByGroup(int day, int month, int year, string group)
    {
        string parameters = "timestamp=" + UnixTime(day, month, year).ToString() + "&group=" + group;
        return Request<Schedule>("schedule.get", parameters);
    }

    public static Task<Result<Schedule>?> ScheduleGetByGroupAsync(int day, int month, int year, string group)
    {
        string parameters = "timestamp=" + UnixTime(day, month, year).ToString() + "&group=" + group;
        return RequestAsync<Schedule>("schedule.get", parameters);
    }

    public static Result<Schedule>? ScheduleGetByEmployee(int day, int month, int year, string employee)
    {
        string parameters = "timestamp=" + UnixTime(day, month, year).ToString() + "&employee=" + employee;
        return Request<Schedule>("schedule.get", parameters);
    }

    public static Task<Result<Schedule>?> ScheduleGetByEmployeeAsync(int day, int month, int year, string employee)
    {
        string parameters = "timestamp=" + UnixTime(day, month, year).ToString() + "&employee=" + employee;
        return RequestAsync<Schedule>("schedule.get", parameters);
    }

    public static Result<Schedule>? ScheduleGetByCabinet(int day, int month, int year, string building, string cabinet)
    {
        string parameters = "timestamp=" + UnixTime(day, month, year).ToString() + "&building=" + building + "&cabinet=" + cabinet;
        return Request<Schedule>("schedule.get", parameters);
    }

    public static Task<Result<Schedule>?> ScheduleGetByCabinetAsync(int day, int month, int year, string building, string cabinet)
    {
        string parameters = "timestamp=" + UnixTime(day, month, year).ToString() + "&building=" + building + "&cabinet=" + cabinet;
        return RequestAsync<Schedule>("schedule.get", parameters);
    }

    public static Result<Schedule>? ScheduleGetByGroup(DateTime dateTime, string group)
    {
        string parameters = "timestamp=" + UnixTime(dateTime).ToString() + "&group=" + group;
        return Request<Schedule>("schedule.get", parameters);
    }

    public static Task<Result<Schedule>?> ScheduleGetByGroupAsync(DateTime dateTime, string group)
    {
        string parameters = "timestamp=" + UnixTime(dateTime).ToString() + "&group=" + group;
        return RequestAsync<Schedule>("schedule.get", parameters);
    }

    public static Result<Schedule>? ScheduleGetByEmployee(DateTime dateTime, string employee)
    {
        string parameters = "timestamp=" + UnixTime(dateTime).ToString() + "&employee=" + employee;
        return Request<Schedule>("schedule.get", parameters);
    }

    public static Task<Result<Schedule>?> ScheduleGetByEmployeeAsync(DateTime dateTime, string employee)
    {
        string parameters = "timestamp=" + UnixTime(dateTime).ToString() + "&employee=" + employee;
        return RequestAsync<Schedule>("schedule.get", parameters);
    }

    public static Result<Schedule>? ScheduleGetByCabinet(DateTime dateTime, string building, string cabinet)
    {
        string parameters = "timestamp=" + UnixTime(dateTime).ToString() + "&building=" + building + "&cabinet=" + cabinet;
        return Request<Schedule>("schedule.get", parameters);
    }

    public static Task<Result<Schedule>?> ScheduleGetByCabinetAsync(DateTime dateTime, string building, string cabinet)
    {
        string parameters = "timestamp=" + UnixTime(dateTime).ToString() + "&building=" + building + "&cabinet=" + cabinet;
        return RequestAsync<Schedule>("schedule.get", parameters);
    }

    static long UnixTime(int day, int month, int year)
    {
        DateTime dateTime = new(year, month, day);
        return ((DateTimeOffset)dateTime).ToUnixTimeSeconds();
    }

    static long UnixTime(DateTime dateTime)
    {
        return ((DateTimeOffset)dateTime).ToUnixTimeSeconds();
    }

    public static Result<Building>? ScheduleGetBuildings()
    {
        return Request<Building>("schedule.getBuildings");
    }

    public static Task<Result<Building>?> ScheduleGetBuildingsAsync()
    {
        return RequestAsync<Building>("schedule.getBuildings");
    }

    public static Result<Division>? GetDivisionsForEmployees()
    {
        return Request<Division>("schedule.getDivisionsForEmployees");
    }

    public static Task<Result<Division>?> GetDivisionsForEmployeesAsync()
    {
        return RequestAsync<Division>("schedule.getDivisionsForEmployees");
    }

    public static Result<Division>? GetDivisionsForStudents()
    {
        return Request<Division>("schedule.getDivisionsForStudents");
    }

    public static Task<Result<Division>?> GetDivisionsForStudentsAsync()
    {
        return RequestAsync<Division>("schedule.getDivisionsForStudents");
    }

    public static Result<Cabinet>? ScheduleGetCabinets(string building)
    {
        string parameters = "building=" + building;
        return Request<Cabinet>("schedule.getCabinets", parameters);
    }

    public static Task<Result<Cabinet>?> ScheduleGetCabinetsAsync(string building)
    {
        string parameters = "building=" + building;
        return RequestAsync<Cabinet>("schedule.getCabinets", parameters);
    }

    public static Result<Cours>? ScheduleGetCourse(string division)
    {
        string parameters = "division=" + division;
        return Request<Cours>("schedule.getCourse", parameters);
    }

    public static Task<Result<Cours>?> ScheduleGetCourseAsync(string division)
    {
        string parameters = "division=" + division;
        return RequestAsync<Cours>("schedule.getCourse", parameters);
    }

    public static Result<EmployeeMin>? ScheduleGetEmployees(string division, string subdivision)
    {
        string parameters = "division=" + division + "&subdivision=" + subdivision;
        return Request<EmployeeMin>("schedule.getEmployees", parameters);
    }

    public static Task<Result<EmployeeMin>?> ScheduleGetEmployeesAsync(string division, string subdivision)
    {
        string parameters = "division=" + division + "&subdivision=" + subdivision;
        return RequestAsync<EmployeeMin>("schedule.getEmployees", parameters);
    }

    public static Result<Exam>? ScheduleGetExamsForStudent(string group)
    {
        string parameters = "group=" + group;
        return Request<Exam>("schedule.getExamens", parameters);
    }

    public static Task<Result<Exam>?> ScheduleGetExamsForStudentAsync(string group)
    {
        string parameters = "group=" + group;
        return RequestAsync<Exam>("schedule.getExamens", parameters);
    }

    public static Result<Exam>? ScheduleGetExamsForEmployee(string employee)
    {
        string parameters = "employee=" + employee;
        return Request<Exam>("schedule.getExamens", parameters);
    }
    public static Task<Result<Exam>?> ScheduleGetExamsForEmployeeAsync(string employee)
    {
        string parameters = "employee=" + employee;
        return RequestAsync<Exam>("schedule.getExamens", parameters);
    }

    public static Result<Group>? ScheduleGetGroups(string division, string course)
    {
        string parameters = "division=" + division + "&course=" + course;
        return Request<Group>("schedule.getGroups", parameters);
    }
    public static Task<Result<Group>?> ScheduleGetGroupsAsync(string division, string course)
    {
        string parameters = "division=" + division + "&course=" + course;
        return RequestAsync<Group>("schedule.getGroups", parameters);
    }

    public static Result<Subdivision>? ScheduleGetSubdivisions(string division)
    {
        string parameters = "division=" + division;
        return Request<Subdivision>("schedule.getSubdivisions", parameters);
    }
    public static Task<Result<Subdivision>?> ScheduleGetSubdivisionsAsync(string division)
    {
        string parameters = "division=" + division;
        return RequestAsync<Subdivision>("schedule.getSubdivisions", parameters);
    }
}
