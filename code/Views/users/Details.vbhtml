@ModelType code.user
@Code
    ViewData("Title") = "Details"
End Code

<h2>Details</h2>

<div>
    <h4>user</h4>
    <hr />
    <dl class="dl-horizontal">
        <dt>
            @Html.DisplayNameFor(Function(model) model.password)
        </dt>

        <dd>
            @Html.DisplayFor(Function(model) model.password)
        </dd>

    </dl>
</div>
<p>
    @Html.ActionLink("Edit", "Edit", New With { .id = Model.username }) |
    @Html.ActionLink("Back to List", "Index")
</p>
