using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace RickyFeliguete.Models.AccountModels
{
    public class AvailableUser
    {
        [Required(ErrorMessage = "Digite um nome de usuário")]
        [Display(Name = "Nome de Usuário")]
        [RegularExpression(@"^[a-zA-Za]*$", ErrorMessage = "Caracteres especiais não são permitidos")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Digite uma senha")]
        [StringLength(10, ErrorMessage = "O tamanho máximo de caracteres é {1} e o mínimo é {2}", MinimumLength = 6)]
        [Display(Name = "Senha")]
        public string UserPassword { get; set; }
        [Display(Name = "Nome completo")]
        public string FullName { get; set; }

        public static List<AvailableUser> AllUsers()
        {
            List<AvailableUser> userList = new List<AvailableUser>();

            AvailableUser user1 = new AvailableUser
            {
                UserName = "Anupam Das",
                UserPassword = "lifeisbeautiful",
                FullName = "Life is Beautiful"
            };

            AvailableUser user2 = new AvailableUser
            {
                UserName = "Chinmoy Das",
                UserPassword = "GoodTime",
                FullName = "Good Time"
            };

            userList.Add(user1);
            userList.Add(user2);

            return userList;
        }
    }
}