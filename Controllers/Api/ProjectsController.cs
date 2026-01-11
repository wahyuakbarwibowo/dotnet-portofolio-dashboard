[ApiController]
[Route("api/projects")]
public class ProjectsController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(new[]
        {
            new { Name = "Portfolio App", Tech = ".NET + Kendo", Year = 2024 },
            new { Name = "HR System", Tech = "ASP.NET Core", Year = 2023 },
            new { Name = "Dashboard BI", Tech = "Kendo Chart", Year = 2022 }
        });
    }
}
