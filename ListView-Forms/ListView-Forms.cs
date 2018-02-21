using System;

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
            await Current.MainPage.Navigation.PushAsync(new ListHugeRecords());
        }
        protected override void OnStart()
        {
            // Handle when your app starts
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
