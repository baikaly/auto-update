Imports System.IO
Imports System.Net

Public Class UpdatingForm

    Private LocalVersionConfig As XmlVersionConfigFile = Nothing
    Private ServerVersionConfig As XmlVersionConfigFile = Nothing

    Private WithEvents webClient As New System.Net.WebClient

    Private _downloadIndex As Integer
    Private _localConfigFileName As String = "version.xml"
    Private _localXmlFilePath As String = Path.Combine(Application.StartupPath, _localConfigFileName)
    Private _updateUrl As String = String.Empty
    Private _deleteFileList As New List(Of String)

    Private _startingName As String = String.Empty




    Private Sub webClient_DownloadFileCompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs) Handles webClient.DownloadFileCompleted
        Me.lvwFile.Items(_downloadIndex).ImageIndex = 2

        lblSinglePercent.Text = "0%"
        prbSingle.Value = 0

        DownloadNextFile()
    End Sub

    Private Sub webClient_DownloadProgressChanged(ByVal sender As System.Object, ByVal e As System.Net.DownloadProgressChangedEventArgs) Handles webClient.DownloadProgressChanged
        Dim currentPercent As String = e.ProgressPercentage & "%"
        If currentPercent <> Me.lvwFile.Items(_downloadIndex).SubItems(3).Text Then
            Me.lvwFile.Items(_downloadIndex).SubItems(3).Text = currentPercent
            prbSingle.Value = e.ProgressPercentage
            lblSinglePercent.Text = currentPercent
            prbAll.Value = Int((_downloadIndex + 1) / Me.lvwFile.Items.Count * 100)
            lblAllPercent.Text = prbAll.Value & "%"
        End If
    End Sub

    Private Sub btnQuit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnQuit.Click
        Process.Start(Path.Combine(Application.StartupPath, _startingName))
        Me.Close()
    End Sub

    Private Sub DownloadNextFile()
        If _downloadIndex < (lvwFile.Items.Count - 1) Then

            _downloadIndex += 1

            lvwFile.Items(_downloadIndex).ImageIndex = 1

            Try
                Dim destPath As String = IO.Path.Combine(Application.StartupPath, lvwFile.Items(_downloadIndex).SubItems(1).Text)
                File.Delete(destPath)
                webClient.Credentials = New System.Net.NetworkCredential("liugp", "654321")
                Debug.WriteLine(_updateUrl & lvwFile.Items(_downloadIndex).SubItems(1).Text)
                webClient.DownloadFileAsync(New Uri(_updateUrl & lvwFile.Items(_downloadIndex).SubItems(1).Text), destPath)

            Catch ex As Exception
                Me.lvwFile.Items(_downloadIndex).ImageIndex = 3
                MsgBox("�����ļ��������󣬸���ʧ�ܡ�����ԭ�� " & ex.Message, MsgBoxStyle.Critical, "����")
                Me.Close()
            End Try
        Else
            UpdateFileCompleted()


        End If
    End Sub

    Private Sub UpdateFileCompleted()
        ' ������ʾ��Ϣ��
        prbSingle.Value = prbSingle.Maximum
        lblSinglePercent.Text = "100%"
        lblAllPercent.Text = "100%"

        ' ɾ������Ҫ���ļ���
        For Each f As String In _deleteFileList
            Try
                File.Delete(Path.Combine(Application.StartupPath, f))
            Catch ex As Exception
                '
            End Try
        Next

        Me.btnQuit.Enabled = True


    End Sub

    Private Sub LoadUpdateFile()
        _updateUrl = Me.ServerVersionConfig.UpdateUrl

        ' ���ҿͻ�����Ҫ���µ��ļ�����Ҫɾ�����ļ���
        For Each p As KeyValuePair(Of String, Version) In Me.LocalVersionConfig.UpdateFileList
            If Me.ServerVersionConfig.UpdateFileList.ContainsKey(p.Key) Then
                If Me.ServerVersionConfig.UpdateFileList(p.Key) > Me.LocalVersionConfig.UpdateFileList(p.Key) Then
                    Dim item As ListViewItem = Me.lvwFile.Items.Add(String.Empty, 0)
                    item.SubItems.Add(p.Key)
                    item.SubItems.Add(Me.ServerVersionConfig.UpdateFileList(p.Key).ToString)
                    item.SubItems.Add(String.Empty)
                End If
            Else
                _deleteFileList.Add(p.Key)
            End If
        Next

        ' ���ҷ�������������Ҫ���ص��ļ���
        For Each p As KeyValuePair(Of String, Version) In Me.ServerVersionConfig.UpdateFileList
            If Me.LocalVersionConfig.UpdateFileList.ContainsKey(p.Key) = False Then
                Dim item As ListViewItem = Me.lvwFile.Items.Add(String.Empty, 0)
                item.SubItems.Add(p.Key)
                item.SubItems.Add(p.Value.ToString)
                item.SubItems.Add(String.Empty)
            End If
        Next

        ' �汾�����ļ�Ϊ���������ļ���
        Dim itemVersion As ListViewItem = Me.lvwFile.Items.Add(String.Empty, 0)
        itemVersion.SubItems.Add("version.xml")
        itemVersion.SubItems.Add(Me.ServerVersionConfig.MainVersion.ToString)
        itemVersion.SubItems.Add(String.Empty)

        ' ���õ�ǰ���ص��ļ�������
        _downloadIndex = -1
    End Sub

    Private Sub UpdatingForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim localXmlFileContent As String = File.ReadAllText(_localXmlFilePath)
        LocalVersionConfig = New XmlVersionConfigFile(localXmlFileContent)
        _updateUrl = Path.Combine(LocalVersionConfig.UpdateUrl, _localConfigFileName)
        _startingName = LocalVersionConfig.StartingName

        Dim serverXmlFileContent As String = String.Empty
        Dim client As New WebClient
        client.Credentials = New System.Net.NetworkCredential("liugp", "654321")
        Try
            serverXmlFileContent = client.DownloadString(New Uri(_updateUrl))
        Catch ex As Exception
            MsgBox("�޷��ӷ�������ȡ�汾������Ϣ������ԭ�� " & ex.Message, vbCritical, "����")

        End Try
        ServerVersionConfig = New XmlVersionConfigFile(serverXmlFileContent)
        If LocalVersionConfig.MainVersion < ServerVersionConfig.MainVersion Then
            LoadUpdateFile()
            '''ǿ�ƽ�������
            'Dim proc() As Process
            'proc = Process.GetProcessesByName("ProQual")
            'For Each p In proc
            '    p.Kill()
            'Next
            'proc = Nothing
            DownloadNextFile()
        Else
            Process.Start(Path.Combine(Application.StartupPath, _startingName))
            Me.Close()
        End If

    End Sub

End Class
