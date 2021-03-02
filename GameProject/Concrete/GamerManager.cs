﻿using GameProject.Abstract;
using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Concrete
{
    class GamerManager : IGamerService
    {
        //Bir manager sınıfının içinde başka bir manager sınıfı kullanacak isek asla new lemeyiz. Onun yerine bir constructor oluştururuz.
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        
        public void Add(Gamer gamer)
        {

            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Kayıt Yapıldı");
            }
            else
            {
                Console.WriteLine("Doğrulama Ve Kayıt Başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt Güncellendi");
        }
    }
}
