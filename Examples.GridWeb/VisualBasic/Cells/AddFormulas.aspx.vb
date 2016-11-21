﻿Imports Aspose.Cells.GridWeb.Data

Namespace Cells
    Public Class AddFormulas
        Inherits System.Web.UI.Page

        Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        End Sub

        Protected Sub btnAddFormula_Click(sender As Object, e As EventArgs)
            ' Clear GridWeb and add a new worksheet
            GridWeb1.WorkSheets.Clear()
            GridWeb1.WorkSheets.Add()

            ' ExStart:AddFormulas
            ' Accessing the worksheet of the Grid that is currently active
            Dim sheet As GridWorksheet = GridWeb1.WorkSheets(GridWeb1.ActiveSheetIndex)

            ' Putting some values to cells
            sheet.Cells("A1").PutValue("1st Value")
            sheet.Cells("A2").PutValue("2nd Value")
            sheet.Cells("A3").PutValue("Sum")
            sheet.Cells("B1").PutValue(125.56)
            sheet.Cells("B2").PutValue(23.93)

            ' Adding a simple formula to "B3" cell
            sheet.Cells("B3").Formula = "=SUM(B1:B2)"
            ' ExEnd:AddFormulas

            ' ExStart:CalculateFormulas
            ' Calculating all formulas added in worksheets
            GridWeb1.WorkSheets.CalculateFormula()
            ' ExEnd:CalculateFormulas
        End Sub

        Protected Sub btnAddComplexFormula_Click(sender As Object, e As EventArgs)
            ' Clear GridWeb
            GridWeb1.WorkSheets.Clear()

            ' Add worksheets
            Dim sheet1 As GridWorksheet = GridWeb1.WorkSheets.Add("Sheet1")
            Dim sheet2 As GridWorksheet = GridWeb1.WorkSheets.Add("Sheet2")

            ' Putting some values to cells
            sheet1.Cells("A1").PutValue(10)
            sheet1.Cells("A2").PutValue(20)
            sheet1.Cells("A3").PutValue(30)
            sheet1.Cells("A4").PutValue(40)
            sheet1.Cells("A5").PutValue(50)

            sheet1.Cells("B1").PutValue(1)
            sheet1.Cells("B2").PutValue(2)
            sheet1.Cells("B3").PutValue(3)
            sheet1.Cells("B4").PutValue(4)
            sheet1.Cells("B5").PutValue(5)

            sheet2.Cells("A1").PutValue("Value for reference : ")
            sheet2.Cells("B1").PutValue(100)
            sheet1.Cells("A6").PutValue("Result")

            ' ExStart:AddComplexFormulas
            ' Adding a bit complex formula to "A1" cell
            sheet1.Cells("B6").Formula = "=(SUM(A1:A5)/AVERAGE(B1:B5))-Sheet2!B1"
            ' ExEnd:AddComplexFormulas

            ' Calculating all formulas added in worksheets
            GridWeb1.WorkSheets.CalculateFormula()
        End Sub
    End Class
End Namespace
