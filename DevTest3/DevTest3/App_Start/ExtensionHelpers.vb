Imports System.Runtime.CompilerServices

Module StringExtensions
    <Extension()>
    Function Contains(ByVal source As String, ByVal value As String, ByVal comparisonType As StringComparison) As Boolean
        Return source.IndexOf(value, comparisonType) <> -1
    End Function
End Module
