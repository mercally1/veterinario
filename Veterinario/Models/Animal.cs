using System.ComponentModel.DataAnnotations;

namespace Veterinario.Models;

public class Animal
{
    [Key]
    public int AnimalId { get; set; }

    [Required, MaxLength(20)]
    public string? Nombre { get; set; }

    [Required, MaxLength(5)]
    public string? Anno { get; set; }

    [Required, MaxLength(30)]
    public string? Tipo { get; set; }
}
