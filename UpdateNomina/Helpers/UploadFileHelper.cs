namespace UpdateNomina.Helpers
{
    public class UploadFileHelper
    {
        public async Task<string> UoloadFileAsync(string in_Path, IFormFile file)
        {
            string path = in_Path;
            using (Stream stream = new FileStream(path, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }
            return path;
        }
    }
}
