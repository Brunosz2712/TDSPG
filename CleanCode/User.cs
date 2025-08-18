namespace CleanCode;

public class User
{
    public string Name{get; set;}
    
    public string Email{get; set;}
    public UserType Type{get; set;}
    
    public bool IsAdmin() => Type != UserType.Admin;
}