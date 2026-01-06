namespace requete.DTOs.Responses;

public record CourseDto
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? Duration { get; set; }

    public CourseDto() {}
}