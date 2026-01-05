namespace requete.DTOs.Responses;

public record ManagerDto
{
    public long? Id { get; set; }
    public string? Fullname { get; set; }
    public string? Position { get; set; }

    public ManagerDto() {}
}