﻿
Namespace Cells
    Public Class SetAutoFilter
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(sender As Object, e As EventArgs) Handles Me.Load
            ' If first visit to the page, init GridWeb
            If Not Page.IsPostBack AndAlso Not GridWeb1.IsPostBack Then
                InitGridWeb()
            End If
        End Sub

        Private Sub InitGridWeb()
            GridWeb1.WorkSheets.Clear()

            ' Gets the web application's path.
            Dim path As String = TryCast(Me.Master, Site).GetDataDir()

            Dim fileName As String = path + "\Cells\Products.xlsx"

            ' Imports from an excel file.
            GridWeb1.ImportExcelFile(fileName)
            GridWeb1.ActiveCell = GridWeb1.WorkSheets(GridWeb1.ActiveSheetIndex).Cells("A1")

            ' ExStart:SetAutoFilter
            ' Access active worksheet
            Dim sheet = GridWeb1.WorkSheets(GridWeb1.ActiveSheetIndex)

            ' Enable GridWeb's auto-filter.
            sheet.AddAutoFilter(0, 0, sheet.Cells.MaxDataColumn)
            sheet.RefreshFilter()
            ' ExEnd:SetAutoFilter
        End Sub

    End Class
End Namespace
