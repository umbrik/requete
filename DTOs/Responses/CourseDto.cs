using requete.Models.HCM;

namespace requete.DTOs.Responses;

public record CourseDto
{
    public long Id { get; set; }

    public string? Code { get; set; }

    public string? Name { get; set; }

    public long? Duration { get; set; }

    public CourseDto() {}

    public CourseDto(Course x)
    {
        Id = x.Id;
        Code = x.Code;
        Name = x.Name;
        Duration = x.Duration;
    }
}