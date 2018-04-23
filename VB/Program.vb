Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB

Namespace FilteredAssociation
	Friend NotInheritable Class Program
		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		Private Sub New()
		End Sub
		<STAThread> _
		Shared Sub Main()
			InitDal()

			Application.EnableVisualStyles()
			Application.SetCompatibleTextRenderingDefault(False)
			Application.Run(New Form1())
		End Sub
		Private Shared Sub InitDal()
			Dim conn As String = MSSqlConnectionProvider.GetConnectionString("(local)", "Northwind")
			XpoDefault.DataLayer = XpoDefault.GetDataLayer(conn, AutoCreateOption.SchemaAlreadyExists)
		End Sub
	End Class
End Namespace