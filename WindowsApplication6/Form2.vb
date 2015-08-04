Public Class AddEditMovie



    Private pMovieToEdit As Movie

    Sub New(ByVal MovieToEdit As Movie)

        'This call is required for the constructor.
        InitializeComponent()



        'Getting Movie to be modified
        pMovieToEdit = MovieToEdit

    End Sub

    Private Sub AddEditMovie_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If pMovieToEdit Is Nothing Then
            'If empty, create new
        Else

            'Else get information and input to corresponding places
            Me.TxtActors.Text = pMovieToEdit.Actors
            Me.TxtReview.Text = pMovieToEdit.Review
            Me.TxtMovieName.Text = pMovieToEdit.Name
            Me.TxtPlot.Text = pMovieToEdit.Plot
            Me.CBGenre1.Text = pMovieToEdit.Genre1
            Me.CBGenre2.Text = pMovieToEdit.Genre2
            Me.CBDirector.Text = pMovieToEdit.Director
            Me.NumRating.Value = pMovieToEdit.Rating
            Me.DTReleaseDate.Value = pMovieToEdit.ReleaseDate
            Me.PictureBox1.Image = pMovieToEdit.Img
        End If

    End Sub

    Private Sub BtnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click

        If pMovieToEdit Is Nothing Then
            'Save Movie Details
            Dim MyMovie As New Movie(Me.TxtMovieName.Text, Me.DTReleaseDate.Value, Me.CBDirector.Text, Me.CBGenre1.Text, Me.CBGenre2.Text, Me.TxtActors.Text, Me.TxtPlot.Text, Me.TxtReview.Text, Me.NumRating.Value, Me.PictureBox1.Image)
            'Add movie to List
            Cynaps.MovieList.Add(MyMovie)
            MsgBox("Movie details successfully Added", vbOKOnly, "Confirmation")
        Else

            'Or edit movie by getting its index from form 1 list
            Cynaps.MovieList(Cynaps.MovieList.IndexOf(pMovieToEdit)).Update(Me.TxtMovieName.Text, Me.DTReleaseDate.Value, Me.CBDirector.Text, Me.CBGenre1.Text, Me.CBGenre2.Text, Me.TxtActors.Text, Me.TxtPlot.Text, Me.TxtReview.Text, Me.NumRating.Value, Me.PictureBox1.Image)
        End If


        Cynaps.UpdateList()
        'Close edit window
        Me.Close()
    End Sub

    Private Sub IMG_AFFICHE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        'Add a picture
        Dim dialog As OpenFileDialog = New OpenFileDialog()
        'Set the Filter.
        dialog.Filter = "Bitmap |*.bmp| JPG | *.jpg | GIF | *.gif | All Files|*.*"

        'Clear the file name
        dialog.FileName = ""

        'Show it
        If dialog.ShowDialog(Me) = DialogResult.OK Then
            'Get the image name
            Dim Cover As String = dialog.FileName

            'Create a new Bitmap and display it
            PictureBox1.Image = System.Drawing.Bitmap.FromFile(Cover)
        End If
    End Sub
End Class