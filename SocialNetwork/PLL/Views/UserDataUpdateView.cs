using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.PLL.Helpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace SocialNetwork.PLL.Views
{
    public class UserDataUpdateView
    {
        UserService userService;
        public UserDataUpdateView(UserService userService)
        {
            this.userService = userService;
        }

        public void Show(User user)
        {
            Console.Write("Имя:");
            user.FirstName = Console.ReadLine();

            Console.Write("Фамилия:");
            user.LastName = Console.ReadLine();

            Console.Write("Фото:");
            user.Photo = Console.ReadLine();

            Console.Write("Любимый фильм:");
            user.FavoriteMovie = Console.ReadLine();

            Console.Write("Любимая книга:");
            user.FavoriteBook = Console.ReadLine();

            this.userService.Update(user);

            SuccessMessage.Show("Профиль обновлён!");
        }
    }
}
