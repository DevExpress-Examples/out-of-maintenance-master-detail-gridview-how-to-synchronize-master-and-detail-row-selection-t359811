@Html.DevExpress().GridView( _
    Sub(settings)
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "GridViewMaster"}
            settings.Name = "gridMaster"
            settings.KeyFieldName = "ID"
            settings.CommandColumn.Visible = True
            settings.CommandColumn.ShowSelectCheckbox = True
            settings.SettingsDetail.ShowDetailRow = True
            settings.Columns.Add("ID")
            settings.Columns.Add("Data")
            settings.ClientSideEvents.SelectionChanged = "gridMaster_SelectionChanged"
            settings.SetDetailRowTemplateContent( _
                Sub(c)
                        Html.RenderAction("GridViewDetail", New With {.ID = DataBinder.Eval(c.DataItem, "ID")})
                End Sub)
    End Sub).Bind(Model).GetHtml()