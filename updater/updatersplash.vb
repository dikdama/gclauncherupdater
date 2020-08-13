'Essa programa verifica se o launchermain do grand chase está atualizado.'
'Ele consulta a database launcher que possui 3 celulas [idver(identificação de versão),data(de atualização) e ver(versão)].'
'Quando o launcher for atualizado, inserimos a data de atualização e o idver e executamos um update, fazendo com que a versão atual(ver) fique com a string LAST.'
'Ex: Atualizei ontem 22/04/2019 e a célula ver dessa data está com a variavel LAST, se eu atualizar hoje 23/04/2019, e tenho que dar um update manual na tabela de forma que que a célula ver da data atual fique com a string LAST.'
'Caso for LAST e data de atualização seja a mesma data que está no launcher ele executa o laucnher main normalmente.'
'Caso for LAST e data de atualização seja diferente da data do launcher ele atualiza o launcher para versão LAST(última), e após isso ele executa normalmente.'
'No caso da string que não tem mais o valor LAST, pode ser colocado qualquer valor, não podendo ser mais LAST,se não ele irá baixar de novo a versão inferior.'
'Nota 1: A implementação de fazer o download do launcher do após checar se ele está desatualizado ainda não está em vigor, devidoao fato de hospedagem ftp do launcher que irá variar e pelo tempo que ainda não tive.'
'Mas futuramente a lógica de conexão estará aqui, pois eu vou constatemente, quando tiver tempo, atualizar meus repositórios.'
'Toda lógica e parametrização foi desenvolvida por mim, e estou a disposição.

'This program checks that the grand chase launchermain is up to date.'
'It queries the database launcher which has 3 cells [idver (version identification), date (update) and ver (version)].'
'When the launcher is updated, we enter the update date and idver and perform an update, making the current version (see) with the string LAST.'
'Ex: I updated yesterday 22/04/2019 and the see cell of that date has the LAST variable, if I update today 23/04/2019, and I have to give a manual update in the table so that the cell sees the date current stick with the string LAST. '
'If it is LAST and the update date is the same date that is on the launcher it will run laucnher main normally.'
'If it is LAST and the update date is different from the launcher date, it updates the launcher to LAST version (last), and after that it runs normally.'
'In the case of the string that no longer has the LAST value, any value can be placed, and it cannot be more LAST, otherwise it will download the lower version again.'
'Note 1: The implementation of downloading the launcher after checking if it is out of date is not yet in effect, due to the fact that the launcher's ftp hosting will vary and for the time I haven't yet.'
'But in the future the connection logic will be here, as I will constantly, when I have time, update my repositories.'
'All logic and parameterization was developed by me, and I am available.

Public Class updatersplash
    Dim tempoup As Integer = 0
    Private objbanco As New acessobd
    Dim download As New Net.WebClient
    'Ao carregar ele executa inicializações (ainda não está com testes condicionais(if e else) necessários, mas se quiser rodar está funcionando normalmente).'
    'When loading it performs initializations (it doesn't have the necessary conditional tests (if and else) yet, but if it wants to run it's working normally).'
    Private Sub updatersplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TransparencyKey = Me.BackColor
        Timeupdate.Start()
        textupdate.Text = "Conectando a database..."
        'objbanco.conectar()
        'O dataset absorve a string, que é transformada em comando pelo datatadapter e datacomand.'
        'The dataset absorbs the string, which is transformed into a command by the datatadapter and datacomand.'
        'Dim dataset As DataSet = '
        'objbanco.executequery("INSERT INTO dbo.mainlauncher(idver,data,ver) VALUES ('250','2020-07-26','NOLAST')")
    End Sub
    'Função só pra init sem testar a conexão do banco'
    'Function only for init without testing the bank connection'
    Private Function letsbora()
        If tempoup > 5 Then
            textupdate.Text = "Atualizando..."
        End If
        If tempoup > 10 Then
            textupdate.Text = "Pronto!"
        End If
        If tempoup > 12 Then
            Application.Exit()
        End If

    End Function
    'Tick do time pra dar tempo de processamento dos dados, adicione uma flag ready=true ou false testando se a maquina ja fez a atualização do launchermain'
    'Tick the time to give data processing time, add a flag ready = true or false testing if the machine has already updated the launchermain'
    Private Sub Timeupdate_Tick(sender As Object, e As EventArgs) Handles Timeupdate.Tick
        tempoup = tempoup + 1
        letsbora()
    End Sub
    ' Private Sub downprogresso(ByVal sender As Object, ByVal e As System.Net.DownloadProgressChangedEventArgs)
    '    textupdate.Text = "Atualizando... " & e.ProgressPercentage & "%"
    ' End Sub
    'Private Sub downcompleted(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    '   textupdate.Text = "Pronto!"
    'End Sub
    'Private Sub ativaeventos()
    'AddHandler() download.DownloadProgressChanged, AddressOf downprogresso
    'AddHandler() download.DownloadFileCompleted, AddressOf downcompleted
    'End Sub

    'Private Sub baixar(ByVal arquivo As String, ByVal destino As String)
    'Try
    'Dim urlweb As Uri(arquivo)
    '       download.DownloadFileAsync(urlweb, destino)
    'Catch e As Exception
    '       MessageBox.Show(e.Message)
    'End Try
    'End Sub


End Class
