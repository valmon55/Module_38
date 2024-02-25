using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XMR.HomeApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DevicePage : ContentPage
    {
        public DevicePage()
        {
            InitializeComponent();
            GetDevices();
        }

        /// <summary>
        /// Метод для выгрузки устройств
        /// </summary>
        public void GetDevices()
        {
            // Создадим некий список устройств.
            // В реальном приложении они могут доставаться из базы или веб-сервиса.
            var homeDevices = new List<string>()
           {
               "Чайник",
               "Стиральная машина",
               "Посудомоечная машина",
               "Мультиварка",
               "Водонагреватель",
               "Плита",
               "Микроволновая печь",
               "Духовой шкаф",
               "Холодильник",
               "Увлажнитель воздуха",
               "Телевизор",
               "Пылесос",
               "Музыкальный центр",
               "Компьютер",
               "Игровая консоль"
           };

            // Создадим новый стек
            var innerStack = new StackLayout();

            // Сохраним в стек имеющиеся данные, используя свойство Children
            foreach (string deviceName in homeDevices)
            {
                var deviceLabel = new Label() { Text = $"   {deviceName}", FontSize = 17 };

                var frame = new Frame()
                {
                    BorderColor = Color.Gray,
                    BackgroundColor = Color.FromHex("#e1e1e1"),
                    CornerRadius = 4,
                    Margin = new Thickness(10, 1)
                };

                frame.Content = deviceLabel;
                
                innerStack.Children.Add(frame);
            }

            // Сохраним стек внутрь уже имеющегося в xaml-файле блока прокручиваемой разметки
            scrollView.Content = innerStack;
        }
    }
}