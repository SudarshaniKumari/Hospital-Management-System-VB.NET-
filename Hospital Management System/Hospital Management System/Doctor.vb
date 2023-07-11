Imports System.Data.SqlClient
Public Class frmdoctor
    Dim con As New SqlConnection
    Dim cmd As SqlCommand
    Dim connectionString As String = "Data Source=DELL-PC;Initial Catalog=DoctorDetails;Integrated Security=True"

    Private Sub poplate()
        con.Close()
        con = New SqlConnection(connectionString)
        Dim quary = ("Select * from Doctor")
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(quary, con)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DGVDoctor.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub Reset()
        txtid.Text = ""
        txtname.Text = ""
        cmdgender.Text = ""
        txtage.Text = ""
        cmbtype.Text = ""
        txtphone.Text = ""
        txtaddress.Text = ""
        cmbdepartment.Text = ""
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtid.Text = ""
        txtname.Text = ""
        cmdgender.Text = ""
        txtage.Text = ""
        cmbtype.Text = ""
        txtphone.Text = ""
        txtaddress.Text = ""
        cmbdepartment.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        con = New SqlConnection(connectionString)
        con.Open()
        cmd = New SqlCommand("Insert into Doctor (id,name,gender,age,type,phonenumber,address,department)Values('" & txtid.Text & "','" & txtname.Text & "','" & cmdgender.Text & "','" & txtage.Text & "','" & cmbtype.Text & "','" & txtphone.Text & "','" & txtaddress.Text & "','" & cmbdepartment.Text & "')", con)
        cmd.ExecuteNonQuery()
        MsgBox("Doctor Add Successfully")
        con.Close()
        poplate()
        Reset()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        If txtid.Text = "" Then
            MsgBox("Enter Doctor id")
        Else
            con.Open()
            Dim quary As String
            quary = "Delete from  Doctor where id = " & txtid.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(quary, con)
            cmd.ExecuteNonQuery()
            MsgBox("Delete Successfully")
            con.Close()
            poplate()
        End If
    End Sub

    Private Sub btnUpdate_Click(sender As Object, e As EventArgs) Handles btnUpdate.Click
        con = New SqlConnection(connectionString)
        con.Open()
        cmd = New SqlCommand("Update Doctor set name='" & txtname.Text & "',gender = '" & cmdgender.Text & "',age = '" & txtage.Text & "',type = '" & cmbtype.Text & "',phonenumber = '" & txtphone.Text & "',address = '" & txtaddress.Text & "',department ='" & cmbdepartment.Text & "' where id = '" & txtid.Text & "' ", con)
        cmd.ExecuteNonQuery()
        MsgBox("Record Updated")
        con.Close()
        poplate()
    End Sub

    Private Sub frmdoctor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        poplate()
    End Sub


End Class