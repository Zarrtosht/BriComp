Public Class Main_form
    'Private Sub Main_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    'Dim dt As New DataTable
    'dt.Rows.Clear()
    'dt.Columns.Clear()
    'dt.Columns.Add("input", GetType(Decimal))

    'Dim dr As DataRow = dt.NewRow()
    'Dim path As String = My.Application.Info.DirectoryPath
    'Dim filePath As String = IO.Path.Combine(path, "..\..\temp\inpBeam.txt")
    'Dim afile As FileIO.TextFieldParser = New FileIO.TextFieldParser(filePath)
    'Dim CurrentRecord As String() ' this array will hold each line of data
    'afile.TextFieldType = FileIO.FieldType.Delimited
    'afile.Delimiters = New String() {","}
    'afile.HasFieldsEnclosedInQuotes = True

    '' parse the actual file
    'While Not afile.EndOfData
    '    Try
    '        CurrentRecord = afile.ReadFields()
    '        dt.Rows.Add(CDec(Val(CurrentRecord(0))))
    '    Catch ex As FileIO.MalformedLineException
    '        MessageBox.Show("Something went wrong")
    '        Stop
    '    End Try
    'End While

    'Dim txtOutp As String = ""

    'For Each row As DataRow In dt.Rows
    '    txtOutp &= row.Item("input").ToString & Environment.NewLine
    'Next row

    'TextBox1.Text = txtOutp

    'End Sub

    Private Sub Exit_Click(sender As Object, e As EventArgs) Handles tsExit.Click
        Close()
    End Sub

    Private Sub AddSteel_Click(sender As Object, e As EventArgs) Handles AddSteel.Click
        SteelGeom_form.Show()
    End Sub

End Class