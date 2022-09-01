''' <summary>
''' 書籍クラス
''' </summary>
Public Class Book
    Public Property Id As Integer
    Public Property Title As String
    Public Property AuthorId As Integer?
    Public Property PublisherId As Integer?
    Public Property Price As Integer

    Public Property Author As Author
    Public Property Publisher As Publisher
End Class

''' <summary>
''' 著者クラス
''' </summary>
Public Class Author
    Public Property Id As Integer
    Public Property Name As String
End Class

''' <summary>
''' 出版社クラス
''' </summary>
Public Class Publisher
    Public Property Id As Integer
    Public Property Name As String
    Public Property Telephone As String
    Public Property Address As String
End Class
