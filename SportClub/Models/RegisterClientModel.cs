using Humanizer.Localisation;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace SportClub.Models
{
    public class RegisterClientModel
    {
        // [Required(ErrorMessageResourceType = typeof(Resources.Resource), ErrorMessageResourceName = "LogRequired")]
        [Required(ErrorMessageResourceName = "Обязательное поле")]
        // [Display(Name = "loginN", ResourceType = typeof(Resources.Resource))]
        [Display(Name = "Login")]
        //  [Remote("IsLoginInUse", "Login", ErrorMessageResourceType = typeof(Resources.Resource),
        //     ErrorMessageResourceName = "loginused")]
        [Remote("IsLoginInUse", "Login", ErrorMessageResourceName="Логин уже зарегестрирован")]
        public string? Login { get; set; }

        /* [Required(ErrorMessageResourceType = typeof(Resources.Resource),
                  ErrorMessageResourceName = "PassRequired")]
         [Display(Name = "password", ResourceType = typeof(Resources.Resource))]
         [Remote("CheckPassword", "Login", ErrorMessageResourceType = typeof(Resources.Resource),
                 ErrorMessageResourceName = "LightPass")]*/
        [Required(ErrorMessageResourceName = "Обязательное поле")]
        [Display(Name = "Password")]
        [Remote("CheckPassword", "Login", ErrorMessageResourceName = "Минимум 8 символов, одна заглавная, одна цифра,один спец.символ")]
        [DataType(DataType.Password)]
        public string? Password { get; set; }

        /* [Required(ErrorMessageResourceType = typeof(Resources.Resource),
                 ErrorMessageResourceName = "PassConRequired")]
         [Display(Name = "passwordConf", ResourceType = typeof(Resources.Resource))]
         [Compare("Password", ErrorMessageResourceType = typeof(Resources.Resource),
                 ErrorMessageResourceName = "passnoteq")]*/
        [Required(ErrorMessageResourceName = "Обязательное поле")]
        [Display(Name = "Confirm password")]
        [Compare("Password", ErrorMessageResourceName = "Пароли не совпадают")]
        [DataType(DataType.Password)]
        public string? PasswordConfirm { get; set; }
        /* [Required(ErrorMessageResourceType = typeof(Resources.Resource),
                 ErrorMessageResourceName = "EmailRequired")]
         [EmailAddress(ErrorMessageResourceType = typeof(Resources.Resource),
                 ErrorMessageResourceName = "unemail")]*/
        [Required(ErrorMessageResourceName = "Обязательное поле")]
        [Display(Name = "email ")]
        [EmailAddress(ErrorMessageResourceName = "не корректный ввод")]
        /* [Remote("IsEmailInUse", "Login", ErrorMessageResourceType = typeof(Resources.Resource),
                 ErrorMessageResourceName = "emailused")]*/
        [Remote("IsEmailInUse", "Login", ErrorMessageResourceName = "email уже зарегестрирован")]
        public string? email { get; set; }
     /*   [Required(ErrorMessageResourceType = typeof(Resources.Resource),
                 ErrorMessageResourceName = "AgeRequired")]
        [Display(Name = "age", ResourceType = typeof(Resources.Resource))]
        [Remote("CheckAge", "Login", ErrorMessageResourceType = typeof(Resources.Resource),
                 ErrorMessageResourceName = "unage")]
        public string? age { get; set; }*/
    }
}
