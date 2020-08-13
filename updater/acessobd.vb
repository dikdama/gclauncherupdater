Public Class acessobd
    'Instanciando a a conexão'
    'Instantiating the connection'
    Dim objcon As SqlClient.SqlConnection
    'A sub de conexão com url tabela user e password do banco de dados'
    'The connection sub with url table user and database password'
    Public Sub conectar()
        Try
            objcon = New SqlClient.SqlConnection("Data Source= DEVELOPEMENT-PC; INITIAL CATALOG= launcher ; USER=sa; PASSWORD=123456")
            objcon.Open()
        Catch ex As Exception
            Throw ex
        End Try

    End Sub
    'A sub que fecha a conexão com banco impedindo o gargalo da maquina ou desperdicio de recurso que não está sendo ultilizado'
    'The sub that closes the connection with the bank preventing the bottleneck of the machine or waste of resources that is not being used'
    Public Sub fechar()
        Try
            If Not IsNothing(objcon) Then
                If objcon.State = ConnectionState.Open Then
                    objcon.Close()
                End If
            End If

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    'Uma simples função que executa uma query(leitura) ou pesquisa no bd ultilizando o command e adpater apartir de uma string que vai ser alocada no upadaterframe'
    'A simple function that performs a query (read) or search in the database using the command and adpater from a string that will be allocated in the upadaterframe'
    Public Function executequery(ByVal command As String) As DataSet
        Dim ds As New DataSet
        Dim objDataAdapter As New SqlClient.SqlDataAdapter
        Dim objcommand As New SqlClient.SqlCommand
        Try
            objcommand = objcon.CreateCommand
            objcommand.CommandText = command
            objDataAdapter = New SqlClient.SqlDataAdapter
            objDataAdapter.Fill(ds)
        Catch ex As Exception
            Throw ex
        End Try
        Return ds
    End Function
End Class
