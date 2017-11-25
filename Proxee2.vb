' Required to grab info 
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Threading

Public Class Proxee
    Dim ping As New Ping
    Dim rp(8) As PingReply
   

    Private Property Cancel As Integer

    Private Property msgVal As MsgBoxResult



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    


        On Error Resume Next

        bgPing.RunWorkerAsync()

        'Delete a .old file if it exists so new updates dont cause conflicts
        Dim deleteOld As String = Application.StartupPath()
        My.Computer.FileSystem.DeleteFile("" + deleteOld + "\proxee.exe.old")

        ' Check for update
        ProxeeUpdate.AutoUpdate()


        'Load Username, password & skype path if they've used program before
        '  Me.Height = 182
        ' Me.Width = 313
        If My.Settings.Username = "" Then
            txtUsername.Text = "Email address"
        Else
            txtUsername.Text = My.Settings.Username
        End If

        If My.Settings.Password = "" Then
            txtPassword.Text = "Proxy Password"
        Else
            txtPassword.Text = My.Settings.Password
        End If
        If My.Settings.skypePath = "" Then
            txtSkypePath.Text = "C:\Program Files (x86)\Skype\Phone\Skype.exe"
        Else
            txtSkypePath.Text = My.Settings.skypePath
        End If



        'Declare the variables


        'self note:
        'change app.manifest -  <requestedExecutionLevel level="requireAdministrator" uiAccess="false" />



        txtUsername.BorderStyle = BorderStyle.FixedSingle

        cmboProxyAddresses.Items.Add("east1.proxee.net:2441")
        cmboProxyAddresses.Items.Add("east2.proxee.net:2551")
        cmboProxyAddresses.Items.Add("west1.proxee.net:4330")
        cmboProxyAddresses.Items.Add("west2.proxee.net:9632")
        cmboProxyAddresses.Items.Add("central1.proxee.net:1081")
        cmboProxyAddresses.Items.Add("central2.proxee.net:1717")
        cmboProxyAddresses.Items.Add("europe1.proxee.net:1810")
        cmboProxyAddresses.Items.Add("canada1.proxee.net:2000")
        cmboProxyAddresses.Items.Add("australia1.proxee.net:2441")



        'Checks if Skype is running for our status bar
        tmrCheckSkype.Enabled = False



        'Sizes the form to hide the optional features unless a user needs to access them
        '    Me.Width = 218
        '   Me.Height = 268





    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As Object, ByVal e As MouseEventArgs)

    End Sub


    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(ByVal sender As Object, ByVal e As EventArgs)


    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub Reload_Click(ByVal sender As Object, ByVal e As EventArgs)


    End Sub


    Private Sub lblTitle_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub lblTitle_MarginChanged(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub lblTitle_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)

    End Sub

    Private Sub ClosedBox_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles Me.MouseDown

    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove

    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

    End Sub


    Private Sub txtUsername_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' When a user clicks the username box, it will remove the default text
        txtUsername.Text = ""
    End Sub

    Private Sub txtUsername_TextChanged(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub txtPassword_Click(ByVal sender As Object, ByVal e As EventArgs)
        ' When a user clicks the password box, it will remove the default text
        txtPassword.Text = ""
    End Sub

    Private Sub txtPassword_TextChanged(ByVal sender As Object, ByVal e As EventArgs)

    End Sub


    Private Sub RectangleShape1_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub RectangleShape1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)

    End Sub

    Private Sub Button1_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs)

    End Sub

    Private Sub lblTitle_MouseMove(ByVal sender As Object, ByVal e As MouseEventArgs)

    End Sub

    Private Sub lblTitle_MouseUp(ByVal sender As Object, ByVal e As MouseEventArgs)

    End Sub

    Private Sub Button1_Click_2(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub Button1_Click_3(ByVal sender As Object, ByVal e As EventArgs) Handles btnProxyOn.Click

        ' Checks to make sure a user has not left the username field set to default or left it blank
        If txtUsername.Text = "" Or txtUsername.Text = "Email Address" Or txtUsername.Text = "Email address" Then
            'MsgBox("You have entered either an incorrect username or no username at all. Please check your information and trying again!")
            txtUsername.BackColor = Color.IndianRed
            stripStatusLabel.Text = "Error: Invalid username"

        Else
            txtUsername.BackColor = Color.PaleGreen


            ' Checks to make sure a user has not left the password field set to default or left it blank
            If txtPassword.Text = "" Or txtPassword.Text = "Proxy Password" Then
                ' MsgBox("You have entered either an incorrect password or no password at all. Please check your information and trying again!")
                txtPassword.BackColor = Color.IndianRed
                stripStatusLabel.Text = "Error: Invalid password"
            Else
                txtPassword.BackColor = Color.PaleGreen


                ' Checks to make sure a user has selected a server.
                If cmboProxyAddresses.Text = "" Or cmboProxyAddresses.Text = "Server" Then
                    ' MsgBox("You have not chosen a server to connect to. Please check your settings and try again!")
                    stripStatusLabel.Text = "Error: No proxy server selected"
                Else






                    ' If a user has entered a username and password combo that isint prohibited (such as leaving the fields blank or default) along with picking a server
                    ' it will now use those as part of The registry editing settings

                    ' Making both the username and password fields all lower case just incase a user entered his/her password using  capital letters
                    ' txtUsername.CharacterCasing = CharacterCasing.Lower
                    ' txtPassword.CharacterCasing = CharacterCasing.Lower

                    ' Adding the username to registry
                    My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Skype\Phone", "ProxyUsername", "" + txtUsername.Text + "")


                    ' Adding the password to registry
                    My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Skype\Phone", "ProxyPassword", "" + txtPassword.Text + "")


                    ' Adding the proxy address (must include port) to the registry
                    My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Skype\Phone", "ProxyAddress", "" + cmboProxyAddresses.Text + "")


                    ' Adding the proxy type (SOCKS5, HTTP, or HTTPS) to the registry
                    ' I have left this as a variable due to possibly wanting to include a combo box at a later date even though all of our proxies
                    ' are SOCKS5
                    My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Skype\Phone", "ProxySetting", "" + cmboProxyType.Text + "")


                    ' Save their  proxy email + proxy password + Skype Path into Windows to recall at future date
                    My.Settings.Username = txtUsername.Text
                    My.Settings.Password = txtPassword.Text
                    My.Settings.skypePath = txtSkypePath.Text
                    My.Settings.Save()



                    On Error Resume Next
                    ' Find all processes relating to Skype so we can close them (if you're running 2 copies of Skype, this will only open one back up)
                    Dim myProcesses() As Process
                    Dim myProcess As Process
                    Dim teller As Integer = 0

                    myProcesses = Process.GetProcessesByName("Skype")
                    stripStatusLabel.Text = "Attempting to close Skype"
                    For Each myProcess In myProcesses
                        myProcess.CloseMainWindow()
                        teller += 1
                    Next
                    If teller > 0 Then
                        ' MessageBox.Show("Proxee - Restarting Skype")
                        stripStatusLabel.Text = "Attempting to restart Skype"
                        Process.Start("" + txtSkypePath.Text + "")
                        tmrCheckSkype.Enabled = True
                    Else
                        'MessageBox.Show("Proxee - Launching Skype")
                        stripStatusLabel.Text = "Attempting to launch Skype"
                        Process.Start("" + txtSkypePath.Text + "")
                        tmrCheckSkype.Enabled = True
                    End If


                End If
            End If
        End If
    End Sub

    Private Sub btnProxyOff_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnProxyOff.Click

        ' Confirm with the user if they are sure they want to turn their proxy off
        msgVal = MsgBox("Are you sure you want to remove your proxy? This leaves you vulnerable to others trying to obtain your IP address!", vbOKCancel + vbInformation, "Are you sure?")
        If msgVal = vbOK Then
            stripStatusLabel.Text = "Removing proxy settings"





            ' Making the username field in the registry blank therefore removing it
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Skype\Phone", "ProxyUsername", "")

            ' Making the password field in the registry blank therefore removing it
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Skype\Phone", "ProxyPassword", "")
            ' Making the proxy address field in the registry blank therefore removing it
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Skype\Phone", "ProxyAddress", "")

            ' Making the proxy type field in the registry blank therefore removing it
            My.Computer.Registry.SetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Skype\Phone", "ProxySetting", "")

            ' Notifying the user the proxy settings have been removed


            On Error Resume Next
            ' Find all processes relating to Skype so we can close them (if you're running 2 copies of Skype, this will only open one back up)
            Dim myProcesses() As Process
            Dim myProcess As Process
            Dim teller As Integer = 0

            myProcesses = Process.GetProcessesByName("Skype")
            stripStatusLabel.Text = "Attempting to close Skype"
            For Each myProcess In myProcesses
                myProcess.CloseMainWindow()
                teller += 1
            Next
            If teller > 0 Then
                ' MessageBox.Show("Proxee - Restarting Skype")
                stripStatusLabel.Text = "Attempting to restart Skype"
                Process.Start("" + txtSkypePath.Text + "")
                tmrCheckSkype.Enabled = True
            Else
                'MessageBox.Show("Proxee - Launching Skype")
                stripStatusLabel.Text = "Attempting to launch Skype"
                Process.Start("" + txtSkypePath.Text + "")
                tmrCheckSkype.Enabled = True
            End If



        End If

        ' If a user declines to turn their proxy off then nothing happens
        If msgVal = vbCancel Then
            Cancel = 1
        End If
    End Sub

    Private Sub Button1_Click_4(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub Timer1_Tick_1(ByVal sender As Object, ByVal e As EventArgs)


    End Sub

    Private Sub btnAbout_Click(ByVal sender As Object, ByVal e As EventArgs)




    End Sub

    Private Sub btnCloseOptions_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub grpboxLat_Click(ByVal sender As Object, ByVal e As EventArgs)





    End Sub

    Private Sub grpboxLat_Enter(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub btnAbout_Click_1(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub btnChangePass_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSite.Click


        Process.Start("https://proxee.net/billing/clientarea.php?action=services")


    End Sub

    Private Sub lblExit_Click(ByVal sender As Object, ByVal e As EventArgs)
        End
    End Sub

    Private Sub cmboProxyAddresses_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub lblTitle_Click_1(ByVal sender As Object, ByVal e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub lblTitle_MouseDown1(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lblTitle.MouseDown

    End Sub

    Private Sub lblTitle_MouseMove1(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lblTitle.MouseMove

    End Sub

    Private Sub lblTitle_MouseUp1(ByVal sender As Object, ByVal e As MouseEventArgs) Handles lblTitle.MouseUp

    End Sub

    Private Sub cmboProxyType_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub tmrVersion_Tick(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub tmrPingList_Tick(ByVal sender As Object, ByVal e As EventArgs)
        txtUsername.Text = My.Settings.Username

    End Sub

    Private Sub Button1_Click_5(ByVal sender As Object, ByVal e As EventArgs)


    End Sub

    Private Sub Button2_Click_1(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As Object, ByVal e As EventArgs)
        If chkPassword.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If


    End Sub

    Private Sub Button1_Click_6(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub TabPage2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tabPing.Click

    End Sub

    Private Sub TabPage1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles tabMain.Click

    End Sub

    Private Sub Button1_Click_7(ByVal sender As Object, ByVal e As EventArgs)



    End Sub

    Private Sub CheckBox1_CheckedChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles chkPassword.CheckedChanged
        If txtPassword.PasswordChar = "*" And chkPassword.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If


    End Sub

    Private Sub cmboProxyAddresses_SelectedIndexChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles cmboProxyAddresses.SelectedIndexChanged

    End Sub

    Private Sub txtPassword_Click1(ByVal sender As Object, ByVal e As EventArgs) Handles txtPassword.Click
        txtPassword.BackColor = Color.White
    End Sub

    Private Sub txtPassword_TextChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub txtUsername_Click1(ByVal sender As Object, ByVal e As EventArgs) Handles txtUsername.Click
        txtUsername.BackColor = Color.White
    End Sub

    Private Sub txtUsername_TextChanged_1(ByVal sender As Object, ByVal e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub ToolStripStatusLabel1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles stripStatusLabel.Click

    End Sub

    Private Sub Timer1_Tick_2(ByVal sender As Object, ByVal e As EventArgs) Handles tmrCheckSkype.Tick
        On Error Resume Next
        ' Starting Skype back up using the file path located in the text box listed below (to allow users to dictate where their Skype install is if not default)

        If Process.GetProcessesByName("Skype").Length <> 0 Then
            stripStatusLabel.Text = "Skype is running"
            tmrCheckSkype.Enabled = False
        Else
            Process.Start("" + txtSkypePath.Text + "")
            stripStatusLabel.Text = "Still attempting to start Skype..."

        End If
    End Sub

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(ByVal sender As Object, ByVal e As EventArgs)

    End Sub


    Private Sub Button1_Click_8(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub StatusStrip1_ItemClicked(ByVal sender As Object, ByVal e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub Button2_Click_2(ByVal sender As Object, ByVal e As EventArgs)

    End Sub

    Private Sub BackgroundWorker1_DoWork(ByVal sender As Object, ByVal e As System.ComponentModel.DoWorkEventArgs) Handles bgPing.DoWork
        On Error Resume Next
        rp(0) = ping.Send("east1.proxee.net")
        rp(1) = ping.Send("east2.proxee.net")
        rp(2) = ping.Send("west1.proxee.net")
        rp(3) = ping.Send("west2.proxee.net")
        rp(4) = ping.Send("central1.proxee.net")
        rp(5) = ping.Send("central2.proxee.net")
        rp(6) = ping.Send("canada1.proxee.net")
        rp(7) = ping.Send("europe1.proxee.net")
        rp(8) = ping.Send("australia1.proxee.net")

    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles bgPing.RunWorkerCompleted
        On Error Resume Next
        lstPing.Items.Add("East 1 Ping: " & rp(0).RoundtripTime & " ms")
        lstPing.Items.Add("East 2 Ping: " & rp(1).RoundtripTime & " ms")
        lstPing.Items.Add("West 1 Ping: " & rp(2).RoundtripTime & " ms")
        lstPing.Items.Add("West 2 Ping: " & rp(3).RoundtripTime & " ms")
        lstPing.Items.Add("Central 1 Ping: " & rp(4).RoundtripTime & " ms")
        lstPing.Items.Add("Central 2 Ping: " & rp(5).RoundtripTime & " ms")
        lstPing.Items.Add("Canada 1 Ping: " & rp(6).RoundtripTime & " ms")
        lstPing.Items.Add("Europe 1 Ping: " & rp(7).RoundtripTime & " ms")
        lstPing.Items.Add("Australia 1 Ping: " & rp(8).RoundtripTime & " ms")


    End Sub

    Private Sub Button1_Click_9(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnViewdetails_Click(sender As Object, e As EventArgs)



    End Sub

    Private Sub Button1_Click_10(ByVal sender As System.Object, ByVal e As System.EventArgs)



    End Sub

    Private Sub Button1_Click_11(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoadRegistry.Click
        Dim retrieveUsername As Object
        Dim retrievePassword As Object
        retrieveUsername = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Skype\Phone", "ProxyUsername", Nothing)
        retrievePassword = My.Computer.Registry.GetValue("HKEY_LOCAL_MACHINE\SOFTWARE\Policies\Skype\Phone", "ProxyPassword", Nothing)
        txtUsername.Text = retrieveUsername
        txtPassword.Text = retrievePassword
        MsgBox("Attempted to load your Proxee.net settings from the Windows registry. If you don't see your username & password above then it means no information was saved in your registry.")
    End Sub
End Class
