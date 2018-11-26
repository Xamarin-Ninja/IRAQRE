using IRAQRE.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace IRAQRE.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HomePage : ContentPage
	{
        public ObservableCollection<LanguagePickerModel> languagePickerItems = new ObservableCollection<LanguagePickerModel>();
		public HomePage ()
		{
			InitializeComponent ();
            languagePickerItems.Add(new LanguagePickerModel
            {
                LanguageName = "Hindi",
                //FlagUrl = "https://www.countryflags.io/in/flat/64.png"
            });
            languagePickerItems.Add(new LanguagePickerModel
            {
                LanguageName = "Chinese",
                //FlagUrl = "https://www.countryflags.io/cn/flat/64.png"
            });
            languagePickerItems.Add(new LanguagePickerModel
            {
                LanguageName = "Kurdish",
                //FlagUrl = "https://www.countryflags.io/iq/flat/64.png"
            });
            LanguagePicker.ItemsSource = languagePickerItems;
        }
	}
}