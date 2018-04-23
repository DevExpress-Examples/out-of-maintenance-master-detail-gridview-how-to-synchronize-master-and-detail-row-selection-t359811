@functions
    Private Function GetFilteredRowCountWithoutPage(ByVal grid As MVCxGridView) As Integer
        Dim selectedRowsOnPage As Integer = 0
        Dim key As Object
        For Each key In grid.GetCurrentPageRowValues("ID")
            If grid.Selection.IsRowSelectedByKey(key) Then
                selectedRowsOnPage += 1
            End If
        Next key
        Return grid.Selection.FilteredCount - selectedRowsOnPage
    End Function
End Functions 

@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "gridDetail" + ViewData("ID")
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "GridViewDetail", .ID = ViewData("ID")}
            settings.Width = System.Web.UI.WebControls.Unit.Percentage(100)
            settings.KeyFieldName = "ID"
            settings.SettingsDetail.MasterGridName = "gridMaster"
            settings.CommandColumn.Visible = True
            settings.CommandColumn.ShowSelectCheckbox = True
            settings.Columns.Add("ID")
            settings.Columns.Add("Data")
            settings.ClientSideEvents.Init = "gridDetail_Init"
            settings.ClientSideEvents.SelectionChanged = "gridDetail_SelectionChanged"

            settings.CustomJSProperties = _
                        Sub(s, e)
                                Dim grid As MVCxGridView = CType(s, MVCxGridView)
                                e.Properties("cpVisibleRowCount") = grid.VisibleRowCount
                                e.Properties("cpFilteredRowCountWithoutPage") = GetFilteredRowCountWithoutPage(grid)
                                e.Properties("cpMasterRowKey") = ViewData("ID")
                        End Sub
    End Sub).Bind(Model).GetHtml()