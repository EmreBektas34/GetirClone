using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GetirClone
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            var images = new List<string>
            {
                "http://cdn.getir.com/misc/611e55d33ea65bef40f9ba05_banner_tr_1629378026496.jpeg",
                "https://i0.wp.com/shiftdelete.net/wp-content/uploads/2022/01/image.png?fit=1280%2C720&ssl=1",
                "https://cdnntr1.img.sputniknews.com/img/104178/86/1041788666_0:0:1200:675_1920x0_80_0_0_f43d22d85332425983572e8210be4efd.jpg",
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ5sQZBql_dyn88JzrIYO7pyckrfw79jNe7YQ&usqp=CAU",
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQXj0mfMbg3FGrJ8x-v3KcSlE32gkyFsTfl4w&usqp=CAU",
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcS4D1irNZXvXg6tt66KzoBL65LvNIika3Wuhw&usqp=CAU",
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRGTcSwa7Zvz8TdxAtkaP8fZcQ-SZNmy906eg&usqp=CAU",
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSxBq4dAgZFC7Es_Z8gWBxAIinkrrYMQ8A1-w&usqp=CAU",
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcRM5uTN7NaQrP8BOuGZJfAOOIVXL0fDrTJYmw&usqp=CAU",
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSWpnNmDMi1KYLK5QL9OKe3PKKM8d4ldRJ57A&usqp=CAU"
            };
            SliderCarouselView.ItemsSource = images;

            Device.StartTimer(TimeSpan.FromSeconds(5), (Func<bool>)(() =>
            {
                SliderCarouselView.Position = (SliderCarouselView.Position + 1) % images.Count;
                return true;
            }));
        }
    }
}
