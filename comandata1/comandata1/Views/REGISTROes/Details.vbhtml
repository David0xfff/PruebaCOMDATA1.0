@ModelType comandata1.REGISTRO
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>REGISTRO</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.APELLIDO)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.APELLIDO)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.DIRECCCION)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.DIRECCCION)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TELEFONO)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TELEFONO)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.SALARIO)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SALARIO)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.AREA)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.AREA)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.FECHA_INGRESO)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.FECHA_INGRESO)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.SEXO)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.SEXO)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.CODIGO)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.CODIGO)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.JEFE)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.JEFE)
        </dd>

        <dt>
            @Html.DisplayNameFor(Function(model) model.TRABAJADOR_A_CARGO)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.TRABAJADOR_A_CARGO)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.NOMBRE }) |
    @Html.ActionLink("Back to List", "Index")
</p>
