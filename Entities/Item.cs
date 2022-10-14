namespace Exam.NET.Entities
{
    public record Item
    {
    public Guid Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public Enum UserType { get; set; }
    public string Email { get; set; } = string.Empty;
    public int Phone { get; set; }
    }
    
}