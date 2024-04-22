using CodePulseAPI.Models.Domain;

namespace CodePulseAPI.Repositories.Interface
{
    public interface IImageRepository
    {
        Task<IEnumerable<BlogImage>> GetAll();
        Task<BlogImage> Upload(IFormFile file, BlogImage blogImage);
    }
}
