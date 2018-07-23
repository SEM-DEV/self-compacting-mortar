Imports System.IO
Public Class Form3
    Private Sub Form2_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Label3.Text = Date.Now
    End Sub
    Dim mouse_offset
    Private Sub Form1_MouseDown(ByVal sender As Object,
ByVal e As System.Windows.Forms.MouseEventArgs) _
Handles MyBase.MouseDown
        mouse_offset = New Point(-e.X, -e.Y)
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object,
ByVal e As System.Windows.Forms.MouseEventArgs) _
Handles MyBase.MouseMove
        If e.Button = Windows.Forms.MouseButtons.Left Then
            Dim mousePos As Point = Control.MousePosition
            mousePos.Offset(mouse_offset.X, mouse_offset.Y)
            Location = mousePos
        End If
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text = "1" Then
            TextBox5.Visible = True
            TextBox6.Visible = True
            TextBox13.Visible = True
            TextBox7.Visible = False
            TextBox10.Visible = False
            TextBox14.Visible = False
            TextBox8.Visible = False
            TextBox11.Visible = False
            TextBox15.Visible = False
            TextBox9.Visible = False
            TextBox12.Visible = False
            TextBox16.Visible = False
            Label26.Visible = False
            Label33.Visible = False
            Label48.Visible = False
            Label42.Visible = False
            Label27.Visible = False
            Label34.Visible = False
            Label47.Visible = False
            Label41.Visible = False
            Label28.Visible = False
            Label35.Visible = False
            Label46.Visible = False
            Label40.Visible = False
            TextBox7.Text = ""
            TextBox10.Text = ""
            TextBox14.Text = ""
            TextBox8.Text = ""
            TextBox11.Text = ""
            TextBox15.Text = ""
            TextBox9.Text = ""
            TextBox12.Text = ""
            TextBox16.Text = ""
        End If
        If ComboBox1.Text = "2" Then
            TextBox5.Visible = True
            TextBox6.Visible = True
            TextBox13.Visible = True
            TextBox7.Visible = True
            TextBox10.Visible = True
            TextBox14.Visible = True
            TextBox8.Visible = False
            TextBox11.Visible = False
            TextBox15.Visible = False
            TextBox9.Visible = False
            TextBox12.Visible = False
            TextBox16.Visible = False
            Label26.Visible = True
            Label33.Visible = True
            Label48.Visible = True
            Label42.Visible = True
            Label27.Visible = False
            Label34.Visible = False
            Label47.Visible = False
            Label41.Visible = False
            Label28.Visible = False
            Label35.Visible = False
            Label46.Visible = False
            Label40.Visible = False
            TextBox8.Text = ""
            TextBox11.Text = ""
            TextBox15.Text = ""
            TextBox9.Text = ""
            TextBox12.Text = ""
            TextBox16.Text = ""
        End If
        If ComboBox1.Text = "3" Then
            TextBox5.Visible = True
            TextBox6.Visible = True
            TextBox13.Visible = True
            TextBox7.Visible = True
            TextBox10.Visible = True
            TextBox14.Visible = True
            TextBox8.Visible = True
            TextBox11.Visible = True
            TextBox15.Visible = True
            TextBox9.Visible = False
            TextBox12.Visible = False
            TextBox16.Visible = False
            Label26.Visible = True
            Label33.Visible = True
            Label48.Visible = True
            Label42.Visible = True
            Label27.Visible = True
            Label34.Visible = True
            Label47.Visible = True
            Label41.Visible = True
            Label28.Visible = False
            Label35.Visible = False
            Label46.Visible = False
            Label40.Visible = False
            TextBox9.Text = ""
            TextBox12.Text = ""
            TextBox16.Text = ""
        End If
        If ComboBox1.Text = "4" Then
            TextBox5.Visible = True
            TextBox6.Visible = True
            TextBox13.Visible = True
            TextBox7.Visible = True
            TextBox10.Visible = True
            TextBox14.Visible = True
            TextBox8.Visible = True
            TextBox11.Visible = True
            TextBox15.Visible = True
            TextBox9.Visible = True
            TextBox12.Visible = True
            TextBox16.Visible = True
            Label26.Visible = True
            Label33.Visible = True
            Label48.Visible = True
            Label42.Visible = True
            Label27.Visible = True
            Label34.Visible = True
            Label47.Visible = True
            Label41.Visible = True
            Label28.Visible = True
            Label35.Visible = True
            Label46.Visible = True
            Label40.Visible = True
        End If
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox1.Text = "1"
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub TextBox7_TextChanged(sender As Object, e As EventArgs) Handles TextBox7.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub TextBox8_TextChanged(sender As Object, e As EventArgs) Handles TextBox8.TextChanged

    End Sub

    Private Sub TextBox9_TextChanged(sender As Object, e As EventArgs) Handles TextBox9.TextChanged

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles Label15.Click

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox5_LostFocus(sender As Object, e As EventArgs) Handles TextBox5.LostFocus
        Dim length5 As String
        length5 = TextBox5.MaxLength - TextBox5.TextLength
        If length5 = 15 Then
            TextBox5.Text = TextBox5.Text & "               "
        End If
        If length5 = 14 Then
            TextBox5.Text = TextBox5.Text & "              "
        End If
        If length5 = 13 Then
            TextBox5.Text = TextBox5.Text & "             "
        End If
        If length5 = 12 Then
            TextBox5.Text = TextBox5.Text & "            "
        End If
        If length5 = 11 Then
            TextBox5.Text = TextBox5.Text & "           "
        End If
        If length5 = 10 Then
            TextBox5.Text = TextBox5.Text & "          "
        End If
        If length5 = 9 Then
            TextBox5.Text = TextBox5.Text & "         "
        End If
        If length5 = 8 Then
            TextBox5.Text = TextBox5.Text & "        "
        End If
        If length5 = 7 Then
            TextBox5.Text = TextBox5.Text & "       "
        End If
        If length5 = 6 Then
            TextBox5.Text = TextBox5.Text & "      "
        End If
        If length5 = 5 Then
            TextBox5.Text = TextBox5.Text & "     "
        End If
        If length5 = 4 Then
            TextBox5.Text = TextBox5.Text & "    "
        End If
        If length5 = 3 Then
            TextBox5.Text = TextBox5.Text & "   "
        End If
        If length5 = 2 Then
            TextBox5.Text = TextBox5.Text & "  "
        End If
        If length5 = 1 Then
            TextBox5.Text = TextBox5.Text & " "
        End If

    End Sub

    Private Sub TextBox7_LostFocus(sender As Object, e As EventArgs) Handles TextBox7.LostFocus
        Dim length51 As String
        length51 = TextBox7.MaxLength - TextBox7.TextLength
        If length51 = 15 Then
            TextBox7.Text = TextBox7.Text & "               "
        End If
        If length51 = 14 Then
            TextBox7.Text = TextBox7.Text & "              "
        End If
        If length51 = 13 Then
            TextBox7.Text = TextBox7.Text & "             "
        End If
        If length51 = 12 Then
            TextBox7.Text = TextBox7.Text & "            "
        End If
        If length51 = 11 Then
            TextBox7.Text = TextBox7.Text & "           "
        End If
        If length51 = 10 Then
            TextBox7.Text = TextBox7.Text & "          "
        End If
        If length51 = 9 Then
            TextBox7.Text = TextBox7.Text & "         "
        End If
        If length51 = 8 Then
            TextBox7.Text = TextBox7.Text & "        "
        End If
        If length51 = 7 Then
            TextBox7.Text = TextBox7.Text & "       "
        End If
        If length51 = 6 Then
            TextBox7.Text = TextBox7.Text & "      "
        End If
        If length51 = 5 Then
            TextBox7.Text = TextBox7.Text & "     "
        End If
        If length51 = 4 Then
            TextBox7.Text = TextBox7.Text & "    "
        End If
        If length51 = 3 Then
            TextBox7.Text = TextBox7.Text & "   "
        End If
        If length51 = 2 Then
            TextBox7.Text = TextBox7.Text & "  "
        End If
        If length51 = 1 Then
            TextBox7.Text = TextBox7.Text & " "
        End If

    End Sub
    Private Sub TextBox8_LostFocus(sender As Object, e As EventArgs) Handles TextBox8.LostFocus
        Dim length52 As String
        length52 = TextBox8.MaxLength - TextBox8.TextLength
        If length52 = 15 Then
            TextBox8.Text = TextBox8.Text & "               "
        End If
        If length52 = 14 Then
            TextBox8.Text = TextBox8.Text & "              "
        End If
        If length52 = 13 Then
            TextBox8.Text = TextBox8.Text & "             "
        End If
        If length52 = 12 Then
            TextBox8.Text = TextBox8.Text & "            "
        End If
        If length52 = 11 Then
            TextBox8.Text = TextBox8.Text & "           "
        End If
        If length52 = 10 Then
            TextBox8.Text = TextBox8.Text & "          "
        End If
        If length52 = 9 Then
            TextBox8.Text = TextBox8.Text & "         "
        End If
        If length52 = 8 Then
            TextBox8.Text = TextBox8.Text & "        "
        End If
        If length52 = 7 Then
            TextBox8.Text = TextBox8.Text & "       "
        End If
        If length52 = 6 Then
            TextBox8.Text = TextBox8.Text & "      "
        End If
        If length52 = 5 Then
            TextBox8.Text = TextBox8.Text & "     "
        End If
        If length52 = 4 Then
            TextBox8.Text = TextBox8.Text & "    "
        End If
        If length52 = 3 Then
            TextBox8.Text = TextBox8.Text & "   "
        End If
        If length52 = 2 Then
            TextBox8.Text = TextBox8.Text & "  "
        End If
        If length52 = 1 Then
            TextBox8.Text = TextBox8.Text & " "
        End If

    End Sub
    Private Sub TextBox9_LostFocus(sender As Object, e As EventArgs) Handles TextBox9.LostFocus
        Dim length53 As String
        length53 = TextBox9.MaxLength - TextBox9.TextLength
        If length53 = 15 Then
            TextBox9.Text = TextBox9.Text & "               "
        End If
        If length53 = 14 Then
            TextBox9.Text = TextBox9.Text & "              "
        End If
        If length53 = 13 Then
            TextBox9.Text = TextBox9.Text & "             "
        End If
        If length53 = 12 Then
            TextBox9.Text = TextBox9.Text & "            "
        End If
        If length53 = 11 Then
            TextBox9.Text = TextBox9.Text & "           "
        End If
        If length53 = 10 Then
            TextBox9.Text = TextBox9.Text & "          "
        End If
        If length53 = 9 Then
            TextBox9.Text = TextBox9.Text & "         "
        End If
        If length53 = 8 Then
            TextBox9.Text = TextBox9.Text & "        "
        End If
        If length53 = 7 Then
            TextBox9.Text = TextBox9.Text & "       "
        End If
        If length53 = 6 Then
            TextBox9.Text = TextBox9.Text & "      "
        End If
        If length53 = 5 Then
            TextBox9.Text = TextBox9.Text & "     "
        End If
        If length53 = 4 Then
            TextBox9.Text = TextBox9.Text & "    "
        End If
        If length53 = 3 Then
            TextBox9.Text = TextBox9.Text & "   "
        End If
        If length53 = 2 Then
            TextBox9.Text = TextBox9.Text & "  "
        End If
        If length53 = 1 Then
            TextBox9.Text = TextBox9.Text & " "
        End If

    End Sub

    Private Sub TextBox5_GotFocus(sender As Object, e As EventArgs) Handles TextBox5.GotFocus
        TextBox5.Text = ""
    End Sub
    Private Sub TextBox7_GotFocus(sender As Object, e As EventArgs) Handles TextBox7.GotFocus
        TextBox7.Text = ""
    End Sub
    Private Sub TextBox8_GotFocus(sender As Object, e As EventArgs) Handles TextBox8.GotFocus
        TextBox8.Text = ""
    End Sub
    Private Sub TextBox9_GotFocus(sender As Object, e As EventArgs) Handles TextBox9.GotFocus
        TextBox9.Text = ""
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub CheckBox1_Click(sender As Object, e As EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked = True Then
            TextBox24.Visible = True
        End If
        If CheckBox1.Checked = False Then
            TextBox24.Visible = False
            TextBox24.Text = ""
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub PutExampleValuesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PutExampleValuesToolStripMenuItem.Click
        TextBox2.Text = "2.5"
        TextBox3.Text = "0.5"
        TextBox4.Text = "1.26"
        TextBox6.Text = "100"
        TextBox13.Text = "3150"
        TextBox17.Text = "0.7"
        TextBox18.Text = "1065"
        TextBox19.Text = "65"
        TextBox20.Text = "2622"
        TextBox21.Text = "1.2"
        TextBox22.Text = "70"
        TextBox23.Text = "30"
    End Sub

    Private Sub StartTheCalculationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartTheCalculationToolStripMenuItem.Click
        If (Val(TextBox6.Text) + Val(TextBox10.Text) + Val(TextBox11.Text) + Val(TextBox12.Text)) = 100 And (Val(TextBox22.Text) + Val(TextBox23.Text)) = 100 Then
            Dim length53 As String
            length53 = TextBox9.MaxLength - TextBox9.TextLength
            If length53 = 15 Then
                TextBox9.Text = TextBox9.Text & "               "
            End If
            If length53 = 14 Then
                TextBox9.Text = TextBox9.Text & "              "
            End If
            If length53 = 13 Then
                TextBox9.Text = TextBox9.Text & "             "
            End If
            If length53 = 12 Then
                TextBox9.Text = TextBox9.Text & "            "
            End If
            If length53 = 11 Then
                TextBox9.Text = TextBox9.Text & "           "
            End If
            If length53 = 10 Then
                TextBox9.Text = TextBox9.Text & "          "
            End If
            If length53 = 9 Then
                TextBox9.Text = TextBox9.Text & "         "
            End If
            If length53 = 8 Then
                TextBox9.Text = TextBox9.Text & "        "
            End If
            If length53 = 7 Then
                TextBox9.Text = TextBox9.Text & "       "
            End If
            If length53 = 6 Then
                TextBox9.Text = TextBox9.Text & "      "
            End If
            If length53 = 5 Then
                TextBox9.Text = TextBox9.Text & "     "
            End If
            If length53 = 4 Then
                TextBox9.Text = TextBox9.Text & "    "
            End If
            If length53 = 3 Then
                TextBox9.Text = TextBox9.Text & "   "
            End If
            If length53 = 2 Then
                TextBox9.Text = TextBox9.Text & "  "
            End If
            If length53 = 1 Then
                TextBox9.Text = TextBox9.Text & " "
            End If
            Dim length52 As String
            length52 = TextBox8.MaxLength - TextBox8.TextLength
            If length52 = 15 Then
                TextBox8.Text = TextBox8.Text & "               "
            End If
            If length52 = 14 Then
                TextBox8.Text = TextBox8.Text & "              "
            End If
            If length52 = 13 Then
                TextBox8.Text = TextBox8.Text & "             "
            End If
            If length52 = 12 Then
                TextBox8.Text = TextBox8.Text & "            "
            End If
            If length52 = 11 Then
                TextBox8.Text = TextBox8.Text & "           "
            End If
            If length52 = 10 Then
                TextBox8.Text = TextBox8.Text & "          "
            End If
            If length52 = 9 Then
                TextBox8.Text = TextBox8.Text & "         "
            End If
            If length52 = 8 Then
                TextBox8.Text = TextBox8.Text & "        "
            End If
            If length52 = 7 Then
                TextBox8.Text = TextBox8.Text & "       "
            End If
            If length52 = 6 Then
                TextBox8.Text = TextBox8.Text & "      "
            End If
            If length52 = 5 Then
                TextBox8.Text = TextBox8.Text & "     "
            End If
            If length52 = 4 Then
                TextBox8.Text = TextBox8.Text & "    "
            End If
            If length52 = 3 Then
                TextBox8.Text = TextBox8.Text & "   "
            End If
            If length52 = 2 Then
                TextBox8.Text = TextBox8.Text & "  "
            End If
            If length52 = 1 Then
                TextBox8.Text = TextBox8.Text & " "
            End If
            Dim length51 As String
            length51 = TextBox7.MaxLength - TextBox7.TextLength
            If length51 = 15 Then
                TextBox7.Text = TextBox7.Text & "               "
            End If
            If length51 = 14 Then
                TextBox7.Text = TextBox7.Text & "              "
            End If
            If length51 = 13 Then
                TextBox7.Text = TextBox7.Text & "             "
            End If
            If length51 = 12 Then
                TextBox7.Text = TextBox7.Text & "            "
            End If
            If length51 = 11 Then
                TextBox7.Text = TextBox7.Text & "           "
            End If
            If length51 = 10 Then
                TextBox7.Text = TextBox7.Text & "          "
            End If
            If length51 = 9 Then
                TextBox7.Text = TextBox7.Text & "         "
            End If
            If length51 = 8 Then
                TextBox7.Text = TextBox7.Text & "        "
            End If
            If length51 = 7 Then
                TextBox7.Text = TextBox7.Text & "       "
            End If
            If length51 = 6 Then
                TextBox7.Text = TextBox7.Text & "      "
            End If
            If length51 = 5 Then
                TextBox7.Text = TextBox7.Text & "     "
            End If
            If length51 = 4 Then
                TextBox7.Text = TextBox7.Text & "    "
            End If
            If length51 = 3 Then
                TextBox7.Text = TextBox7.Text & "   "
            End If
            If length51 = 2 Then
                TextBox7.Text = TextBox7.Text & "  "
            End If
            If length51 = 1 Then
                TextBox7.Text = TextBox7.Text & " "
            End If

            Dim length5 As String
            length5 = TextBox5.MaxLength - TextBox5.TextLength
            If length5 = 15 Then
                TextBox5.Text = TextBox5.Text & "               "
            End If
            If length5 = 14 Then
                TextBox5.Text = TextBox5.Text & "              "
            End If
            If length5 = 13 Then
                TextBox5.Text = TextBox5.Text & "             "
            End If
            If length5 = 12 Then
                TextBox5.Text = TextBox5.Text & "            "
            End If
            If length5 = 11 Then
                TextBox5.Text = TextBox5.Text & "           "
            End If
            If length5 = 10 Then
                TextBox5.Text = TextBox5.Text & "          "
            End If
            If length5 = 9 Then
                TextBox5.Text = TextBox5.Text & "         "
            End If
            If length5 = 8 Then
                TextBox5.Text = TextBox5.Text & "        "
            End If
            If length5 = 7 Then
                TextBox5.Text = TextBox5.Text & "       "
            End If
            If length5 = 6 Then
                TextBox5.Text = TextBox5.Text & "      "
            End If
            If length5 = 5 Then
                TextBox5.Text = TextBox5.Text & "     "
            End If
            If length5 = 4 Then
                TextBox5.Text = TextBox5.Text & "    "
            End If
            If length5 = 3 Then
                TextBox5.Text = TextBox5.Text & "   "
            End If
            If length5 = 2 Then
                TextBox5.Text = TextBox5.Text & "  "
            End If
            If length5 = 1 Then
                TextBox5.Text = TextBox5.Text & " "
            End If
            Dim smratio As String
            Dim wpratio As String
            Dim volume As String
            Dim per1po As String
            Dim per2po As String
            Dim per3po As String
            Dim per4po As String
            Dim vol1po As String
            Dim vol2po As String
            Dim vol3po As String
            Dim vol4po As String
            Dim volsand As String
            Dim volwater As String
            Dim den1po As String
            Dim den2po As String
            Dim den3po As String
            Dim den4po As String
            Dim qua1po As Double
            Dim qua2po As Double
            Dim qua3po As Double
            Dim qua4po As Double
            Dim quasand As String
            Dim densand As String
            Dim abssand As String
            Dim persup As String
            Dim quasup As String
            Dim watercont As String
            Dim quawater As String
            Dim waterper1 As String
            Dim waterper2 As String
            Dim quaw1 As String
            Dim quaw2 As String
            Dim waterpowderratio As String
            Dim pv As String
            Dim wv As String
            smratio = Val(TextBox3.Text)
            wpratio = Val(TextBox4.Text)
            volume = Val(TextBox2.Text)
            per1po = Val(TextBox6.Text)
            per2po = Val(TextBox10.Text)
            per3po = Val(TextBox11.Text)
            per4po = Val(TextBox12.Text)
            den1po = Val(TextBox13.Text)
            den2po = Val(TextBox14.Text)
            den3po = Val(TextBox15.Text)
            den4po = Val(TextBox16.Text)
            densand = Val(TextBox20.Text)
            abssand = Val(TextBox21.Text)
            persup = Val(TextBox17.Text)
            watercont = Val(TextBox19.Text)
            waterper1 = Val(TextBox22.Text)
            waterper2 = Val(TextBox23.Text)
            Label25.Text = TextBox5.Text
            Label26.Text = TextBox7.Text
            Label27.Text = TextBox8.Text
            Label28.Text = TextBox9.Text
            Label49.Text = TextBox5.Text
            Label48.Text = TextBox7.Text
            Label47.Text = TextBox8.Text
            Label46.Text = TextBox9.Text
            pv = (1 - smratio) * 100 / (1 + wpratio)
            Label19.Text = Math.Round(CType(pv, Double), 2) & " %"
            wv = (1 - smratio) * 100 / (1 + wpratio) * wpratio
            Label20.Text = Math.Round(CType(wv, Double), 2) & " %"
            Label23.Text = Math.Round(smratio * 100, 2) & " %"
            volsand = volume * smratio
            Label36.Text = Math.Round(CType(volsand, Double), 3) & " L"
            volwater = (volume * wv) / 100
            Label37.Text = Math.Round(CType(volwater, Double), 3) & " L"
            quasand = ((densand * volsand) / 1000) - (((densand * volsand) / 1000) * abssand) / 100
            Label39.Text = Math.Round(CType(quasand, Double), 3) & " Kg"
            If ComboBox1.Text = "1" Then
                Label25.Text = TextBox5.Text
                Label26.Text = ""
                Label27.Text = ""
                Label28.Text = ""
                Label49.Text = TextBox5.Text
                Label48.Text = ""
                Label47.Text = ""
                Label46.Text = ""
                vol1po = (volume * per1po * pv) / 10000
                Label32.Text = Math.Round(CType(vol1po, Double), 3) & " L"
                qua1po = (den1po * vol1po) / 1000
                Label43.Text = Math.Round(CType(qua1po, Double), 3) & " Kg"
                quasup = (persup / 100) * (qua1po)
                Label54.Text = Math.Round(CType(quasup, Double), 3) & " Kg"
                quawater = volwater + (((densand * volsand) / 1000) * abssand / 100) - (watercont * quasup) / 100
                Label38.Text = Math.Round(CType(quawater, Double), 3) & " Kg"
                quaw1 = (waterper1 / 100) * quawater
                Label50.Text = Math.Round(CType(quaw1, Double), 3) & " Kg"
                quaw2 = (waterper2 / 100) * quawater
                Label52.Text = Math.Round(CType(quaw2, Double), 3) & " Kg"
                waterpowderratio = volwater / (qua1po)
                Label56.Text = Math.Round(CType(waterpowderratio, Double), 3)
            End If
            If ComboBox1.Text = "2" Then
                Label25.Text = TextBox5.Text
                Label26.Text = TextBox7.Text
                Label27.Text = ""
                Label28.Text = ""
                Label49.Text = TextBox5.Text
                Label48.Text = TextBox7.Text
                Label47.Text = ""
                Label46.Text = ""
                vol1po = (volume * per1po * pv) / 10000
                Label32.Text = Math.Round(CType(vol1po, Double), 3) & " L"
                qua1po = (den1po * vol1po) / 1000
                Label43.Text = Math.Round(CType(qua1po, Double), 3) & " Kg"
                vol2po = (volume * per2po * pv) / 10000
                Label33.Text = Math.Round(CType(vol2po, Double), 3) & " L"
                qua2po = (den2po * vol2po) / 1000
                Label42.Text = Math.Round(CType(qua2po, Double), 3) & " Kg"
                quasup = (persup / 100) * (qua1po + qua2po)
                Label54.Text = Math.Round(CType(quasup, Double), 3) & " Kg"
                quawater = volwater + (((densand * volsand) / 1000) * abssand / 100) - (watercont * quasup) / 100
                Label38.Text = Math.Round(CType(quawater, Double), 3) & " Kg"
                quaw1 = (waterper1 / 100) * quawater
                Label50.Text = Math.Round(CType(quaw1, Double), 3) & " Kg"
                quaw2 = (waterper2 / 100) * quawater
                Label52.Text = Math.Round(CType(quaw2, Double), 3) & " Kg"
                waterpowderratio = volwater / (qua1po + qua2po)
                Label56.Text = Math.Round(CType(waterpowderratio, Double), 3)
            End If
            If ComboBox1.Text = "3" Then
                Label25.Text = TextBox5.Text
                Label26.Text = TextBox7.Text
                Label27.Text = TextBox8.Text
                Label28.Text = ""
                Label49.Text = TextBox5.Text
                Label48.Text = TextBox7.Text
                Label47.Text = TextBox8.Text
                Label46.Text = ""
                vol1po = (volume * per1po * pv) / 10000
                Label32.Text = Math.Round(CType(vol1po, Double), 3) & " L"
                qua1po = (den1po * vol1po) / 1000
                Label43.Text = Math.Round(CType(qua1po, Double), 3) & " Kg"
                vol2po = (volume * per2po * pv) / 10000
                Label33.Text = Math.Round(CType(vol2po, Double), 3) & " L"
                vol3po = (volume * per3po * pv) / 10000
                Label34.Text = Math.Round(CType(vol3po, Double), 3) & " L"
                qua2po = (den2po * vol2po) / 1000
                Label42.Text = Math.Round(CType(qua2po, Double), 3) & " Kg"
                qua3po = (den3po * vol3po) / 1000
                Label41.Text = Math.Round(CType(qua3po, Double), 3) & " Kg"
                quasup = (persup / 100) * (qua1po + qua2po + qua3po)
                Label54.Text = Math.Round(CType(quasup, Double), 3) & " Kg"
                quawater = volwater + (((densand * volsand) / 1000) * abssand / 100) - (watercont * quasup) / 100
                Label38.Text = Math.Round(CType(quawater, Double), 3) & " Kg"
                quaw1 = (waterper1 / 100) * quawater
                Label50.Text = Math.Round(CType(quaw1, Double), 3) & " Kg"
                quaw2 = (waterper2 / 100) * quawater
                Label52.Text = Math.Round(CType(quaw2, Double), 3) & " Kg"
                waterpowderratio = volwater / (qua1po + qua2po + qua3po)
                Label56.Text = Math.Round(CType(waterpowderratio, Double), 3)
            End If
            If ComboBox1.Text = "4" Then
                Label25.Text = TextBox5.Text
                Label26.Text = TextBox7.Text
                Label27.Text = TextBox8.Text
                Label28.Text = TextBox9.Text
                Label49.Text = TextBox5.Text
                Label48.Text = TextBox7.Text
                Label47.Text = TextBox8.Text
                Label46.Text = TextBox9.Text
                vol1po = (volume * per1po * pv) / 10000
                Label32.Text = Math.Round(CType(vol1po, Double), 3) & " L"
                qua1po = (den1po * vol1po) / 1000
                Label43.Text = Math.Round(CType(qua1po, Double), 3) & " Kg"
                vol2po = (volume * per2po * pv) / 10000
                Label33.Text = Math.Round(CType(vol2po, Double), 3) & " L"
                vol3po = (volume * per3po * pv) / 10000
                Label34.Text = Math.Round(CType(vol3po, Double), 3) & " L"
                vol4po = (volume * per4po * pv) / 10000
                Label35.Text = Math.Round(CType(vol4po, Double), 3) & " L"
                qua2po = (den2po * vol2po) / 1000
                Label42.Text = Math.Round(CType(qua2po, Double), 3) & " Kg"
                qua3po = (den3po * vol3po) / 1000
                Label41.Text = Math.Round(CType(qua3po, Double), 3) & " Kg"
                qua4po = (den4po * vol4po) / 1000
                Label40.Text = Math.Round(CType(qua4po, Double), 3) & " Kg"
                quasup = (persup / 100) * (qua1po + qua2po + qua3po + qua4po)
                Label54.Text = Math.Round(CType(quasup, Double), 3) & " Kg"
                quawater = volwater + (((densand * volsand) / 1000) * abssand / 100) - (watercont * quasup) / 100
                Label38.Text = Math.Round(CType(quawater, Double), 3) & " Kg"
                quaw1 = (waterper1 / 100) * quawater
                Label50.Text = Math.Round(CType(quaw1, Double), 3) & " Kg"
                quaw2 = (waterper2 / 100) * quawater
                Label52.Text = Math.Round(CType(quaw2, Double), 3) & " Kg"
                waterpowderratio = volwater / (qua1po + qua2po + qua3po + qua4po)
                Label56.Text = Math.Round(CType(waterpowderratio, Double), 3)
            End If
        Else
            MsgBox("Il faut assurer que la somme de pourcentage des poudres est 100% même pour la somme de l'eau 01 et l'eau 02 doit être 100%")
        End If


    End Sub

    Private Sub SaveAsTextFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsTextFileToolStripMenuItem.Click
        Dim smratio As String
        Dim wpratio As String
        Dim volume As String
        Dim per1po As String
        Dim per2po As String
        Dim per3po As String
        Dim per4po As String
        Dim vol1po As String
        Dim vol2po As String
        Dim vol3po As String
        Dim vol4po As String
        Dim volsand As String
        Dim volwater As String
        Dim den1po As String
        Dim den2po As String
        Dim den3po As String
        Dim den4po As String
        Dim qua1po As Double
        Dim qua2po As Double
        Dim qua3po As Double
        Dim qua4po As Double
        Dim quasand As String
        Dim densand As String
        Dim abssand As String
        Dim persup As String
        Dim quasup As String
        Dim watercont As String
        Dim quawater As String
        Dim waterper1 As String
        Dim waterper2 As String
        Dim quaw1 As String
        Dim quaw2 As String
        Dim waterpowderratio As String
        Dim pv As String
        Dim wv As String
        smratio = Val(TextBox3.Text)
        wpratio = Val(TextBox4.Text)
        volume = "1000"
        per1po = Val(TextBox6.Text)
        per2po = Val(TextBox10.Text)
        per3po = Val(TextBox11.Text)
        per4po = Val(TextBox12.Text)
        den1po = Val(TextBox13.Text)
        den2po = Val(TextBox14.Text)
        den3po = Val(TextBox15.Text)
        den4po = Val(TextBox16.Text)
        densand = Val(TextBox20.Text)
        abssand = Val(TextBox21.Text)
        persup = Val(TextBox17.Text)
        watercont = Val(TextBox19.Text)
        waterper1 = Val(TextBox22.Text)
        waterper2 = Val(TextBox23.Text)
        pv = (1 - smratio) * 100 / (1 + wpratio)
        wv = (1 - smratio) * 100 / (1 + wpratio) * wpratio
        volsand = volume * smratio
        volwater = (volume * wv) / 100
        quasand = ((densand * volsand) / 1000) - (((densand * volsand) / 1000) * abssand) / 100
        Dim file As StreamWriter
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "TXT Files (*.txt*)|*.txt"
        Dim results As DialogResult
        results = saveFileDialog1.ShowDialog
        If results = DialogResult.OK Then
            file = New StreamWriter(saveFileDialog1.FileName, True)
            file.WriteLine("---------------------------------Début---------------------------------")
            file.WriteLine("Nom du malaxage: " & TextBox1.Text)
            file.WriteLine(DateTime.Now)
            file.WriteLine("Volume de mortier               " & TextBox2.Text & " L")
            file.WriteLine("Sable/Mortier par Vol           " & (Val(TextBox3.Text) * 100) & " %")
            file.WriteLine("Eau/poudres par Vol             " & TextBox4.Text)
            file.WriteLine("Superplastifiant par Vol        " & TextBox17.Text & " %")
            file.WriteLine("Densité de superplastifiant     " & TextBox18.Text & " Kg/m3")
            file.WriteLine("Contenance d'eau super-plas     " & TextBox19.Text & " %")
            file.WriteLine("Densité de sable                " & TextBox20.Text & " Kg/m3")
            file.WriteLine("Absorption d'eau (sable)        " & TextBox21.Text & " %")
            file.WriteLine("Eau 01                          " & TextBox22.Text & " %")
            file.WriteLine("Eau 02                          " & TextBox23.Text & " %")
            If ComboBox1.Text = "1" Then
                vol1po = (volume * per1po * pv) / 10000
                qua1po = (den1po * vol1po) / 1000
                quasup = (persup / 100) * (qua1po)
                quawater = volwater + (((densand * volsand) / 1000) * abssand / 100) - (watercont * quasup) / 100
                quaw1 = (waterper1 / 100) * quawater
                quaw2 = (waterper2 / 100) * quawater
                waterpowderratio = volwater / (qua1po)
                file.WriteLine("Nom du poudre" & "   " & "pourcentage %" & "    " & "Densité Kg/m3")
                file.WriteLine(TextBox5.Text & "    " & TextBox6.Text & "               " & TextBox13.Text)
                file.WriteLine("                                 ")
                file.WriteLine("Résultats:")
                file.WriteLine("Volume par %")
                file.WriteLine("Poudre Vol                      " & Label19.Text)
                file.WriteLine("Eau Vol                         " & Label20.Text)
                file.WriteLine("Sable Vol                       " & Label23.Text)
                file.WriteLine("Volume par L")
                file.WriteLine("Sable                           " & Label36.Text)
                file.WriteLine("Eau                             " & Label37.Text)
                file.WriteLine(Label25.Text & "                " & Label32.Text)
                file.WriteLine("Quantité par Kg")
                file.WriteLine("Sable                           " & Label39.Text)
                file.WriteLine("Eau total                       " & Label38.Text)
                file.WriteLine("Eau 01                          " & Label50.Text)
                file.WriteLine("Eau 02                          " & Label52.Text)
                file.WriteLine("Superplastifiant                " & Label54.Text)
                file.WriteLine("Eau/Poudre                      " & Label56.Text)
                file.WriteLine(Label49.Text & "                " & Label43.Text)
                file.WriteLine("                                 ")
                file.WriteLine("La quantité par 1m3:")
                file.WriteLine("Sable                           " & Math.Round(CType(quasand, Double), 3) & " Kg/m3")
                file.WriteLine("L'eau total                     " & Math.Round(CType(quawater, Double), 3) & " Kg/m3")
                file.WriteLine("Eau 01                          " & Math.Round(CType(quaw1, Double), 3) & " Kg/m3")
                file.WriteLine("Eau 02                          " & Math.Round(CType(quaw2, Double), 3) & " Kg/m3")
                file.WriteLine("Superplastifiant                " & Math.Round(CType(quasup, Double), 3) & " Kg/m3")
                file.WriteLine(Label49.Text & "                " & Math.Round(CType(qua1po, Double), 3) & " Kg/m3")
            End If
            If ComboBox1.Text = "2" Then
                vol1po = (volume * per1po * pv) / 10000
                qua1po = (den1po * vol1po) / 1000
                vol2po = (volume * per2po * pv) / 10000
                qua2po = (den2po * vol2po) / 1000
                quasup = (persup / 100) * (qua1po + qua2po)
                quawater = volwater + (((densand * volsand) / 1000) * abssand / 100) - (watercont * quasup) / 100
                quaw1 = (waterper1 / 100) * quawater
                quaw2 = (waterper2 / 100) * quawater
                waterpowderratio = volwater / (qua1po + qua2po)
                file.WriteLine("Nom du poudre" & "   " & "pourcentage %" & "    " & "Densité Kg/m3")
                file.WriteLine(TextBox5.Text & "    " & TextBox6.Text & "                " & TextBox13.Text)
                file.WriteLine(TextBox7.Text & "    " & TextBox10.Text & "                " & TextBox14.Text)
                file.WriteLine("                                 ")
                file.WriteLine("Résultats:")
                file.WriteLine("Volume par %")
                file.WriteLine("Poudre Vol                      " & Label19.Text)
                file.WriteLine("Eau Vol                         " & Label20.Text)
                file.WriteLine("Sable Vol                       " & Label23.Text)
                file.WriteLine("Volume par L")
                file.WriteLine("Sable                           " & Label36.Text)
                file.WriteLine("Eau                             " & Label37.Text)
                file.WriteLine(Label25.Text & "                " & Label32.Text)
                file.WriteLine(Label26.Text & "                " & Label33.Text)
                file.WriteLine("Quantité par Kg")
                file.WriteLine("Sable                           " & Label39.Text)
                file.WriteLine("Eau total                       " & Label38.Text)
                file.WriteLine("Eau 01                          " & Label50.Text)
                file.WriteLine("Eau 02                          " & Label52.Text)
                file.WriteLine("Superplastifiant                " & Label54.Text)
                file.WriteLine("Eau/Poudre                      " & Label56.Text)
                file.WriteLine(Label49.Text & "                " & Label43.Text)
                file.WriteLine(Label48.Text & "                " & Label42.Text)
                file.WriteLine("                                 ")
                file.WriteLine("La quantité par 1m3:")
                file.WriteLine("Sable                           " & Math.Round(CType(quasand, Double), 3) & " Kg/m3")
                file.WriteLine("L'eau total                     " & Math.Round(CType(quawater, Double), 3) & " Kg/m3")
                file.WriteLine("Eau 01                          " & Math.Round(CType(quaw1, Double), 3) & " Kg/m3")
                file.WriteLine("Eau 02                          " & Math.Round(CType(quaw2, Double), 3) & " Kg/m3")
                file.WriteLine("Superplastifiant                " & Math.Round(CType(quasup, Double), 3) & " Kg/m3")
                file.WriteLine(Label49.Text & "                " & Math.Round(CType(qua1po, Double), 3) & " Kg/m3")
                file.WriteLine(Label48.Text & "                " & Math.Round(CType(qua2po, Double), 3) & " Kg/m3")
            End If
            If ComboBox1.Text = "3" Then
                vol1po = (volume * per1po * pv) / 10000
                qua1po = (den1po * vol1po) / 1000
                vol2po = (volume * per2po * pv) / 10000
                vol3po = (volume * per3po * pv) / 10000
                qua2po = (den2po * vol2po) / 1000
                qua3po = (den3po * vol3po) / 1000
                quasup = (persup / 100) * (qua1po + qua2po + qua3po)
                quawater = volwater + (((densand * volsand) / 1000) * abssand / 100) - (watercont * quasup) / 100
                quaw1 = (waterper1 / 100) * quawater
                quaw2 = (waterper2 / 100) * quawater
                waterpowderratio = volwater / (qua1po + qua2po + qua3po)
                file.WriteLine("Nom du poudre" & "   " & "pourcentage %" & "    " & "Densité Kg/m3")
                file.WriteLine(TextBox5.Text & "    " & TextBox6.Text & "                " & TextBox13.Text)
                file.WriteLine(TextBox7.Text & "    " & TextBox10.Text & "                " & TextBox14.Text)
                file.WriteLine(TextBox8.Text & "    " & TextBox11.Text & "                " & TextBox15.Text)
                file.WriteLine("                                 ")
                file.WriteLine("Résultats:")
                file.WriteLine("Volume par %")
                file.WriteLine("Poudre Vol                      " & Label19.Text)
                file.WriteLine("Eau Vol                         " & Label20.Text)
                file.WriteLine("Sable Vol                       " & Label23.Text)
                file.WriteLine("Volume par L")
                file.WriteLine("Sable                           " & Label36.Text)
                file.WriteLine("Eau                             " & Label37.Text)
                file.WriteLine(Label25.Text & "                " & Label32.Text)
                file.WriteLine(Label26.Text & "                " & Label33.Text)
                file.WriteLine(Label27.Text & "                " & Label34.Text)
                file.WriteLine("Quantité par Kg")
                file.WriteLine("Sable                           " & Label39.Text)
                file.WriteLine("Eau total                       " & Label38.Text)
                file.WriteLine("Eau 01                          " & Label50.Text)
                file.WriteLine("Eau 02                          " & Label52.Text)
                file.WriteLine("Superplastifiant                " & Label54.Text)
                file.WriteLine("Eau/Poudre                      " & Label56.Text)
                file.WriteLine(Label49.Text & "                " & Label43.Text)
                file.WriteLine(Label48.Text & "                " & Label42.Text)
                file.WriteLine(Label47.Text & "                " & Label41.Text)
                file.WriteLine("                                 ")
                file.WriteLine("La quantité par 1m3:")
                file.WriteLine("Sable                           " & Math.Round(CType(quasand, Double), 3) & " Kg/m3")
                file.WriteLine("L'eau total                     " & Math.Round(CType(quawater, Double), 3) & " Kg/m3")
                file.WriteLine("Eau 01                          " & Math.Round(CType(quaw1, Double), 3) & " Kg/m3")
                file.WriteLine("Eau 02                          " & Math.Round(CType(quaw2, Double), 3) & " Kg/m3")
                file.WriteLine("Superplastifiant                " & Math.Round(CType(quasup, Double), 3) & " Kg/m3")
                file.WriteLine(Label49.Text & "                " & Math.Round(CType(qua1po, Double), 3) & " Kg/m3")
                file.WriteLine(Label48.Text & "                " & Math.Round(CType(qua2po, Double), 3) & " Kg/m3")
                file.WriteLine(Label47.Text & "                " & Math.Round(CType(qua3po, Double), 3) & " Kg/m3")
            End If
            If ComboBox1.Text = "4" Then
                vol1po = (volume * per1po * pv) / 10000
                qua1po = (den1po * vol1po) / 1000
                vol2po = (volume * per2po * pv) / 10000
                vol3po = (volume * per3po * pv) / 10000
                vol4po = (volume * per4po * pv) / 10000
                qua2po = (den2po * vol2po) / 1000
                qua3po = (den3po * vol3po) / 1000
                qua4po = (den4po * vol4po) / 1000
                quasup = (persup / 100) * (qua1po + qua2po + qua3po + qua4po)
                quawater = volwater + (((densand * volsand) / 1000) * abssand / 100) - (watercont * quasup) / 100
                quaw1 = (waterper1 / 100) * quawater
                quaw2 = (waterper2 / 100) * quawater
                waterpowderratio = volwater / (qua1po + qua2po + qua3po + qua4po)
                file.WriteLine("Nom du poudre" & "   " & "pourcentage %" & "    " & "Densité Kg/m3")
                file.WriteLine(TextBox5.Text & "    " & TextBox6.Text & "                " & TextBox13.Text)
                file.WriteLine(TextBox7.Text & "    " & TextBox10.Text & "                " & TextBox14.Text)
                file.WriteLine(TextBox8.Text & "    " & TextBox11.Text & "                " & TextBox15.Text)
                file.WriteLine(TextBox9.Text & "    " & TextBox12.Text & "                " & TextBox16.Text)
                file.WriteLine("                                 ")
                file.WriteLine("Résultats:")
                file.WriteLine("Volume par %")
                file.WriteLine("Poudre Vol                      " & Label19.Text)
                file.WriteLine("Eau Vol                         " & Label20.Text)
                file.WriteLine("Sable Vol                       " & Label23.Text)
                file.WriteLine("Volume par L")
                file.WriteLine("Sable                           " & Label36.Text)
                file.WriteLine("Eau                             " & Label37.Text)
                file.WriteLine(Label25.Text & "                " & Label32.Text)
                file.WriteLine(Label26.Text & "                " & Label33.Text)
                file.WriteLine(Label27.Text & "                " & Label34.Text)
                file.WriteLine(Label28.Text & "                " & Label35.Text)
                file.WriteLine("Quantité par Kg")
                file.WriteLine("Sable                           " & Label39.Text)
                file.WriteLine("Eau total                       " & Label38.Text)
                file.WriteLine("Eau 01                          " & Label50.Text)
                file.WriteLine("Eau 02                          " & Label52.Text)
                file.WriteLine("Superplastifiant                " & Label54.Text)
                file.WriteLine("Eau/Poudre                      " & Label56.Text)
                file.WriteLine(Label49.Text & "                " & Label43.Text)
                file.WriteLine(Label48.Text & "                " & Label42.Text)
                file.WriteLine(Label47.Text & "                " & Label41.Text)
                file.WriteLine(Label46.Text & "                " & Label40.Text)
                file.WriteLine("                                 ")
                file.WriteLine("La quantité par 1m3:")
                file.WriteLine("Sable                           " & Math.Round(CType(quasand, Double), 3) & " Kg/m3")
                file.WriteLine("L'eau total                     " & Math.Round(CType(quawater, Double), 3) & " Kg/m3")
                file.WriteLine("Eau 01                          " & Math.Round(CType(quaw1, Double), 3) & " Kg/m3")
                file.WriteLine("Eau 02                          " & Math.Round(CType(quaw2, Double), 3) & " Kg/m3")
                file.WriteLine("Superplastifiant                " & Math.Round(CType(quasup, Double), 3) & " Kg/m3")
                file.WriteLine(Label49.Text & "                " & Math.Round(CType(qua1po, Double), 3) & " Kg/m3")
                file.WriteLine(Label48.Text & "                " & Math.Round(CType(qua2po, Double), 3) & " Kg/m3")
                file.WriteLine(Label47.Text & "                " & Math.Round(CType(qua3po, Double), 3) & " Kg/m3")
                file.WriteLine(Label46.Text & "                " & Math.Round(CType(qua4po, Double), 3) & " Kg/m3")
            End If
            If CheckBox1.Checked = True Then
                file.WriteLine("                                 ")
                file.WriteLine("Commentaires:")
                file.WriteLine(TextBox24.Text)
            End If
            file.WriteLine("----------------------------------Fin-----------------------------------")
            file.Close()
        End If

    End Sub

    Private Sub SaveAsDocFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveAsDocFileToolStripMenuItem.Click
        Dim smratio As String
        Dim wpratio As String
        Dim volume As String
        Dim per1po As String
        Dim per2po As String
        Dim per3po As String
        Dim per4po As String
        Dim vol1po As String
        Dim vol2po As String
        Dim vol3po As String
        Dim vol4po As String
        Dim volsand As String
        Dim volwater As String
        Dim den1po As String
        Dim den2po As String
        Dim den3po As String
        Dim den4po As String
        Dim qua1po As Double
        Dim qua2po As Double
        Dim qua3po As Double
        Dim qua4po As Double
        Dim quasand As String
        Dim densand As String
        Dim abssand As String
        Dim persup As String
        Dim quasup As String
        Dim watercont As String
        Dim quawater As String
        Dim waterper1 As String
        Dim waterper2 As String
        Dim quaw1 As String
        Dim quaw2 As String
        Dim waterpowderratio As String
        Dim pv As String
        Dim wv As String
        smratio = Val(TextBox3.Text)
        wpratio = Val(TextBox4.Text)
        volume = "1000"
        per1po = Val(TextBox6.Text)
        per2po = Val(TextBox10.Text)
        per3po = Val(TextBox11.Text)
        per4po = Val(TextBox12.Text)
        den1po = Val(TextBox13.Text)
        den2po = Val(TextBox14.Text)
        den3po = Val(TextBox15.Text)
        den4po = Val(TextBox16.Text)
        densand = Val(TextBox20.Text)
        abssand = Val(TextBox21.Text)
        persup = Val(TextBox17.Text)
        watercont = Val(TextBox19.Text)
        waterper1 = Val(TextBox22.Text)
        waterper2 = Val(TextBox23.Text)
        pv = (1 - smratio) * 100 / (1 + wpratio)
        wv = (1 - smratio) * 100 / (1 + wpratio) * wpratio
        volsand = volume * smratio
        volwater = (volume * wv) / 100
        quasand = ((densand * volsand) / 1000) - (((densand * volsand) / 1000) * abssand) / 100
        Dim file As StreamWriter
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "doc file (*.doc*)|*.doc"
        Dim results As DialogResult
        results = saveFileDialog1.ShowDialog
        If results = DialogResult.OK Then
            file = New StreamWriter(saveFileDialog1.FileName, True)
            file.WriteLine("---------------------------------Début---------------------------------")
            file.WriteLine("Nom du malaxage: " & TextBox1.Text)
            file.WriteLine(DateTime.Now)
            file.WriteLine("Volume de mortier               " & TextBox2.Text & " L")
            file.WriteLine("Sable/Mortier par Vol           " & (Val(TextBox3.Text) * 100) & " %")
            file.WriteLine("Eau/poudres par Vol             " & TextBox4.Text)
            file.WriteLine("Superplastifiant par Vol        " & TextBox17.Text & " %")
            file.WriteLine("Densité de superplastifiant     " & TextBox18.Text & " Kg/m3")
            file.WriteLine("Contenance d'eau super-plas     " & TextBox19.Text & " %")
            file.WriteLine("Densité de sable                " & TextBox20.Text & " Kg/m3")
            file.WriteLine("Absorption d'eau (sable)        " & TextBox21.Text & " %")
            file.WriteLine("Eau 01                          " & TextBox22.Text & " %")
            file.WriteLine("Eau 02                          " & TextBox23.Text & " %")
            If ComboBox1.Text = "1" Then
                vol1po = (volume * per1po * pv) / 10000
                qua1po = (den1po * vol1po) / 1000
                quasup = (persup / 100) * (qua1po)
                quawater = volwater + (((densand * volsand) / 1000) * abssand / 100) - (watercont * quasup) / 100
                quaw1 = (waterper1 / 100) * quawater
                quaw2 = (waterper2 / 100) * quawater
                waterpowderratio = volwater / (qua1po)
                file.WriteLine("Nom du poudre" & "   " & "pourcentage %" & "    " & "Densité Kg/m3")
                file.WriteLine(TextBox5.Text & "    " & TextBox6.Text & "               " & TextBox13.Text)
                file.WriteLine("                                 ")
                file.WriteLine("Résultats:")
                file.WriteLine("Volume par %")
                file.WriteLine("Poudre Vol                      " & Label19.Text)
                file.WriteLine("Eau Vol                         " & Label20.Text)
                file.WriteLine("Sable Vol                       " & Label23.Text)
                file.WriteLine("Volume par L")
                file.WriteLine("Sable                           " & Label36.Text)
                file.WriteLine("Eau                             " & Label37.Text)
                file.WriteLine(Label25.Text & "                " & Label32.Text)
                file.WriteLine("Quantité par Kg")
                file.WriteLine("Sable                           " & Label39.Text)
                file.WriteLine("Eau total                       " & Label38.Text)
                file.WriteLine("Eau 01                          " & Label50.Text)
                file.WriteLine("Eau 02                          " & Label52.Text)
                file.WriteLine("Superplastifiant                " & Label54.Text)
                file.WriteLine("Eau/Poudre                      " & Label56.Text)
                file.WriteLine(Label49.Text & "                " & Label43.Text)
                file.WriteLine("                                 ")
                file.WriteLine("La quantité par 1m3:")
                file.WriteLine("Sable                           " & Math.Round(CType(quasand, Double), 3) & " Kg/m3")
                file.WriteLine("L'eau total                     " & Math.Round(CType(quawater, Double), 3) & " Kg/m3")
                file.WriteLine("Eau 01                          " & Math.Round(CType(quaw1, Double), 3) & " Kg/m3")
                file.WriteLine("Eau 02                          " & Math.Round(CType(quaw2, Double), 3) & " Kg/m3")
                file.WriteLine("Superplastifiant                " & Math.Round(CType(quasup, Double), 3) & " Kg/m3")
                file.WriteLine(Label49.Text & "                " & Math.Round(CType(qua1po, Double), 3) & " Kg/m3")
            End If
            If ComboBox1.Text = "2" Then
                vol1po = (volume * per1po * pv) / 10000
                qua1po = (den1po * vol1po) / 1000
                vol2po = (volume * per2po * pv) / 10000
                qua2po = (den2po * vol2po) / 1000
                quasup = (persup / 100) * (qua1po + qua2po)
                quawater = volwater + (((densand * volsand) / 1000) * abssand / 100) - (watercont * quasup) / 100
                quaw1 = (waterper1 / 100) * quawater
                quaw2 = (waterper2 / 100) * quawater
                waterpowderratio = volwater / (qua1po + qua2po)
                file.WriteLine("Nom du poudre" & "   " & "pourcentage %" & "    " & "Densité Kg/m3")
                file.WriteLine(TextBox5.Text & "    " & TextBox6.Text & "                " & TextBox13.Text)
                file.WriteLine(TextBox7.Text & "    " & TextBox10.Text & "                " & TextBox14.Text)
                file.WriteLine("                                 ")
                file.WriteLine("Résultats:")
                file.WriteLine("Volume par %")
                file.WriteLine("Poudre Vol                      " & Label19.Text)
                file.WriteLine("Eau Vol                         " & Label20.Text)
                file.WriteLine("Sable Vol                       " & Label23.Text)
                file.WriteLine("Volume par L")
                file.WriteLine("Sable                           " & Label36.Text)
                file.WriteLine("Eau                             " & Label37.Text)
                file.WriteLine(Label25.Text & "                " & Label32.Text)
                file.WriteLine(Label26.Text & "                " & Label33.Text)
                file.WriteLine("Quantité par Kg")
                file.WriteLine("Sable                           " & Label39.Text)
                file.WriteLine("Eau total                       " & Label38.Text)
                file.WriteLine("Eau 01                          " & Label50.Text)
                file.WriteLine("Eau 02                          " & Label52.Text)
                file.WriteLine("Superplastifiant                " & Label54.Text)
                file.WriteLine("Eau/Poudre                      " & Label56.Text)
                file.WriteLine(Label49.Text & "                " & Label43.Text)
                file.WriteLine(Label48.Text & "                " & Label42.Text)
                file.WriteLine("                                 ")
                file.WriteLine("La quantité par 1m3:")
                file.WriteLine("Sable                           " & Math.Round(CType(quasand, Double), 3) & " Kg/m3")
                file.WriteLine("L'eau total                     " & Math.Round(CType(quawater, Double), 3) & " Kg/m3")
                file.WriteLine("Eau 01                          " & Math.Round(CType(quaw1, Double), 3) & " Kg/m3")
                file.WriteLine("Eau 02                          " & Math.Round(CType(quaw2, Double), 3) & " Kg/m3")
                file.WriteLine("Superplastifiant                " & Math.Round(CType(quasup, Double), 3) & " Kg/m3")
                file.WriteLine(Label49.Text & "                " & Math.Round(CType(qua1po, Double), 3) & " Kg/m3")
                file.WriteLine(Label48.Text & "                " & Math.Round(CType(qua2po, Double), 3) & " Kg/m3")
            End If
            If ComboBox1.Text = "3" Then
                vol1po = (volume * per1po * pv) / 10000
                qua1po = (den1po * vol1po) / 1000
                vol2po = (volume * per2po * pv) / 10000
                vol3po = (volume * per3po * pv) / 10000
                qua2po = (den2po * vol2po) / 1000
                qua3po = (den3po * vol3po) / 1000
                quasup = (persup / 100) * (qua1po + qua2po + qua3po)
                quawater = volwater + (((densand * volsand) / 1000) * abssand / 100) - (watercont * quasup) / 100
                quaw1 = (waterper1 / 100) * quawater
                quaw2 = (waterper2 / 100) * quawater
                waterpowderratio = volwater / (qua1po + qua2po + qua3po)
                file.WriteLine("Nom du poudre" & "   " & "pourcentage %" & "    " & "Densité Kg/m3")
                file.WriteLine(TextBox5.Text & "    " & TextBox6.Text & "                " & TextBox13.Text)
                file.WriteLine(TextBox7.Text & "    " & TextBox10.Text & "                " & TextBox14.Text)
                file.WriteLine(TextBox8.Text & "    " & TextBox11.Text & "                " & TextBox15.Text)
                file.WriteLine("                                 ")
                file.WriteLine("Résultats:")
                file.WriteLine("Volume par %")
                file.WriteLine("Poudre Vol                      " & Label19.Text)
                file.WriteLine("Eau Vol                         " & Label20.Text)
                file.WriteLine("Sable Vol                       " & Label23.Text)
                file.WriteLine("Volume par L")
                file.WriteLine("Sable                           " & Label36.Text)
                file.WriteLine("Eau                             " & Label37.Text)
                file.WriteLine(Label25.Text & "                " & Label32.Text)
                file.WriteLine(Label26.Text & "                " & Label33.Text)
                file.WriteLine(Label27.Text & "                " & Label34.Text)
                file.WriteLine("Quantité par Kg")
                file.WriteLine("Sable                           " & Label39.Text)
                file.WriteLine("Eau total                       " & Label38.Text)
                file.WriteLine("Eau 01                          " & Label50.Text)
                file.WriteLine("Eau 02                          " & Label52.Text)
                file.WriteLine("Superplastifiant                " & Label54.Text)
                file.WriteLine("Eau/Poudre                      " & Label56.Text)
                file.WriteLine(Label49.Text & "                " & Label43.Text)
                file.WriteLine(Label48.Text & "                " & Label42.Text)
                file.WriteLine(Label47.Text & "                " & Label41.Text)
                file.WriteLine("                                 ")
                file.WriteLine("La quantité par 1m3:")
                file.WriteLine("Sable                           " & Math.Round(CType(quasand, Double), 3) & " Kg/m3")
                file.WriteLine("L'eau total                     " & Math.Round(CType(quawater, Double), 3) & " Kg/m3")
                file.WriteLine("Eau 01                          " & Math.Round(CType(quaw1, Double), 3) & " Kg/m3")
                file.WriteLine("Eau 02                          " & Math.Round(CType(quaw2, Double), 3) & " Kg/m3")
                file.WriteLine("Superplastifiant                " & Math.Round(CType(quasup, Double), 3) & " Kg/m3")
                file.WriteLine(Label49.Text & "                " & Math.Round(CType(qua1po, Double), 3) & " Kg/m3")
                file.WriteLine(Label48.Text & "                " & Math.Round(CType(qua2po, Double), 3) & " Kg/m3")
                file.WriteLine(Label47.Text & "                " & Math.Round(CType(qua3po, Double), 3) & " Kg/m3")
            End If
            If ComboBox1.Text = "4" Then
                vol1po = (volume * per1po * pv) / 10000
                qua1po = (den1po * vol1po) / 1000
                vol2po = (volume * per2po * pv) / 10000
                vol3po = (volume * per3po * pv) / 10000
                vol4po = (volume * per4po * pv) / 10000
                qua2po = (den2po * vol2po) / 1000
                qua3po = (den3po * vol3po) / 1000
                qua4po = (den4po * vol4po) / 1000
                quasup = (persup / 100) * (qua1po + qua2po + qua3po + qua4po)
                quawater = volwater + (((densand * volsand) / 1000) * abssand / 100) - (watercont * quasup) / 100
                quaw1 = (waterper1 / 100) * quawater
                quaw2 = (waterper2 / 100) * quawater
                waterpowderratio = volwater / (qua1po + qua2po + qua3po + qua4po)
                file.WriteLine("Nom du poudre" & "   " & "pourcentage %" & "    " & "Densité Kg/m3")
                file.WriteLine(TextBox5.Text & "    " & TextBox6.Text & "                " & TextBox13.Text)
                file.WriteLine(TextBox7.Text & "    " & TextBox10.Text & "                " & TextBox14.Text)
                file.WriteLine(TextBox8.Text & "    " & TextBox11.Text & "                " & TextBox15.Text)
                file.WriteLine(TextBox9.Text & "    " & TextBox12.Text & "                " & TextBox16.Text)
                file.WriteLine("                                 ")
                file.WriteLine("Résultats:")
                file.WriteLine("Volume par %")
                file.WriteLine("Poudre Vol                      " & Label19.Text)
                file.WriteLine("Eau Vol                         " & Label20.Text)
                file.WriteLine("Sable Vol                       " & Label23.Text)
                file.WriteLine("Volume par L")
                file.WriteLine("Sable                           " & Label36.Text)
                file.WriteLine("Eau                             " & Label37.Text)
                file.WriteLine(Label25.Text & "                " & Label32.Text)
                file.WriteLine(Label26.Text & "                " & Label33.Text)
                file.WriteLine(Label27.Text & "                " & Label34.Text)
                file.WriteLine(Label28.Text & "                " & Label35.Text)
                file.WriteLine("Quantité par Kg")
                file.WriteLine("Sable                           " & Label39.Text)
                file.WriteLine("Eau total                       " & Label38.Text)
                file.WriteLine("Eau 01                          " & Label50.Text)
                file.WriteLine("Eau 02                          " & Label52.Text)
                file.WriteLine("Superplastifiant                " & Label54.Text)
                file.WriteLine("Eau/Poudre                      " & Label56.Text)
                file.WriteLine(Label49.Text & "                " & Label43.Text)
                file.WriteLine(Label48.Text & "                " & Label42.Text)
                file.WriteLine(Label47.Text & "                " & Label41.Text)
                file.WriteLine(Label46.Text & "                " & Label40.Text)
                file.WriteLine("                                 ")
                file.WriteLine("La quantité par 1m3:")
                file.WriteLine("Sable                           " & Math.Round(CType(quasand, Double), 3) & " Kg/m3")
                file.WriteLine("L'eau total                     " & Math.Round(CType(quawater, Double), 3) & " Kg/m3")
                file.WriteLine("Eau 01                          " & Math.Round(CType(quaw1, Double), 3) & " Kg/m3")
                file.WriteLine("Eau 02                          " & Math.Round(CType(quaw2, Double), 3) & " Kg/m3")
                file.WriteLine("Superplastifiant                " & Math.Round(CType(quasup, Double), 3) & " Kg/m3")
                file.WriteLine(Label49.Text & "                " & Math.Round(CType(qua1po, Double), 3) & " Kg/m3")
                file.WriteLine(Label48.Text & "                " & Math.Round(CType(qua2po, Double), 3) & " Kg/m3")
                file.WriteLine(Label47.Text & "                " & Math.Round(CType(qua3po, Double), 3) & " Kg/m3")
                file.WriteLine(Label46.Text & "                " & Math.Round(CType(qua4po, Double), 3) & " Kg/m3")
            End If
            If CheckBox1.Checked = True Then
                file.WriteLine("                                 ")
                file.WriteLine("Commentaires:")
                file.WriteLine(TextBox24.Text)
            End If
            file.WriteLine("----------------------------------Fin-----------------------------------")
            file.Close()
        End If
    End Sub

    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Form4.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label30_Click(sender As Object, e As EventArgs) Handles Label30.Click

    End Sub
End Class

