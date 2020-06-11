@Code
    ViewData("Title") = "Home Page"
End Code

<div class="jumbotron">
    <h1>Comdata</h1>
    
</div>

<div class="row">
    <div class="col-md-4">
        <h2>@Html.ActionLink("Registro", "index", "REGISTROes")</h2>
        <p>
            pretende sistematizar el proceso de registro de personas que trabajan para Comdata.
        </p>
        <p><a class="btn btn-default" @Html.ActionLink("Registrar nuevo usuario", "index", "REGISTROes") </a></p>
    </div>
  
  
</div>
