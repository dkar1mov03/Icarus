using Microsoft.AspNetCore.Http;

namespace Icarus.Service.DTOs.Assets;

public class AssetForCreationDto
{
    public IFormFile Logo { get; set; }
    public decimal Rating { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public string Address { get; set; }
    public string CompanyWebUrl { get; set; }
    public string InstagramUrl { get; set; }
    public string TelegramUrl { get; set; }
    public string FacebookUrl { get; set; }
    public string Latitude { get; set; }
    public string Longitude { get; set; }
}
