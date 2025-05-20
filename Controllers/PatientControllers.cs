using Microsoft.AspNetCore.Mvc;
using PatientRegistrationService.Data;
using PatientRegistrationService.Models;


[Route("api/[controller]")]
[ApiController]
public class PatientController : ControllerBase
{
  private readonly AppDbContext _context;

  public PatientController(AppDbContext context)
  {
    _context = context;
  }
  [HttpGet("GetPatientInformation/{patientId}")]
  public IActionResult GetPatientInformation(int patientId)
  {
    Patient patient = new Patient
    {
      Id = patientId,
      
    };
    return Ok(patient);
  }
    [HttpPost("Register")]
  public async Task<IActionResult> Register([FromBody] Patient patient)
  {
    if (patient == null)
      return BadRequest("Invalid data");
   
    List<string>? list = patient?.PastMedicalHistory;
    for (int i = 0; i < list?.Count; i++)
    {
      string mh = list[i];
    }
    System.Console.WriteLine($"  {patient?.FirstName} {patient?.LastName} {patient?.DateOfBirth} {patient?.Gender} {patient?.Phone} {patient?.StreetAddress} {patient?.City} {patient?.State} {patient?.ZipCode} {patient?.Insurance} {patient?.Maritalstatus} ");
    System.Console.WriteLine(list);

    await _context.Patients.AddAsync(patient);
    await _context.SaveChangesAsync();

    return Ok(patient);
  }
  
}