Public Class Form1
    Dim rotor1Wiring As String = "EKMFLGDQVZNTOWYHXUSPAIBRCJ"
    Dim rotor2Wiring As String = "AJDKSIRUXBLHWTMCQGZNPYFVOE"
    Dim rotor3Wiring As String = "BDFHJLCPRTXVZNYEIWGAKMUSQO"
    Dim reflectorBWiring As String = "YRUHQSLDPXNGOKMIEBFZCWVJAT"
    Dim stdAlphabet As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZ"
    Dim rRotorStart As Integer
    Dim mRotorStart As Integer
    Dim lRotorStart As Integer
    Dim rRotorSelect As Integer
    Dim mRotorSelect As Integer
    Dim lRotorSelect As Integer

    Private Sub RRotorStartCbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RRotorStartCbox.SelectedIndexChanged
        rRotorStart = RRotorStartCbox.SelectedIndex

    End Sub

    Private Sub MRotorStartCbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MRotorStartCbox.SelectedIndexChanged
        mRotorStart = MRotorStartCbox.SelectedIndex
    End Sub

    Private Sub LRotorStartCbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LRotorStartCbox.SelectedIndexChanged
        lRotorStart = LRotorStartCbox.SelectedIndex
    End Sub

    Private Sub RRotorSelectCbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles RRotorSelectCbox.SelectedIndexChanged
        rRotorSelect = RRotorSelectCbox.SelectedIndex + 1
    End Sub

    Private Sub MRotorSelectCbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MRotorSelectCbox.SelectedIndexChanged
        mRotorSelect = MRotorSelectCbox.SelectedIndex + 1
    End Sub

    Private Sub LRotorSelectCbox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LRotorSelectCbox.SelectedIndexChanged
        lRotorSelect = LRotorSelectCbox.SelectedIndex + 1
    End Sub

    Private Sub RunBtn_Click(sender As Object, e As EventArgs) Handles RunBtn.Click
        'Converts starting positions to numerical offsets. 'A' is an offset of 0, 'B' is an offset of 1, etc. 
        Dim rOffset As Integer = rRotorStart
        Dim mOffset As Integer = mRotorStart
        Dim lOffset As Integer = lRotorStart
        Dim inputTextLine As String = InputTxt.Text.ToUpper
        Dim currLetter As Integer
        Dim rOnce As Boolean = False
        Dim mOnce As Boolean = False
        Dim lOnce As Boolean = False
        Dim outputTextLine As String = ""

        DebugTxt.AppendText(inputTextLine + Environment.NewLine)

        For iter As Integer = 0 To inputTextLine.Length - 1
            currLetter = Asc(inputTextLine(iter))
            DebugTxt.AppendText("Current Letter: " + Chr(currLetter) + Environment.NewLine)
            ' If the character is less than a space character or greater than a capital Z, convert to an X
            If currLetter <= 32 Or currLetter > 90 Then
                currLetter = 88
            End If

            '**Send through right-hand rotor, which steps every time**
            If rOffset < 25 Then
                rOffset += 1
            Else
                rOffset = 0
            End If
            '48 is the ASCII value for '0'
            DebugTxt.AppendText("Right-hand rotor offset: " + Chr(rOffset + 48) + Environment.NewLine)
            currLetter += rOffset

            'Wrap value around back to start if letter value has gotten larger than ASCII 'Z'
            If currLetter > 90 Then
                currLetter -= 26
            End If

            DebugTxt.AppendText("Letter after applying right-hand rotor offset: " + Chr(currLetter) + Environment.NewLine)

            currLetter = rotor(currLetter, rRotorSelect)

            DebugTxt.AppendText("Letter after going through the right-hand rotor: " + Chr(currLetter) + Environment.NewLine)

            '**Middle Rotor, which does not step in this version**

            'Apply offset of right-hand rotor
            currLetter -= rOffset
            'Wrap around if the letter value has decreased below the ASCII 'A'
            If currLetter < 65 Then
                currLetter += 26
            End If
            DebugTxt.AppendText("Letter after applying right-hand rotor offset: " + Chr(currLetter) + Environment.NewLine)

            'Apply offset of middle rotor and adjust if letter value has increased above ASCII 'Z'
            currLetter += mOffset
            If currLetter > 90 Then
                currLetter -= 26
            End If

            DebugTxt.AppendText("Letter after applying middle rotor offset: " + Chr(currLetter) + Environment.NewLine)

            'Send through the actual rotor switching
            currLetter = rotor(currLetter, mRotorSelect)

            DebugTxt.AppendText("Letter after going through the middle rotor: " + Chr(currLetter) + Environment.NewLine)

            '**Left-hand Rotor, which does not step in this version**

            'Apply offset of middle rotor
            currLetter -= mOffset
            'Wrap around if the letter value has decreased below the ASCII 'A'
            If currLetter < 65 Then
                currLetter += 26
            End If

            DebugTxt.AppendText("Letter after applying middle rotor offset: " + Chr(currLetter) + Environment.NewLine)

            'Apply offset of left-hand rotor and adjust if letter value has increased above ASCII 'Z'
            currLetter += lOffset
            If currLetter > 90 Then
                currLetter -= 26
            End If

            DebugTxt.AppendText("Letter after applying left-hand rotor offset: " + Chr(currLetter) + Environment.NewLine)

            'Send through the actual rotor switching
            currLetter = rotor(currLetter, lRotorSelect)
            DebugTxt.AppendText("Letter after going through the left-hand rotor: " + Chr(currLetter) + Environment.NewLine)

            '**Reflector**

            'Apply offset of left-hand rotor
            currLetter -= lOffset
            'Wrap around if the letter value has decreased below the ASCII 'A'
            If currLetter < 65 Then
                currLetter += 26
            End If
            DebugTxt.AppendText("Letter after applying left-hand rotor offset: " + Chr(currLetter) + Environment.NewLine)

            'Send through reflector
            currLetter = reflector(currLetter)
            DebugTxt.AppendText("Letter after going through the reflector: " + Chr(currLetter) + Environment.NewLine)

            '**Inverse left-hand rotor**

            'Apply offset of left-hand rotor and adjust if letter value has increased above ASCII 'Z'
            currLetter += lOffset
            If currLetter > 90 Then
                currLetter -= 26
            End If
            DebugTxt.AppendText("Letter after applying left-hand rotor offset: " + Chr(currLetter) + Environment.NewLine)

            'Send through the actual rotor switching
            currLetter = reverseRotor(currLetter, lRotorSelect)
            DebugTxt.AppendText("Letter after going through the left-hand rotor in reverse: " + Chr(currLetter) + Environment.NewLine)

            '**Inverse middle rotor**

            'Apply offset of left-hand rotor
            currLetter -= lOffset
            'Wrap around if the letter value has decreased below the ASCII 'A'
            If currLetter < 65 Then
                currLetter += 26
            End If
            DebugTxt.AppendText("Letter after applying left-hand rotor offset: " + Chr(currLetter) + Environment.NewLine)

            'Apply offset of middle rotor and adjust if letter value has increased above ASCII 'Z'
            currLetter += mOffset
            If currLetter > 90 Then
                currLetter -= 26
            End If
            DebugTxt.AppendText("Letter after applying middle rotor offset: " + Chr(currLetter) + Environment.NewLine)

            currLetter = reverseRotor(currLetter, mRotorSelect)
            DebugTxt.AppendText("Letter after going through the middle rotor in reverse: " + Chr(currLetter) + Environment.NewLine)

            '**Inverse right-hand rotor**

            'Apply offset of middle rotor
            currLetter -= mOffset
            'Wrap around if the letter value has decreased below the ASCII 'A'
            If currLetter < 65 Then
                currLetter += 26
            End If
            DebugTxt.AppendText("Letter after applying middle rotor offset: " + Chr(currLetter) + Environment.NewLine)

            'Apply offset of right-hand rotor and adjust if letter value has increased above ASCII 'Z'
            currLetter += rOffset
            If currLetter > 90 Then
                currLetter -= 26
            End If
            DebugTxt.AppendText("Letter after applying right-hand rotor offset: " + Chr(currLetter) + Environment.NewLine)

            currLetter = reverseRotor(currLetter, rRotorSelect)
            DebugTxt.AppendText("Letter after going through the right-hand rotor in reverse: " + Chr(currLetter) + Environment.NewLine)

            'Apply offset of right-hand rotor
            currLetter -= rOffset
            'Wrap around if the letter value has decreased below the ASCII 'A'
            If currLetter < 65 Then
                currLetter += 26
            End If
            DebugTxt.AppendText("Letter after applying right-hand rotor offset: " + Chr(currLetter) + Environment.NewLine)

            '**Add to output**
            outputTextLine += Chr(currLetter)
            DebugTxt.AppendText("Output: " + Chr(currLetter) + Environment.NewLine)
        Next

        OutputTxt.Text = outputTextLine

    End Sub

    Private Function rotor(letter As Integer, rotorSelect As Integer)
        If rotorSelect = 1 Then
            DebugTxt.AppendText("Rotor selected: I" + Environment.NewLine)
            Return Asc(rotor1Wiring(letter - Asc("A")))
        ElseIf rotorSelect = 2 Then
            DebugTxt.AppendText("Rotor selected: II" + Environment.NewLine)
            Return Asc(rotor2Wiring(letter - Asc("A")))
        Else
            DebugTxt.AppendText("Rotor selected: III" + Environment.NewLine)
            Return Asc(rotor3Wiring(letter - Asc("A")))
        End If

    End Function

    Private Function reverseRotor(letter As Integer, rotorSelect As Integer)
        If rotorSelect = 1 Then
            Return Asc(stdAlphabet(findInString(rotor1Wiring, Chr(letter))))
        ElseIf rotorSelect = 2 Then
            Return Asc(stdAlphabet(findInString(rotor2Wiring, Chr(letter))))
        Else
            Return Asc(stdAlphabet(findInString(rotor3Wiring, Chr(letter))))
        End If

    End Function

    Private Function reflector(letter As Integer)
        Return Asc(reflectorBWiring(letter - Asc("A")))
    End Function

    Private Function findInString(str As String, character As Char)
        For counter As Integer = 0 To str.Length - 1
            If str(counter) = character Then
                Return counter
                Exit For
            End If
        Next
        'Return -1 if character not found
        Return -1
    End Function
End Class
