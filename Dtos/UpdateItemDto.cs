namespace Exam.NET.Dtos
{
    public record UpdateItemDto
    {
        
    public string Name { get; set; } = string.Empty;
    public Enum UserType { get; set; }
    public string Email { get; set; } = string.Empty;
    public int Phone { get; set; }
    }
}