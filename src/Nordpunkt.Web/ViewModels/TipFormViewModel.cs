using System.ComponentModel.DataAnnotations;

namespace Nordpunkt.Web.ViewModels;

public class TipFormViewModel
{
    [Required(ErrorMessage = "Skriv en rubrik för ditt tips.")]
    [Display(Name = "Rubrik")]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage = "Beskriv vad ditt tips handlar om.")]
    [Display(Name = "Beskrivning")]
    public string Description { get; set; } = string.Empty;

    [Display(Name = "Namn (frivilligt)")]
    public string? Name { get; set; }

    [RegularExpression(@"^[^@\s]+@[^@\s]+\.[^@\s]+$", ErrorMessage = "Skriv en giltig e-postadress, till exempel namn@exempel.se.")]
    [Display(Name = "E-post (frivilligt)")]
    public string? Email { get; set; }

    [Display(Name = "Telefon (frivilligt)")]
    public string? Phone { get; set; }

    // [Required] fungerar inte på bool, eftersom false också är ett värde.
    [Range(typeof(bool), "true", "true", ErrorMessage = "Du måste godkänna hur vi behandlar dina personuppgifter.")]
    [Display(Name = "Jag godkänner att Nordpunkt behandlar mina uppgifter för att hantera tipset.")]
    public bool Consent { get; set; }
}
