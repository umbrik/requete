namespace requete.DTOs.Responses;

public record LearningResultDto
{
    public long? Id { get; set; }
    public string? Fullname { get; set; }
    public string? Position { get; set; }

    public LearningResultDto() {}

    public LearningResultDto(Models.HCM.Learning learning)
    {
        Id = learning.Id;
        Fullname = learning.PersonFullname;
        Position = learning.PersonPositionName;
    }

    public LearningResultDto(Models.HCM.ActiveLearning learning)
    {
        Id = learning.Id;
        Fullname = learning.PersonFullname;
        Position = learning.PersonPositionName;
    }
}