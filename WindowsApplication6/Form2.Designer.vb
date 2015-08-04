<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddEditMovie
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TxtMovieName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.DTReleaseDate = New System.Windows.Forms.DateTimePicker()
        Me.CBDirector = New System.Windows.Forms.ComboBox()
        Me.CBGenre2 = New System.Windows.Forms.ComboBox()
        Me.TxtActors = New System.Windows.Forms.RichTextBox()
        Me.TxtPlot = New System.Windows.Forms.RichTextBox()
        Me.TxtReview = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.NumRating = New System.Windows.Forms.NumericUpDown()
        Me.BtnSave = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.CBGenre1 = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumRating, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Location = New System.Drawing.Point(13, 13)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(188, 233)
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'TxtMovieName
        '
        Me.TxtMovieName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtMovieName.Location = New System.Drawing.Point(253, 13)
        Me.TxtMovieName.Name = "TxtMovieName"
        Me.TxtMovieName.Size = New System.Drawing.Size(275, 30)
        Me.TxtMovieName.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(226, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Release Date :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(226, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Director :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(224, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Genre 2 :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(226, 218)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Actors :"
        '
        'DTReleaseDate
        '
        Me.DTReleaseDate.Location = New System.Drawing.Point(334, 61)
        Me.DTReleaseDate.Name = "DTReleaseDate"
        Me.DTReleaseDate.Size = New System.Drawing.Size(194, 22)
        Me.DTReleaseDate.TabIndex = 6
        Me.DTReleaseDate.Value = New Date(2015, 1, 16, 0, 0, 0, 0)
        '
        'CBDirector
        '
        Me.CBDirector.FormattingEnabled = True
        Me.CBDirector.Location = New System.Drawing.Point(334, 101)
        Me.CBDirector.Name = "CBDirector"
        Me.CBDirector.Size = New System.Drawing.Size(194, 24)
        Me.CBDirector.TabIndex = 7
        '
        'CBGenre2
        '
        Me.CBGenre2.FormattingEnabled = True
        Me.CBGenre2.Location = New System.Drawing.Point(334, 171)
        Me.CBGenre2.Name = "CBGenre2"
        Me.CBGenre2.Size = New System.Drawing.Size(194, 24)
        Me.CBGenre2.TabIndex = 8
        '
        'TxtActors
        '
        Me.TxtActors.Location = New System.Drawing.Point(334, 201)
        Me.TxtActors.Name = "TxtActors"
        Me.TxtActors.Size = New System.Drawing.Size(194, 65)
        Me.TxtActors.TabIndex = 9
        Me.TxtActors.Text = ""
        '
        'TxtPlot
        '
        Me.TxtPlot.Location = New System.Drawing.Point(13, 281)
        Me.TxtPlot.Name = "TxtPlot"
        Me.TxtPlot.Size = New System.Drawing.Size(515, 85)
        Me.TxtPlot.TabIndex = 10
        Me.TxtPlot.Text = ""
        '
        'TxtReview
        '
        Me.TxtReview.Location = New System.Drawing.Point(13, 393)
        Me.TxtReview.Name = "TxtReview"
        Me.TxtReview.Size = New System.Drawing.Size(515, 81)
        Me.TxtReview.TabIndex = 11
        Me.TxtReview.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 258)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Plot : "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 373)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 17)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Review :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 481)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(56, 17)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Grade :"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(138, 481)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 17)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "/100"
        '
        'NumRating
        '
        Me.NumRating.Location = New System.Drawing.Point(82, 479)
        Me.NumRating.Name = "NumRating"
        Me.NumRating.Size = New System.Drawing.Size(50, 22)
        Me.NumRating.TabIndex = 16
        Me.NumRating.Value = New Decimal(New Integer() {50, 0, 0, 0})
        '
        'BtnSave
        '
        Me.BtnSave.Location = New System.Drawing.Point(334, 490)
        Me.BtnSave.Name = "BtnSave"
        Me.BtnSave.Size = New System.Drawing.Size(174, 32)
        Me.BtnSave.TabIndex = 17
        Me.BtnSave.Text = "Save and Close"
        Me.BtnSave.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(226, 141)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 17)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Genre 1 :"
        '
        'CBGenre1
        '
        Me.CBGenre1.FormattingEnabled = True
        Me.CBGenre1.Location = New System.Drawing.Point(334, 141)
        Me.CBGenre1.Name = "CBGenre1"
        Me.CBGenre1.Size = New System.Drawing.Size(194, 24)
        Me.CBGenre1.TabIndex = 19
        '
        'AddEditMovie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(540, 534)
        Me.Controls.Add(Me.CBGenre1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.BtnSave)
        Me.Controls.Add(Me.NumRating)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtReview)
        Me.Controls.Add(Me.TxtPlot)
        Me.Controls.Add(Me.TxtActors)
        Me.Controls.Add(Me.CBGenre2)
        Me.Controls.Add(Me.CBDirector)
        Me.Controls.Add(Me.DTReleaseDate)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtMovieName)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "AddEditMovie"
        Me.Text = "AjoutEditionFilm"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumRating, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents TxtMovieName As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents DTReleaseDate As System.Windows.Forms.DateTimePicker
    Friend WithEvents CBDirector As System.Windows.Forms.ComboBox
    Friend WithEvents CBGenre2 As System.Windows.Forms.ComboBox
    Friend WithEvents TxtActors As System.Windows.Forms.RichTextBox
    Friend WithEvents TxtPlot As System.Windows.Forms.RichTextBox
    Friend WithEvents TxtReview As System.Windows.Forms.RichTextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents NumRating As System.Windows.Forms.NumericUpDown
    Friend WithEvents BtnSave As System.Windows.Forms.Button
    Friend WithEvents IMG_AFFICHE As System.Windows.Forms.PictureBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents CBGenre1 As System.Windows.Forms.ComboBox
End Class
