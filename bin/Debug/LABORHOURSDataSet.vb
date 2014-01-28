Partial Class LABORHOURSDataSet
    Partial Class PROPERTIESDataTable

        Private Sub PROPERTIESDataTable_PROPERTIESRowChanging(ByVal sender As System.Object, ByVal e As PROPERTIESRowChangeEvent) Handles Me.PROPERTIESRowChanging

        End Sub

    End Class

    Partial Class WORKERSDataTable

        Private Sub WORKERSDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.IDColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class

    Partial Class MILEAGEDataTable

    End Class

    Partial Class LABORHOURSDataTable

        Private Sub LABORHOURSDataTable_ColumnChanging(ByVal sender As System.Object, ByVal e As System.Data.DataColumnChangeEventArgs) Handles Me.ColumnChanging
            If (e.Column.ColumnName = Me.OTDTColumn.ColumnName) Then
                'Add user code here
            End If

        End Sub

    End Class


End Class
