namespace MyFace.Models.Request
{
    public class CreatePostRequestModel
    {
        public string Message { get; set; }
        public string ImageUrl { get; set; }
        public int UserId { get; set; }
    }
}