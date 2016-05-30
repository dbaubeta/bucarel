Imports Excel = Microsoft.Office.Interop.Excel

Public Class ReporteStock

    Dim ctrl As New Negocio.Controller

    Private Sub ReporteStock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.txtArchivo.Text = System.IO.Directory.GetCurrentDirectory + "\StockProductos.xlsx"

    End Sub



    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click

        GenerarExcelStockProductos()


    End Sub


    Private Sub GenerarExcelStockProductos()


        Dim filaloop As Integer
        Dim columnaloop As Integer


        Dim l As List(Of Entidades.reportestock)
        l = ctrl.obtenerReporteStock

        Dim tl As List(Of Entidades.talle)
        tl = ctrl.obtenerTalles

        Dim xlApp As Excel.Application = New Microsoft.Office.Interop.Excel.Application()

        If xlApp Is Nothing Then
            MessageBox.Show("Excel is not properly installed!!")
            Return
        End If

        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        xlWorkBook = xlApp.Workbooks.Add()
        xlWorkSheet = xlWorkBook.Sheets(1)

        Dim filainicio As Integer = 2
        Dim columnainicio As Integer = 1

        xlWorkSheet.Cells(filainicio, 1) = "Producto"

        columnaloop = columnainicio + 1
        For Each t As Entidades.talle In tl
            xlWorkSheet.Cells(filainicio, columnaloop) = t.nombre
            columnaloop += 1
        Next


        filaloop = filainicio
        Dim ultimoProducto As String = ""
        For Each r As Entidades.reportestock In l

            If r.productonombre <> ultimoProducto Then
                ultimoProducto = r.productonombre
                filaloop += 1
            End If

            columnaloop = tl.FindIndex(Function(x) x.nombre = r.talle) + 2
            xlWorkSheet.Cells(filaloop, 1) = r.productonombre
            xlWorkSheet.Cells(filaloop, columnaloop) = r.stock

        Next

        ' FORMATEO 
        ' ====================================================================================
        With xlWorkSheet
            .Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            With .Range("A1", "A" + filaloop.ToString)
                .Font.Bold = True
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
                .Columns.AutoFit()
            End With
            With .Range(.Cells(filainicio, 1), .Cells(filainicio, (tl.Count + 1)))
                .Font.Bold = True
                With .Interior
                    .Pattern = Excel.XlPattern.xlPatternSolid
                    .PatternColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                    .ThemeColor = Excel.XlThemeColor.xlThemeColorAccent1
                    .TintAndShade = -0.499984740745262
                    .PatternTintAndShade = 0
                End With
                .Font.Color = Color.White

            End With


            .Activate()
            .Application.ActiveWindow.SplitRow = 2
            .Application.ActiveWindow.SplitColumn = 1
            .Application.ActiveWindow.FreezePanes = True

        End With



        xlWorkBook.SaveAs(Me.txtArchivo.Text, Excel.XlFileFormat.xlOpenXMLWorkbook, misValue, misValue, misValue, misValue, _
         Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)

        xlWorkBook.Close(True, misValue, misValue)
        xlApp.Quit()

        releaseObject(xlWorkSheet)
        releaseObject(xlWorkBook)
        releaseObject(xlApp)

        RunCommandCom(Me.txtArchivo.Text, "", False)

        '4MessageBox.Show("Archivo creado")

        l = Nothing
        tl = Nothing

    End Sub


    Shared Sub RunCommandCom(command As String, arguments As String, permanent As Boolean)
        Dim p As Process = New Process()
        Dim pi As ProcessStartInfo = New ProcessStartInfo()
        pi.Arguments = " " + If(permanent = True, "/K", "/C") + " " + command + " " + arguments
        pi.FileName = "cmd.exe"
        p.StartInfo = pi
        p.Start()
    End Sub

    Private Sub GenerarExcelStockMateriales()


        Dim filaloop As Integer
        Dim columnaloop As Integer


        Dim l As List(Of Entidades.reportestock)
        l = ctrl.obtenerReporteStock

        Dim tl As List(Of Entidades.talle)
        tl = ctrl.obtenerTalles

        Dim xlApp As Excel.Application = New Microsoft.Office.Interop.Excel.Application()

        If xlApp Is Nothing Then
            MessageBox.Show("Excel is not properly installed!!")
            Return
        End If

        Dim xlWorkBook As Excel.Workbook
        Dim xlWorkSheet As Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value

        xlWorkBook = xlApp.Workbooks.Add()
        xlWorkSheet = xlWorkBook.Sheets(1)

        Dim filainicio As Integer = 2
        Dim columnainicio As Integer = 1

        xlWorkSheet.Cells(filainicio, 1) = "Producto"

        columnaloop = columnainicio + 1
        For Each t As Entidades.talle In tl
            xlWorkSheet.Cells(filainicio, columnaloop) = t.nombre
            columnaloop += 1
        Next


        filaloop = filainicio
        Dim ultimoProducto As String = ""
        For Each r As Entidades.reportestock In l

            If r.productonombre <> ultimoProducto Then
                ultimoProducto = r.productonombre
                filaloop += 1
            End If

            columnaloop = tl.FindIndex(Function(x) x.nombre = r.talle) + 2
            xlWorkSheet.Cells(filaloop, 1) = r.productonombre
            xlWorkSheet.Cells(filaloop, columnaloop) = r.stock

        Next


        With xlWorkSheet
            .Cells.HorizontalAlignment = Excel.XlHAlign.xlHAlignCenter
            .Cells.VerticalAlignment = Excel.XlVAlign.xlVAlignCenter
            With .Range("A1", "A" + filaloop.ToString)
                .Font.Bold = True
                .HorizontalAlignment = Excel.XlHAlign.xlHAlignLeft
            End With
            With .Range(.Cells(filainicio, 1), .Cells(filainicio, (tl.Count + 1)))
                .Font.Bold = True
                With .Interior
                    .Pattern = Excel.XlPattern.xlPatternSolid
                    .PatternColorIndex = Excel.XlColorIndex.xlColorIndexAutomatic
                    .ThemeColor = Excel.XlThemeColor.xlThemeColorAccent1
                    .TintAndShade = -0.499984740745262
                    .PatternTintAndShade = 0
                End With
                .Font.Color = Color.White

            End With


            .Activate()
            .Application.ActiveWindow.SplitRow = 2
            .Application.ActiveWindow.SplitColumn = 1
            .Application.ActiveWindow.FreezePanes = True

        End With

        xlWorkBook.SaveAs("F:\git\bucarel\excel\StockProductos.xlsx", Excel.XlFileFormat.xlOpenXMLWorkbook, misValue, misValue, misValue, misValue, _
         Excel.XlSaveAsAccessMode.xlExclusive, misValue, misValue, misValue, misValue, misValue)
        xlWorkBook.Close(True, misValue, misValue)
        xlApp.Quit()

        releaseObject(xlWorkSheet)
        releaseObject(xlWorkBook)
        releaseObject(xlApp)

        MessageBox.Show("Archivo creado")

        l = Nothing
        tl = Nothing



    End Sub




    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub



End Class