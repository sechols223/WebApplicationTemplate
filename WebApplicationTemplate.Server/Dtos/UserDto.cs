namespace WebApplicationTemplate.Server.Dtos;

public class UserDto
{
    public int Id { get; set; }
    public required string Username { get; set; }
    public required string Firstname { get; set; }
    public required string Lastname { get; set; }
    public required string Email { get; set; }
}