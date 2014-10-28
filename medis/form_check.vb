Imports MySql.Data.MySqlClient
Imports System.Data
Public Class form_check
    Dim conn As New MySqlConnection
    Dim mycommand As New MySqlCommand
    Dim S As String
    Dim dr As MySqlDataReader
    Dim myAdapter As New MySqlDataAdapter
    Dim mydata As New DataTable
    Dim illnessesdata As New System.Windows.Forms.TextBox
    Dim enablednumber As New System.Windows.Forms.TextBox
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        illnesschecklist()

        Dim one, two, three, four, five, six, seven, eight, nine, ten As New System.Windows.Forms.TextBox
        'tuburculin test
        If CheckBox1.Checked = True Then
            one.Text = one.Text.ToString + "First "
        Else
        End If
        If CheckBox2.Checked = True Then
            one.Text = one.Text.ToString + "Second "
        Else
        End If
        If CheckBox3.Checked = True Then
            one.Text = one.Text.ToString + "Third"
        Else
        End If

        'BGC
        If CheckBox4.Checked = True Then
            two.Text = two.Text.ToString + "First "
        Else
        End If
        If CheckBox5.Checked = True Then
            two.Text = two.Text.ToString + "Second "
        Else
        End If
        If CheckBox6.Checked = True Then
            two.Text = two.Text.ToString + "Third"
        Else
        End If

        'OPV
        If CheckBox7.Checked = True Then
            three.Text = three.Text.ToString + "First "
        Else
        End If
        If CheckBox8.Checked = True Then
            three.Text = three.Text.ToString + "Second "
        Else
        End If
        If CheckBox9.Checked = True Then
            three.Text = three.Text.ToString + "Third"
        Else
        End If

        'DPT
        If CheckBox10.Checked = True Then
            four.Text = four.Text.ToString + "First "
        Else
        End If
        If CheckBox11.Checked = True Then
            four.Text = four.Text.ToString + "Second "
        Else
        End If
        If CheckBox12.Checked = True Then
            four.Text = four.Text.ToString + "Third"
        Else
        End If

        'Measles Vaccine
        If CheckBox13.Checked = True Then
            five.Text = five.Text.ToString + "First "
        Else
        End If
        If CheckBox14.Checked = True Then
            five.Text = five.Text.ToString + "Second "
        Else
        End If
        If CheckBox15.Checked = True Then
            five.Text = five.Text.ToString + "Third"
        Else
        End If

        'Mumps
        If CheckBox16.Checked = True Then
            six.Text = six.Text.ToString + "First "
        Else
        End If
        If CheckBox17.Checked = True Then
            six.Text = six.Text.ToString + "Second "
        Else
        End If
        If CheckBox18.Checked = True Then
            six.Text = six.Text.ToString + "Third"
        Else
        End If

        'Rubella
        If CheckBox19.Checked = True Then
            seven.Text = seven.Text.ToString + "First "
        Else
        End If
        If CheckBox20.Checked = True Then
            seven.Text = seven.Text.ToString + "Second "
        Else
        End If
        If CheckBox21.Checked = True Then
            seven.Text = seven.Text.ToString + "Third"
        Else
        End If

        'Typ0hoid Fever
        If CheckBox22.Checked = True Then
            eight.Text = eight.Text.ToString + "First "
        Else
        End If
        If CheckBox23.Checked = True Then
            eight.Text = eight.Text.ToString + "Second "
        Else
        End If
        If CheckBox24.Checked = True Then
            eight.Text = eight.Text.ToString + "Third"
        Else
        End If

        'Cholera
        If CheckBox25.Checked = True Then
            nine.Text = nine.Text.ToString + "First "
        Else
        End If
        If CheckBox26.Checked = True Then
            nine.Text = nine.Text.ToString + "Second "
        Else
        End If
        If CheckBox27.Checked = True Then
            nine.Text = nine.Text.ToString + "Third"
        Else
        End If

        'Hepatitis
        If CheckBox28.Checked = True Then
            ten.Text = ten.Text.ToString + "First "
        Else
        End If
        If CheckBox29.Checked = True Then
            ten.Text = ten.Text.ToString + "Second "
        Else
        End If
        If CheckBox30.Checked = True Then
            ten.Text = ten.Text.ToString + "Third"
        Else
        End If


        conn.ConnectionString = "server=localhost;username=root;password=;database=dbmis"
        conn.Open()
        S = "Insert into checkup (Fullname,Position,Department,Date,Year_Course,DateofBirth,Age,Sex,Civil_Status,Home_Address,Boarding_Address,Father_Name,Father_Occupation,Father_Tel, Mother_Name,Mother_Occupation,Mother_Tel,HusbandWife,HusbandWife_Occupation,HusbandWife_Tel, LandladyLandlord,LandladyLandlord_Tel,Illnesses,Immunization_Tuberculin_Test_Stage, Immunization_Tuberculin_Test_Booster, Immunization_Tuberculin_Test_Booster1, Immunization_Tuberculin_Test_Reaction, Immunization_BCG_Stage, Immunization_BCG_Booster, Immunization_BCG_Booster1, Immunization_BCG_Reaction, Immunization_DPT_Stage, Immunization_DPT_Booster, Immunization_DPT_Booster1, Immunization_DPT_Reaction, Immunization_OPV_Stage, Immunization_OPV_Booster, Immunization_OPV_Booster1, Immunization_OPV_Reaction, Immunization_Measles_Vaccine_Stage, Immunization_Measles_Vaccine_Booster, Immunization_Measles_Vaccine_Booster1, Immunization_Measles_Vaccine_Reaction, Immunization_Mumps_Stage, Immunization_Mumps_Booster, Immunization_Mumps_Booster1, Immunization_Mumps_Reaction, Immunization_Rubella_Stage, Immunization_Rubella_Booster, Immunization_Rubella_Booster1, Immunization_Rubella_Reaction, Immunization_Typhoid_Fever_Stage, Immunization_Typhoid_Fever_Booster, Immunization_Typhoid_Fever_Booster1, Immunization_Typhoid_Fever_Reaction, Immunization_Cholera_Stage, Immunization_Cholera_Booster, Immunization_Cholera_Booster1, Immunization_Cholera_Reaction, Immunization_Hepatitis_Stage, Immunization_Hepatitis_Booster, Immunization_Hepatitis_Booster1, Immunization_Hepatitis_Reaction)  values ('" & TextBox1.Text & "', '" & TextBox3.Text & "', '" & ComboBox4.Text & "', '" & MaskedTextBox1.Text & "', '" & TextBox2.Text & "','" & MaskedTextBox2.Text & "', '" & ComboBox3.Text & "', '" & ComboBox1.Text & "', '" & ComboBox2.Text & "', '" & TextBox5.Text & "', '" & TextBox6.Text & "', '" & TextBox7.Text & "', '" & TextBox14.Text & "', '" & TextBox10.Text & "', '" & TextBox8.Text & "', '" & TextBox15.Text & "', '" & TextBox17.Text & "', '" & TextBox9.Text & "', '" & TextBox16.Text & "', '" & TextBox18.Text & "', '" & TextBox12.Text & "', '" & TextBox19.Text & "', '" & illnessesdata.Text.ToString() & "', '" & one.Text & "', '" & TextBox21.Text & "', '" & TextBox22.Text & "', '" & TextBox23.Text & "', '" & two.Text & "', '" & TextBox24.Text & "', '" & TextBox25.Text & "', '" & TextBox26.Text & "', '" & three.Text & "', '" & TextBox27.Text & "', '" & TextBox28.Text & "', '" & TextBox29.Text & "', '" & four.Text & "', '" & TextBox30.Text & "', '" & TextBox31.Text & "', '" & TextBox32.Text & "', '" & five.Text & "', '" & TextBox33.Text & "', '" & TextBox34.Text & "', '" & TextBox35.Text & "', '" & six.Text & "', '" & TextBox36.Text & "', '" & TextBox37.Text & "', '" & TextBox38.Text & "', '" & seven.Text & "', '" & TextBox39.Text & "', '" & TextBox40.Text & "', '" & TextBox41.Text & "', '" & eight.Text & "', '" & TextBox42.Text & "', '" & TextBox43.Text & "', '" & TextBox44.Text & "', '" & nine.Text & "', '" & TextBox45.Text & "', '" & TextBox46.Text & "', '" & TextBox47.Text & "', '" & ten.Text & "', '" & TextBox48.Text & "', '" & TextBox49.Text & "', '" & TextBox50.Text & "')"
        mycommand.Connection = conn
        mycommand.CommandText = S
        dr = mycommand.ExecuteReader()
        While dr.Read()
            MaskedTextBox1.Text = dr("Date")
            TextBox1.Text = dr("Fullname")
            TextBox3.Text = dr("Position")
            ComboBox4.Text = dr("Department")
            TextBox2.Text = dr("Year_Course")
            MaskedTextBox2.Text = dr("DateofBirth")
            ComboBox3.Text = dr("Age")
            ComboBox1.Text = dr("Sex")
            ComboBox2.Text = dr("Civil_Status")
            TextBox5.Text = dr("Home_Address")
            TextBox6.Text = dr("Boarding_Address")
            TextBox7.Text = dr("Father_Name")
            TextBox14.Text = dr("Father_Occupation")
            TextBox10.Text = dr("Father_Tel")
            TextBox8.Text = dr("Mother_Name")
            TextBox15.Text = dr("Mother_Occupation")
            TextBox17.Text = dr("Mother_Tel")
            TextBox9.Text = dr("HusbandWife")
            TextBox16.Text = dr("HusbandWife_Occupation")
            TextBox18.Text = dr("HusbandWife_Tel")
            TextBox12.Text = dr("LandladyLandlord")
            TextBox19.Text = dr("LandladyLandlord_Tel")
            illnessesdata.Text.ToString(dr("Illnesses"))
            one.Text = dr("Immunization_Tuberculin_Test_Stage")
            TextBox21.Text = dr("Immunization_Tuberculin_Test_Booster")
            TextBox22.Text = dr("Immunization_Tuberculin_Test_Booster1")
            TextBox23.Text = dr("Immunization_Tuberculin_Test_Reaction")
            two.Text = dr("Immunization_BCG_Stage")
            TextBox24.Text = dr("Immunization_BCG_Booster")
            TextBox25.Text = dr("Immunization_BCG_Booster1")
            TextBox26.Text = dr("Immunization_BCG_Reaction")
            three.Text = dr("Immunization_DPT_Stage")
            TextBox27.Text = dr("Immunization_DPT_Booster")
            TextBox28.Text = dr("Immunization_DPT_Booster1")
            TextBox29.Text = dr("Immunization_DPT_Reaction")
            four.Text = dr("Immunization_OPV_Stage")
            TextBox30.Text = dr("Immunization_OPV_Booster")
            TextBox31.Text = dr("Immunization_OPV_Booster1")
            TextBox32.Text = dr("Immunization_OPV_Reaction")
            five.Text = dr("Immunization_Measles_Vaccine_Stage")
            TextBox33.Text = dr("Immunization_Measles_Vaccine_Booster")
            TextBox34.Text = dr("Immunization_Measles_Vaccine_Booster1")
            TextBox35.Text = dr("Immunization_Measles_Vaccine_Reaction")
            six.Text = dr("Immunization_Mumps_Stage")
            TextBox36.Text = dr("Immunization_Mumps_Booster")
            TextBox37.Text = dr("Immunization_Mumps_Booster1")
            TextBox38.Text = dr("Immunization_Mumps_Reaction")
            seven.Text = dr("Immunization_Rubella_Stage")
            TextBox39.Text = dr("Immunization_Rubella_Booster")
            TextBox40.Text = dr("Immunization_Rubella_Booster1")
            TextBox41.Text = dr("Immunization_Rubella_Reaction")
            eight.Text = dr("Immunization_Typhoid_Fever_Stage")
            TextBox42.Text = dr("Immunization_Typhoid_Fever_Booster")
            TextBox43.Text = dr("Immunization_Typhoid_Fever_Booster1")
            TextBox44.Text = dr("Immunization_Typhoid_Fever_Reaction")
            nine.Text = dr("Immunization_Cholera_Stage")
            TextBox45.Text = dr("Immunization_Cholera_Booster")
            TextBox46.Text = dr("Immunization_Cholera_Booster1")
            TextBox47.Text = dr("Immunization_Cholera_Reaction")
            ten.Text = dr("Immunization_Hepatitis_Stage")
            TextBox48.Text = dr("Immunization_Hepatitis_Booster")

            TextBox49.Text = dr("Immunization_Hepatitis_Booster1")
            TextBox50.Text = dr("Immunization_Hepatitis_Reaction")


        End While
        conn.Close()
        MsgBox("Record is Save.", MsgBoxStyle.Information, "Medical Information System")


        TextBox1.Clear()
        TextBox3.Clear()

        TextBox2.Clear()

        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
        TextBox14.Clear()
        TextBox10.Clear()
        TextBox8.Clear()
        TextBox15.Clear()
        TextBox17.Clear()
        TextBox9.Clear()
        TextBox16.Clear()
        TextBox18.Clear()
        TextBox12.Clear()
        TextBox19.Clear()
        TextBox21.Clear()
        TextBox22.Clear()
        TextBox23.Clear()
        TextBox24.Clear()
        TextBox25.Clear()
        TextBox26.Clear()
        TextBox27.Clear()
        TextBox28.Clear()
        TextBox29.Clear()
        TextBox30.Clear()
        TextBox31.Clear()
        TextBox32.Clear()
        TextBox33.Clear()
        TextBox34.Clear()
        TextBox35.Clear()
        TextBox36.Clear()
        TextBox37.Clear()
        TextBox38.Clear()
        TextBox39.Clear()
        TextBox40.Clear()
        TextBox41.Clear()
        TextBox42.Clear()
        TextBox43.Clear()
        TextBox44.Clear()
        TextBox45.Clear()
        TextBox46.Clear()
        TextBox47.Clear()
        TextBox48.Clear()
        TextBox49.Clear()
        TextBox50.Clear()
    End Sub
    Public Sub illnesschecklist()
        If CheckedListBox1.CheckedItems.Count = 0 Then
            illnessesdata.Text = "n/a"


        Else

            illnessesdata.Clear()

            If CheckedListBox1.CheckedItems.Contains("Allergy") = True Then
                illnessesdata.Text = illnessesdata.Text.ToString + "Allergy  "
            Else
            End If

            If CheckedListBox1.CheckedItems.Contains("Pertussis") = True Then
                illnessesdata.Text = illnessesdata.Text.ToString + "Pertussis "
            Else
            End If

            If CheckedListBox1.CheckedItems.Contains("Measles") = True Then
                illnessesdata.Text = illnessesdata.Text.ToString + " Measles "
            Else
            End If

            If CheckedListBox1.CheckedItems.Contains("Rubella") = True Then
                illnessesdata.Text = illnessesdata.Text.ToString + "Rubella "
            Else
            End If

            If CheckedListBox1.CheckedItems.Contains("Mumps") = True Then
                illnessesdata.Text = illnessesdata.Text.ToString + "Mumps "
            Else
            End If

            If CheckedListBox1.CheckedItems.Contains("Chicken Pox") = True Then
                illnessesdata.Text = illnessesdata.Text.ToString + "Chicken Pox "
            Else
            End If

            If CheckedListBox1.CheckedItems.Contains("Diptheria") = True Then
                illnessesdata.Text = illnessesdata.Text.ToString + "Diptheria "
            Else
            End If

            If CheckedListBox1.CheckedItems.Contains("Asthma") = True Then
                illnessesdata.Text = illnessesdata.Text.ToString + "Asthma "
            Else
            End If

            If CheckedListBox1.CheckedItems.Contains("Rheumatic Fever") = True Then
                illnessesdata.Text = illnessesdata.Text.ToString + "Rheumatic Fever "
            Else
            End If

            If CheckedListBox1.CheckedItems.Contains("Otitis Media") = True Then
                illnessesdata.Text = illnessesdata.Text.ToString + "Otitis Media "
            Else
            End If

            If CheckedListBox1.CheckedItems.Contains("Convulsions") = True Then
                illnessesdata.Text = illnessesdata.Text.ToString + "Convulsions "
            Else
            End If

            If CheckedListBox1.CheckedItems.Contains("Operation") = True Then
                illnessesdata.Text = illnessesdata.Text.ToString + "Operation "
            Else
            End If

            If CheckedListBox1.CheckedItems.Contains("Other Illnesses") = True Then
                illnessesdata.Text = illnessesdata.Text.ToString + "Other Illnesses "
            Else
            End If



        End If


    End Sub
    Public Sub immunization()
        Dim one, two, three, four, five, six, seven, eight, nine, ten As New System.Windows.Forms.TextBox
        'tuburculin test
        If CheckBox1.Checked = True Then
            one.Text = one.Text.ToString + "First "
        Else
        End If
        If CheckBox2.Checked = True Then
            one.Text = one.Text.ToString + "Second "
        Else
        End If
        If CheckBox3.Checked = True Then
            one.Text = one.Text.ToString + "Third"
        Else
        End If

        'BGC
        If CheckBox4.Checked = True Then
            two.Text = two.Text.ToString + "First "
        Else
        End If
        If CheckBox5.Checked = True Then
            two.Text = two.Text.ToString + "Second "
        Else
        End If
        If CheckBox6.Checked = True Then
            two.Text = two.Text.ToString + "Third"
        Else
        End If

        'OPV
        If CheckBox7.Checked = True Then
            three.Text = three.Text.ToString + "First "
        Else
        End If
        If CheckBox8.Checked = True Then
            three.Text = three.Text.ToString + "Second "
        Else
        End If
        If CheckBox9.Checked = True Then
            three.Text = three.Text.ToString + "Third"
        Else
        End If

        'DPT
        If CheckBox10.Checked = True Then
            four.Text = four.Text.ToString + "First "
        Else
        End If
        If CheckBox11.Checked = True Then
            four.Text = four.Text.ToString + "Second "
        Else
        End If
        If CheckBox12.Checked = True Then
            four.Text = four.Text.ToString + "Third"
        Else
        End If

        'Measles Vaccine
        If CheckBox13.Checked = True Then
            five.Text = five.Text.ToString + "First "
        Else
        End If
        If CheckBox14.Checked = True Then
            five.Text = five.Text.ToString + "Second "
        Else
        End If
        If CheckBox15.Checked = True Then
            five.Text = five.Text.ToString + "Third"
        Else
        End If

        'Mumps
        If CheckBox16.Checked = True Then
            six.Text = six.Text.ToString + "First "
        Else
        End If
        If CheckBox17.Checked = True Then
            six.Text = six.Text.ToString + "Second "
        Else
        End If
        If CheckBox18.Checked = True Then
            six.Text = six.Text.ToString + "Third"
        Else
        End If

        'Rubella
        If CheckBox19.Checked = True Then
            seven.Text = seven.Text.ToString + "First "
        Else
        End If
        If CheckBox20.Checked = True Then
            seven.Text = seven.Text.ToString + "Second "
        Else
        End If
        If CheckBox21.Checked = True Then
            seven.Text = seven.Text.ToString + "Third"
        Else
        End If

        'Typ0hoid Fever
        If CheckBox22.Checked = True Then
            eight.Text = eight.Text.ToString + "First "
        Else
        End If
        If CheckBox23.Checked = True Then
            eight.Text = eight.Text.ToString + "Second "
        Else
        End If
        If CheckBox24.Checked = True Then
            eight.Text = eight.Text.ToString + "Third"
        Else
        End If

        'Cholera
        If CheckBox25.Checked = True Then
            nine.Text = nine.Text.ToString + "First "
        Else
        End If
        If CheckBox26.Checked = True Then
            nine.Text = nine.Text.ToString + "Second "
        Else
        End If
        If CheckBox27.Checked = True Then
            nine.Text = nine.Text.ToString + "Third"
        Else
        End If

        'Hepatitis
        If CheckBox28.Checked = True Then
            ten.Text = ten.Text.ToString + "First "
        Else
        End If
        If CheckBox29.Checked = True Then
            ten.Text = ten.Text.ToString + "Second "
        Else
        End If
        If CheckBox30.Checked = True Then
            ten.Text = ten.Text.ToString + "Third"
        Else
        End If
    End Sub
    Private Sub form_check_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim x As Integer
        For x = 1 To 150
            ComboBox3.Items.Add(x)

        Next
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim checkup As New Form

        form_menu.Panel1.Controls.Clear()
        form_menu.Panel1.Controls.Add(checkup)
        checkup.Dock = DockStyle.Fill
    End Sub
End Class
