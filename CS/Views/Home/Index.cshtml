<script type="text/javascript">
    function gridMaster_SelectionChanged(s, e) {
        var key = s.GetRowKey(e.visibleIndex);
        var detailGridName = "gridDetail" + key;
        var detailGrid = ASPxClientControl.GetControlCollection().GetByName(detailGridName);

        if (detailGrid != null) {
            if (s.IsRowSelectedOnPage(e.visibleIndex))
                detailGrid.SelectRows();
            else
                detailGrid.UnselectRows();
        }
    }

    function gridDetail_Init(s, e) {
        var selectedKeys = gridMaster.GetSelectedKeysOnPage();

        for (var i = 0; i < selectedKeys.length; i++) {
            if (selectedKeys[i] == s.cpMasterRowKey) {
                s.SelectRows();
                break;
            }
        }
    }

    function gridDetail_SelectionChanged(s, e) {
        var totalSelectedCount = GetSelectedFilteredRowCount(s);
        var isEverythingSelected = s.cpVisibleRowCount == totalSelectedCount;

        if (isEverythingSelected)
            gridMaster.SelectRowsByKey(s.cpMasterRowKey);
        else
            gridMaster.UnselectRowsByKey(s.cpMasterRowKey);
    }

    function GetSelectedFilteredRowCount(grid) {
        return grid.cpFilteredRowCountWithoutPage + grid.GetSelectedKeysOnPage().length;
    }
</script>

@Html.Action("GridViewMaster")