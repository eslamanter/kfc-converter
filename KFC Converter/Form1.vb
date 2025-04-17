Public Class Form1

    Dim k, f, c As Decimal
    Private Sub btn_1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_1.Click
        Try
            If Me.rad_1.Checked = True Then
                k = Me.txt_1.Text
                f = ((k - 273) * 1.8) + 32
                c = k - 273
                Me.txt_2.Text = f
                Me.txt_3.Text = c
            End If
            If Me.rad_2.Checked = True Then
                k = ((f - 32) / 1.8) + 273
                f = Me.txt_2.Text
                c = (f - 32) / 1.8
                Me.txt_1.Text = k
                Me.txt_3.Text = c
            End If
            If Me.rad_3.Checked = True Then
                k = c + 273
                f = (c * 1.8) + 32
                c = Me.txt_3.Text
                Me.txt_1.Text = k
                Me.txt_2.Text = f
            End If
        Catch
        End Try
    End Sub
End Class
