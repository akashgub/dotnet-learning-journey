class Developer : Employee, IEmployeeActions
{
    public string ProgrammingLanguage { get; set; }

    public Developer(int id, string name, string programmingLanguage)
        : base(id, name)
    {
        ProgrammingLanguage = programmingLanguage;
    }

    public override void Work()
    {
        Console.WriteLine($"{Name} is developing software using {ProgrammingLanguage}.");
    }

    public void AttendMeeting()
    {
        Console.WriteLine($"{Name} is attending a meeting.");
    }

    public void SubmitReport()
    {
        Console.WriteLine($"{Name} submitted the development report.");
    }
}