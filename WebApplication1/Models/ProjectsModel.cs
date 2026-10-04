namespace WebApplication1.Models;

// For listing the projects
// Requires ID, Name, Date Last Updated
public class ProjectsModel
{
    public int ProjID { get; set; }
    public string? ProjName { get; set; }
    public string? RepoLink { get; set; } = string.Empty;
    public DateOnly DateUpdated { get; set; }
    
}