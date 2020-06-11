@ModelType IEnumerable(Of comandata1.REGISTRO)
@Code
ViewData("Title") = "Index"
End Code

<h2>Index</h2>

<p>
    @Html.ActionLink("Create New", "Create")
</p>
<table class="table">
    <tr>
        <th>
            @Html.DisplayNameFor(Function(model) model.APELLIDO)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.DIRECCCION)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TELEFONO)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.SALARIO)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.AREA)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.FECHA_INGRESO)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.SEXO)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.CODIGO)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.JEFE)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.TRABAJADOR_A_CARGO)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
        <td>
            @Html.DisplayFor(Function(modelItem) item.APELLIDO)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.DIRECCCION)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TELEFONO)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.SALARIO)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.AREA)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.FECHA_INGRESO)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.SEXO)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.CODIGO)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.JEFE)
        </td>
        <td>
            @Html.DisplayFor(Function(modelItem) item.TRABAJADOR_A_CARGO)
        </td>
        <td>
            @Html.ActionLink("Edit", "Edit", New With {.id = item.NOMBRE }) |
            @Html.ActionLink("Details", "Details", New With {.id = item.NOMBRE }) |
            @Html.ActionLink("Delete", "Delete", New With {.id = item.NOMBRE })
        </td>
    </tr>
Next

</table>
