' Required to grab info from internet
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Threading

Public Class Proxee
    Dim ping As New Ping
    Dim rp(13) As PingReply
   

    Private Property Cancel As Integer

    Private Property msgVal As MsgBoxResult



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load



        On Error Resume Next

        BackgroundWorker1.RunWorkerAsync()

        'Delete a .old file if it exists so new updates dont cause conflicts
        Dim deleteOld As String = Application.StartupPath()
        My.Computer.FileSystem.DeleteFile("" + deleteOld + "\proxee.exe.old")

        ' Check for update
        ProxeeUpdate.AutoUpdate()

        ' Me.Height = 182
        ' Me.Width = 318
        ' txtWarning.Hide()

        '  Dim exePath As String = Application.ExecutablePath()
        ' Dim infoReader As System.IO.FileInfo
        'infoReader = My.Computer.FileSystem.GetFileInfo(exePath)


        'If infoReader.Length = 63230 Then
        'Me.Height = 182
        'Me.Width = 318
        'stripStatusLabel.Text = "Status: Ready"
        'Else
        'Tab2.Hide()
        ' Me.Height = 388
        'Me.Width = 568
        'txtWarning.Show()
        'txtWarning.Width = 534
        'txtWarning.Height = 333
        'txtWarning.Show()
        'System.Media.SystemSounds.Exclamation.Play()
        'End If


        '    MsgBox("File is " & infoReader.Length & " bytes.")






        'Load Username + password if theyve used program before

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



        'Declare the variables


        'self note:
        'change app.manifest -  <requestedExecutionLevel level="requireAdministrator" uiAccess="false" />



        txtUsername.BorderStyle = BorderStyle.FixedSingle

        cmboProxyAddresses.Items.Add("atlanta.proxee.net:2441")
        cmboProxyAddresses.Items.Add("atlanta2.proxee.net:2551")
        cmboProxyAddresses.Items.Add("seattle.proxee.net:1080")
        cmboProxyAddresses.Items.Add("seattle2.proxee.net:1455")
        cmboProxyAddresses.Items.Add("newyork.proxee.net:8203")
        cmboProxyAddresses.Items.Add("newyork2.proxee.net:5150")
        cmboProxyAddresses.Items.Add("dallas.proxee.net:2000")
        cmboProxyAddresses.Items.Add("dallas2.proxee.net:1685")
        cmboProxyAddresses.Items.Add("la.proxee.net:4330")
        cmboProxyAddresses.Items.Add("la2.proxee.net:9632")
        cmboProxyAddresses.Items.Add("chicago.proxee.net:1081")
        cmboProxyAddresses.Items.Add("chicago2.proxee.net:1717")
        cmboProxyAddresses.Items.Add("frankfurt.proxee.net:1810")
        cmboProxyAddresses.Items.Add("montreal.proxee.net:2000")


    

        'Checks if Skype is running for our status bar
        tmrCheckSkype.Enabled = False



        'Sizes the form to hide the optional features unless a user needs to access them
        '    Me.Width = 218
        '   Me.Height = 268


        '____________________________________________________
        '|                                                  |
        '|proxee.net automatic proxy installer              |
        '|Keep my about form intact if you use this program |
        '|__________________________________________________|

        'Some background on how to get the proxy list to load from remote source:

        'Create a folder on your web server (for example, name it "servers") so you can navigate to www.yourwebsite.com/servers/

        'Create 5 .txt files named whatever you want (server1.txt, server2.txt, server3.txt, server4.txt, server5.txt for example)

        'Inside each txt file, you'll want to put the IP:PORT of your proxy (for example server1.txt would contain 209.141.39.122:9999, server2.txt would contain 209.141.39.123:9999 and so on)
        'Or if you have a domain with "A" records setup, you can use subdomain.domain.com:port

        'Put said files in the newly created folder

        'Edit the timer named 'tmrLoad' accordingly (mainly change the URLs)

        'If you did all this correctly, it should function fine.

      

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub NotifyIcon1_MouseDoubleClick(sender As Object, e As MouseEventArgs)

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Reload_Click(sender As Object, e As EventArgs)


    End Sub


    Private Sub lblTitle_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblTitle_MarginChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblTitle_MouseDown(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub ClosedBox_MouseDown(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
    
    End Sub

    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
    
    End Sub

    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp

    End Sub


    Private Sub txtUsername_Click(sender As Object, e As EventArgs)
        ' When a user clicks the username box, it will remove the default text
        txtUsername.Text = ""
    End Sub

    Private Sub txtUsername_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub txtPassword_Click(sender As Object, e As EventArgs)
        ' When a user clicks the password box, it will remove the default text
        txtPassword.Text = ""
    End Sub

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs)

    End Sub


    Private Sub RectangleShape1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub RectangleShape1_MouseDown(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub Button1_MouseDown(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub lblTitle_MouseMove(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub lblTitle_MouseUp(sender As Object, e As MouseEventArgs)

    End Sub

    Private Sub Button1_Click_2(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_3(sender As Object, e As EventArgs) Handles btnProxyOn.Click

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


                    ' Save their  proxy email + proxy password into Windows to recall at future date
                    My.Settings.Username = txtUsername.Text
                    My.Settings.Password = txtPassword.Text
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

    Private Sub btnProxyOff_Click(sender As Object, e As EventArgs) Handles btnProxyOff.Click

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

    Private Sub Button1_Click_4(sender As Object, e As EventArgs)

    End Sub

    Private Sub Timer1_Tick_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub btnAbout_Click(sender As Object, e As EventArgs)

    


    End Sub

    Private Sub btnCloseOptions_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub grpboxLat_Click(sender As Object, e As EventArgs)

       



    End Sub

    Private Sub grpboxLat_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnAbout_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnChangePass_Click(sender As Object, e As EventArgs) Handles btnChangePass.Click


        Process.Start("http://proxee.net/billing/clientarea.php?action=products")


    End Sub

    Private Sub lblExit_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub cmboProxyAddresses_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblTitle_Click_1(sender As Object, e As EventArgs) Handles lblTitle.Click

    End Sub

    Private Sub lblTitle_MouseDown1(sender As Object, e As MouseEventArgs) Handles lblTitle.MouseDown
     
    End Sub

    Private Sub lblTitle_MouseMove1(sender As Object, e As MouseEventArgs) Handles lblTitle.MouseMove
     
    End Sub

    Private Sub lblTitle_MouseUp1(sender As Object, e As MouseEventArgs) Handles lblTitle.MouseUp

    End Sub

    Private Sub cmboProxyType_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub tmrVersion_Tick(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tmrPingList_Tick(sender As Object, e As EventArgs)
        txtUsername.Text = My.Settings.Username

    End Sub

    Private Sub Button1_Click_5(sender As Object, e As EventArgs)


    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        If chkPassword.Checked Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If


    End Sub

    Private Sub Button1_Click_6(sender As Object, e As EventArgs)

    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles tabPing.Click

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles tabMain.Click

    End Sub

    Private Sub Button1_Click_7(sender As Object, e As EventArgs)



    End Sub

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles chkPassword.CheckedChanged
        If txtPassword.PasswordChar = "*" And chkPassword.Checked = True Then
            txtPassword.PasswordChar = ""
        Else
            txtPassword.PasswordChar = "*"
        End If


    End Sub

    Private Sub cmboProxyAddresses_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmboProxyAddresses.SelectedIndexChanged

    End Sub

    Private Sub txtPassword_Click1(sender As Object, e As EventArgs) Handles txtPassword.Click
        txtPassword.BackColor = Color.White
    End Sub

    Private Sub txtPassword_TextChanged_1(sender As Object, e As EventArgs) Handles txtPassword.TextChanged

    End Sub

    Private Sub txtUsername_Click1(sender As Object, e As EventArgs) Handles txtUsername.Click
        txtUsername.BackColor = Color.White
    End Sub

    Private Sub txtUsername_TextChanged_1(sender As Object, e As EventArgs) Handles txtUsername.TextChanged

    End Sub

    Private Sub ToolStripStatusLabel1_Click(sender As Object, e As EventArgs) Handles stripStatusLabel.Click

    End Sub

    Private Sub Timer1_Tick_2(sender As Object, e As EventArgs) Handles tmrCheckSkype.Tick
        On Error Resume Next
        ' Starting Skype back up using the file path located in the text box listed below (to allow users to dictate where their Skype install is if not default)

        If Process.GetProcessesByName("Skype").Length <> 0 Then
            stripStatusLabel.Text = "Skype is running"
            tmrCheckSkype.Enabled = False
        Else
            stripStatusLabel.Text = "Error: Unable to find Skype process"

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs)

    End Sub


    Private Sub Button1_Click_8(sender As Object, e As EventArgs)

    End Sub

    Private Sub StatusStrip1_ItemClicked(sender As Object, e As ToolStripItemClickedEventArgs) Handles StatusStrip1.ItemClicked

    End Sub

    Private Sub Button2_Click_2(sender As Object, e As EventArgs)
  
    End Sub

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        rp(0) = ping.Send("atlanta.proxee.net")
        rp(1) = ping.Send("atlanta2.proxee.net")
        rp(2) = ping.Send("seattle.proxee.net")
        rp(3) = ping.Send("seattle2.proxee.net")
        rp(4) = ping.Send("newyork.proxee.net")
        rp(5) = ping.Send("newyork2.proxee.net")
        rp(6) = ping.Send("dallas.proxee.net")
        rp(7) = ping.Send("dallas2.proxee.net")
        rp(8) = ping.Send("la.proxee.net")
        rp(9) = ping.Send("la2.proxee.net")
        rp(10) = ping.Send("chicago.proxee.net")
        rp(11) = ping.Send("chicago2.proxee.net")
        rp(12) = ping.Send("frankfurt.proxee.net")
        rp(13) = ping.Send("montreal.proxee.net")


    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        On Error Resume Next
        lstPing.Items.Add("Atlanta Ping: " & rp(0).RoundtripTime & " ms")
        lstPing.Items.Add("Atlanta 2 Ping: " & rp(1).RoundtripTime & " ms")
        lstPing.Items.Add("Seattle Ping: " & rp(2).RoundtripTime & " ms")
        lstPing.Items.Add("Seattle 2 Ping: " & rp(3).RoundtripTime & " ms")
        lstPing.Items.Add("New York Ping: " & rp(4).RoundtripTime & " ms")
        lstPing.Items.Add("New York 2 Ping: " & rp(5).RoundtripTime & " ms")
        lstPing.Items.Add("Dallas Ping: " & rp(6).RoundtripTime & " ms")
        lstPing.Items.Add("Dallas 2 Ping: " & rp(7).RoundtripTime & " ms")
        lstPing.Items.Add("Los Angeles Ping: " & rp(8).RoundtripTime & " ms")
        lstPing.Items.Add("Los Angeles 2 Ping: " & rp(9).RoundtripTime & " ms")
        lstPing.Items.Add("Chicago Ping: " & rp(10).RoundtripTime & " ms")
        lstPing.Items.Add("Chicago 2 Ping: " & rp(11).RoundtripTime & " ms")
        lstPing.Items.Add("Frankfurt Ping: " & rp(12).RoundtripTime & " ms")
        lstPing.Items.Add("Montreal Ping: " & rp(13).RoundtripTime & " ms")


    End Sub
End Class
