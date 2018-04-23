Imports Microsoft.VisualBasic
Imports System
Namespace WindowsApplication16
	Partial Public Class Form1
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
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.layoutView1 = New DevExpress.XtraGrid.Views.Layout.LayoutView()
			Me.colName = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_layoutViewColumn1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.title = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.layoutViewField_layoutViewColumn2 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.totalTurnover = New DevExpress.XtraGrid.Columns.LayoutViewColumn()
			Me.repositoryItemSpinEdit1 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
			Me.layoutViewField_layoutViewColumn3 = New DevExpress.XtraGrid.Views.Layout.LayoutViewField()
			Me.layoutViewCard1 = New DevExpress.XtraGrid.Views.Layout.LayoutViewCard()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_layoutViewColumn1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_layoutViewColumn2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewField_layoutViewColumn3, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.EmbeddedNavigator.Name = ""
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.layoutView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() { Me.repositoryItemSpinEdit1})
			Me.gridControl1.Size = New System.Drawing.Size(543, 324)
			Me.gridControl1.TabIndex = 1
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.layoutView1})
			' 
			' layoutView1
			' 
			Me.layoutView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.LayoutViewColumn() { Me.colName, Me.title, Me.totalTurnover})
			Me.layoutView1.GridControl = Me.gridControl1
			Me.layoutView1.Name = "layoutView1"
			Me.layoutView1.OptionsView.ViewMode = DevExpress.XtraGrid.Views.Layout.LayoutViewMode.Row
			Me.layoutView1.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways
			Me.layoutView1.TemplateCard = Me.layoutViewCard1
'			Me.layoutView1.CustomCardLayout += New DevExpress.XtraGrid.Views.Layout.Events.LayoutViewCustomCardLayoutEventHandler(Me.layoutView1_CustomCardLayout);
'			Me.layoutView1.CustomUnboundColumnData += New DevExpress.XtraGrid.Views.Base.CustomColumnDataEventHandler(Me.layoutView1_CustomUnboundColumnData);
			' 
			' colName
			' 
			Me.colName.Caption = "Name"
			Me.colName.FieldName = "Name"
			Me.colName.LayoutViewField = Me.layoutViewField_layoutViewColumn1
			Me.colName.Name = "colName"
			' 
			' layoutViewField_layoutViewColumn1
			' 
			Me.layoutViewField_layoutViewColumn1.EditorPreferredWidth = 10
			Me.layoutViewField_layoutViewColumn1.Location = New System.Drawing.Point(0, 0)
			Me.layoutViewField_layoutViewColumn1.Name = "layoutViewField_layoutViewColumn1"
			Me.layoutViewField_layoutViewColumn1.Size = New System.Drawing.Size(123, 27)
			Me.layoutViewField_layoutViewColumn1.TextLocation = DevExpress.Utils.Locations.Left
			Me.layoutViewField_layoutViewColumn1.TextSize = New System.Drawing.Size(72, 20)
			' 
			' title
			' 
			Me.title.Caption = "Title"
			Me.title.FieldName = "Title"
			Me.title.LayoutViewField = Me.layoutViewField_layoutViewColumn2
			Me.title.Name = "title"
			Me.title.UnboundType = DevExpress.Data.UnboundColumnType.String
			' 
			' layoutViewField_layoutViewColumn2
			' 
			Me.layoutViewField_layoutViewColumn2.EditorPreferredWidth = 10
			Me.layoutViewField_layoutViewColumn2.Location = New System.Drawing.Point(0, 27)
			Me.layoutViewField_layoutViewColumn2.Name = "layoutViewField_layoutViewColumn2"
			Me.layoutViewField_layoutViewColumn2.Size = New System.Drawing.Size(123, 27)
			Me.layoutViewField_layoutViewColumn2.TextLocation = DevExpress.Utils.Locations.Left
			Me.layoutViewField_layoutViewColumn2.TextSize = New System.Drawing.Size(72, 20)
			' 
			' totalTurnover
			' 
			Me.totalTurnover.Caption = "TotalTurnover"
			Me.totalTurnover.ColumnEdit = Me.repositoryItemSpinEdit1
			Me.totalTurnover.FieldName = "TotalTurnover"
			Me.totalTurnover.LayoutViewField = Me.layoutViewField_layoutViewColumn3
			Me.totalTurnover.Name = "totalTurnover"
			Me.totalTurnover.UnboundType = DevExpress.Data.UnboundColumnType.Decimal
			' 
			' repositoryItemSpinEdit1
			' 
			Me.repositoryItemSpinEdit1.AutoHeight = False
			Me.repositoryItemSpinEdit1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() { New DevExpress.XtraEditors.Controls.EditorButton()})
			Me.repositoryItemSpinEdit1.Name = "repositoryItemSpinEdit1"
			' 
			' layoutViewField_layoutViewColumn3
			' 
			Me.layoutViewField_layoutViewColumn3.EditorPreferredWidth = 10
			Me.layoutViewField_layoutViewColumn3.Location = New System.Drawing.Point(0, 54)
			Me.layoutViewField_layoutViewColumn3.Name = "layoutViewField_layoutViewColumn3"
			Me.layoutViewField_layoutViewColumn3.Size = New System.Drawing.Size(123, 27)
			Me.layoutViewField_layoutViewColumn3.TextLocation = DevExpress.Utils.Locations.Left
			Me.layoutViewField_layoutViewColumn3.TextSize = New System.Drawing.Size(72, 20)
			' 
			' layoutViewCard1
			' 
			Me.layoutViewCard1.CustomizationFormText = "layoutViewTemplateCard"
			Me.layoutViewCard1.ExpandButtonLocation = DevExpress.Utils.GroupElementLocation.AfterText
			Me.layoutViewCard1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() { Me.layoutViewField_layoutViewColumn1, Me.layoutViewField_layoutViewColumn2, Me.layoutViewField_layoutViewColumn3})
			Me.layoutViewCard1.Name = "layoutViewTemplateCard"
			Me.layoutViewCard1.Text = "layoutViewTemplateCard"
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(543, 324)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_layoutViewColumn1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_layoutViewColumn2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.repositoryItemSpinEdit1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewField_layoutViewColumn3, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.layoutViewCard1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents layoutView1 As DevExpress.XtraGrid.Views.Layout.LayoutView
		Private colName As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_layoutViewColumn1 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private title As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private layoutViewField_layoutViewColumn2 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private totalTurnover As DevExpress.XtraGrid.Columns.LayoutViewColumn
		Private repositoryItemSpinEdit1 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
		Private layoutViewField_layoutViewColumn3 As DevExpress.XtraGrid.Views.Layout.LayoutViewField
		Private layoutViewCard1 As DevExpress.XtraGrid.Views.Layout.LayoutViewCard

	End Class
End Namespace

