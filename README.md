# gclauncherupdater
Simple API for update launcher of GC in VB

<p align="center">
    <img alt="UpdaterGC" src="updaterlogo.png" width="388" height="260" />
</p>
<p>
<p align="left">
  	<img alt="PT-BR" src="https://imgur.com/a/iYd87ii" width="30" height="30"/>
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
	
- Exemplo:
Considere a tabela `atualizações` abaixo:
`-----------------------
|id |	 data 	| ver 	|
|010|2020-08-09 |old1	|
|011|2020-08-26 |old2	|
|025|2020-09-10	|old65	|
|036|2020-10-21	|LAST	|
-------------------------`
1. Manobra de atualização 
`-----------------------
|id |	 data 	| ver 	|
|010|2020-08-09 |old1	|
|011|2020-08-26 |old2	|
|025|2020-09-10	|old65	|
|036|2020-10-21	|fixbug2|
-------------------------`
2. Finalizando
`-----------------------
|id |	 data 	| ver 	|
|010|2020-08-09 |old1	|
|011|2020-08-26 |old2	|
|025|2020-09-10	|old65	|
|036|2020-10-21	|fixbug2|
|073|2020-12-29 |LAST	|
-------------------------`
3. Ao iniciar o updater ele verifica se a data da última atualização(`data`), 
quando `ver==LAST`, é igual a data de criação do `launcher-main`.

*Necessário compilar, e o código inclui comentários para explicar melhor.*

## Receita do componente

Basta colocar na pasta raiz do game, e indicar o caminho do seu launcher/starter do game, 
criar a lógica de download do arquivo, e também configurar sua comunicação com o 
banco de dados em:
`objcon = New SqlClient.SqlConnection("Data Source= meu computador; INITIAL CATALOG= launcher ; USER=sa; PASSWORD:123456;")`

## Notas do contribuidor

Olá sou Vitor '[dikdama](linkdogithub.com)' Gabriel,
Sou programmer community, e faço isso por diversão.
Desenvolvi esse projeto por amor ao jogo grandchase. 
Pretendo, assim que tiver tempo, verificar as issues e fixes de tempos em tempos.
Qualquer dúvida sobre algo do projeto, você pode me falar.
O projeto é público e de uso livre, mas um agradecimento é sempre bem vindo hahaha.
by dikdama [GitHub:r0t1v - Discord:dikdama#9689]

<p align="left">
  	<img alt="EN-US" src="https://imgur.com/a/atJm5rL" width="30" height="30" />
</p>