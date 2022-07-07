using System;

namespace Entities.Models;

public class Otp
{
    public Guid Id { get; set; }
    public string Key { get; set; }
    public string Message { get; set; }
    public DateTime CreateAt { get; set; }
    public Guid UserId { get; set; }
    public bool IsUsed { get; set; }
    public virtual Person Person { get; set; }
}