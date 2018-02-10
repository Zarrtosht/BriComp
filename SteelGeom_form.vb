Public Class SteelGeom_form
    Dim tfo As Integer = Nothing
    Dim bfo As Integer = Nothing
    Dim tw As Integer = Nothing
    Dim hw As Integer = Nothing
    Dim tfu As Integer = Nothing
    Dim bfu As Integer = Nothing
    Dim z As Integer = Nothing
    Dim H As Integer = Nothing
    Dim A As Double = Nothing
    Dim CG As Integer = Nothing
    Dim I As Double = Nothing
    Dim Wfo As Double = Nothing
    Dim Wwo As Double = Nothing
    Dim Wwu As Double = Nothing
    Dim Wfu As Double = Nothing
    Dim shape_fo As New System.Drawing.Rectangle(New Point(250, 400), New Size(bfo, tfo))
    Dim shape_web As New System.Drawing.Rectangle(New Point(250, 400), New Size(tw, hw))
    Dim shape_fu As New System.Drawing.Rectangle(New Point(250, 400), New Size(bfu, tfu))
    Dim pt1 As New Point(shape_fo.X, shape_fo.Y + CG)
    Dim pt2 As New Point(shape_fo.X + bfo, shape_fo.Y + CG)

    Private Sub SteelGeom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tbName.SelectAll()
        tbTfo.Text = 20
        tbBfo.Text = 200
        tbTw.Text = 20
        tbHw.Text = 200
        tbTfu.Text = 20
        tbBfu.Text = 200

        Dim myPen As New System.Drawing.Pen(System.Drawing.Color.Blue)
        Dim formGraphics As System.Drawing.Graphics
        formGraphics = Me.grpPrevSteelGeom.CreateGraphics()
        formGraphics.DrawLine(myPen, 300, 500, 200, 200)
        myPen.Dispose()
        formGraphics.Dispose()
    End Sub

    Private Sub btnCancelSteelGeom_Click(sender As Object, e As EventArgs) Handles btnCancelSteelGeom.Click
        Close()
    End Sub

    Private Sub btnCalcSteelGeom_Click(sender As Object, e As EventArgs) Handles btnCalcSteelGeom.Click
        If tbTfo.Text = "" Or tbBfo.Text = "" Or tbTw.Text = "" Or tbHw.Text = "" Or tbTfu.Text = "" _
            Or tbBfu.Text = "" Then
            MessageBox.Show("Input is missing!")
        Else

            'Cross section constant calculations
            tfo = tbTfo.Text
            bfo = tbBfo.Text
            tw = tbTw.Text
            hw = tbHw.Text
            tfu = tbTfu.Text
            bfu = tbBfu.Text

            H = tfo + hw + tfu
            A = (tfo * bfo + tw * hw + tfu * bfu) / 1000 ^ 2
            CG = (tfo * bfo * tfo / 2 + tw * hw * (hw / 2 + tfo) + tfu * bfu * (tfo + hw + tfu / 2)) / (A * 1000 ^ 2)
            I = (tfo ^ 3 * bfo / 12 + tfo * bfo * (tfo / 2 - CG) ^ 2 _
            + tw * hw ^ 3 / 12 + tw * hw * (tfo + hw / 2 - CG) ^ 2 _
            + tfu ^ 3 * bfu + tfu * bfu * (tfo + hw + tfu / 2 - CG) ^ 2) / 1000 ^ 4
            Wfo = I / -CG * 1000
            Wwo = I / ((tfo - CG) / 1000)
            Wwu = I / ((tfo + hw - CG) / 1000)
            Wfu = I / ((tfo + hw + tfu - CG) / 1000)

            tbConst.Text = "H = " & H & " mm" & Environment.NewLine
            tbConst.Text &= "A = " & Math.Round(A, 5) & " m2" & Environment.NewLine
            tbConst.Text &= "CG = " & CG & " mm" & Environment.NewLine
            tbConst.Text &= "I = " & Math.Round(I, 5) & " m4" & Environment.NewLine
            tbConst.Text &= "Wfo = " & Math.Round(Wfo, 5) & " m3" & Environment.NewLine
            tbConst.Text &= "Wwo = " & Math.Round(Wwo, 5) & " m3" & Environment.NewLine
            tbConst.Text &= "Wwu = " & Math.Round(Wwu, 5) & " m3" & Environment.NewLine
            tbConst.Text &= "Wfu = " & Math.Round(Wfu, 5) & " m3" & Environment.NewLine

            'Cross section drawing 237-688,9-560 451,551
            Dim refWidth As Integer = grpPrevSteelGeom.Width
            Dim refHeight As Integer = grpPrevSteelGeom.Height
            Dim refMidW As Integer = grpPrevSteelGeom.Location.X + refWidth / 2
            Dim refMidH As Integer = grpPrevSteelGeom.Location.Y + refHeight / 2 + 4

            Dim sclW As Double = 1
            Dim sclH As Double = 1

            If bfo > refWidth - 50 Or bfu > refWidth - 50 Then
                sclW = Math.Round((refWidth - 50) / Math.Max(bfo, bfu), 5)
            End If
            If tfo + hw + tfu > refHeight - 50 Then
                sclH = Math.Round((refHeight - 50) / (tfo + hw + tfu), 5)
            End If
            Dim scl As Integer = sclW * sclH

            Me.Invalidate()
            'Web
            shape_web.Width = tw * sclW * sclH
            shape_web.Height = hw * sclW * sclH
            shape_web.X = (refMidW - shape_web.Width / 2)
            shape_web.Y = (refMidH - shape_web.Height / 2)

            'Top flange
            shape_fo.Width = bfo * sclW * sclH
            shape_fo.Height = tfo * sclW * sclH
            shape_fo.X = (refMidW - shape_fo.Width / 2)
            shape_fo.Y = (refMidH - shape_web.Height / 2 - shape_fo.Height)

            'Bottom flange
            shape_fu.Width = bfu * sclW * sclH
            shape_fu.Height = tfu * sclW * sclH
            shape_fu.X = (refMidW - shape_fu.Width / 2)
            shape_fu.Y = (refMidH + shape_web.Height / 2)

            pt1.X = refMidW - refWidth / 2 + 50
            pt1.Y = shape_fo.Y + CG * sclH * sclW
            pt2.X = refMidW + refWidth / 2 - 50
            pt2.Y = pt1.Y

            'If tbZ.Text IsNot String Then
            '    tbConst.Text &= "a = " & A & " m^2" & Environment.NewLine
            'End If
        End If

    End Sub

    Private Sub SteelGeom_form_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        e.Graphics.FillRectangle(Brushes.Black, shape_fu)
        e.Graphics.FillRectangle(Brushes.Black, shape_fo)
        e.Graphics.FillRectangle(Brushes.Black, shape_web)
        'e.Graphics.DrawRectangle(Pens.Red, shape_fo)
        'e.Graphics.DrawRectangle(Pens.Red, shape_web)
        'e.Graphics.DrawRectangle(Pens.Red, shape_fu)
        e.Graphics.DrawLine(Pens.Blue, pt1, pt2)
        'e.Graphics.Draw(Brushes.Red, origo)

    End Sub

    Private Sub tbTfo_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles tbTfo.KeyPress _
        , tbBfo.KeyPress, tbTw.KeyPress, tbHw.KeyPress, tbTfu.KeyPress, tbBfu.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then e.KeyChar = ""

    End Sub

    'Private Sub btnAddSteelGeom_Click(sender As Object, e As EventArgs) Handles btnAddSteelGeom.Click
    '    If tbTfo.Text = "" Or tbBfo.Text = "" Or tbTw.Text = "" Or tbHw.Text = "" Or tbTfu.Text = "" _
    '       Or tbBfu.Text = "" Then
    '        MessageBox.Show("Input is missing!")
    '    Else
    '        Dim SteelGeom1 As New SteelGeom(A, CG, I, Wfo, Wwo, Wwu, Wfu, Name)
    '        SteelGeom1.Setname(tbName.Text)
    '        SteelGeom1.addNode()
    '        MessageBox.Show("New Geometry Added!")
    '    End If

    'End Sub
End Class