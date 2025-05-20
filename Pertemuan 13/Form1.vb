Imports System.Drawing
Imports System.Windows.Forms

Public Class Form1

    Dim map = {
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0},
        {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
        {0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0},
        {0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 0},
        {0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0},
        {0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0},
        {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
        {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
        {0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0},
        {0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 1, 1, 0, 1, 0},
        {0, 1, 0, 1, 0, 0, 0, 1, 0, 0, 0, 1, 0, 1, 0},
        {0, 1, 0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0, 1, 0},
        {0, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 1, 0},
        {0, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 1, 0},
        {0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0}
    }

    Dim tsz = 30

    Dim pacx = 1
    Dim pacy = 1

    ' Posisi 3 hantu
    Dim enmx = 7
    Dim enmy = 7
    Dim enmx2 = 5
    Dim enmy2 = 5
    Dim enmx3 = 9
    Dim enmy3 = 9

    ' Posisi goal
    Dim goalx = 1
    Dim goaly = 13

    Dim bmp As Bitmap

    Dim oldpacx = 0
    Dim oldpacy = 0

    Dim oldenmx = 0
    Dim oldenmy = 0
    Dim oldenmx2 = 0
    Dim oldenmy2 = 0
    Dim oldenmx3 = 0
    Dim oldenmy3 = 0

    Dim health = 3
    Dim healthx = 1
    Dim healthy = 14  ' dibawah peta (pastikan PictureBox cukup tinggi)

    Dim isImmune As Boolean = False
    Dim immuneCounter As Integer = 0
    Dim immuneDuration As Integer = 10  ' misal 10x tick

    ' Sprite gambar
    Dim wall As Image = Image.FromFile("D:\Pemerograman Dekstop\Pertemuan 13\bata.png")
    Dim way As Image = Image.FromFile("D:\Pemerograman Dekstop\Pertemuan 13\rumput.png")
    Dim pac As Image = Image.FromFile("D:\Pemerograman Dekstop\Pertemuan 13\pakman.png")
    Dim pacRight As Image = Image.FromFile("D:\Pemerograman Dekstop\Pertemuan 13\pakman.png")
    Dim pacLeft As Image = Image.FromFile("D:\Pemerograman Dekstop\Pertemuan 13\pakman3.png")
    Dim pacUp As Image = Image.FromFile("D:\Pemerograman Dekstop\Pertemuan 13\pakman4.png")
    Dim pacDown As Image = Image.FromFile("D:\Pemerograman Dekstop\Pertemuan 13\pakman2.png")
    Dim enm As Image = Image.FromFile("D:\Pemerograman Dekstop\Pertemuan 13\hantu3.png")
    Dim enm2 As Image = Image.FromFile("D:\Pemerograman Dekstop\Pertemuan 13\hantu2.png")
    Dim enm3 As Image = Image.FromFile("D:\Pemerograman Dekstop\Pertemuan 13\hantu1.png")
    Dim goal As Image = Image.FromFile("D:\Pemerograman Dekstop\Pertemuan 13\omah.jpg")
    Dim hearth As Image = Image.FromFile("D:\Pemerograman Dekstop\Pertemuan 13\heart.png")
    Dim heartRed As Image = Image.FromFile("D:\Pemerograman Dekstop\Pertemuan 13\heart_red.png")

    Dim rndGen As New Random()

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.Width = map.GetLength(1) * tsz
        PictureBox1.Height = (map.GetLength(0) + 1) * tsz
        Me.Width = PictureBox1.Width + 40
        Me.Height = PictureBox1.Height + 60

        bmp = New Bitmap(PictureBox1.Width, PictureBox1.Height)
        PictureBox1.Image = bmp
        Me.KeyPreview = True

        Timer1.Interval = 200
        Timer1.Enabled = True
        Redraw()
    End Sub

    Private Sub Redraw()
        Dim g As Graphics = Graphics.FromImage(bmp)

        For y = 0 To map.GetLength(0) - 1
            For x = 0 To map.GetLength(1) - 1
                If map(y, x) = 0 Then
                    g.DrawImage(wall, x * tsz, y * tsz, tsz, tsz)
                Else
                    g.DrawImage(way, x * tsz, y * tsz, tsz, tsz)
                End If
            Next
        Next

        g.DrawImage(goal, goalx * tsz, goaly * tsz, tsz, tsz)
        g.DrawImage(pac, pacx * tsz, pacy * tsz, tsz, tsz)
        g.DrawImage(enm, enmx * tsz, enmy * tsz, tsz, tsz)
        g.DrawImage(enm2, enmx2 * tsz, enmy2 * tsz, tsz, tsz)
        g.DrawImage(enm3, enmx3 * tsz, enmy3 * tsz, tsz, tsz)

        For i = 0 To health - 1
            If health = 1 AndAlso DateTime.Now.Second Mod 2 = 0 Then
                g.DrawImage(heartRed, (healthx + i) * tsz, healthy * tsz, tsz, tsz)
            Else
                g.DrawImage(hearth, (healthx + i) * tsz, healthy * tsz, tsz, tsz)
            End If
        Next

        PictureBox1.Refresh()
        g.Dispose()
    End Sub

    Private Sub Form1_KeyDown(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        Select Case e.KeyCode
            Case Keys.Up
                If map(pacy - 1, pacx) = 1 Then
                    pac = pacUp
                    pacy -= 1
                End If
            Case Keys.Down
                If map(pacy + 1, pacx) = 1 Then
                    pac = pacDown
                    pacy += 1
                End If
            Case Keys.Left
                If map(pacy, pacx - 1) = 1 Then
                    pac = pacLeft
                    pacx -= 1
                End If
            Case Keys.Right
                If map(pacy, pacx + 1) = 1 Then
                    pac = pacRight
                    pacx += 1
                End If
        End Select
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        MoveEnemy(enmx, enmy, oldenmx, oldenmy)
        MoveEnemy(enmx2, enmy2, oldenmx2, oldenmy2)
        MoveEnemy(enmx3, enmy3, oldenmx3, oldenmy3)

        If isImmune Then
            immuneCounter -= 1
            If immuneCounter <= 0 Then
                isImmune = False
            End If
        End If

        If Not isImmune Then
            If (pacx = enmx AndAlso pacy = enmy) OrElse
               (pacx = enmx2 AndAlso pacy = enmy2) OrElse
               (pacx = enmx3 AndAlso pacy = enmy3) Then

                health -= 1
                isImmune = True
                immuneCounter = immuneDuration

                If health <= 0 Then
                    Timer1.Enabled = False
                    MessageBox.Show("Pakman Dies! WOOOO CHUPUUUUU")
                End If
            End If
        End If

        If pacx = goalx AndAlso pacy = goaly Then
            Timer1.Enabled = False
            MessageBox.Show("Pakman safe at Home!")
        End If

        Redraw()
    End Sub

    Private Sub MoveEnemy(ByRef ex As Integer, ByRef ey As Integer, ByRef oldex As Integer, ByRef oldey As Integer)
        Dim dx = pacx - ex
        Dim dy = pacy - ey
        Dim moved = False

        Dim directions = New List(Of Integer)({0, 1, 2, 3})
        directions = directions.OrderBy(Function() rndGen.Next()).ToList()

        For Each arah In directions
            Select Case arah
                Case 0
                    If ey > 0 AndAlso map(ey - 1, ex) = 1 AndAlso oldey <> ey - 1 Then
                        ey -= 1 : moved = True : Exit For
                    End If
                Case 1
                    If ey < map.GetLength(0) - 1 AndAlso map(ey + 1, ex) = 1 AndAlso oldey <> ey + 1 Then
                        ey += 1 : moved = True : Exit For
                    End If
                Case 2
                    If ex > 0 AndAlso map(ey, ex - 1) = 1 AndAlso oldex <> ex - 1 Then
                        ex -= 1 : moved = True : Exit For
                    End If
                Case 3
                    If ex < map.GetLength(1) - 1 AndAlso map(ey, ex + 1) = 1 AndAlso oldex <> ex + 1 Then
                        ex += 1 : moved = True : Exit For
                    End If
            End Select
        Next

        oldex = ex
        oldey = ey
    End Sub
End Class


'dibuat oleh mingfee