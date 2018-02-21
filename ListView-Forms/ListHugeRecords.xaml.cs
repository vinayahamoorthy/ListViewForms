using System;
using System.Collections.Generic;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using Xamarin.Forms;

namespace ListViewForms
{
    public partial class ListHugeRecords : ContentPage
    {
        private List<ListData> listDataValue;
        private JArray json;
        private async void LoadFormData()
        {
            try
            {

                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync("https://api.myjson.com/bins/c1p3p");
                    var responseContent = response.Content;
                    string result = responseContent.ReadAsStringAsync().Result;
                    json = JArray.Parse(result);

                    listDataValue = new List<ListData>();
                    foreach (var item in json)
                    {
                        listDataValue.Add(new ListData
                        {
                            About = item["about"].ToString(),
                            Company = item["company"].ToString(),
                            Greeting = item["greeting"].ToString(),

                        });
                    }
                    listView.ItemsSource = listDataValue;
                }
                System.Diagnostics.Debug.WriteLine("End " + DateTime.Now.ToString("hh:mm:ss"));
            }
            catch (Exception ex)
            {
                //await DisplayAlert("Error", ex.Message.ToString(), "Ok");
            }
        }
        public ListHugeRecords()
        {
            InitializeComponent();
            LoadFormData();
            System.Diagnostics.Debug.WriteLine("Start "+DateTime.Now.ToString("hh:mm:ss"));
        }
    }
}
