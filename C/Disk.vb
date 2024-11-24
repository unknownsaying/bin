Imports System
Imports System.Collections.Generic

Public Class VirtualDisk
    Private files As Dictionary(Of String, Byte())
    Private capacity As Long
    Private used As Long

    Public Sub New(capacityInBytes As Long)
        files = New Dictionary(Of String, Byte())
        capacity = capacityInBytes
        used = 0
    End Sub

    Public Sub WriteFile(fileName As String, content As Byte())
        If used + content.Length <= capacity Then
            If files.ContainsKey(fileName) Then
                used -= files(fileName).Length
            End If
            files(fileName) = content
            used += content.Length
            Console.WriteLine("File '{fileName}' written successfully.")
        Else
            Throw New Exception("Not enough space on the disk.")
        End If
    End Sub

    Public Function ReadFile(fileName As String) As Byte()
        If files.ContainsKey(fileName) Then
            Return files(fileName)
        Else
            Throw New Exception("File '{fileName}' not found.")
        End If
    End Function

    Public Sub DeleteFile(fileName As String)
        If files.ContainsKey(fileName) Then
            used -= files(fileName).Length
            files.Remove(fileName)
            Console.WriteLine("File '{fileName}' deleted successfully.")
        Else
            Throw New Exception("File '{fileName}' not found.")
        End If
    End Sub

    Public Sub ListFiles()
        Console.WriteLine("Files on the disk:")
        For Each fileName In files.Keys
            Console.WriteLine("- {fileName} ({files(fileName).Length} bytes)")
        Next
        Console.WriteLine("Total files: {files.Count}")
        Console.WriteLine("Used space: {used} bytes")
        Console.WriteLine("Free space: {capacity - used} bytes")
    End Sub

    Public Function GetCapacity() As Long
        Return capacity
    End Function

    Public Function GetUsedSpace() As Long
        Return used
    End Function

    Public Function GetFreeSpace() As Long
        Return capacity - used
    End Function
End Class

