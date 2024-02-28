<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddressLabelForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.InputGroupBox = New System.Windows.Forms.GroupBox()
        Me.ZipLabel = New System.Windows.Forms.Label()
        Me.StateLabel = New System.Windows.Forms.Label()
        Me.CityLabel = New System.Windows.Forms.Label()
        Me.StreetAddressLabel = New System.Windows.Forms.Label()
        Me.LastNameLabel = New System.Windows.Forms.Label()
        Me.FirstNameLabel = New System.Windows.Forms.Label()
        Me.ZipTextBox = New System.Windows.Forms.TextBox()
        Me.StateTextBox = New System.Windows.Forms.TextBox()
        Me.CityTextBox = New System.Windows.Forms.TextBox()
        Me.StreetAddressTextBox = New System.Windows.Forms.TextBox()
        Me.LastNameTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox()
        Me.OutputGroupBox = New System.Windows.Forms.GroupBox()
        Me.DisplayLabel = New System.Windows.Forms.Label()
        Me.DisplayButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.InputGroupBox.SuspendLayout()
        Me.OutputGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'InputGroupBox
        '
        Me.InputGroupBox.Controls.Add(Me.ZipLabel)
        Me.InputGroupBox.Controls.Add(Me.StateLabel)
        Me.InputGroupBox.Controls.Add(Me.CityLabel)
        Me.InputGroupBox.Controls.Add(Me.StreetAddressLabel)
        Me.InputGroupBox.Controls.Add(Me.LastNameLabel)
        Me.InputGroupBox.Controls.Add(Me.FirstNameLabel)
        Me.InputGroupBox.Controls.Add(Me.ZipTextBox)
        Me.InputGroupBox.Controls.Add(Me.StateTextBox)
        Me.InputGroupBox.Controls.Add(Me.CityTextBox)
        Me.InputGroupBox.Controls.Add(Me.StreetAddressTextBox)
        Me.InputGroupBox.Controls.Add(Me.LastNameTextBox)
        Me.InputGroupBox.Controls.Add(Me.FirstNameTextBox)
        Me.InputGroupBox.Location = New System.Drawing.Point(9, 18)
        Me.InputGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.InputGroupBox.Name = "InputGroupBox"
        Me.InputGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.InputGroupBox.Size = New System.Drawing.Size(266, 255)
        Me.InputGroupBox.TabIndex = 0
        Me.InputGroupBox.TabStop = False
        Me.InputGroupBox.Text = "Mailing Address"
        '
        'ZipLabel
        '
        Me.ZipLabel.AutoSize = True
        Me.ZipLabel.Location = New System.Drawing.Point(13, 202)
        Me.ZipLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.ZipLabel.Name = "ZipLabel"
        Me.ZipLabel.Size = New System.Drawing.Size(50, 13)
        Me.ZipLabel.TabIndex = 10
        Me.ZipLabel.Text = "Zip Code"
        '
        'StateLabel
        '
        Me.StateLabel.AutoSize = True
        Me.StateLabel.Location = New System.Drawing.Point(13, 166)
        Me.StateLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.StateLabel.Name = "StateLabel"
        Me.StateLabel.Size = New System.Drawing.Size(32, 13)
        Me.StateLabel.TabIndex = 9
        Me.StateLabel.Text = "State"
        '
        'CityLabel
        '
        Me.CityLabel.AutoSize = True
        Me.CityLabel.Location = New System.Drawing.Point(13, 130)
        Me.CityLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.CityLabel.Name = "CityLabel"
        Me.CityLabel.Size = New System.Drawing.Size(24, 13)
        Me.CityLabel.TabIndex = 8
        Me.CityLabel.Text = "City"
        '
        'StreetAddressLabel
        '
        Me.StreetAddressLabel.AutoSize = True
        Me.StreetAddressLabel.Location = New System.Drawing.Point(13, 94)
        Me.StreetAddressLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.StreetAddressLabel.Name = "StreetAddressLabel"
        Me.StreetAddressLabel.Size = New System.Drawing.Size(76, 13)
        Me.StreetAddressLabel.TabIndex = 7
        Me.StreetAddressLabel.Text = "Street Address"
        '
        'LastNameLabel
        '
        Me.LastNameLabel.AutoSize = True
        Me.LastNameLabel.Location = New System.Drawing.Point(13, 58)
        Me.LastNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.LastNameLabel.Name = "LastNameLabel"
        Me.LastNameLabel.Size = New System.Drawing.Size(58, 13)
        Me.LastNameLabel.TabIndex = 6
        Me.LastNameLabel.Text = "Last Name"
        '
        'FirstNameLabel
        '
        Me.FirstNameLabel.AutoSize = True
        Me.FirstNameLabel.Location = New System.Drawing.Point(13, 23)
        Me.FirstNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.FirstNameLabel.Name = "FirstNameLabel"
        Me.FirstNameLabel.Size = New System.Drawing.Size(57, 13)
        Me.FirstNameLabel.TabIndex = 2
        Me.FirstNameLabel.Text = "First Name"
        '
        'ZipTextBox
        '
        Me.ZipTextBox.Location = New System.Drawing.Point(4, 217)
        Me.ZipTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ZipTextBox.Name = "ZipTextBox"
        Me.ZipTextBox.Size = New System.Drawing.Size(78, 20)
        Me.ZipTextBox.TabIndex = 5
        '
        'StateTextBox
        '
        Me.StateTextBox.Location = New System.Drawing.Point(4, 181)
        Me.StateTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.StateTextBox.Name = "StateTextBox"
        Me.StateTextBox.Size = New System.Drawing.Size(78, 20)
        Me.StateTextBox.TabIndex = 4
        '
        'CityTextBox
        '
        Me.CityTextBox.Location = New System.Drawing.Point(4, 145)
        Me.CityTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.CityTextBox.Name = "CityTextBox"
        Me.CityTextBox.Size = New System.Drawing.Size(236, 20)
        Me.CityTextBox.TabIndex = 3
        '
        'StreetAddressTextBox
        '
        Me.StreetAddressTextBox.Location = New System.Drawing.Point(4, 110)
        Me.StreetAddressTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.StreetAddressTextBox.Name = "StreetAddressTextBox"
        Me.StreetAddressTextBox.Size = New System.Drawing.Size(236, 20)
        Me.StreetAddressTextBox.TabIndex = 2
        '
        'LastNameTextBox
        '
        Me.LastNameTextBox.Location = New System.Drawing.Point(4, 74)
        Me.LastNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.LastNameTextBox.Name = "LastNameTextBox"
        Me.LastNameTextBox.Size = New System.Drawing.Size(236, 20)
        Me.LastNameTextBox.TabIndex = 1
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.Location = New System.Drawing.Point(4, 38)
        Me.FirstNameTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(236, 20)
        Me.FirstNameTextBox.TabIndex = 0
        '
        'OutputGroupBox
        '
        Me.OutputGroupBox.Controls.Add(Me.DisplayLabel)
        Me.OutputGroupBox.Location = New System.Drawing.Point(279, 18)
        Me.OutputGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.OutputGroupBox.Name = "OutputGroupBox"
        Me.OutputGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.OutputGroupBox.Size = New System.Drawing.Size(279, 199)
        Me.OutputGroupBox.TabIndex = 1
        Me.OutputGroupBox.TabStop = False
        Me.OutputGroupBox.Text = "Address Label"
        '
        'DisplayLabel
        '
        Me.DisplayLabel.AutoSize = True
        Me.DisplayLabel.Location = New System.Drawing.Point(5, 23)
        Me.DisplayLabel.Name = "DisplayLabel"
        Me.DisplayLabel.Size = New System.Drawing.Size(0, 13)
        Me.DisplayLabel.TabIndex = 0
        '
        'DisplayButton
        '
        Me.DisplayButton.Location = New System.Drawing.Point(279, 219)
        Me.DisplayButton.Margin = New System.Windows.Forms.Padding(2)
        Me.DisplayButton.Name = "DisplayButton"
        Me.DisplayButton.Size = New System.Drawing.Size(90, 54)
        Me.DisplayButton.TabIndex = 6
        Me.DisplayButton.Text = "Display Label"
        Me.DisplayButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(374, 219)
        Me.ClearButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(90, 54)
        Me.ClearButton.TabIndex = 7
        Me.ClearButton.Text = "Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(468, 219)
        Me.ExitButton.Margin = New System.Windows.Forms.Padding(2)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(90, 54)
        Me.ExitButton.TabIndex = 8
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'AddressLabelForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(568, 287)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.DisplayButton)
        Me.Controls.Add(Me.OutputGroupBox)
        Me.Controls.Add(Me.InputGroupBox)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "AddressLabelForm"
        Me.Text = "Address Label Viewer"
        Me.InputGroupBox.ResumeLayout(False)
        Me.InputGroupBox.PerformLayout()
        Me.OutputGroupBox.ResumeLayout(False)
        Me.OutputGroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InputGroupBox As GroupBox
    Friend WithEvents OutputGroupBox As GroupBox
    Friend WithEvents LastNameTextBox As TextBox
    Friend WithEvents FirstNameTextBox As TextBox
    Friend WithEvents FirstNameLabel As Label
    Friend WithEvents ZipTextBox As TextBox
    Friend WithEvents StateTextBox As TextBox
    Friend WithEvents CityTextBox As TextBox
    Friend WithEvents StreetAddressTextBox As TextBox
    Friend WithEvents ZipLabel As Label
    Friend WithEvents StateLabel As Label
    Friend WithEvents CityLabel As Label
    Friend WithEvents StreetAddressLabel As Label
    Friend WithEvents LastNameLabel As Label
    Friend WithEvents DisplayButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DisplayLabel As Label
End Class
