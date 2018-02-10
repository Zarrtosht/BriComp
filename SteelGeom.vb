Public Class SteelGeom
    Dim A As Double = Nothing
    Dim CG As Integer = Nothing
    Dim I As Double = Nothing
    Dim Wfo As Double = Nothing
    Dim Wwo As Double = Nothing
    Dim Wwu As Double = Nothing
    Dim Wfu As Double = Nothing
    Private Name As String

    Public ReadOnly Property GetName() As String
        Get
            Return Name
        End Get
    End Property

    Public Sub Setname(value As String)
        If IsNumeric(value) Then
            MessageBox.Show("Name can't be a number", "Error")
        Else
            Name = value
        End If
    End Sub

    Public Sub New(Ain As Double,
                   CGin As Integer,
                   Iin As Double,
                   Wfoin As Double,
                   Wwoin As Double,
                   Wwuin As Double,
                   Wfuin As Double,
                   Namein As String)

        A = Ain
        CG = CGin
        I = Iin
        Wfo = Wfoin
        Wwo = Wwoin
        Wwu = Wwuin
        Wfu = Wfuin
        Name = Namein

    End Sub

    Public Overridable Function addNode() As String
        Main_form.Tree.Nodes(2).Nodes(0).Nodes.Add(Name)
        Main_form.TextBox1.Text &= ">> New Steel cross section added <<" & Environment.NewLine

    End Function
End Class
