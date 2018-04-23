<script type="text/javascript">
    function OnInit(s, e) {
        TrackLayout(s.cpClientLayout);
    }
    function OnEndCallback(s, e) {
        TrackLayout(s.cpClientLayout);
    }
    function TrackLayout(layout) {
        if (!lb.FindItemByValue(layout))
            lb.AddItem(layout);
        lb.SetValue(layout);
    }
    function OnSelectedIndexChanged(s, e) {
        gv.PerformCallback({ layoutToApply : s.GetValue() });
    }
</script>

@Html.DevExpress().ListBox( _
    Sub(settings)
            settings.Name = "lb"
            settings.Properties.EnableClientSideAPI = True
            settings.Properties.ClientSideEvents.SelectedIndexChanged = "OnSelectedIndexChanged"
    End Sub).GetHtml()

@Html.Action("GridViewPartial")