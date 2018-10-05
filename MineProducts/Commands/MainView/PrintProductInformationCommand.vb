Imports System.Drawing.Printing
Imports MineProducts.Events
Imports MineProducts.Events.Interfaces
Imports MineProducts.Models

Namespace Commands.MainView
    Public Class PrintProductInformationCommand
        Inherits CommandBase

        Private ReadOnly _eventAggregator As IEventAggregator
        Private _product As Product
        Private _mine As Mine
        Private ReadOnly _richTextBox As New RichTextBox

        Public Sub New(eventAggregator As IEventAggregator)
            _eventAggregator = eventAggregator
            _eventAggregator.Subscribe(Of PrintProductInformationMessage)(
                Sub(message)
                    _mine = message.SelectedMine
                    _product = message.SelectedProduct
                    Execute()
                End Sub
            )
        End Sub

        Public Overrides Sub Execute()
            PrepareProductSheet()
            Try
                Dim printer As New PrintDocument()
                AddHandler printer.PrintPage, AddressOf PrintPageHandler
                printer.Print()
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub

        Private Sub PrepareProductSheet()
            _richTextBox.Text = $"Mine: {_mine.Name}" + Environment.NewLine
            _richTextBox.Text = _richTextBox.Text + $"Explosive Product: {_product.Name}" + Environment.NewLine
            _richTextBox.Text = _richTextBox.Text + $"Application End Use: {_product.ApplicationEndUse}" + Environment.NewLine
            _richTextBox.Text = _richTextBox.Text + $"Fume Class: {_product.FumeClass}" + Environment.NewLine
            _richTextBox.Text = _richTextBox.Text + $"Explosive Density: {_product.ExplosiveDensity} g/cc" + Environment.NewLine
            _richTextBox.Text = _richTextBox.Text + Environment.NewLine
            _richTextBox.Text = _richTextBox.Text + Environment.NewLine
            _richTextBox.Text = _richTextBox.Text + $"|--------------------------------------------------------------------------------| " + Environment.NewLine
            _richTextBox.Text = _richTextBox.Text + $"|      Cartridge     |     Cartridge     |      Detonation     |     Detonation    | " + Environment.NewLine
            _richTextBox.Text = _richTextBox.Text + $"| Diameter (mm) | Diameter (ins)  | Velocity (m/sec) | Velocity (ft/sec) | " + Environment.NewLine

            For Each productSize As ProductSize In _product.ProductSizes
                Dim column1 = productSize.CartridgeDiameterMm.ToString()
                Dim column2 = productSize.CartridgeDiameterMm.ToString()
                Dim column3 = productSize.CartridgeDiameterMm.ToString()
                Dim column4 = productSize.CartridgeDiameterMm.ToString()

                _richTextBox.Text = _richTextBox.Text + $"|     {column1}    |    {column2}    |      {column3}     |     {column4}    | " + Environment.NewLine
            Next
            _richTextBox.Text = _richTextBox.Text + $"|--------------------------------------------------------------------------------| " + Environment.NewLine
        End Sub

        Private Sub PrintPageHandler(sender As Object, e As PrintPageEventArgs)
            Dim linesPerPage As Single = 0
            Dim yPos As Single = 0
            Dim curLineCount = 0
            Dim leftMargin As Single = e.MarginBounds.Left
            Dim topMargin As Single = e.MarginBounds.Top
            Dim line As String = Nothing
            Dim printFont = New Font("Verdana", 10)
            Dim totalLineCount = 0

            ' Calculate the number of lines per page.
            linesPerPage = e.MarginBounds.Height / printFont.GetHeight(e.Graphics)

            ' Print each line of the file. 
            While curLineCount < linesPerPage
                If (_richTextBox.Lines.Length - 1) < totalLineCount Then
                    line = Nothing
                    Exit While
                End If
                line = _richTextBox.Lines(totalLineCount)
                yPos = topMargin + curLineCount * printFont.GetHeight(e.Graphics)
                e.Graphics.DrawString(line, printFont, Brushes.Black, leftMargin, yPos, New StringFormat())
                curLineCount += 1
                totalLineCount += 1
            End While

            ' If more lines exist, print another page. 
            If (line IsNot Nothing) Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
        End Sub
    End Class
End NameSpace