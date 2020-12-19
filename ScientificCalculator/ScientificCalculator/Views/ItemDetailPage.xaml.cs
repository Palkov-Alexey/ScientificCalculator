using ScientificCalculator.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ScientificCalculator.Views
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