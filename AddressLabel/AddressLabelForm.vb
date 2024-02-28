'Alex Wheelock
'RCET 0625
'Spring 2024
'Address Label Form
'https://github.com/AlexWheelock/AddressLabel.git

Option Strict On
Option Explicit On
Public Class AddressLabelForm

    'sets all of the text boxes and the output to blank when the clear button is pressed
    Sub Clear()
        FirstNameTextBox.Text = ""
        LastNameTextBox.Text = ""
        StreetAddressTextBox.Text = ""
        CityTextBox.Text = ""
        StateTextBox.Text = ""
        ZipTextBox.Text = ""
        DisplayLabel.Text = ""
    End Sub

    'compiles the user inputs from the text boxes to the correct mailing format
    Sub FormatOutput()
        Dim message As String
        Dim firstName As String = FirstNameTextBox.Text
        Dim lastName As String = LastNameTextBox.Text
        Dim streetAddress As String = StreetAddressTextBox.Text
        Dim city As String = CityTextBox.Text
        Dim state As String = UCase(StateTextBox.Text)
        Dim zip As String = ZipTextBox.Text
        Dim errorMessage As String = "Please enter your:"

        'determines if the fields have been filled in properly, and compiles the error message
        If firstName = "" Then
            errorMessage = (errorMessage & " first name")
        Else
        End If

        If lastName = "" Then
            If errorMessage = "" Then
                errorMessage = (errorMessage & " last name")
            Else errorMessage = (errorMessage & ", last name")
            End If
        Else
        End If

        If streetAddress = "" Then
            If errorMessage = "" Then
                errorMessage = (errorMessage & " street address")
            Else errorMessage = (errorMessage & ", street address")
            End If
        Else
        End If

        If city = "" Then
            If errorMessage = "" Then
                errorMessage = (errorMessage & " city")
            Else errorMessage = (errorMessage & ", city")
            End If
        Else
        End If

        If state = "" Then
            If errorMessage = "" Then
                errorMessage = (errorMessage & " state")
            Else errorMessage = (errorMessage & ", state")
            End If
        Else
        End If

        If zip = "" Then
            If errorMessage = "" Then
                errorMessage = (errorMessage & " zip code")
            Else errorMessage = (errorMessage & ", zip code")
            End If
        Else
        End If

        If errorMessage <> "" Then
            errorMessage = (errorMessage & ".")
            MsgBox(errorMessage)
        Else
            message = ($"{firstName} " & $"{lastName}" & vbCrLf _
                        & $"{streetAddress}" & vbCrLf _
                        & $"{city}, " & $"{state} " & $"{zip}")

            DisplayLabel.Text = message
        End If




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
        FormatOutput()
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub AddressLabelForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DisplayLabel_Click(sender As Object, e As EventArgs) Handles DisplayLabel.Click

    End Sub
End Class
