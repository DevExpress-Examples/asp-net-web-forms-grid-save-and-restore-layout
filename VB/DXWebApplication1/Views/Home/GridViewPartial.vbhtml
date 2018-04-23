@Html.DevExpress().GridView( _
    Sub(settings)
            settings.Name = "gv"
            settings.CallbackRouteValues = New With {.Controller = "Home", .Action = "GridViewPartial"}
            settings.CustomActionRouteValues = New With {.Controller = "Home", .Action = "GridViewPartialCustom"}

            settings.Settings.ShowFilterBar = GridViewStatusBarMode.Visible
            settings.Settings.ShowFilterRow = True
            settings.Settings.ShowGroupPanel = True

            settings.KeyFieldName = "ID"
    
            settings.Columns.Add("ID")
            settings.Columns.Add("Text")

            settings.CustomJSProperties = _
                Sub(s, e)
                        Dim gridView As MVCxGridView = CType(s, MVCxGridView)
                        e.Properties("cpClientLayout") = gridView.SaveClientLayout()
                End Sub

            settings.BeforeGetCallbackResult = _
                Sub(s, e)
                        If (ViewData("Layout") IsNot Nothing) Then
                            Dim gridView As MVCxGridView = CType(s, MVCxGridView)
                            gridView.LoadClientLayout(ViewData("Layout").ToString())
                        End If
                End Sub
    
            settings.ClientSideEvents.Init = "OnInit"
            settings.ClientSideEvents.EndCallback = "OnEndCallback"
    
    End Sub).Bind(Model).GetHtml()
