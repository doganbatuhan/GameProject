using GameProject.Validation;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Customer
{
    // MicroService
    class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;
        List<Gamer> gamers;

        public GamerManager(IUserValidationService userValidationService)
        {
            gamers = new List<Gamer>();
            _userValidationService = userValidationService;
        }
        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                gamers.Add(gamer);
                Console.WriteLine("Kayıt oldu");
            }
            else
            {
                Console.WriteLine("Doğrulama başarısız. Kayıt başarısız");
            }

        }
        public void Delete(Gamer gamer)
        {
            gamers.Remove(gamer);
            Console.WriteLine("Kayıt silindi");
        }
        public List<Gamer> GamerDb()
        {
            return gamers;
        }
        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
