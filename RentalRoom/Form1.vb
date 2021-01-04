Imports MySql.Data.MySqlClient
Public Class Form1
    Dim mov As Boolean
    Dim movx, movy As Integer

    Dim Connection As New MySqlConnection("server=localhost; user=root; password=; database=db_vb2")
    Dim MySQLCMD As New MySqlCommand
    Dim MySQLDA As New MySqlDataAdapter
    Dim DT As New DataTable

    Dim Table_Name As String = "customer"
    Dim Data As Integer

    Dim LoadImagesStr As Boolean = False
    Dim IDRam, NameRam, PriceRam, AmountRam As String
    Dim IMG_FileNameInput As String
    Dim StatusInput As String = "Save"

    Private Sub pbID_Click(sender As Object, e As EventArgs) Handles pbID.Click
        OpenFileDialog1.FileName = ""
        OpenFileDialog1.Filter = "JPEG (*.jpeg;*.jpg)|*.jpeg;*.jpg"

        If (OpenFileDialog1.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
            IMG_FileNameInput = OpenFileDialog1.FileName
            pbID.ImageLocation = IMG_FileNameInput
        End If
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel1.MouseDown
        mov = True
        movx = Windows.Forms.Cursor.Position.X - Me.Left
        movy = Windows.Forms.Cursor.Position.Y - Me.Top
    End Sub

    Private Sub Panel1_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel1.MouseUp
        mov = False
    End Sub

    Private Sub btnmmn_Click(sender As Object, e As EventArgs) Handles btnmmn.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub tbID_TextChanged(sender As Object, e As EventArgs) Handles tbID.TextChanged

    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As MouseEventArgs) Handles Panel1.MouseMove
        If mov Then
            Me.Left = Windows.Forms.Cursor.Position.X - movx
            Me.Top = Windows.Forms.Cursor.Position.Y - movy
        End If
    End Sub

    Private Sub Guna2TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Dim SqlCmdSearchstr As String

    Private Sub MaterialSingleLineTextField1_Click(sender As Object, e As EventArgs) Handles MaterialSingleLineTextField1.Click

    End Sub

    Dim Col0Ram As Integer = 0

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim mstream As New System.IO.MemoryStream()
        Dim arrImage() As Byte
        pbID.Image.Save(mstream, System.Drawing.Imaging.ImageFormat.Jpeg)
        arrImage = mstream.GetBuffer()
        Connection.Open()
        MySQLCMD = New MySqlCommand
        With MySQLCMD
            .CommandText = "INSERT INTO " & Table_Name & " (ID,name,sname,gender,phone,personal_id) VALUES (@ID,@name,@sname,@gender,@phone,@personal_id)"
            .Connection = Connection
            .Parameters.AddWithValue("@ID", tbID.Text)
            .Parameters.AddWithValue("@name", tbname.Text)
            .Parameters.AddWithValue("@sname", tbsname.Text)
            .Parameters.AddWithValue("@gender", tbgender.Text)
            .Parameters.AddWithValue("@phone", tbphone.Text)
            .Parameters.AddWithValue("@personal_id", arrImage)
            .ExecuteNonQuery()
        End With
        MsgBox("Data saved successfully", MsgBoxStyle.Information, "Information")
        IMG_FileNameInput = ""
        Connection.Close()
    End Sub

    Private Sub tbID_KeyDown(sender As Object, e As KeyEventArgs) Handles tbID.KeyDown, tbname.KeyDown, tbsname.KeyDown, tbgender.KeyDown, tbphone.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub Guna2TextBox1_KeyDown(sender As Object, e As KeyEventArgs)
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub

    Private Sub MaterialSingleLineTextField1_KeyDown(sender As Object, e As KeyEventArgs) Handles MaterialSingleLineTextField1.KeyDown, MaterialSingleLineTextField2.KeyDown, MaterialSingleLineTextField3.KeyDown
        If e.KeyCode = Keys.Enter Then
            SendKeys.Send("{TAB}")
            SendKeys.Send("{TAB}")
        Else
            Exit Sub
        End If
        e.SuppressKeyPress = True
    End Sub
End Class
