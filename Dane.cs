using System.ComponentModel.DataAnnotations;

public class Dane
{
    [Required(ErrorMessage = "Proszę podaj Imię")]
    [MinLength(2, ErrorMessage = "Imię musi mieć minimum 2 znaki")]
    public string Imie { get; set; }

    [Required(ErrorMessage = "Proszę podaj Nazwisko")]
    [MinLength(2, ErrorMessage = "Nazwisko musi mieć minimum 2 znaki")]
    public string Nazwisko { get; set; }

    [Required(ErrorMessage = "Proszę podaj Email")]
    [EmailAddress(ErrorMessage = "Niepoprawny format adresu email")]
    public string Email { get; set; }

    [Required(ErrorMessage = "Proszę podaj hasło")]
    [MinLength(8, ErrorMessage = "Hasło musi mieć minimum 8 znaków")]
    [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).+$", ErrorMessage = "Hasło musi zawierać przynajmniej jedną dużą literę, jedną małą literę oraz jedną cyfrę")]
    public string Haslo { get; set; }

    [Required(ErrorMessage = "Proszę potwierdź hasło")]
    [Compare("Haslo", ErrorMessage = "Hasła muszą być takie same")]
    public string PotwierdzenieHasla { get; set; }

    [Required(ErrorMessage = "Proszę podaj nr telefonu")]
    [Phone(ErrorMessage = "Niepoprawny format numeru telefonu")]
    public string Telefon { get; set; }

    [Required(ErrorMessage = "Proszę podaj wiek")]
    [Range(10, 80, ErrorMessage = "Wiek musi być w przedziale 10-80")]
    public int Wiek { get; set; }

    [Required(ErrorMessage = "Proszę wybierz miasto")]
    public string Miasto { get; set; }
}

