using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace CRUD_on_images.ViewModels
{
    public class UploadImageViewModel
    {
        [Required]
        [Display(Name = "Picture")]
        public IFormFile? SpeakerPicture { get; set; }
    }
}
