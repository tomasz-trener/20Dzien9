<%@ Page Language="C#" MasterPageFile="~/Glowny.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="P03AplikacjaZawodnicy.Default" %>


<asp:Content ID="Content1" ContentPlaceHolderID="content" runat="server">
 <div class="row">
    <div class="col-md-12">
        <div class="card">
            <div class="card-header">
                <h4 class="card-title">Simple Table</h4>
            </div>
            <div class="card-body">
                <div class="table-responsive">
                    <table class="table">
                        <thead class=" text-primary">
                            <th>Nazwa
                      </th>
                            <th>Kraj
                      </th>
                            <th>Data urodzenia
                      </th>
                            <th>Wzrost
                      </th>
                            <th>Waga
                            </th>
                        </thead>
                        <tbody>

                            <%

                                foreach (var z in Zawodnicy)
                                {%>

                            <tr>
                                <td><%= z.Imie + " " + z.Nazwisko %></td>
                                <td><%= z.Kraj %></td>
                                <td><%= z.DataSformatowana %></td>
                                <td><%= z.Wzrost %></td>
                                <td><%= z.Waga %></td>
                            </tr>

                            <%}

                            %>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>

</div>

</asp:Content>




