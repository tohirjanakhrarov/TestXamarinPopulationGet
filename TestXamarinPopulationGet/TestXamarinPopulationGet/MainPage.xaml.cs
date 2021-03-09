using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using RestSharp;
using Newtonsoft.Json.Linq;

namespace TestXamarinPopulationGet
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            string country = inpt.Text;
            var client = new RestClient("https://world-population.p.rapidapi.com/population?country_name="+country);
            var request = new RestRequest(Method.GET);
            request.AddHeader("x-rapidapi-key", "7d2f5569ebmshe1f90a801d84a41p1a757djsn0ff6193a1d4a");
            request.AddHeader("x-rapidapi-host", "world-population.p.rapidapi.com");
            IRestResponse response = client.Execute(request);
            var objects = response.Content;
            JObject json = JObject.Parse(objects);
            result_inpt.Text = Convert.ToString(json);
            
        }
    }
}
