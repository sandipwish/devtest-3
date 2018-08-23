Imports System.ComponentModel.DataAnnotations

Public Class GetPlayerRanking

    <Required(ErrorMessage:="Player Name is required")>
    Property Name As String
    Property Ranking As Integer

End Class
