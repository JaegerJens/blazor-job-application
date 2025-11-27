using System.Text.Json.Serialization;

namespace blazor_job_applications.Model;

public enum ApplicationStatus
{
    ApplicationSend = 0,
    ApplicationAccepted = 1,
    JobInterview = 2,
    ApplicationRejected = 3,
    Success = 4,
}

public record CompanyInfo
{
    [JsonInclude]
    public required string Name;
    [JsonInclude]
    public required string Sector;
    [JsonInclude]
    public required Uri Website;
    [JsonInclude]
    public required string OfficeLocation;
}

public record JobApplication
{
    [JsonInclude]
    public required CompanyInfo Company;
    [JsonInclude]
    public DateOnly? FirstContact;
    [JsonInclude]
    public required ApplicationStatus Status;
    [JsonInclude]
    public required Uri JobAd;
    [JsonInclude]
    public decimal? Salary;
    [JsonInclude]
    public HashSet<string> Skills = [];
}
