Imports System.Drawing.Imaging
Imports System.Reflection

Module ModConfig

    Private App As PictureBox
    Private tmInit As Timer    
    Private frmCollection As New List(Of Form)
    Private _form As New Form
    Private _image As Image

    Public Sub OpenForm(ByVal frm As Form, ByVal image As Image)

        _form = frm

        If _form.IsHandleCreated Then
            _form.Visible = True
            _form.Select()
            _form.BringToFront()
        Else
            _image = image

            _form.Show()
            _form.BringToFront()
            _form.ShowInTaskbar = False
            _form.Owner = frmDashboard

            tmInit = New Timer With {.Interval = 1, .Enabled = True}

            AddHandler tmInit.Tick, AddressOf _TakeScreenShot
            AddHandler _form.FormClosing, AddressOf _FormClosing
            AddHandler _form.Resize, AddressOf _Resize

            frmCollection.Add(_form)
        End If
    End Sub

    Private Sub _FormClosing(sender As Object, e As FormClosingEventArgs)
        RemoveControls(sender)
        frmCollection.Remove(sender)
        frmDashboard.Select()
        frmDashboard.Activate()
    End Sub

    Private Sub _Resize(sender As Object, e As EventArgs)
        If sender.WindowState = FormWindowState.Minimized Then
            sender.WindowState = FormWindowState.Normal
            sender.Visible = False
        End If
    End Sub

    Private Sub _TakeScreenShot(sender As Object, e As EventArgs)
        Threading.Thread.Sleep(300)
        AddFormTaskBar()
        AddHandlerAddressOf()        
        tmInit.Enabled = False
    End Sub

    Private Sub AddFormTaskBar()
        App = New PictureBox
        App.Name = _form.Name
        App.Tag = _form.Name

        App.InitialImage = TakeScreenShot(_form)
        App.Image = _image
        App.Image.Tag = _form.Text
    End Sub

    Private Function TakeScreenShot(ByVal Form As Form) As Bitmap
        Dim bounds As Rectangle
        Dim screenshot As Bitmap
        Dim graph As Graphics
        bounds = Screen.PrimaryScreen.Bounds
        screenshot = New System.Drawing.Bitmap(Form.Bounds.Width - 17, Form.Bounds.Height - 12, PixelFormat.Format32bppArgb)
        graph = Graphics.FromImage(screenshot)
        graph.CopyFromScreen(Form.Bounds.X + 7, Form.Bounds.Y + 5, 0, 0, Form.Bounds.Size, CopyPixelOperation.SourceCopy)
        Return screenshot
    End Function

    Private list As Lazy(Of Type()) = New Lazy(Of Type())(Function() Assembly.GetExecutingAssembly().GetTypes())
    Function TypeFromName(name As String) As Type
        Return list.Value.Where(Function(t) t.Name = name).FirstOrDefault()
    End Function

    Private Sub App_MouseUp(sender As Object, e As MouseEventArgs)

        Dim Apps As PictureBox = DirectCast(sender, PictureBox)

        Dim _frm As Form = frmCollection.FirstOrDefault(Function(myObject) myObject.Name = Apps.Name)

        If _frm.MinimizeBox = False Then
            MsgBox("Sentimos muito, mas essa tela não pode ficar minimizada na barra de tarefas", MsgBoxStyle.Exclamation, "Aviso")
        Else
            If _frm.Visible = False Then
                _frm.Visible = True
                _frm.Select()
                _frm.BringToFront()
            Else
                _frm.Visible = False
            End If
        End If
       
    End Sub

    Private Sub App_MouseEnter(ByVal sender As Object, ByVal e As System.EventArgs)
        Try
            Dim Apps As PictureBox = DirectCast(sender, PictureBox)

            MinimizedApps.picIcon.Image = Apps.Image
            MinimizedApps.lblName.Text = Apps.Image.Tag
            MinimizedApps.picThumb.Image = Apps.InitialImage

            MinimizedApps.Show()

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub App_MouseLeave(ByVal sender As Object, ByVal e As System.EventArgs)
        MinimizedApps.Close()
    End Sub

    Private Sub AddHandlerAddressOf()

        App.Size = New Size(32, 32)
        App.Margin = New Padding(4)
        App.SizeMode = PictureBoxSizeMode.CenterImage

        frmDashboard.menuTarefas.Controls.Add(App)

        AddHandler App.MouseEnter, AddressOf App_MouseEnter
        AddHandler App.MouseLeave, AddressOf App_MouseLeave
        AddHandler App.MouseUp, AddressOf App_MouseUp
    End Sub

    Private Sub RemoveControls(ByVal curItem As Form)
        With frmDashboard.menuTarefas
            For i = .Controls.Count - 1 To 0 Step -1
                If .Controls(i).Tag = curItem.Name Then
                    .Controls.RemoveAt(i)
                    Exit Sub
                End If
            Next
        End With
    End Sub

End Module
