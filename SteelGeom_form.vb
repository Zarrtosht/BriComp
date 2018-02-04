Public Class SteelGeom_form
    Dim SteelGeomName As String = ""
    Dim tfo As Integer = Nothing
    Dim bfo As Integer = Nothing
    Dim tw As Integer = Nothing
    Dim hw As Integer = Nothing
    Dim tfu As Integer = Nothing
    Dim bfu As Integer = Nothing
    Dim z As Integer = Nothing
    Dim A As Double = Nothing
    Dim CG As Integer = Nothing
    Dim I As Double = Nothing
    Dim Wfo As Double = Nothing
    Dim Wwo As Double = Nothing
    Dim Wwu As Double = Nothing
    Dim Wfu As Double = Nothing

    Private Sub SteelGeom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbName.SelectAll()
    End Sub

    Private Sub btnCancelSteelGeom_Click(sender As Object, e As EventArgs) Handles btnCancelSteelGeom.Click
        Close()
    End Sub

    Private Sub btnCalcSteelGeom_Click(sender As Object, e As EventArgs) Handles btnCalcSteelGeom.Click
        If tbTfo.Text = "" Or tbBfo.Text = "" Or tbTw.Text = "" Or tbHw.Text = "" Or tbTfu.Text = "" _
            Or tbBfu.Text = "" Then
            MessageBox.Show("Input is missing!")
        Else
            tfo = tbTfo.Text
            bfo = tbBfo.Text
            tw = tbTw.Text
            hw = tbHw.Text
            tfu = tbTfu.Text
            bfu = tbBfu.Text

            A = (tfo * bfo + tw * hw + tfu * bfu) / 1000 ^ 2
            CG = (tfo * bfo * tfo / 2 + tw * hw * (hw / 2 + tfo) + tfu * bfu * (tfo + hw + tfu / 2)) / (A * 1000 ^ 2)
            I = (tfo ^ 3 * bfo / 12 + tfo * bfo * (tfo / 2 - CG) ^ 2 _
            + tw * hw ^ 3 / 12 + tw * hw * (tfo + hw / 2 - CG) ^ 2 _
            + tfu ^ 3 * bfu + tfu * bfu * (tfo + hw + tfu / 2 - CG) ^ 2) / 1000 ^ 4
            Wfo = I / -CG * 1000
            Wwo = I / ((tfo - CG) / 1000)
            Wwu = I / ((tfo + hw - CG) / 1000)
            Wfu = I / ((tfo + hw + tfu - CG) / 1000)

            tbConst.Text = "A = " & Math.Round(A, 3) & " m2" & Environment.NewLine
            tbConst.Text &= "CG = " & CG & " mm" & Environment.NewLine
            tbConst.Text &= "I = " & Math.Round(I, 3) & " m4" & Environment.NewLine
            tbConst.Text &= "Wfo = " & Math.Round(Wfo, 3) & " m3" & Environment.NewLine
            tbConst.Text &= "Wwo = " & Math.Round(Wwo, 3) & " m3" & Environment.NewLine
            tbConst.Text &= "Wwu = " & Math.Round(Wwu, 3) & " m3" & Environment.NewLine
            tbConst.Text &= "Wfu = " & Math.Round(Wfu, 3) & " m3" & Environment.NewLine

            'If tbZ.Text IsNot String Then
            '    tbConst.Text &= "a = " & A & " m^2" & Environment.NewLine
            'End If
        End If

    End Sub

    Private Sub tbTfo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbTfo.KeyPress _
        , tbBfo.KeyPress, tbTw.KeyPress, tbHw.KeyPress, tbTfu.KeyPress, tbBfu.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""

    End Sub

    Private Sub btnAddSteelGeom_Click(sender As Object, e As EventArgs) Handles btnAddSteelGeom.Click
        If tbTfo.Text = "" Or tbBfo.Text = "" Or tbTw.Text = "" Or tbHw.Text = "" Or tbTfu.Text = "" _
           Or tbBfu.Text = "" Then
            MessageBox.Show("Input is missing!")
        Else
            Dim SteelGeom1 As New SteelGeom(A, CG, I, Wfo, Wwo, Wwu, Wfu, Name)
            SteelGeom1.Setname(tbName.Text)
            SteelGeom1.addNode()
            MessageBox.Show("New Geometry Added!")
        End If

    End Sub
End Class