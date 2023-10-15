using System.ComponentModel.DataAnnotations;

namespace HelloLibrary.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}