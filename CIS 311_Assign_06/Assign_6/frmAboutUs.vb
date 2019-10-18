Public NotInheritable Class frmAboutUs

    Private Sub frmAboutUs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.LabelProductName.Text = "Conversion Calculator"
        Me.LabelVersion.Text = "1.0.0"
        Me.LabelCopyright.Text = "rjzinger " & My.Application.Info.Copyright
        Me.LabelCompanyName.Text = "SoftwareForYou"
        Me.TextBoxDescription.Text = "This application allows users to input two values, either in binary, decimal, or hex, " &
            "when they hit convert, the other values' properties are shown. The user then can do logical functions, AND, OR, " &
            "Xor, and NOT Value 1."
    End Sub

    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub
End Class
