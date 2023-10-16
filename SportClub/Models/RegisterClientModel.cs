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
        public string? Email { get; set; }
        /*   [Required(ErrorMessageResourceType = typeof(Resources.Resource),
                    ErrorMessageResourceName = "AgeRequired")]
           [Display(Name = "age", ResourceType = typeof(Resources.Resource))]
           [Remote("CheckAge", "Login", ErrorMessageResourceType = typeof(Resources.Resource),
                    ErrorMessageResourceName = "unage")]
           public string? age { get; set; }*/
        [Required(ErrorMessageResourceName = "Обязательное поле")]
        [Display(Name = "Date of birth ")]
        public string? DateOfBirth { get; set; }
        [Required(ErrorMessageResourceName = "Обязательное поле")]
        [Display(Name = "Phone number")]
        [RegularExpression(@"\(\d{3}\)-\d{3} \d{2} \d{2}", ErrorMessage = "Введите номер в формате (097)-111 11 11")]
        public string? Phone { get; set; }
        [Required(ErrorMessageResourceName = "Обязательное поле")]     
        public string Gender {  get; set; }
        [Required(ErrorMessageResourceName = "Обязательное поле")]
        [Display(Name = "Имя")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Поле 'Имя' должно содержать только буквы.")]
        public string Name { get; set; }
        [Required(ErrorMessageResourceName = "Обязательное поле")]
        [Display(Name = "Фамилию")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Поле 'Имя' должно содержать только буквы.")]
        public string Surname { get; set; }
        [Required(ErrorMessageResourceName = "Обязательное поле")]
        [RegularExpression("^[a-zA-Z]+$", ErrorMessage = "Поле 'Имя' должно содержать только буквы.")]
        [Display(Name = "Отчество")]
        public string Dopname { get; set; }
    }
}
