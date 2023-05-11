using P02Biblioteka;
using P02Biblioteka.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P01AplikacjeWeboweWstep
{
    public partial class ZawodnicyFormularz : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ManagerZawodnikow mz = new ManagerZawodnikow();
            Zawodnik[] zawodnicy=  mz.WczytajZawodnikow();

            foreach (var zawodnik in zawodnicy)
            {
                lbDane.Items.Add(zawodnik.ImieNazwiskoKraj);
            }


        }
    }
}