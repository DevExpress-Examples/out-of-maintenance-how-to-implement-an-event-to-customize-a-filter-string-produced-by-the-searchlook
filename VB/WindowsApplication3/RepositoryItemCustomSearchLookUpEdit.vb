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
	<UserRepositoryItem("RegisterCustomEdit")> _
	Public Class RepositoryItemCustomSearchLookUpEdit
		Inherits RepositoryItemSearchLookUpEdit
		Private Shared ReadOnly _updateDisplayFilter As Object = New Object()

		Shared Sub New()
			RegisterCustomEdit()
		End Sub

		Public Sub New()
		End Sub

		Public Const CustomEditName As String = "CustomSearchLookUpEdit"

		Public Overrides ReadOnly Property EditorTypeName() As String
			Get
				Return CustomEditName
			End Get
		End Property

		Public Shared Sub RegisterCustomEdit()
			Dim img As Image = Nothing
			Try
				img = CType(Bitmap.FromStream(System.Reflection.Assembly.GetExecutingAssembly(). GetManifestResourceStream("DevExpress.CustomEditors.CustomEdit.bmp")), Bitmap)
			Catch
			End Try
			EditorRegistrationInfo.Default.Editors.Add(New EditorClassInfo(CustomEditName, GetType(CustomSearchLookUpEdit), GetType(RepositoryItemCustomSearchLookUpEdit), GetType(SearchLookUpEditBaseViewInfo), New ButtonEditPainter(), True, img))
		End Sub

		Public Custom Event UpdateDisplayFilter As UpdateDisplayFilterHandler
			AddHandler(ByVal value As UpdateDisplayFilterHandler)
				Me.Events.AddHandler(_updateDisplayFilter, value)
			End AddHandler
			RemoveHandler(ByVal value As UpdateDisplayFilterHandler)
				Me.Events.RemoveHandler(_updateDisplayFilter, value)
			End RemoveHandler
			RaiseEvent(ByVal sender As Object, ByVal e As DisplayFilterEventArgs)
			End RaiseEvent
		End Event

		Protected Friend Overridable Sub RaiseUpdateDisplayFilter(ByVal e As DisplayFilterEventArgs)
			Dim handler As UpdateDisplayFilterHandler = CType(Events(_updateDisplayFilter), UpdateDisplayFilterHandler)
			If handler IsNot Nothing Then
				handler(GetEventSender(), e)
			End If
		End Sub

		Public Overrides Sub Assign(ByVal item As RepositoryItem)
			MyBase.Assign(item)
			Dim source As RepositoryItemCustomSearchLookUpEdit = TryCast(item, RepositoryItemCustomSearchLookUpEdit)
			Events.AddHandler(_updateDisplayFilter, source.Events(_updateDisplayFilter))
		End Sub
	End Class
End Namespace