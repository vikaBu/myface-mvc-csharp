using MyFace.Models.Database;

namespace MyFace.Models.Request
{
    public class CreateInteractionRequestModel
    {
        public InteractionType InteractionType { get; set; }
        public int UserId { get; set; }
    }
}