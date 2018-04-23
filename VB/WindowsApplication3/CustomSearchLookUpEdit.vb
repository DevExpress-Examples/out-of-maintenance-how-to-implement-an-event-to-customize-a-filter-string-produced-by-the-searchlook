Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Skins
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraEditors.Registrator
Imports System.Drawing
Imports DevExpress.XtraEditors.ViewInfo
Imports DevExpress.XtraEditors.Drawing
Imports DevExpress.XtraEditors
Imports System.ComponentModel
Imports DevExpress.XtraEditors.Popup
Imports System.Reflection

Namespace DXSample

	Public Class CustomSearchLookUpEdit
		Inherits SearchLookUpEdit
		Shared Sub New()
			RepositoryItemCustomSearchLookUpEdit.RegisterCustomEdit()
		End Sub

		Public Sub New()
		End Sub

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return RepositoryItemCustomSearchLookUpEdit.CustomEditName
			End Get
		End Property

		<DesignerSerializationVisibility(DesignerSerializationVisibility.Content)> _
		Public Shadows ReadOnly Property Properties() As RepositoryItemCustomSearchLookUpEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemCustomSearchLookUpEdit)
			End Get
		End Property

		  Protected Overrides Function CreatePopupForm() As DevExpress.XtraEditors.Popup.PopupBaseForm
			Return New CustomPopupSearchLookUpEditForm(Me)
		  End Function

		Public Custom Event UpdateDisplayFilter As UpdateDisplayFilterHandler
			AddHandler(ByVal value As UpdateDisplayFilterHandler)
				AddHandler Me.Properties.UpdateDisplayFilter, value
			End AddHandler
			RemoveHandler(ByVal value As UpdateDisplayFilterHandler)
				RemoveHandler Me.Properties.UpdateDisplayFilter, value
			End RemoveHandler
			RaiseEvent(ByVal sender As Object, ByVal e As DisplayFilterEventArgs)
			End RaiseEvent
		End Event
	End Class
End Namespace