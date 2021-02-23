using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    interface IUserValidationService //kullanıcı doğrulama servisi
    {
        bool Validate(Gamer gamer);
    }
}
