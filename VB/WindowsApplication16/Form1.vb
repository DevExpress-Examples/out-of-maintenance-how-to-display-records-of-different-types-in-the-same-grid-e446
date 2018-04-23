Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Layout

Namespace WindowsApplication16
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub layoutView1_CustomUnboundColumnData(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.CustomColumnDataEventArgs) Handles layoutView1.CustomUnboundColumnData
			Dim view As LayoutView = TryCast(sender, LayoutView)
			Dim list As BindingList(Of Person) = TryCast(view.DataSource, BindingList(Of Person))
			Dim p As Person = list(e.ListSourceRowIndex)
			If e.Column.FieldName = "Title" Then
				Dim emp As Employee = TryCast(p, Employee)
				If emp IsNot Nothing Then
					If e.IsGetData Then
						e.Value = (TryCast(p, Employee)).Title
					End If
				End If
			End If
			If e.Column.FieldName = "TotalTurnover" Then
				Dim cust As Customer = TryCast(p, Customer)
				If cust IsNot Nothing Then
					If e.IsGetData Then
						e.Value = (TryCast(p, Customer)).TotalTurnover
					End If
				End If
			End If
		End Sub


		Private Sub layoutView1_CustomCardLayout(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Layout.Events.LayoutViewCustomCardLayoutEventArgs) Handles layoutView1.CustomCardLayout
			Dim view As LayoutView = TryCast(sender, LayoutView)
			Dim p As Person = TryCast(view.GetRow(e.RowHandle), Person)
			Dim colTitleName As String = view.Columns("Title").LayoutViewField.Name
			Dim colTotalTurnover As String = view.Columns("TotalTurnover").LayoutViewField.Name
			If p.GetType() Is GetType(Employee) Then
				e.CardDifferences.AddItemDifference(colTitleName, LayoutItemDifferenceType.ItemVisibility, True)
				e.CardDifferences.AddItemDifference(colTotalTurnover, LayoutItemDifferenceType.ItemVisibility, False)
			End If
			If p.GetType() Is GetType(Customer) Then
				e.CardDifferences.AddItemDifference(colTitleName, LayoutItemDifferenceType.ItemVisibility, False)
				e.CardDifferences.AddItemDifference(colTotalTurnover, LayoutItemDifferenceType.ItemVisibility, True)
			End If

		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim list As BindingList(Of Person) = New BindingList(Of Person)()
			list.Add(New Employee())
			list.Add(New Customer())
			gridControl1.DataSource = list
			layoutView1.OptionsBehavior.Editable = False
		End Sub
	End Class

	Friend Class Person
		Public ReadOnly Property Name() As String
			Get
				Return "Person Name"
			End Get
		End Property
	End Class

	Friend Class Employee
		Inherits Person
		Public ReadOnly Property Title() As String
			Get
				Return "Title"
			End Get
		End Property
	End Class

	Friend Class Customer
		Inherits Person
		Public ReadOnly Property TotalTurnover() As Decimal
			Get
				Return 3000
			End Get
		End Property
	End Class
End Namespace