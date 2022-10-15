using System.ComponentModel.DataAnnotations;

namespace coresolution.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}