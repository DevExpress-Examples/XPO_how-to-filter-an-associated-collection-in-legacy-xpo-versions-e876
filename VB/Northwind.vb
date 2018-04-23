Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Namespace Northwind

	<Persistent("Categories")> _
	Public Class Category
		Inherits XPLiteObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		<Key(True), Persistent("CategoryID")> _
		Private fCategoryID As Integer = -1

		<PersistentAlias("fCategoryID")> _
		Public ReadOnly Property CategoryID() As Integer
			Get
				Return fCategoryID
			End Get
		End Property
		Private fCategoryName As String
		Public Property CategoryName() As String
			Get
				Return fCategoryName
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("CategoryName", fCategoryName, value)
			End Set
		End Property
		Private fDescription As String
		Public Property Description() As String
			Get
				Return fDescription
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("Description", fDescription, value)
			End Set
		End Property

		<Association("ProductCategories")> _
		Public ReadOnly Property Products() As XPCollection(Of Product)
			Get
				Return GetCollection(Of Product)("Products")
			End Get
		End Property

		' a filtered collection
		Public ReadOnly Property AvailableProducts() As XPCollection(Of Product)
			Get
				Dim filter As CriteriaOperator = New OperandProperty("Discontinued") <> New OperandValue(True)
				Return New XPCollection(Of Product)(Me.Products, filter)
			End Get
		End Property
	End Class

	<Persistent("Products")> _
	Public Class Product
		Inherits XPLiteObject
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub

		<Key(True), Persistent("ProductID")> _
		Private fProductID As Integer = -1

		<PersistentAlias("fProductID")> _
		Public ReadOnly Property ProductID() As Integer
			Get
				Return fProductID
			End Get
		End Property

		Private fProductName As String
		Public Property ProductName() As String
			Get
				Return fProductName
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("ProductName", fProductName, value)
			End Set
		End Property

		Private fCategory As Category
		<Persistent("CategoryID"), Association("ProductCategories")> _
		Public Property Category() As Category
			Get
				Return fCategory
			End Get
			Set(ByVal value As Category)
				SetPropertyValue(Of Category)("Category", fCategory, value)
			End Set
		End Property

		Private fUnitPrice As Decimal
		Public Property UnitPrice() As Decimal
			Get
				Return fUnitPrice
			End Get
			Set(ByVal value As Decimal)
				SetPropertyValue(Of Decimal)("UnitPrice", fUnitPrice, value)
			End Set
		End Property
		Private fDiscontinued As Boolean
		Public Property Discontinued() As Boolean
			Get
				Return fDiscontinued
			End Get
			Set(ByVal value As Boolean)
				SetPropertyValue(Of Boolean)("Discontinued", fDiscontinued, value)
			End Set
		End Property
	End Class

End Namespace
