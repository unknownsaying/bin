Imports System

Public Class VirtualRAM
    Private memory As Byte()
    Private size As Integer

    Public Sub New(sizeInBytes As Integer)
        size = sizeInBytes
        memory = New Byte(size - 1) {}
    End Sub

    Public Sub Write(address As Integer, value As Byte)
        If address >= 0 AndAlso address < size Then
            memory(address) = value
        Else
            Throw New IndexOutOfRangeException("Address out of range")
        End If
    End Sub

    Public Function Read(address As Integer) As Byte
        If address >= 0 AndAlso address < size Then
            Return memory(address)
        Else
            Throw New IndexOutOfRangeException("Address out of range")
        End If
    End Function

    Public Function GetSize() As Integer
        Return size
    End Function
End Class

Module Program
    Sub Main()
        ' Create a virtual RAM with 1024 bytes
        Dim ram As New VirtualRAM(1024)

        ' Write some values to the virtual RAM
        ram.Write(0, 42)
        ram.Write(1, 255)
        ram.Write(100, 123)

        ' Read and display values from the virtual RAM
        Console.WriteLine("Value at address 0: " & ram.Read(0))
        Console.WriteLine("Value at address 1: " & ram.Read(1))
        Console.WriteLine("Value at address 100: " & ram.Read(100))

        ' Try to access an out-of-range address
        Try
            ram.Write(1024, 1)
        Catch ex As IndexOutOfRangeException
            Console.WriteLine("Error: " & ex.Message)
        End Try

        ' Display the size of the virtual RAM
        Console.WriteLine("Virtual RAM size: " & ram.GetSize() & " bytes")

        Console.ReadLine() ' Keep console window open
    End Sub
End Module