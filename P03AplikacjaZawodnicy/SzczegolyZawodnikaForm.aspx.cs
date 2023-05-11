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
    public partial class SzczegolyZawodnikaForm : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            
            string idStr = Request["id"];
            if (!string.IsNullOrEmpty(idStr) && !Page.IsPostBack)
            {
                int id = Convert.ToInt32(idStr);

                ManagerZawodnikow managerZawodnikow = new ManagerZawodnikow();
                Zawodnik zawodnik = managerZawodnikow.PodajZawodnika(id);

                txtId.Text = Convert.ToString(zawodnik.Id_zawodnika);
                txtImie.Text = zawodnik.Imie;
                txtNazwisko.Text = zawodnik.Nazwisko;
                txtKraj.Text = zawodnik.Kraj;
                txtWaga.Text = Convert.ToString(zawodnik.Waga);
                txtWzrost.Text = Convert.ToString(zawodnik.Wzrost);
                txtDataUr.Text = zawodnik.DataSformatowana;
            }  
        }

        protected void btnZapisz_Click(object sender, EventArgs e)
        {
            Zawodnik zawodnik = new Zawodnik();
            zawodnik.Id_zawodnika = Convert.ToInt32(txtId.Text);
            zawodnik.Imie = txtImie.Text;
            zawodnik.Nazwisko = txtNazwisko.Text;
            zawodnik.Kraj = txtKraj.Text;
            zawodnik.DataUrodzenia = Convert.ToDateTime(txtDataUr.Text);
            zawodnik.Waga = Convert.ToInt32(txtWaga.Text);
            zawodnik.Wzrost = Convert.ToInt32(txtWzrost.Text);

            ManagerZawodnikow managerZawodnikow = new ManagerZawodnikow();
            managerZawodnikow.Edytuj(zawodnik);

            Response.Redirect("Default.aspx");

        }
    }
}