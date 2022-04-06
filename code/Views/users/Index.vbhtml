@ModelType IEnumerable(Of code.user)
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
            @Html.DisplayNameFor(Function(model) model.username)
        </th>
        <th>
            @Html.DisplayNameFor(Function(model) model.password)
        </th>
        <th></th>
    </tr>

@For Each item In Model
    @<tr>
    <td>
        @Html.DisplayFor(Function(modelItem) item.username)
    </td>
    <td>
        @Html.DisplayFor(Function(modelItem) item.password)
    </td>
    <td>
        @Html.ActionLink("Edit", "Edit", New With {.id = item.username}) |
        @Html.ActionLink("Details", "Details", New With {.id = item.username}) |
        @Html.ActionLink("Delete", "Delete", New With {.id = item.username})
    </td>
</tr>
Next

</table>
