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

	Public Delegate Sub UpdateDisplayFilterHandler(ByVal sender As Object, ByVal e As DisplayFilterEventArgs)
	Public Class DisplayFilterEventArgs
		Inherits EventArgs
		Private filterText_Renamed As String
		Public Sub New(ByVal filterText As String)
			Me.filterText_Renamed = filterText
		End Sub
		Public Property FilterText() As String
			Get
				Return filterText_Renamed
			End Get
			Set(ByVal value As String)
				If filterText_Renamed <> value Then
					filterText_Renamed = value
				End If
			End Set
		End Property
	End Class
End Namespace