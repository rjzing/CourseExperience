Public NotInheritable Class frmAboutUs

    Private Sub frmAboutUs_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Text = "About Big J Catering"
        LabelProductName.Text = "Big J Catering Order Form"
        LabelCompanyName.Text = "Big J Catering"
        LabelVersion.Text = "1.00.00"
        LabelCopyright.Text = "© rjzinger"
        TextBoxDescription.Text = "Big J Catering has been around since 1997 and we're proud to have you as a customer." &
            "We use the most quality ingridents in all of our meals. What are you waiting for? Order Now!"
    End Sub


    Private Sub OKButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OKButton.Click
        Me.Close()
    End Sub

End Class
