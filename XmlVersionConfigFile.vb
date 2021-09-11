Imports System.Xml
Imports System.Xml.Linq
'Download by http://www.codesc.net
Public Class XmlVersionConfigFile

    Public Property UpdateUrl As String = String.Empty
    Public Property Username As String = String.Empty
    Public Property Password As String = String.Empty
    Public Property MainVersion As Version = Version.Parse("0.0.0.0")
    Public Property DeleteLocalFile As Boolean = False
    Public Property LastUpdateTime As Date = DateTimePicker.MinimumDateTime
    Public Property UpdateDescription As String = String.Empty
    Public Property StartingName As String = String.Empty
    Public Property UpdateFileList As Dictionary(Of String, Version) = Nothing

    Public Sub New(ByVal fileContent As String)
        ParseXmlVersionFile(fileContent)
    End Sub

    Private Function ParseXmlVersionFile(ByVal fileContent As String) As Boolean
        Dim xdoc As XDocument = Nothing
        Try
            xdoc = XDocument.Parse(fileContent)
        Catch ex As Exception
            Debug.Print(ex.Message)
            Return False
        End Try

        Try
            Me.Username = xdoc.Element("AutoUpdater").Element("Updater").Element("Username").Value
            Me.Password = xdoc.Element("AutoUpdater").Element("Updater").Element("Password").Value
        Catch ex As Exception
            Debug.Print(ex.Message)
        End Try

        Try
            Dim str = xdoc.Element("AutoUpdater").Element("Updater").Element("DeleteLocalFile").Value
            If str.ToLower = "true" Or str = "1" Or str = "是" Then
                DeleteLocalFile = True
            Else
                DeleteLocalFile = False
            End If
        Catch ex As Exception

        End Try

        Try
            Me.UpdateUrl = xdoc.Element("AutoUpdater").Element("Updater").Element("UpdateUrl").Value
            Me.StartingName = xdoc.Element("AutoUpdater").Element("Updater").Element("StartingName").Value
            Me.MainVersion = Version.Parse(xdoc.Element("AutoUpdater").Element("Updater").Element("MainVersion").Value)
            Date.TryParse(xdoc.Element("AutoUpdater").Element("Updater").Element("LastUpdateTime").Value, Me.LastUpdateTime)
            Me.UpdateDescription = xdoc.Element("AutoUpdater").Element("Updater").Element("UpdateDescription").Value

            Me.UpdateFileList = New Dictionary(Of String, Version)
            Dim query = From UpdateFile In xdoc.Descendants("UpdateFile") Select UpdateFile
            For Each fileInfo As XElement In query
                Me.UpdateFileList.Add(fileInfo.Attribute("Name").Value, Version.Parse(fileInfo.Attribute("Version").Value))
            Next
        Catch ex As Exception
            'MessageBox.Show(ex.Message)
            Debug.Print(ex.Message)
            Return False
        End Try
        

        Return True
    End Function
End Class
