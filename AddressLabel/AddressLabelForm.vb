'Alex Wheelock
'RCET 0625
'Spring 2024
'Address Label Form
'https://github.com/AlexWheelock/AddressLabel.git

Option Strict On
Option Explicit On
Public Class AddressLabelForm

    Sub Clear()
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        StreetAddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipTextBox.Text = ""
    End Sub

    Sub Output()

    End Sub

    Private Sub InputGroupBox_Enter(sender As Object, e As EventArgs) Handles InputGroupBox.Enter

    End Sub

    Private Sub FirstNameLabel_Click(sender As Object, e As EventArgs) Handles FirstNameLabel.Click

    End Sub

    Private Sub FirstNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstNameTextBox.TextChanged

    End Sub

    Private Sub LastNameLabel_Click(sender As Object, e As EventArgs) Handles LastNameLabel.Click

    End Sub

    Private Sub LastNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles LastNameTextBox.TextChanged

    End Sub

    Private Sub StreetAddressLabel_Click(sender As Object, e As EventArgs) Handles StreetAddressLabel.Click

    End Sub

    Private Sub StreetAddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles StreetAddressTextBox.TextChanged

    End Sub

    Private Sub CityLabel_Click(sender As Object, e As EventArgs) Handles CityLabel.Click

    End Sub

    Private Sub CityTextBox_TextChanged(sender As Object, e As EventArgs) Handles CityTextBox.TextChanged

    End Sub

    Private Sub StateLabel_Click(sender As Object, e As EventArgs) Handles StateLabel.Click

    End Sub

    Private Sub StateTextBox_TextChanged(sender As Object, e As EventArgs) Handles StateTextBox.TextChanged

    End Sub

    Private Sub ZipLabel_Click(sender As Object, e As EventArgs) Handles ZipLabel.Click

    End Sub

    Private Sub ZipTextBox_TextChanged(sender As Object, e As EventArgs) Handles ZipTextBox.TextChanged

    End Sub

    Private Sub OutputGroupBox_Enter(sender As Object, e As EventArgs) Handles OutputGroupBox.Enter

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Clear()
    End Sub

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub AddressLabelForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DisplayLabel_Click(sender As Object, e As EventArgs) Handles DisplayLabel.Click

    End Sub
End Class
