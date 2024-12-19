using NovotecDB.Models;

namespace Novotec.API.Dto;

public class PersonDto
{
    public int PersonId { get; set; }
    public string PersonalNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Country { get; set; }
    public string ZipCode { get; set; }
    public string StreetName { get; set; }
    public string City { get; set; }
    public DateTime? ContractFrom { get; set; }
    public DateTime? ContractTo { get; set; }
    public string ChipCode { get; set; }

    public PersonDto()
    {
        
    }
    public PersonDto(Employee employee, Address? address, Card? card)
    {
        PersonalNumber = employee.Empersno;
        PersonId = (int)employee.Emident;
        FirstName = address?.Adfname1 ?? "";
        LastName = address?.Adlname1 ?? "";
        ZipCode = address?.Adzip ?? "";
        StreetName = address?.Adstr ?? "";
        Country = address?.Adctry ?? "";
        City = address?.Adloc ?? "";
        ContractFrom = employee.Emstart;
        ContractTo = employee.Emend;
        ChipCode = card?.Cano ?? "";
    }
}