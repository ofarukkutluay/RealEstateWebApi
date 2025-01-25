using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using RealEstateWebApi.Domain.Entities;

namespace RealEstateWebApi.Domain.Enums;

[NotMapped]
public class PropertyCategory
{
    public Commercial Commercial { get; set; }
    public Land Land { get; set; }
    public Residential Residential { get; set; }
    public Tourism Tourism { get; set; }

}
