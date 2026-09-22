class Manager : Employee, IEmployeeActions
{
    public int TeamSize { get; set; }

    public Manager(int id, string name, int teamSize)
        : base(id, name)
    {
        TeamSize = teamSize;
    }

    public override void Work()
    {
        Console.WriteLine($"{Name} is managing a team of {TeamSize} people.");
    }

    public void AttendMeeting()
    {
        Console.WriteLine($"{Name} is attending a management meeting.");
    }

    public void SubmitReport()
    {
        Console.WriteLine($"{Name} submitted the management report.");
    }
}