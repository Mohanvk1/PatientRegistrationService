using Microsoft.AspNetCore.Mvc;


[Route("api/[controller]")]
[ApiController]
public class PatientController : ControllerBase
{
  [HttpGet("GetPatientInformation/{patientId}")]
  public IActionResult GetPatientInformation(int patientId)
  {
    Patient patient = new Patient
    {
      Id = patientId,
      FirstName = "Mohan",
      LastName = "CH",
      // Age = 25,
      // Diagnosis = "Hypertension",
      // DateOfBirth = "mm-dd-yy",
      Insurance = "cigna",
      // Phone=9457322287
    };
    return Ok(patient);
  }
  [HttpPost("Register")]
  public IActionResult Register([FromBody]Patient patient)
  {
    System.Console.WriteLine(patient.Id);
    return Ok(patient);
  }

  
}