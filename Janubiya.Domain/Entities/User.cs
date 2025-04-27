using Janubiya.Domain.Common;

namespace Janubiya.Domain.Entities
{
    public class User : BaseEntity
    {
        public required string Username { get; set; }
        public required string Email { get; set; }
        public required string Password { get; set; }
        public required string Role { get; set; }

    }
}