namespace RealEstateWebApi.Application.DTOs;

public class CustomerDto
{
    public uint Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string FullName { get; set; }
    public string MobileNumber { get; set; }
    public string? MobileNumber2 { get; set; }
    public string? PhoneNumber { get; set; }
    public string? PhoneNumber2 { get; set; }
    public string? Email { get; set; }
    public uint CityId { get; set; }
    public string City { get; set; }
    public uint DistrictId { get; set; }
    public string District { get; set; }
    public uint? NeighborhoodId { get; set; }
    public string Neighborhood { get; set; }
    public DateTime? BirthDay { get; set; }
    public long? CitizenNumber { get; set; }
    public string StatusKey { get; set; }
    public string? Status { get; set; }

    public string RegisterUser { get; set; }
    public string AssignedUser { get; set; }
    public uint? RegisterUserId { get; set; }
    public uint? AssignedUserId { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public bool IsActive { get; set; }

}