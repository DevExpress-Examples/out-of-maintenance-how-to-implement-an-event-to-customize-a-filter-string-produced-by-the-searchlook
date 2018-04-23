Imports Microsoft.VisualBasic
Imports System
Namespace DXSample
	Partial Public Class Main
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Me.defaultLookAndFeel1 = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
			Me.customersBindingSource = New System.Windows.Forms.BindingSource(Me.components)
			Me.nwindDataSet = New DXSample.nwindDataSet()
			Me.customersTableAdapter = New DXSample.nwindDataSetTableAdapters.CustomersTableAdapter()
			Me.customSearchLookUpEdit1 = New DXSample.CustomSearchLookUpEdit()
			Me.customSearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customSearchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.customSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' defaultLookAndFeel1
			' 
			Me.defaultLookAndFeel1.LookAndFeel.SkinName = "DevExpress Dark Style"
			' 
			' customersBindingSource
			' 
			Me.customersBindingSource.DataMember = "Customers"
			Me.customersBindingSource.DataSource = Me.nwindDataSet
			' 
			' nwindDataSet
			' 
			Me.nwindDataSet.DataSetName = "nwindDataSet"
			Me.nwindDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
			' 
			' customersTableAdapter
			' 
			Me.customersTableAdapter.ClearBeforeFill = True
			' 
			' customSearchLookUpEdit1
			' 
			Me.customSearchLookUpEdit1.Location = New System.Drawing.Point(105, 99)
			Me.customSearchLookUpEdit1.Name = "customSearchLookUpEdit1"
			Me.customSearchLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
			Me.customSearchLookUpEdit1.Properties.DataSource = Me.customersBindingSource
			Me.customSearchLookUpEdit1.Properties.DisplayMember = "ContactName"
			Me.customSearchLookUpEdit1.Properties.ValueMember = "CustomerID"
			Me.customSearchLookUpEdit1.Properties.View = Me.customSearchLookUpEdit1View
			Me.customSearchLookUpEdit1.Size = New System.Drawing.Size(290, 20)
			Me.customSearchLookUpEdit1.TabIndex = 0
'			Me.customSearchLookUpEdit1.UpdateDisplayFilter += New DXSample.UpdateDisplayFilterHandler(Me.OnUpdateDisplayFilter);
			' 
			' customSearchLookUpEdit1View
			' 
			Me.customSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
			Me.customSearchLookUpEdit1View.Name = "customSearchLookUpEdit1View"
			Me.customSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
			Me.customSearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
			' 
			' Main
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(508, 275)
			Me.Controls.Add(Me.customSearchLookUpEdit1)
			Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
			Me.Name = "Main"
			Me.Text = "CustomSearchLookUpEdit"
'			Me.Load += New System.EventHandler(Me.OnFormLoad);
			CType(Me.customersBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.nwindDataSet, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customSearchLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.customSearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private defaultLookAndFeel1 As DevExpress.LookAndFeel.DefaultLookAndFeel
		Private WithEvents customSearchLookUpEdit1 As CustomSearchLookUpEdit
		Private customSearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
		Private nwindDataSet As nwindDataSet
		Private customersBindingSource As System.Windows.Forms.BindingSource
		Private customersTableAdapter As DXSample.nwindDataSetTableAdapters.CustomersTableAdapter
	End Class
End Namespace

