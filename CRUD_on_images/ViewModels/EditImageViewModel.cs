namespace CRUD_on_images.ViewModels
{
    public class EditImageViewModel : UploadImageViewModel
    {
        public int Id { get; set; }
        public string? ExistingImage { get; set; }
    }
}
