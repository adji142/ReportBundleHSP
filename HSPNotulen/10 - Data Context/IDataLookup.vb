Namespace HSP.Data
    Public Interface IDataLookup
        Function GetLookup(ByVal TextSearch As String, ByVal Parameter As Object) As DataSet
    End Interface
End Namespace
