Imports System.Xml.Serialization
Imports System.IO

Public Class Cynaps

    Private pAddWindow As AddEditMovie
    Private pCurrentMovie As Movie
    Private pMovieList As List(Of Movie)
    Public Property MovieList As List(Of Movie)
        Get
            Return pMovieList
        End Get
        Set(ByVal value As List(Of Movie))
            pMovieList = value
        End Set
    End Property

    Private Sub MovieList_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'new List
        pMovieList = New List(Of Movie)

        'Get information
        Deserialization()

        'Update List
        UpdateList()

    End Sub

    Private Sub MovieList_FormClosing(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.FormClosing
        'Serialize movie when closing
        Serialization()
    End Sub

    Private Sub LBMovieList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LBMovieList.SelectedIndexChanged

        'Selection check
        If Not Me.LBMovieList.SelectedItem Is Nothing Then
            'Find specific movie
            For Each MovieToList As Movie In pMovieList
                If MovieToList.Name = LBMovieList.SelectedItem.ToString Then
                    'Insert in global variable
                    Me.pCurrentMovie = MovieToList
                End If
            Next

            'Update Movie info
            Me.LBL_TITRE.Text = Me.pCurrentMovie.Name
            Me.LblReleaseDate.Text = Me.pCurrentMovie.ReleaseDate.ToShortDateString 'just the Date
            Me.LblGenre1.Text = Me.pCurrentMovie.Genre1
            Me.LblGenre2.Text = Me.pCurrentMovie.Genre2
            Me.LblDirector.Text = Me.pCurrentMovie.Director
            Me.LblActors.Text = Me.pCurrentMovie.Actors
            Me.LblPlot.Text = Me.pCurrentMovie.Plot
            Me.LblReview.Text = Me.pCurrentMovie.Review
            Me.LblRating.Text = Me.pCurrentMovie.Rating
            Me.PictureBox1.Image = Me.pCurrentMovie.Img
        End If

    End Sub

    Public Sub UpdateList()
        'Clear movie list
        Me.LBMovieList.Items.Clear()
        'Traverse movies in list
        For Each MovieToList As Movie In pMovieList
            'Fill list, going by name

            Me.LBMovieList.Items.Add(MovieToList)
        Next
    End Sub

#Region "File Edit Button"

    Private Sub BtnDeleteEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnDeleteEntry.Click

        'Confirmation
        If MsgBox("Are you sure you want to delete this Movie ?", vbYesNo, "Confirmation") Then
            'Remove from List
            Me.pMovieList.Remove(pCurrentMovie)
        End If

        'Update List
        UpdateList()

    End Sub

    Private Sub BtnNewEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnNewEntry.Click
        'If new movie, pass "Nothing" As argument

        pAddWindow = New AddEditMovie(Nothing)
        pAddWindow.Show()
    End Sub

    Private Sub BtnUpdateEntry_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpdateEntry.Click
        'If  there is an update, pass current movie as argument
        pAddWindow = New AddEditMovie(pCurrentMovie)
        pAddWindow.Show()
    End Sub

#End Region

#Region "Save and Get"

    Private Sub Deserialization()
        If File.Exists("MovieLibrary.xml") Then
            'If file exists, we open it and get its stream
            Dim FStream As Stream = File.OpenRead("MovieLibrary.xml")
            Dim Deserializer As New XmlSerializer(GetType(List(Of Movie)))
            'Deserialization and conversion of type "Movie" return
            pMovieList = Deserializer.Deserialize(FStream)
            'Close stream
            FStream.Close()
        End If
    End Sub

    Private Sub Serialization()
        'Create file and Get its stream
        Dim FStream As FileStream = File.Create("MovieLibrary.xml")
        Dim Serializer As New XmlSerializer(GetType(List(Of Movie)))
        'Serialization and Writing
        Serializer.Serialize(FStream, pMovieList)
        'Closing File
        FStream.Close()
    End Sub

#End Region

#Region "Search Section"


    Private Sub BtnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSearch.Click
        Search()
    End Sub

    Private Sub BtnClrSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnClrSearch.Click
        Me.TxtTitle.Text = ""
        Me.CbActor.Text = ""
        Me.CBYear.Text = ""
        Me.CBGenre.Text = ""
        Me.CbDirector.Text = ""

        UpdateList()
    End Sub

    Private Sub Search()

        'Clear List
        Me.LBMovieList.Items.Clear()
        'Traversing movies in list
        For Each MovieToList As Movie In pMovieList

            If Me.TxtTitle.Text <> "" Then
                If MovieToList.Name.Contains(Me.TxtTitle.Text) Then
                    Me.LBMovieList.Items.Add(MovieToList)
                End If
            End If

            If Me.CbActor.Text <> "" Then
                If MovieToList.Actors.Contains(Me.CbActor.Text) Then
                    Me.LBMovieList.Items.Add(MovieToList)
                End If
            End If

            If Me.CBYear.Text <> "" Then
                If CDate(MovieToList.ReleaseDate).Year = Me.CBYear.Text Then
                    Me.LBMovieList.Items.Add(MovieToList)
                End If
            End If

            If Me.CBGenre.Text <> "" Then
                If MovieToList.Genre1.Contains(Me.CBGenre.Text) Or MovieToList.Genre2.Contains(Me.CBGenre.Text) Then
                    Me.LBMovieList.Items.Add(MovieToList)
                End If
            End If

            If Me.CbDirector.Text <> "" Then
                If MovieToList.Director.Contains(Me.CbDirector.Text) Then
                    Me.LBMovieList.Items.Add(MovieToList)
                End If
            End If

        Next

    End Sub

#End Region


    
End Class