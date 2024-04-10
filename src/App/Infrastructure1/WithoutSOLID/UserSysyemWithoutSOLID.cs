namespace App.Infrastructure1.WithoutSoild;

public class UserSysyemWithoutSOLID : object
{
    public UserSysyemWithoutSOLID() : base()
    {
    }

    // Without Solid

    public void Create()
    {
        Console.WriteLine("Created");
    }

    public void Update()
    {
        Console.WriteLine("Updated");
    }

    public void Delete()
    {
        Console.WriteLine("Deleted");
    }

    public void SendEmail()
    {
        Console.WriteLine("Sent");
    }

    public void LogInformation()
    {
        Console.WriteLine("Saved");
    }
}
