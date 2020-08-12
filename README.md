# gclauncherupdater
Simple API for update launcher of GC in VB

<p align="center">
    <img alt="UpdaterGC" src="https://i.imgur.com/XAFTddp.png" width="388" height="260" />
</p>
<p>
<p align="left">
  	<img alt="PT-BR" src="https://i.imgur.com/3fl9Sfi.gif" width="30" height="20"/>
</p>

## Conteúdo

Esse projeto contém o updater, o arquivo que atualiza o `launcher-main` do meu projeto principal;

Ele verifica se o launcher-main está atualizado, executando uma consulta na database;
Ele prescisa fazer a verificação de atualização, pois somente o `launcher` atualizado 
irá baixar os arquivos que foram atualizados naquela versão correspondente;
Ele possui um código simples e limpo, e é bem interativo na questão do frame.

## Notas do código

- Foi desenvolvido em `VBasic/.NET` para rodar nas versões mais simples de `.NET Framework`, 
mantendo assim a transparência entre os sistemas operacionais.
- Na rotina do programa, ele deve ler uma database e uma tabela específica, 
contendo no mínimo 3 células.
- Uma célula `id (int ou longint)` para controle do DBA sobre a quantidade de atualizações,
 uma célula `data (dia da atualização)` para controle do DBA sobre o dia que foi atualizado 
 e uma célula `ver (LAST)`, onde está terá valor `LAST` quando for a atualização atual.
- O updater deve verficar quando a `data` dessa `ver`=='LAST' correspondente, for igual a 
data de criação do launcher-main.
- Quando for o DBA for executar uma manobra de atualização, ele deve dar um `UPDATE` 
em todas as células `ver`, tornando com que nenhuma delas fique com o valor `LAST`.
- Após isso, ele deve dar um `INSERT` alocando 'LAST' na célula `ver` nesta linha da tabela, 
significando que agora essa é a atualização atual.

*Necessário compilar, e o código inclui comentários para explicar melhor.*

## Receita do componente

Basta colocar na pasta raiz do game, e indicar o caminho do seu launcher/starter do game, 
criar a lógica de download do arquivo, e também configurar sua comunicação com o 
banco de dados em:

`objcon = New SqlClient.SqlConnection("Data Source= meu computador; INITIAL CATALOG= launcher ; USER=sa; PASSWORD:123456;")`

## Deployed

<p align="center">
  	<img alt="updaterAPI" src="https://i.imgur.com/iVnYRvp.gif" width="640" height="480" />
</p>


## Notas do contribuidor

Olá sou Vitor '[dikdama](https://github.com/dikdama)' Gabriel,
Sou programmer community, e faço isso por diversão.
Desenvolvi esse projeto por amor ao jogo grandchase. 
Pretendo, assim que tiver tempo, verificar as issues e fixes de tempos em tempos.
Qualquer dúvida sobre algo do projeto, você pode me falar.
O projeto é público e de uso livre, mas um agradecimento é sempre bem vindo hahaha.
As contas r0t1v e dikdama são minhas, sendo a r0t1v é pessoal e a dikdama é pra mim brincar hahahaha. 
by dikdama GitHub: [r0t1v](https://github.com/r0t1v)-[dikdama](https://github.com/dikdama) - Discord:dikdama#9689

<p align="left">
  	<img alt="EN-US" src="https://i.imgur.com/QqtGoQ4.gif" width="30" height="20" />
</p>