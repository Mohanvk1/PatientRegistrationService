public class Patient
{
    public int Id { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    // public int Age { get; set; }
    // public string? Diagnosis { get; set; }
    public DateTime DateOfBirth { get; set; }
    public string? Insurance { get; set; }

    public long Phone { get; set; }

    public string? StreetAddress { get; set; }
    public string? City { get; set; }
    public string? State { get; set; }
    public string? ZipCode { get; set; }
    public string? Country { get; set; }

    public string? Gender { get; set; }
    public string? Maritalstatus{ get; set; }
    public List<string>? PastMedicalHistory{ get; set; }
    
}