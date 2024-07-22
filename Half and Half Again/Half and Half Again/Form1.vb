Public Class Form1
    Dim intIndexLow As Integer
    Dim intIndexMiddle As Integer
    Dim intIndexHigh As Integer

    Dim intSrchForValue As Integer

    Dim blnValueFound As Boolean = False

    Dim intNumsList() As Integer = {1, 3, 5, 7, 11, 13, 17, 19, 23, 29, 31}

    Dim blnArrayListLoaded As Boolean = False
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnLoadList.Enabled = True

        txtInput.Text = Nothing
        txtInput.Focus()
        lblOutputMsg.Text = Nothing
    End Sub

    Private Sub txtInput_KeyPress(sender As Object, e As System.Windows.Forms.KeyPressEventArgs) Handles txtInput.KeyPress
        If (Asc(e.KeyChar) >= 48 And Asc(e.KeyChar) <= 57) Or Asc(e.KeyChar) = 8 Then
        Else
            e.Handled = True
            MessageBox.Show("Enter Numbers Only", "Input Error")
        End If
    End Sub

    Private Sub btnLoadList_Click(sender As Object, e As EventArgs) Handles btnLoadList.Click
        Dim intEndIndex As Integer = intNumsList.Length - 1

        For intSubscript = 0 To intEndIndex
            lstArrayItems.Items.Add(intNumsList(intSubscript))
        Next

        lblOutputMsg.Text = "-- List Box Loaded --"

        blnArrayListLoaded = True

        btnLoadList.Enabled = False
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        If blnArrayListLoaded = False Then
            lblOutputMsg.Text = "-- Click the Load Array Button --"
            Exit Sub
        End If

        If txtInput.Text = Nothing Then
            lblOutputMsg.Text = "-- Type in a Value to Search For --"
            Exit Sub
        End If

        lblOutputMsg.Text = Nothing

        intSrchForValue = CInt(txtInput.Text)

        intIndexLow = 0
        intIndexHigh = intNumsList.Length - 1

        blnValueFound = False

        BinarySearchArray()

        If blnValueFound = True Then
            lblOutputMsg.Text = intSrchForValue & " was FOUND in the Array"
        Else
            lblOutputMsg.Text = intSrchForValue & " was NOT FOUND in the Array"
        End If
    End Sub

    Public Sub BinarySearchArray()
        Do While intIndexLow <= intIndexHigh
            intIndexMiddle = (intIndexLow + intIndexHigh) / 2

            If intNumsList(intIndexMiddle) = intSrchForValue Then
                blnValueFound = True
                Exit Sub
            End If

            If intNumsList(intIndexMiddle) > intSrchForValue Then
                intIndexHigh = intIndexMiddle - 1
            Else
                intIndexLow = intIndexMiddle + 1
            End If
        Loop
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lstArrayItems.Items.Clear()

        blnArrayListLoaded = False

        btnLoadList.Enabled = False

        lblOutputMsg.Text = ""

        txtInput.Text = Nothing
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        End
    End Sub
End Class
