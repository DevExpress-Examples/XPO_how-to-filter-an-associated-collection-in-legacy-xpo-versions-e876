Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports Northwind
Imports DevExpress.XtraGrid.Views.Grid

Namespace FilteredAssociation
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub gridView1_MasterRowGetChildList(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs) Handles gridView1.MasterRowGetChildList
			Dim masterGrid As GridView = TryCast(sender, GridView)
			Dim category As Category = CType(masterGrid.GetRow(e.RowHandle), Category)
			e.ChildList = category.AvailableProducts
		End Sub
	End Class
End Namespace