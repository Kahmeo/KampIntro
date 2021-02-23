using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{

    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;  //constructor

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        //MicroService
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt Oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama Başarısız. Kayıt başarısız.");
            }
            
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Silindi");
        }
    }
}
