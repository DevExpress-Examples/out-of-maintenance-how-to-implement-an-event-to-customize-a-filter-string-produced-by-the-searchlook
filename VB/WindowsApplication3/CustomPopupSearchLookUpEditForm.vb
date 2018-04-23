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

Namespace DXSample

	Public Class CustomPopupSearchLookUpEditForm
		Inherits PopupSearchLookUpEditForm
		Public Sub New(ByVal edit As SearchLookUpEdit)
			MyBase.New(edit)
		End Sub

		Protected Overrides Sub UpdateDisplayFilter(ByVal displayFilter As String)
			Dim args As New DisplayFilterEventArgs(displayFilter)
			Properties.RaiseUpdateDisplayFilter(args)
			MyBase.UpdateDisplayFilter(args.FilterText)
		End Sub

		Public Shadows ReadOnly Property Properties() As RepositoryItemCustomSearchLookUpEdit
			Get
				Return TryCast(MyBase.Properties, RepositoryItemCustomSearchLookUpEdit)
			End Get
		End Property
	End Class

End Namespace