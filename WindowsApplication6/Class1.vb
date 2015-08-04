Public Class Movie

    Private pName As String
    Public Property Name As String
        Get
            Return pName
        End Get
        Set(ByVal value As String)
            pName = value
        End Set
    End Property

    Private pReleaseDate As Date
    Public Property ReleaseDate As Date
        Get
            Return pReleaseDate
        End Get
        Set(ByVal value As Date)
            pReleaseDate = value
        End Set
    End Property

    Private pDirector As String
    Public Property Director As String
        Get
            Return pDirector
        End Get
        Set(ByVal value As String)
            pDirector = value
        End Set
    End Property

    Private pGenre1 As String
    Public Property Genre1 As String
        Get
            Return pGenre1
        End Get
        Set(ByVal value As String)
            pGenre1 = value
        End Set
    End Property

    Private pGenre2 As String
    Public Property Genre2 As String
        Get
            Return pGenre2
        End Get
        Set(ByVal value As String)
            pGenre2 = value
        End Set
    End Property

    Private pActors As String
    Public Property Actors As String
        Get
            Return pActors
        End Get
        Set(ByVal value As String)
            pActors = value
        End Set
    End Property

    Private pImg As Image
    Public Property Img As Image
        Get
            Return pImg
        End Get
        Set(ByVal value As Image)
            pImg = value
        End Set
    End Property

    Private pPlot As String
    Public Property Plot As String
        Get
            Return pPlot
        End Get
        Set(ByVal value As String)
            pPlot = value
        End Set
    End Property

    Private pReview As String
    Public Property Review As String
        Get
            Return pReview
        End Get
        Set(ByVal value As String)
            pReview = value
        End Set
    End Property

    Private pRating As Integer
    Public Property Rating As Integer
        Get
            Return pRating
        End Get
        Set(ByVal value As Integer)
            pRating = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal Name As String, ByVal ReleaseDate As Date, ByVal Director As String, ByVal Genre1 As String, ByVal Genre2 As String, ByVal Actors As String, ByVal Plot As String, ByVal Review As String, ByVal Rating As Integer, ByVal Img As Image)
        pName = Name
        pReleaseDate = ReleaseDate
        pDirector = Director
        pGenre1 = Genre1
        pGenre2 = Genre2
        pActors = Actors
        pPlot = Plot
        pReview = Review
        pRating = Rating
        pImg = Img
    End Sub

    Public Sub Update(ByVal Name As String, ByVal ReleaseDate As Date, ByVal Director As String, ByVal Genre1 As String, ByVal Genre2 As String, ByVal Actors As String, ByVal Plot As String, ByVal Review As String, ByVal Rating As Integer, ByVal Img As Image)
        pName = Name
        pReleaseDate = ReleaseDate
        pDirector = Director
        pGenre1 = Genre1
        pGenre2 = Genre2
        pActors = Actors
        pPlot = Plot
        pReview = Review
        pRating = Rating
        pImg = Img
    End Sub

    ' Tostring Overload
    Public Overrides Function ToString() As String
        Return pName
    End Function

End Class