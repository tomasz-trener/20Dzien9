using P02Biblioteka;
using P02Biblioteka.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace P03AplikacjaZawodnicy
{
    public partial class Default : System.Web.UI.Page
    {
        public Zawodnik[] Zawodnicy;
        protected void Page_Load(object sender, EventArgs e)
        {
            ManagerZawodnikow managerZawodnikow = new ManagerZawodnikow();
            Zawodnicy = managerZawodnikow.WczytajZawodnikow();
        }
    }
}