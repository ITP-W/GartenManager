using System.ComponentModel;
using Xamarin.Forms;
using GartenManager.ViewModels;

namespace GartenManager.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}