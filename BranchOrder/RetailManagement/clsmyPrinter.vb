
'Print Class 
Public Class myPrinter
   
    'Below is the sub that prints the text to the printer.
    Public Sub prt(ByVal text As String)
        TextToBePrinted = text
        Dim prn As New Printing.PrintDocument
        Using (prn)

            prn.PrinterSettings.PrinterName = printer
            prn.PrinterSettings.Copies = copies
            '// Adds a handler for PrintDocument.PrintPage 
            '(the sub PrintPageHandler)
            AddHandler prn.PrintPage, _
               AddressOf Me.PrintPageHandler
            '\\
            prn.Print() 'Prints.
            '// Removes the handler for PrintDocument.PrintPage 
            '(the sub PrintPageHandler)
            RemoveHandler prn.PrintPage, _
               AddressOf Me.PrintPageHandler
            '\\
        End Using
    End Sub
    'Below is code that sets the fonts etc...
    Private Sub PrintPageHandler(ByVal sender As Object, _
       ByVal args As Printing.PrintPageEventArgs)
        Dim myFont As New Font("Courier New", 10)
        args.Graphics.DrawString(TextToBePrinted, _
           New Font(myFont, FontStyle.Regular), _
           Brushes.Black, 50, 50)
    End Sub
End Class


