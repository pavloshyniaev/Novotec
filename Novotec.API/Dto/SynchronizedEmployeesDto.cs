namespace Novotec.API.Dto;

public class SynchronizedEmployeesDto
{
    public List<PersonDto> AddedEmployees {get; set;}
    public List<PersonDto> UpdatedEmployees {get; set;}
    public List<PersonDto> DeletedEmployees {get; set;}

    public SynchronizedEmployeesDto(List<PersonDto> added, List<PersonDto> updated, List<PersonDto> deleted)
    {
        AddedEmployees = added;
        UpdatedEmployees = updated;
        DeletedEmployees = deleted;
    }
}