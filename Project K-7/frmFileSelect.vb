Public Class frmFileSelect

    Public strUpdates As String = "Updates | Test"

    Public Function MarqueeLeft(ByVal Text As String)
        Dim str1 As String = Text.Remove(0, 1)
        Dim str2 As String = Text(0)

        Return str1 & str2

    End Function

    Private Sub Grow0(ByVal objSender As System.Object)
        For Each Control In Me.Controls
            If objSender.Location.y <= Control.Location.y Then
                lblDescription.Text = lblDescription.Text + ", " + Control.Name

            End If
        Next
    End Sub

    Public Sub Grow(ByVal objObject As System.Object, ByVal strObjectName As String)
        Dim dblNewFontSize As Integer = objObject.Font.Size

        For intCount As Integer = 0 To 7 Step 1
            If objObject.Font.Size >= 17 And objObject.Font.Size <= 28 Then
                dblNewFontSize += 1

                If strObjectName = "lblContinue" Then
                    lblLoad.Top += 1
                    lblNew.Top += 1
                    lblDev.Top += 1

                ElseIf strObjectName = "lblLoad" Then
                    lblNew.Top += 1
                    lblDev.Top += 1

                ElseIf strObjectName = "lblNew" Then
                    lblDev.Top += 1

                End If

                objObject.Font = New Font("Microsoft Sans Serif", dblNewFontSize, FontStyle.Bold)

                Me.Refresh()

                System.Threading.Thread.Sleep(1)

            End If
        Next
    End Sub

    Public Sub Shrink(ByVal objObject As System.Object, ByVal strObjectName As String)
        Dim dblNewFontSize As Integer = objObject.Font.Size

        For intCount As Integer = 0 To 7 Step 1
            If objObject.Font.Size >= 18 And objObject.Font.Size <= 29 Then
                dblNewFontSize -= 1

                If strObjectName = "lblContinue" Then
                    lblLoad.Top -= 1
                    lblNew.Top -= 1
                    lblDev.Top -= 1

                ElseIf strObjectName = "lblLoad" Then
                    lblNew.Top -= 1
                    lblDev.Top -= 1

                ElseIf strObjectName = "lblNew" Then
                    lblDev.Top -= 1

                End If

                objObject.Font = New Font("Microsoft Sans Serif", dblNewFontSize, FontStyle.Bold)

                Me.Refresh()

                System.Threading.Thread.Sleep(1)

            End If
        Next

    End Sub

    Private Sub frmFileSelect_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        For Each Control In Me.Controls
            'lblDescription.Text = lblDescription.Text + ", " + Control.Name

        Next

    End Sub

    Private Sub tmrScroll_Tick(sender As System.Object, e As System.EventArgs) Handles tmrScroll.Tick

        lblUpdates.Text = MarqueeLeft(lblUpdates.Text)

    End Sub

    Private Sub lblContinue_MouseHover(sender As Object, e As System.EventArgs) Handles lblContinue.MouseHover
        Grow(sender, "lblContinue")

    End Sub

    Private Sub lblContinue_MouseLeave(sender As Object, e As System.EventArgs) Handles lblContinue.MouseLeave
        Shrink(sender, "lblContinue")

    End Sub

    Private Sub lblLoad_MouseHover(sender As Object, e As System.EventArgs) Handles lblLoad.MouseHover
        Grow(sender, "lblLoad")

    End Sub

    Private Sub lblLoad_MouseLeave(sender As Object, e As System.EventArgs) Handles lblLoad.MouseLeave
        Shrink(sender, "lblLoad")

    End Sub

    Private Sub lblNew_MouseHover(sender As Object, e As System.EventArgs) Handles lblNew.MouseHover
        'Grow(sender, "lblNew")
        Grow0(sender)

    End Sub

    Private Sub lblNew_MouseLeave(sender As Object, e As System.EventArgs) Handles lblNew.MouseLeave
        Shrink(sender, "lblNew")

    End Sub

    Private Sub lblDev_MouseHover(sender As Object, e As System.EventArgs) Handles lblDev.MouseHover
        Grow(sender, "lblDev")

    End Sub

    Private Sub lblDev_MouseLeave(sender As Object, e As System.EventArgs) Handles lblDev.MouseLeave
        Shrink(sender, "lblDev")

    End Sub

    Private Sub lblQuit_MouseHover(sender As Object, e As System.EventArgs) Handles lblQuit.MouseHover
        Grow(sender, "lblQuit")

    End Sub

    Private Sub lblQuit_MouseLeave(sender As Object, e As System.EventArgs) Handles lblQuit.MouseLeave
        Shrink(sender, "lblQuit")

    End Sub

    Private Sub frmFileSelect_SizeChanged(sender As Object, e As System.EventArgs) Handles Me.SizeChanged
        lblUpdates.Text = strUpdates

        For intCount As Integer = (((Me.Width - 292) - lblUpdates.Width) / 7) - 1 To 0 Step -1
            lblUpdates.Text += " "

        Next
    End Sub

    Private Sub lblQuit_Click(sender As System.Object, e As System.EventArgs) Handles lblQuit.Click
        Me.Close()

    End Sub
End Class
