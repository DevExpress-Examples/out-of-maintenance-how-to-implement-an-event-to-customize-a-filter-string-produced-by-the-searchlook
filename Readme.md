<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128629492/10.2.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3135)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [CustomPopupSearchLookUpEditForm.cs](./CS/WindowsApplication3/CustomPopupSearchLookUpEditForm.cs) (VB: [CustomPopupSearchLookUpEditForm.vb](./VB/WindowsApplication3/CustomPopupSearchLookUpEditForm.vb))
* [CustomSearchLookUpEdit.cs](./CS/WindowsApplication3/CustomSearchLookUpEdit.cs) (VB: [CustomSearchLookUpEdit.vb](./VB/WindowsApplication3/CustomSearchLookUpEdit.vb))
* [DisplayFilterEventArgs.cs](./CS/WindowsApplication3/DisplayFilterEventArgs.cs) (VB: [DisplayFilterEventArgs.vb](./VB/WindowsApplication3/DisplayFilterEventArgs.vb))
* [Main.cs](./CS/WindowsApplication3/Main.cs) (VB: [Main.vb](./VB/WindowsApplication3/Main.vb))
* [Program.cs](./CS/WindowsApplication3/Program.cs) (VB: [Program.vb](./VB/WindowsApplication3/Program.vb))
* [RepositoryItemCustomSearchLookUpEdit.cs](./CS/WindowsApplication3/RepositoryItemCustomSearchLookUpEdit.cs) (VB: [RepositoryItemCustomSearchLookUpEdit.vb](./VB/WindowsApplication3/RepositoryItemCustomSearchLookUpEdit.vb))
<!-- default file list end -->
# How to implement an event to customize a filter string produced by the SearchLookUpEdit


<p>Sometimes it is useful to adjust a string entered in the Find Panel based upon any rules and filter data correspondingly. For instance, if an end-user enters <strong>one two</strong> in the Find Panel data search will be performed according to whether or not  either <strong>one</strong> or  <strong>two</strong>  string is contained  in any search column. To search data against  whole <strong>"</strong><strong>one two</strong><strong>"</strong><strong> </strong>string it is necessary to enclose the filter string in quotes (please review the <a href="http://documentation.devexpress.com/#WindowsForms/CustomDocument8869"><u>Find Panel</u></a> help article to learn all capabilities of the Find Panel). To make this behavior default you can add the quotes to the filter string manually by handling the <strong>SearchLookUpEdit.UpdateDisplayFilter event</strong>. </p><p>This examples illustrates how to implement the SearchLookUpEdit.UpdateDisplayFilter event.</p>

<br/>


