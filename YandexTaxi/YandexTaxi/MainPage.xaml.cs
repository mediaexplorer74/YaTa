using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

using YandexGo.Service.Interfaces;
using YandexGo.Service.Services;

namespace YandexTaxi
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            CallInitTasks();
        }

        //static async Task 
        async void CallInitTasks()
        {
            IUserService userService = new UserService();
            //await userService.CreateAsync(new UserForCreation()
            //{
            //    FirstName = "John",
            //    LastName = "Doe",
            //    Username = "jdoe",
            //    Address = "ksmksmsmsc",
            //    Email = "kscscmsakcmskm@gmail.com",
            //    Login = "ksckdckdcdkc",
            //    Password = "ldskmskmcks19129103@#@@#@",
            //    PhoneNumber = "+998900965664",
            //    UserMode = UserMode.Admin,

            //});
            //await userService.UpdateAsync(5, new UserForCreation()
            //{
            //    FirstName = "John",
            //    LastName = "Doe",
            //    Username = "jsdmkmsk",
            //    Address = "14/62/21",
            //    Email = "kscscmsmsmkkm@gmail.com",
            //    Login = "ksckdckdccmknn",
            //    Password = "ldskms19129103@#@@#@",
            //    PhoneNumber = "+998900965664",
            //    UserMode = UserMode.Admin,
            //});

            //await userService.DeleteAsync(u => u.Id == 5);

            Debug.WriteLine((await userService.GetAsync(u => u.Id == 8)).Login);
            // TODO: TextBox output
        }
    }
}
