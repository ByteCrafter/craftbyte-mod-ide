﻿Public Class CreateProject
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then ' Check if the User wants to select an Mod name later
            TextBox2.Enabled = False
        Else
            TextBox2.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox1.Text.Length < 3 Then
            MessageBox.Show("The Project Name Textbox can't be empty or be under 3 letters!", "Project Name too short!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        If TextBox2.Text = "" Or TextBox2.Text.Length < 3 Then
            MessageBox.Show("The Mod Name Textbox can't be empty or be under 3 letters!", "Mod Name too short!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        If RadioButton1.Checked = False And RadioButton2.Checked = False Then
            MessageBox.Show("Please select an Version you want to develop for!", "Select an Version you want to develop for!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End If
        If CheckBox1.Checked = True Then
            ' todo
        End If
    End Sub
End Class