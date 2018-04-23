Imports Microsoft.VisualBasic
Imports System
Namespace FilteredAssociation
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
			Dim gridLevelNode1 As New DevExpress.XtraGrid.GridLevelNode()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Form1))
			Me.gridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colProductName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDiscontinued = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.xpCollection1 = New DevExpress.Xpo.XPCollection()
			Me.unitOfWork1 = New DevExpress.Xpo.UnitOfWork()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colCategoryID = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCategoryName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colDescription = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.memoEdit1 = New DevExpress.XtraEditors.MemoEdit()
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.unitOfWork1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridView2
			' 
			Me.gridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colProductName, Me.colUnitPrice, Me.colDiscontinued})
			Me.gridView2.GridControl = Me.gridControl1
			Me.gridView2.Name = "gridView2"
			Me.gridView2.OptionsDetail.EnableMasterViewMode = False
			Me.gridView2.OptionsView.ShowGroupPanel = False
			Me.gridView2.ViewCaption = "Available Products"
			' 
			' colProductName
			' 
			Me.colProductName.Caption = "ProductName"
			Me.colProductName.FieldName = "ProductName"
			Me.colProductName.Name = "colProductName"
			Me.colProductName.Visible = True
			Me.colProductName.VisibleIndex = 0
			' 
			' colUnitPrice
			' 
			Me.colUnitPrice.Caption = "UnitPrice"
			Me.colUnitPrice.FieldName = "UnitPrice"
			Me.colUnitPrice.Name = "colUnitPrice"
			Me.colUnitPrice.Visible = True
			Me.colUnitPrice.VisibleIndex = 1
			' 
			' colDiscontinued
			' 
			Me.colDiscontinued.Caption = "Discontinued"
			Me.colDiscontinued.FieldName = "Discontinued"
			Me.colDiscontinued.Name = "colDiscontinued"
			Me.colDiscontinued.Visible = True
			Me.colDiscontinued.VisibleIndex = 2
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.xpCollection1
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			gridLevelNode1.LevelTemplate = Me.gridView2
			gridLevelNode1.RelationName = "Products"
			Me.gridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() { gridLevelNode1})
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(661, 291)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1, Me.gridView2})
			' 
			' xpCollection1
			' 
			Me.xpCollection1.DisplayableProperties = "This;CategoryID;CategoryName;Description;Products"
			Me.xpCollection1.ObjectType = GetType(Northwind.Category)
			Me.xpCollection1.Session = Me.unitOfWork1
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colCategoryID, Me.colCategoryName, Me.colDescription})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.Name = "gridView1"
			Me.gridView1.OptionsView.ShowGroupPanel = False
'			Me.gridView1.MasterRowGetChildList += New DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventHandler(Me.gridView1_MasterRowGetChildList);
			' 
			' colCategoryID
			' 
			Me.colCategoryID.Caption = "CategoryID"
			Me.colCategoryID.FieldName = "CategoryID"
			Me.colCategoryID.Name = "colCategoryID"
			Me.colCategoryID.OptionsColumn.ReadOnly = True
			Me.colCategoryID.Visible = True
			Me.colCategoryID.VisibleIndex = 0
			' 
			' colCategoryName
			' 
			Me.colCategoryName.Caption = "CategoryName"
			Me.colCategoryName.FieldName = "CategoryName"
			Me.colCategoryName.Name = "colCategoryName"
			Me.colCategoryName.Visible = True
			Me.colCategoryName.VisibleIndex = 1
			' 
			' colDescription
			' 
			Me.colDescription.Caption = "Description"
			Me.colDescription.FieldName = "Description"
			Me.colDescription.Name = "colDescription"
			Me.colDescription.Visible = True
			Me.colDescription.VisibleIndex = 2
			' 
			' memoEdit1
			' 
			Me.memoEdit1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.memoEdit1.EditValue = resources.GetString("memoEdit1.EditValue")
			Me.memoEdit1.Location = New System.Drawing.Point(0, 291)
			Me.memoEdit1.Name = "memoEdit1"
			Me.memoEdit1.Size = New System.Drawing.Size(661, 102)
			Me.memoEdit1.TabIndex = 1
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(661, 393)
			Me.Controls.Add(Me.gridControl1)
			Me.Controls.Add(Me.memoEdit1)
			Me.Name = "Form1"
			Me.Text = "View available products in each category"
			CType(Me.gridView2, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.xpCollection1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.unitOfWork1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.memoEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private xpCollection1 As DevExpress.Xpo.XPCollection
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private unitOfWork1 As DevExpress.Xpo.UnitOfWork
		Private gridView2 As DevExpress.XtraGrid.Views.Grid.GridView
		Private colCategoryID As DevExpress.XtraGrid.Columns.GridColumn
		Private colCategoryName As DevExpress.XtraGrid.Columns.GridColumn
		Private colDescription As DevExpress.XtraGrid.Columns.GridColumn
		Private colProductName As DevExpress.XtraGrid.Columns.GridColumn
		Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn
		Private colDiscontinued As DevExpress.XtraGrid.Columns.GridColumn
		Private memoEdit1 As DevExpress.XtraEditors.MemoEdit
	End Class
End Namespace

