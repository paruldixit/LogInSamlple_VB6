Public Class Tapi
    Private Sub Tapi_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Form1.Close()
        Dim menuBar As New MainMenu()

        Dim menuItemFile As New MenuItem("&File")
        Dim menuItemEdit As New MenuItem("&Edit")
        Dim menuItemTools As New MenuItem("&Tools")
        Dim menuItemHelp As New MenuItem("&Help")

        menuBar.MenuItems.Add(menuItemFile)
        menuBar.MenuItems.Add(menuItemEdit)
        menuBar.MenuItems.Add(menuItemTools)
        menuBar.MenuItems.Add(menuItemHelp)

        Me.Menu = menuBar

    End Sub

End Class