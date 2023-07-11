
Imports System.Data.SqlClient
Public Class frmpatient

    Dim con As New SqlConnection
    Dim cmd As SqlCommand
    Dim connectionString As String = "Data Source=DELL-PC;Initial Catalog=PatientDetails;Integrated Security=True"

    Private Sub poplate()
        con.Close()
        con = New SqlConnection(connectionString)
        Dim quary = ("Select * from Patient")
        Dim adapter As SqlDataAdapter
        adapter = New SqlDataAdapter(quary, con)
        Dim builder As New SqlCommandBuilder(adapter)
        Dim ds As DataSet
        ds = New DataSet
        adapter.Fill(ds)
        DGVPatient.DataSource = ds.Tables(0)
        con.Close()
    End Sub

    Private Sub Reset()
        txtid.Text = ""
        txtname.Text = ""
        txtdisease.Text = ""
        txtage.Text = ""
        cmdgender.Text = ""
        txtaddress.Text = ""
        txtphone.Text = ""
        DateTimePicker2.Value.ToString()
        cmbdepartment.Text = ""
        txtbednumber.Text = ""
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtid.Text = ""
        txtname.Text = ""
        txtdisease.Text = ""
        txtage.Text = ""
        cmdgender.Text = ""
        txtaddress.Text = ""
        txtphone.Text = ""
        DateTimePicker2.Value.ToString()
        cmbdepartment.Text = ""
        txtbednumber.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        con = New SqlConnection(connectionString)
        con.Open()
        cmd = New SqlCommand("Insert into Patient (id,name,disease,age,gender,address,phonenumber,registerdate,department,bednumber)Values('" & txtid.Text & "','" & txtname.Text & "','" & txtdisease.Text & "','" & txtage.Text & "','" & cmdgender.Text & "','" & txtaddress.Text & "','" & txtphone.Text & "','" & DateTimePicker2.Text & "','" & cmbdepartment.Text & "','" & txtbednumber.Text & "')", con)
        cmd.ExecuteNonQuery()
        MsgBox("Patient Add Successfully")
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
            quary = "Delete from  Patient where id = " & txtid.Text & ""
            Dim cmd As SqlCommand
            cmd = New SqlCommand(quary, con)
            cmd.ExecuteNonQuery()
            MsgBox("Delete Successfully")
            con.Close()
            poplate()
        End If
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        con = New SqlConnection(connectionString)
        con.Open()
        cmd = New SqlCommand("Update Patient set name='" & txtname.Text & "',disease='" & txtdisease.Text & "',age = '" & txtage.Text & "',gender = '" & cmdgender.Text & "',address = '" & txtaddress.Text & "',phonenumber = '" & txtphone.Text & "',registerdate = '" & DateTimePicker2.Text & "',department ='" & cmbdepartment.Text & "',bednumber = '" & txtbednumber.Text & "' where id = '" & txtid.Text & "' ", con)
        cmd.ExecuteNonQuery()
        MsgBox("Record Updated")
        con.Close()
        poplate()
    End Sub

    Private Sub frmpatient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        poplate()
    End Sub
End Class