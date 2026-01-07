using System.Text.Json.Serialization;

namespace requete.DTOs.Responses;

public record LearningResultDto
{
    public long? Id { get; set; }
    public string? Fullname { get; set; }
    public string? CourseName { get; set; }

    public LearningResultDto() { }

    public LearningResultDto(
        long? id,
        string? fullname,
        string? courseName
    )
    {
        Id = id;
        Fullname = fullname;
        CourseName = courseName;
    }

    public LearningResultDto(Models.HCM.Learning learning): this(
        learning.Id,
        learning.PersonFullname,
        learning.CourseName) { }

    public LearningResultDto(Models.HCM.ActiveLearning learning): this(
        learning.Id,
        learning.PersonFullname,
        learning.CourseName) { }
}