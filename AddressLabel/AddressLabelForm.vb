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
    'if there are errors, then it compiles an error message to display to the user, telling them what to fix
    Sub FormatOutput()
        Dim message As String
        Dim firstName As String = FirstNameTextBox.Text
        Dim firstNameTest As Integer = 0
        Dim lastName As String = LastNameTextBox.Text
        Dim lastNameTest As Integer = 0
        Dim streetAddress As String = StreetAddressTextBox.Text
        Dim streetAddressTest() As String = Split(StreetAddressTextBox.Text)
        Dim streetAddressNumber As Integer = 0
        Dim city As String = CityTextBox.Text
        Dim cityTest As Integer = 0
        Dim state As String = UCase(StateTextBox.Text)
        Dim stateTest As Integer = 0
        Dim zip As String = ZipTextBox.Text
        Dim zipNumberTest As Integer
        Dim errorMessage As String = "Please enter your:"

        'checks if a first name was entered
        'checks if a valid last name was entered
        Try
            firstNameTest = CInt(firstName)

            errorMessage = (errorMessage & " valid first name")

        Catch ex As Exception
            If firstName = "" Then
                errorMessage = (errorMessage & " first name")
            Else
            End If
        End Try

        'checks if a last name was entered
        'checks if a valid last name was entered
        Try
            lastNameTest = CInt(lastName)
            If lastNameTest <> 0 Then
                If errorMessage = "Please enter your:" Then
                    errorMessage = (errorMessage & " valid last name")
                Else errorMessage = (errorMessage & ", valid last name")
                End If
            Else
            End If
        Catch ex As Exception
            If lastName = "" Then
                If errorMessage = "Please enter your:" Then
                    errorMessage = (errorMessage & " last name")
                Else errorMessage = (errorMessage & ", last name")
                End If
            End If
        End Try

        'checks if there is a home number in the street address
        'checks if there has been a street address entered
        Try
            streetAddressNumber = CInt(streetAddressTest(0))

        Catch ex As Exception
            If streetAddressNumber <= 0 Then
                If streetAddress = "" Then
                    If errorMessage = "Please enter your:" Then
                        errorMessage = (errorMessage & " street address")
                    Else errorMessage = (errorMessage & ", street address")
                    End If
                ElseIf streetaddressnumber <= 0 Then
                    If errorMessage = "Please enter your:" Then
                        errorMessage = (errorMessage & " valid street address")
                    Else errorMessage = (errorMessage & ", valid street address")
                    End If
                End If
            End If
        End Try

        'checks that a city was entered
        'checks that it is not a number
        Try
            cityTest = CInt(city)
            If cityTest <> 0 Then
                If errorMessage = "Please enter your:" Then
                    errorMessage = (errorMessage & " valid city")
                Else errorMessage = (errorMessage & ", valid city")
                End If
            Else
            End If
        Catch ex As Exception
            If city = "" Then
                If errorMessage = "Please enter your:" Then
                    errorMessage = (errorMessage & " city")
                Else errorMessage = (errorMessage & ", city")
                End If
            End If
        End Try

        'checks that a state was entered
        'checks that the state entered is not a number
        Try
            stateTest = CInt(state)
            If stateTest <> 0 Then
                If errorMessage = "Please enter your:" Then
                    errorMessage = (errorMessage & " valid state")
                Else errorMessage = (errorMessage & ", valid state")
                End If
            Else
            End If
        Catch ex As Exception
            If state = "" Then
                If errorMessage = "Please enter your:" Then
                    errorMessage = (errorMessage & " state")
                Else errorMessage = (errorMessage & ", state")
                End If
            End If
        End Try

        'checks that a zip code was entered
        'checks that the zip code entered is a number
        Try
            zipNumberTest = CInt(zip)

        Catch ex As Exception
            If zipNumberTest <= 0 Then
                If zip = "" Then
                    If errorMessage = "Please enter your:" Then
                        errorMessage = (errorMessage & " zip code")
                    Else errorMessage = (errorMessage & ", zip code")
                    End If
                ElseIf zipNumberTest <= 0 Then
                    If errorMessage = "Please enter your:" Then
                        errorMessage = (errorMessage & " valid zip code")
                    Else errorMessage = (errorMessage & ", valid zip code")
                    End If
                End If
            End If
        End Try

        'if there was anything wrong with the inputs then it will give the user an error message.
        'else it will format the output properly
        If errorMessage <> "Please enter your:" Then
            errorMessage = (errorMessage & ".")
            MsgBox(errorMessage)
        Else
            message = ($"{firstName} " & $"{lastName}" & vbCrLf _
                        & $"{streetAddress}" & vbCrLf _
                        & $"{city}, " & $"{state} " & $"{zip}")
            DisplayLabel.Text = message
        End If
    End Sub

    'pressing the clear button will call the Clear sub to clear the inputs and output
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        Clear()
    End Sub

    'pressing the display button will call the FormatOutput sub to format the output
    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click
        FormatOutput()
    End Sub

    'exit button closes the windows form, can also be accessed by pressing esc
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'group box that houses the input text boxes and their labels
    Private Sub InputGroupBox_Enter(sender As Object, e As EventArgs) Handles InputGroupBox.Enter
    End Sub

    'first name text box input label
    Private Sub FirstNameLabel_Click(sender As Object, e As EventArgs) Handles FirstNameLabel.Click
    End Sub

    'first name text box input 
    Private Sub FirstNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles FirstNameTextBox.TextChanged
    End Sub

    'last name text box input label
    Private Sub LastNameLabel_Click(sender As Object, e As EventArgs) Handles LastNameLabel.Click
    End Sub

    'last name text box input
    Private Sub LastNameTextBox_TextChanged(sender As Object, e As EventArgs) Handles LastNameTextBox.TextChanged
    End Sub

    'street address text box input label
    Private Sub StreetAddressLabel_Click(sender As Object, e As EventArgs) Handles StreetAddressLabel.Click
    End Sub

    'street address text box input
    Private Sub StreetAddressTextBox_TextChanged(sender As Object, e As EventArgs) Handles StreetAddressTextBox.TextChanged
    End Sub

    'city text box input label
    Private Sub CityLabel_Click(sender As Object, e As EventArgs) Handles CityLabel.Click
    End Sub

    'city text box input
    Private Sub CityTextBox_TextChanged(sender As Object, e As EventArgs) Handles CityTextBox.TextChanged
    End Sub

    'state text box input label
    Private Sub StateLabel_Click(sender As Object, e As EventArgs) Handles StateLabel.Click
    End Sub

    'state text box input 
    Private Sub StateTextBox_TextChanged(sender As Object, e As EventArgs) Handles StateTextBox.TextChanged
    End Sub

    'zip code text box input label
    Private Sub ZipLabel_Click(sender As Object, e As EventArgs) Handles ZipLabel.Click
    End Sub

    'zip code text box input
    Private Sub ZipTextBox_TextChanged(sender As Object, e As EventArgs) Handles ZipTextBox.TextChanged
    End Sub

    'group box that houses the output text label
    Private Sub OutputGroupBox_Enter(sender As Object, e As EventArgs) Handles OutputGroupBox.Enter
    End Sub

    'the windows form
    Private Sub AddressLabelForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    'the display label that is used as the output
    Private Sub DisplayLabel_Click(sender As Object, e As EventArgs) Handles DisplayLabel.Click
    End Sub

End Class
