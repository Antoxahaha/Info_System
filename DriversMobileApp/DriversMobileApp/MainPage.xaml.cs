using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Services.Maps;
using Windows.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Maps;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


// Документацию по шаблону элемента "Пустая страница" см. по адресу https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x419

namespace DriversMobileApp
{
    /// <summary>
    /// Пустая страница, которую можно использовать саму по себе или для перехода внутри фрейма.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ServiceReference1.Service1Client client;
        List<RoutesClass> routes = new List<RoutesClass>();
        string[,] Routes;
        double Sh1 = 0;
        double Dol1 = 0;
        List<int> indexes = new List<int>();
        double ShStock = 54.78465934;
        double DolStock = 32.04519071;

        public MainPage()
        {
            this.InitializeComponent();
            client = new ServiceReference1.Service1Client();
            SelectRoutes();
              Sh1 = ShStock;
              Dol1 = DolStock;
        }
        private async void SelectRoutes()
        {
            routes.Clear();
            int y = 0;
            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();
            var result = await client.Select_SendingAsync();
            Routes = new string[result.Count,9];
            for(int i=0;i< result.Count;i++)
            {
                RoutesClass rc = new RoutesClass();
                rc.id = result[i].Id;
                rc.NameFirm = result[i].NameFirm.ToString();
               rc.NameModel = result[i].NameModel.ToString();
                rc.VonderCode = result[i].VonderCode.ToString();
                rc.Count = result[i].Count.ToString();
                rc.Address= result[i].Address.ToString();
                rc.Shirota= result[i].Shirota.ToString();
               rc.Dolgota = result[i].Dolgota.ToString();
                rc.Status = result[i].Status.ToString();                 
                routes.Add(rc);
            }
             InitCombo();
        }
        private void InitCombo()
        {
            List<string> list = new List<string>();
            for (int i = 0; i < routes.Count; i++)
            {
               if(routes[i].Status.Contains("Отправлено"))
                {
                    list.Add(routes[i].Address);                 
                }
            }
            list = list.Distinct().ToList();
            comboroutes.Items.Clear();
            comboroutes.SelectedValue = "";
            for (int i=0;i<list.Count;i++)
            {
                comboroutes.Items.Add(list[i]);
            }
   
        }
        private async void ShowRouteOnMap(double latStart, double logtStart, double latEnd, double logtEnd)
        {
            mapcontrol.Routes.Clear();
            mapcontrol.MapServiceToken = "lAejNL4aylv9Og9xHESA~AjORsxlQB1z3VeNkvudRVw~AhywFw6FejFc2FQLtjWsyy6vzQ2KOHKv5zGIRI4jmAhIjzw2jaS6VMm1T_f9dB1i";
            BasicGeoposition startLocation = new BasicGeoposition()
            { Latitude = latStart, Longitude = logtStart };
            BasicGeoposition endLocation = new BasicGeoposition()
            { Latitude = latEnd, Longitude = logtEnd };
            MapRouteFinderResult routeResult =
                  await MapRouteFinder.GetDrivingRouteAsync(
                  new Geopoint(startLocation),
                  new Geopoint(endLocation),
                  MapRouteOptimization.Time,
                  MapRouteRestrictions.None);
            if (routeResult.Status == MapRouteFinderStatus.Success)
            {
                MapRouteView viewOfRoute = new MapRouteView(routeResult.Route);
                viewOfRoute.RouteColor = Colors.Red;
                viewOfRoute.OutlineColor = Colors.Black;
                mapcontrol.Routes.Add(viewOfRoute);
                await mapcontrol.TrySetViewBoundsAsync(
                      routeResult.Route.BoundingBox,
                      null,
                      Windows.UI.Xaml.Controls.Maps.MapAnimationKind.None);
            }
        }
        string helpstr = "";
        private void comboroutes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            indexes.Clear();
            Lists.Items.Clear();
            double Sh2 = 0;
            double Dol2 = 0;
            if (comboroutes.SelectedValue!=null)
            {
                for (int i = 0; i < routes.Count; i++)
                {
                    if (routes[i].Status.Contains("Отправлено"))
                    {
                        if (comboroutes.SelectedValue.Equals(routes[i].Address))
                        {
                            indexes.Add(i);
                            helpstr = routes[i].Status;
                        }
                    }
                }
                int ind = indexes[0];
                if (routes[ind].Shirota.Contains('.'))
                {
                    string[] s = routes[ind].Shirota.Split('.');
                    routes[ind].Shirota = s[0] + "," + s[1];
                }
                if (routes[ind].Dolgota.Contains('.'))
                {
                    string[] s = routes[ind].Dolgota.Split('.');
                    routes[ind].Dolgota = s[0] + "," + s[1];
                }
                Sh2 = Convert.ToDouble(routes[ind].Shirota);
                Dol2 = Convert.ToDouble(routes[ind].Dolgota);
                ShowRouteOnMap(Sh1, Dol1, Sh2, Dol2);
                Sh1 = Sh2;
                Dol1 = Dol2;
           for (int i=0;i< indexes.Count;i++)
                {
                    int t = indexes[i];
                    Lists.Items.Add("Фирма: "+routes[t].NameFirm + "\n"+ "Модель: " + routes[t].NameModel + "\n"+"Артикул: "  + routes[t].VonderCode + "\n"+ "Количество: " + routes[t].Count);
                }
            }else
            {
                Sh1 = 54.78465934;
                Dol1 = 32.04519071;
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {        
            SelectRoutes();
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            Upd();
            SelectRoutes();
        }
        private async  void Upd()
        {
            client = new ServiceReference1.Service1Client();    
            ServiceReference1.Sending s = new ServiceReference1.Sending();
                for (int i=0;i< indexes.Count;i++)
                {
                    int y = indexes[i];
                     s.Id = routes[y].id;
                    s.NameFirm = routes[y].NameFirm;
                    s.NameModel = routes[y].NameModel;
                    s.VonderCode = routes[y].VonderCode;
                    s.Count = Convert.ToInt32(routes[y].Count);
                    s.Address = routes[y].Address;
                    s.Status = "Доставлено"; 
                    s.TimeOfSend = "Не получено";
                  await  client.Update_SendingAsync(s.VonderCode, s.Address, helpstr, s.Id, s);
                }          
        }
    }
}
