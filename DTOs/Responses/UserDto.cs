namespace requete.DTOs.Responses;

public record UserDto
{
    public long? Id { get; set; }
    public string? Fullname { get; set; }
    public string? Position { get; set; }

    public UserDto() {}

    public UserDto(Models.HCM.FuncManager x)
    {
        Id = x.ObjectId;
        Fullname = x.PersonFullname;
        Position = x.PersonPosition?.Name;
    }
}