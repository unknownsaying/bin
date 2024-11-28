Module Program
    Sub Main()
        ' Create a virtual disk with 1MB capacity
        Dim disk As New VirtualDisk(1024 * 1024)

        ' Write some files
        disk.WriteFile("file1.txt", System.Text.Encoding.UTF8.GetBytes("Hello, World!"))
        disk.WriteFile("file2.txt", System.Text.Encoding.UTF8.GetBytes("This is a test file."))
        disk.WriteFile("image.jpg", New Byte(1023) {})  ' 1KB of zero bytes

        ' List files
        disk.ListFiles()

        ' Read a file
        Dim content As Byte() = disk.ReadFile("file1.txt")
        Console.WriteLine($"Content of file1.txt: {System.Text.Encoding.UTF8.GetString(content)}")

        ' Delete a file
        disk.DeleteFile("file2.txt")

        ' Try to read the deleted file
        Try
            disk.ReadFile("file2.txt")
        Catch ex As Exception
            Console.WriteLine($"Error: {ex.Message}")
        End Try

        ' List files again
        disk.ListFiles()

        ' Display disk information
        Console.WriteLine($"Disk capacity: {disk.GetCapacity()} bytes")
        Console.WriteLine($"Used space: {disk.GetUsedSpace()} bytes")
        Console.WriteLine($"Free space: {disk.GetFreeSpace()} bytes")

        Console.ReadLine() ' Keep console window open
    End Sub
End Module
