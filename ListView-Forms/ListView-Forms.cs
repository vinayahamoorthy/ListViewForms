using System;
using Microsoft.AppCenter;
using Microsoft.AppCenter.Analytics;
using Microsoft.AppCenter.Crashes;
using Xamarin.Forms;

namespace ListViewForms
{
    public class App : Application
    {
        public App()
        {
            Button button = new Button
            {
                Text = "Click Me!",
                Font = Font.SystemFontOfSize(NamedSize.Large),
                BorderWidth = 1,
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.CenterAndExpand
            };
            button.Clicked += OnButtonClicked;

            // The root page of your application
            var content = new ContentPage
            {
                Title = "ListView-Forms",
                Content = new StackLayout
                {
                    VerticalOptions = LayoutOptions.Center,
                    Children = {
                        button
                    }
                }
            };

            MainPage = new NavigationPage(content);
        }
        async void OnButtonClicked(object sender, EventArgs e)
        {
            Analytics.TrackEvent("Home Page");
            await Current.MainPage.Navigation.PushAsync(new ListHugeRecords());
           // throw new NotImplementedException();
        }
        protected override void OnStart()
        {
            // Handle when your app starts

            AppCenter.Start("ios=fb6a1462-bfb5-4383-b56f-13d3e8a26419;" + "uwp={Your UWP App secret here};" + "android={Your Android App secret here}", typeof(Analytics), typeof(Crashes));
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
