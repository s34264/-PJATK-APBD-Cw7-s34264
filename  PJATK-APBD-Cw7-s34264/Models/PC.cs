namespace PJATK_APBD_Cw7_s34264.Models;

public class PC
{
    public int Id { get; set; }
    
    public string Name { get; set; } = null!;
    public float Weight { get; set; }
    public int Warranty { get; set; }
    public DateTime CreatedAt { get; set; }
    public int Stock { get; set; }
    
    public virtual ICollection<PCComponent> PCComponents { get; set; } = [];
}