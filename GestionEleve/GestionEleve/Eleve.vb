Imports System.Data.OleDb
Imports System.IO

Public Class Eleve
    Public cnString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\CHRIS\Documents\Visual Studio 2010\Projects\GestionEleve\GestionEleve\bin\Debug\DataBase.accdb;Persist Security Info=False;"
    Public cn As New OleDbConnection
    Public Cmd As New OleDbCommand
    Public da As New OleDbDataAdapter
    Public dr As OleDbDataReader
    'Public dr As New OleDbDataReader
    Sub Effaccer()
        txt_Matricul.Text = ""
        txt_Nom.Text = ""
        txt_Postnom.Text = ""
        cb_Sexe.ValueMember = ""
        txt_Datedenaissance.Text = ""
        txt_Lieudenaissance.Text = ""
        txt_Nomdupere.Text = ""
        txt_Nomdelamere.Text = ""
        txt_Religion.Text = ""
        txt_Ecoledeprov.Text = ""
        cb_Inscritdans.Text = ""
        txt_Addresse.Text = ""
        txt_Tel.Text = ""
    End Sub
    Sub fillcombo()
        cn.ConnectionString = cnString
        cn.Open()
        cnString = "SELECT * FROM Classe"
        With Cmd
            .CommandText = cnString
            .Connection = cn
            dr = Cmd.ExecuteReader
        End With
        While (dr.Read())
            cb_Inscritdans.Items.Add(dr.Item(1))
        End While
        Cmd.Dispose()
        dr.Close()
    End Sub
    Private Sub btn_Recherche_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Recherche.Click
        RechercherEleve.Show()
    End Sub

    Private Sub Eleve_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try
            cn.ConnectionString = cnString
            cn.Open()
            MsgBox("Connection Reussie a la Base des Donnees", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.Close()
        Call fillcombo()
    End Sub

    Private Sub btn_Add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Add.Click
        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
        Try
            With Cmd
                .Connection = cn
                .CommandText = "INSERT INTO Eleve (Matricul,Nom,Postnom,Sexe,Datedenaissance,Lieudenaissance,Nomdupere,Nomdelamere,Religion,Ecoledeprov,Inscritdans,Addresse,Tel) " & " VALUES ('" & Me.txt_Matricul.Text & "','" & Me.txt_Nom.Text & "','" & Me.txt_Postnom.Text & "','" & Me.cb_Sexe.Text & "','" & Me.txt_Datedenaissance.Text & "','" & Me.txt_Lieudenaissance.Text & "','" & Me.txt_Nomdupere.Text & "','" & Me.txt_Nomdelamere.Text & "','" & Me.txt_Religion.Text & "','" & Me.txt_Ecoledeprov.Text & "','" & Me.cb_Inscritdans.Text & "','" & Me.txt_Addresse.Text & "','" & Me.txt_Tel.Text & "') "
                'Dim ms As New MemoryStream()
                'Dim bmpImage As New Bitmap(Pic_Elece.Image)
                'bmpImage.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg)
                'Dim data As Byte() = ms.GetBuffer()
                'Dim p As New OleDbParameter("@image", OleDbType.VarBinary)
                'p.Value = data
                '.Parameters.Add(p)

                .ExecuteNonQuery()
            End With
            MsgBox("Enregistrement reussie a la base de donnee", vbInformation)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        cn.Close()
    End Sub

    Private Sub btn_Parcourrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Parcourrir.Click
        Dim open As New OpenFileDialog
        open.ShowDialog()
        open.Filter = "Images (*.png)|*.png|(*.jpg)|*.jpg|(*.bmp)|*.bmp|All Files(*.*)|*.*"
        'open.Filter = "Text files (*.txt)|*.txt"
        Pic_Elece.ImageLocation = open.FileName
        txt_Pict.Text = open.SafeFileName
    End Sub

    Private Sub btn_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_New.Click
        Call Effaccer()
    End Sub

    Private Sub cb_Inscritdans_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cb_Inscritdans.SelectedIndexChanged

    End Sub

    Private Sub btn_Del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Del.Click


        '    Try
        '        With Cmd
        '            .Connection = cn
        '            .CommandText = "DELETE FROM Eleve WHERE Matricul= '" & txt_Matricul.Text & "'"
        '            MsgBox("Voulez-vous vraiment Supprimer Cette eleve", vbYesNo)
        '            .ExecuteNonQuery()

        '        End With
        '        MsgBox("Suppression Reussie", vbInformation)
        '    Catch ex As Exception
        '        MsgBox(ex.Message)
        '    End Try
        '    cn.Close()
        'Else
        '    Exit Sub
        'End If
        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
        If MessageBox.Show("Voulez-vous vraiment supprimer l'enregistrement?", "ETES-VOUS SURE?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Try
                With Cmd
                    .Connection = cn
                    .CommandText = "DELETE FROM Eleve WHERE Matricul= '" & txt_Matricul.Text & "'"
                    'MsgBox("Voulez-vous vraiment Supprimer Cette eleve", vbYesNo)
                    .ExecuteNonQuery()

                End With
                MsgBox("Suppression Reussie", vbInformation)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            cn.Close()
        End If
    End Sub

    Private Sub btn_Edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Edit.Click
        If Not cn.State = ConnectionState.Open Then
            cn.Open()
        End If
        If MessageBox.Show("Voulez-vous vraiment Mettre a jours l'enregistrement?", "ETES-VOUS SURE?", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Try
                'With Cmd
                '    .Connection = cn
                '    .CommandText = "UPDATE FROM Eleve WHERE Matricul= '" & txt_Matricul.Text & "'"
                '    'MsgBox("Voulez-vous vraiment Supprimer Cette eleve", vbYesNo)
                '    .ExecuteNonQuery()

                'End With
                Cmd.CommandText = "UPDATE Eleve SET Nom='" & txt_Nom.Text & "',Postnom='" & txt_Postnom.Text & "',Sexe='" & cb_Sexe.Text & "',Datedenaissance='" & txt_Datedenaissance.Text & "',Lieudenaissance='" & txt_Lieudenaissance.Text & "',Nomdupere='" & txt_Nomdupere.Text & "',Nomdelamere='" & txt_Nomdelamere.Text & "',Religion='" & txt_Religion.Text & "',Ecoledeprov='" & txt_Ecoledeprov.Text & "',Inscritdans='" & cb_Inscritdans.Text & "',Addresse='" & txt_Addresse.Text & "',Tel='" & txt_Tel.Text & "' WHERE Matricul='" & txt_Matricul.Text & "'"
                Cmd.Connection = cn
                Cmd.ExecuteNonQuery()
                cn.Close()

                'With Cmd
                '    .Connection = cn
                '    .CommandText = "UPDATE FROM * Eleve WHERE Matricul= '" & txt_Matricul.Text & "'"
                '    Matricul, Nom, Postnom, Sexe, Datedenaissance, Lieudenaissance, Nomdupere, Nomdelamere, Religion, Ecoledeprov, Inscritdans, Addresse, Tel
                '    .CommandText = "update Eleve set Matricul='" & txt_Matricul.Text & "', Nom='" & txt_Nom.Text & "',Postnom='" & txt_Postnom.Text & "',Sexe='" & cb_Sexe.Text & "',Datedenaissance='" & txt_Datedenaissance.Text & "',Lieudenaissance='" & txt_Lieudenaissance.Text & "',Nomdupere='" & txt_Nomdupere.Text & "',Nomdelamere='" & txt_Nomdelamere.Text & "',Religion='" & txt_Religion.Text & "',Ecoledeprov='" & txt_Ecoledeprov.Text & "',Inscritdans='" & cb_Inscritdans.Text & "',Addresse='" & txt_Addresse.Text & "',Tel='" & txt_Tel.Text & "'"
                '    MsgBox("Voulez-vous vraiment Supprimer Cette eleve", vbYesNo)
                '    .ExecuteNonQuery()

                'End With
                MsgBox("MODIFICATION REUSSIE", vbInformation)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        End If
        cn.Close()
        'Dim cb As String = "update Book set AccessionNo='" & txtAccessionNo.Text & "', BookTitle='" & txtBookTitle.Text & "',Author='" & txtAuthor.Text & "',JointAuthors='" & txtJointAuthor.Text & "',Subject='" & cmbSubject.Text & "',Department='" & cmbDepartment.Text & "',Barcode='" & txtBarcode.Text & "',ISBN='" & txtISBN.Text & "',Volume='" & txtVolume.Text & "',Edition='" & txtEdition.Text & "',ClassNo='" & txtClassNo.Text & "',Publisher='" & txtPublisherName.Text & "',PlaceOfPublisher='" & txtPlaceOfPublisher.Text & "',CD='" & txtCD.Text & "',PublishingYear='" & txtPublishingYear.Text & "',Reference=" & txtReference.Text & ",NoOfBooks=" & txtNoOfBooks.Text & ",AlmiraPosition='" & txtAlmiraPosition.Text & "',Price=" & txtPrice.Text & ",BillDate=#" & dtpBillDate.Text & "#,Remarks='" & txtRemarks.Text & "',SupplierName='" & cmbSupplierName.Text & "' where AccessionNo='" & TextBox1.Text & "'"
        'Cmd = New OleDbCommand(cb)
        'Cmd.Connection = con
        'Cmd.ExecuteNonQuery()
        'con.Close()
    End Sub


    Private Sub btn_Deposdocs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Deposdocs.Click
        DepotDossier.Show()
    End Sub


End Class