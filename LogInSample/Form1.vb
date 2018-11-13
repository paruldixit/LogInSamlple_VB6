' To disallow the explicit declaration of variables like python
Option Explicit On
Imports MySql.Data.MySqlClient
Imports excel = Microsoft.Office.Interop.Excel


Public Class Form1

    Dim MySqlConn As MySqlConnection
    Dim Command As MySqlCommand

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;user id=root;password=Password@10;database=empdetails"

        Dim Reader As MySqlDataReader

        Try
            MySqlConn.Open()
            Dim Query As String
            Query = "insert into empdetails.user_details(lastname, firstname, emailid, mobileno) values('" & TextBox2.Text & "', '" & TextBox1.Text & "', '" & TextBox3.Text & "', '" & TextBox4.Text & "')"
            Command = New MySqlCommand(Query, MySqlConn)
            Reader = Command.ExecuteReader
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()
            TextBox4.Clear()
            MessageBox.Show("Data Saved")
            MySqlConn.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            MySqlConn.Dispose()
        End Try
    End Sub

    Private Sub LoadData_Click(sender As Object, e As EventArgs) Handles LoadData.Click
        Dim da As MySqlDataAdapter
        MySqlConn = New MySqlConnection
        MySqlConn.ConnectionString = "server=localhost;user id=root;password=Password@10;database=empdetails"
        MySqlConn.Open()
        Dim str As String
        str = "select * from user_details"
        da = New MySqlDataAdapter(str, MySqlConn)
        Dim ds = New DataSet
        da.Fill(ds, "user_details")
        DataGridView1.DataSource = ds.Tables("user_details")
        da.Dispose()
        MySqlConn.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim userMsg As String
        userMsg = Microsoft.VisualBasic.InputBox("Enter the name you want to delete", "Delete User", "Example abc")
        If userMsg <> "" Then
            MySqlConn = New MySqlConnection
            MySqlConn.ConnectionString = "server=localhost;user id=root;password=Password@10;database=empdetails"

            Dim Reader As MySqlDataReader

            Try
                MySqlConn.Open()
                Dim Query As String
                Query = "delete from empdetails.user_details where firstname='" & userMsg & "'"
                Command = New MySqlCommand(Query, MySqlConn)
                Reader = Command.ExecuteReader
                MessageBox.Show("Data Deleted")
                MySqlConn.Close()
            Catch ex As Exception
                MsgBox(ex.Message)
            Finally
                MySqlConn.Dispose()
            End Try
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Tapi.Show()

    End Sub

    Private Sub TextBox1_MouseEnter(sender As Object, e As EventArgs) Handles TextBox1.MouseEnter
        TextBox1.BackColor = Color.Blue
        TextBox1.ForeColor = Color.Red
    End Sub

    Private Sub TextBox1_MouseLeave(sender As Object, e As EventArgs) Handles TextBox1.MouseLeave
        TextBox1.BackColor = Color.White
        TextBox1.ForeColor = Color.Black

    End Sub

    Private Sub GenerateReport_Click(sender As Object, e As EventArgs) Handles GenerateReport.Click
        Dim Excelapp As excel.Application
        Dim wb As excel.Workbook
        Dim ws As excel.Worksheet
        Dim range As excel.Range
        ' Start Excela and get application object

        Excelapp = CreateObject("Excel.Application")
        Excelapp.Visible = True
        'Add new workbook
        wb = Excelapp.Workbooks.Add
        ws = wb.ActiveSheet

        'Add Table header 
        ws.Cells(1, 1).Value = "First Name"
        ws.Cells(1, 2).Value = "Last Name"
        ws.Cells(1, 3).Value = "Full Name"
        ws.Cells(1, 4).Value = "Specilization"

        'Format cell
        With ws.Range("A1", "D1")
            .Font.Bold = True
            .VerticalAlignment = excel.XlVAlign.xlVAlignCenter
        End With

        'create an Array
        Dim Students(2, 2) As String
        Students(0, 0) = "zara"
        Students(0, 1) = "Ali"
        Students(1, 0) = "Nuha"
        Students(1, 1) = "Ali"

        ' Fill A1 : B2
        ws.Range("A2", "B3").Value = Students
        range = ws.Range("C2", "C3")
        range.Formula = "=A2 & "" "" & B2"

        With ws
            .Cells(2, 4).Value = "Biology"
            .Cells(3, 4).Value = "Mathematics"
        End With

        ' Auto Fit Coloum
        range = ws.Range("A1, D1")
        range.EntireColumn.AutoFit()

        'Excelapp.Visible = True
        Excelapp.UserControl = True

        'Release object reference
        range = Nothing
        ws = Nothing
        wb = Nothing
        Excelapp.Quit()
        Excelapp = Nothing


Err_Handler:
        If Err.Number > 0 Then
            MsgBox(Err.Description, vbCritical, "Error :" & Err.Number)
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim NewCode As String
        Dim ObjectConvertPostCode As ConvertPostCode
        ObjectConvertPostCode = New ConvertPostCode
        NewCode = ObjectConvertPostCode.DoCovert(TextBox1.Text)
        TextBox1.Text = NewCode
        ObjectConvertPostCode.DoMessageBox()
    End Sub
End Class



