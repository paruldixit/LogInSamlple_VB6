Public Class ConvertPostCode

    Public Function DoCovert(ByVal postcode As String) 'As String
        Dim ConverPostcode As String
        ConverPostcode = StrConv(postcode, VbStrConv.Uppercase)
        'DoCovert = ConverPostcode
        Return ConverPostcode
    End Function

    Public Sub DoMessageBox()
        MessageBox.Show("Conversion Completed")
    End Sub
End Class
