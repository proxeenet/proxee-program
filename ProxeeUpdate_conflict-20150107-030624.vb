Imports System.Text.RegularExpressions
Imports System.Threading
Module ProxeeUpdate
    Public Sub AutoUpdate()

        On Error Resume Next


        Dim CurrentVersion As String = "v6.2" '--- Change this to Current version, needs changing on every update
        Dim ProgramName As String = "Proxee" '--- Change this to Your Progran Name
        Dim SiteName As String = "http://proxee.net/UpdateCHK.html" '--- Change this to Your Update page
        Dim VersionCHK, GetVer, GetVerLink As String
        Dim GetUpd As Integer


        Dim WebRequest As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create(SiteName)
        Dim WebResponse As System.Net.HttpWebResponse = WebRequest.GetResponse
        Dim STR As System.IO.StreamReader = New System.IO.StreamReader(WebResponse.GetResponseStream())
        Dim ReadSource As String = STR.ReadToEnd
        Dim Regex As New System.Text.RegularExpressions.Regex(ProgramName & "=v(\d+).(\d+)=(.*?).exe")
        Dim matches As MatchCollection = Regex.Matches(ReadSource)

        For Each match As Match In matches
            Dim RegSplit() As String = Split(match.ToString, "=")
            GetVer = RegSplit(1)
            GetVerLink = RegSplit(2)
        Next

        If GetVer > CurrentVersion Then
            GetUpd = MsgBox("Proxee.net Proxy Program is outdated!" & vbCrLf & "A new update is available and ready to download" & _
            vbCrLf & "Current version: " & CurrentVersion & vbCrLf & "Version Avalible: " & _
            GetVer & vbCrLf & vbCrLf & "Update Now?", vbYesNo, "Update")

            If GetUpd = vbYes Then
                Dim exePath As String = Application.ExecutablePath()
                Dim exePath1 As String = Application.StartupPath()
                Dim sfd As New SaveFileDialog
                sfd.InitialDirectory = exePath1
                sfd.DefaultExt = "exe"
                sfd.AddExtension = True

                sfd.FileName = IO.Path.GetFileName(GetVerLink)
                If sfd.ShowDialog = DialogResult.OK Then

                    ' sfd.Filter = "Executable File|*.exe"
                    'sfd.DefaultExt = "exe"
                    'sfd.AddExtension = True

                    My.Computer.FileSystem.RenameFile("" + exePath + "", "proxee.exe.old")
                    My.Computer.Network.DownloadFile(GetVerLink, sfd.FileName)
                    MsgBox("Update complete. Please launch the updated version now.")
                    End



                End If
            End If
        Else
            Proxee.stripStatusLabel.Text = "Status: Ready"
        End If

    End Sub
End Module
