Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors


Namespace DXSample
	Partial Public Class Main
		Inherits XtraForm
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub OnFormLoad(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			' TODO: This line of code loads data into the 'nwindDataSet.Customers' table. You can move, or remove it, as needed.
			Me.customersTableAdapter.Fill(Me.nwindDataSet.Customers)
		End Sub

		Private Sub OnUpdateDisplayFilter(ByVal sender As Object, ByVal e As DisplayFilterEventArgs) Handles customSearchLookUpEdit1.UpdateDisplayFilter
			If e.FilterText <> String.Empty Then
				e.FilterText = """"c + e.FilterText & """"c
			End If
		End Sub
	End Class
End Namespace
