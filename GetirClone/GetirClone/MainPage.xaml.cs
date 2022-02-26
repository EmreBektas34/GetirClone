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

            Ly1.WidthRequest = 50;

            var images = new List<string>
            {
                "http://cdn.getir.com/misc/611e55d33ea65bef40f9ba05_banner_tr_1629378026496.jpeg",
                "https://i0.wp.com/shiftdelete.net/wp-content/uploads/2022/01/image.png?fit=1280%2C720&ssl=1",
                "https://cdnntr1.img.sputniknews.com/img/104178/86/1041788666_0:0:1200:675_1920x0_80_0_0_f43d22d85332425983572e8210be4efd.jpg",
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQ5sQZBql_dyn88JzrIYO7pyckrfw79jNe7YQ&usqp=CAU"
            };
            SliderCarouselView.ItemsSource = images;

            Device.StartTimer(TimeSpan.FromSeconds(5), (Func<bool>)(() =>
            {
                SliderCarouselView.Position = (SliderCarouselView.Position + 1) % images.Count;
                return true;
            }));
            //getirImages();
        }

        void getirImages()
        {
            getir.ImageSource = "https://cdn3.iconfinder.com/data/icons/spring-2-1/30/Harvest-48.png";
            getirbuyuk.ImageSource = "https://cdn3.iconfinder.com/data/icons/spring-2-1/30/Harvest-48.png";
            getiryemek.ImageSource = "https://cdn3.iconfinder.com/data/icons/spring-2-1/30/Harvest-48.png";
            getircarsi.ImageSource = "https://cdn3.iconfinder.com/data/icons/spring-2-1/30/Harvest-48.png";
            getirsu.ImageSource = "https://cdn3.iconfinder.com/data/icons/spring-2-1/30/Harvest-48.png";
            getirtaksi.ImageSource = "https://cdn3.iconfinder.com/data/icons/spring-2-1/30/Harvest-48.png";
        }
    }
}
