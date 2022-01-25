using Core.Entities;

namespace Pims.Entities.Dtos
{
    public class UserForLoginDto: IDto
    {
        public string Email { get; set; }

        public string Password { get; set; }
    }
}
