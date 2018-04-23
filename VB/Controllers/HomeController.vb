Imports System.Linq
Imports System.Web.Mvc

Namespace GridViewMasterDetailSelection
	Public Class HomeController
		Inherits Controller

		Public Function Index() As ActionResult
			Return View()
		End Function

		Public Function GridViewMaster() As ActionResult
			Dim model = Enumerable.Range(0, 5).Select(Function(i) New With {Key .ID = i, Key .Data = "Master Data " & i})
			Return PartialView(model)
		End Function

		Public Function GridViewDetail(ByVal id As String) As ActionResult
			ViewData("ID") = id
			Dim model = Enumerable.Range(0, 15).Select(Function(i) New With {Key .ID = i, Key .Data = id & " Detail Data " & i})
			Return PartialView("GridViewDetail", model)
		End Function
	End Class
End Namespace