<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128550770/14.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T146962)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/DXWebApplication1/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/DXWebApplication1/Controllers/HomeController.vb))
* **[GridViewPartial.cshtml](./CS/DXWebApplication1/Views/Home/GridViewPartial.cshtml)**
* [Index.cshtml](./CS/DXWebApplication1/Views/Home/Index.cshtml)
<!-- default file list end -->
# GridView - How to track ClientLayout with a separate ListBox
<!-- run online -->
**[[Run Online]](https://codecentral.devexpress.com/t146962/)**
<!-- run online end -->


This example illustrates how to track and apply ClientLayout using a separate ListBox.<br />The main implementation details are:<br />- Handle the <strong>GridViewSettings.CustomJSProperties</strong> event and store the currently applied client layout via the <strong>MVCxGridView.SaveClientLayout</strong> method;<br />- Handle the client-side <strong>ASPxClientGridView Init</strong> and <strong>EndCallback</strong> events, and store the currently applied client layout using a separate ListBox;<br />- Handle the client-side <strong>ASPxClientListBox.SelectedIndexChanged</strong> event and perform a custom GridView callback via the client-side <strong>MVCxClientGridView.PerformCallback</strong> method. Pass the selected client layout as a parameter;<br />- Handle the custom GridView callback via a separate Action method, retrieve the client layout to be applied, and store this value with ViewData;<br />- Handle the <strong>GridViewSettings.BeforeGetCallbackResult</strong> event and check if any client layout should be applied. If so, apply it via <strong>MVCxGridView.LoadClientLayout</strong>.<br /><br /><strong>WebForms Version:</strong><br /><a href="https://www.devexpress.com/Support/Center/p/E2534">How to save/load the ASPxGridView's ClientLayout Data and choose them from the ASPxListBox</a><br /><br /><strong>See Also:</strong><br /><a href="https://www.devexpress.com/Support/Center/p/T205817">T205817: GridView - How to programmatically Save/Load the last ClientLayout within the Session</a>

<br/>


