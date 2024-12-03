using NovotecDB.Models;

namespace Novotec.API.Dto;

public class PersonDto
{
    public int PersonId { get; set; }
    public string PersonalNumber { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime DateOfBirth { get; set; }
    public DateTime? ContractFrom { get; set; }
    public DateTime? ContractTo { get; set; }
    public string ChipNumber { get; set; }
    public string ChipCode { get; set; }

    public PersonDto(Employee employee, Address? address, Card? card)
    {
        PersonalNumber = employee.Empersno;
        PersonId = (int)employee.Emident;
        FirstName = address?.Adfname1 ?? "";
        LastName = address?.Adlname1 ?? "";
        ContractFrom = employee.Emstart;
        ContractTo = employee.Emend;
        ChipNumber = card?.Cano ?? "";
    }
}