public class UserSessionService
{
    public RegistrationModel? RegistrationInfo { get; set; }

    private Dictionary<int, List<string>> attendance = new();

    public void MarkAttendance(int eventId, string userName)
    {
        if (!attendance.ContainsKey(eventId))
            attendance[eventId] = new List<string>();

        if (!attendance[eventId].Contains(userName))
            attendance[eventId].Add(userName);
    }

    public List<string> GetAttendees(int eventId)
    {
        return attendance.ContainsKey(eventId) ? attendance[eventId] : new List<string>();
    }
}
