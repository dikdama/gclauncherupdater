# gclauncherupdater
Simple API for update launcher of GC in VB

<p align="center">
    <img alt="UpdaterGC" src="https://i.imgur.com/XAFTddp.png" width="388" height="260" />
</p>
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
- O updater deve verficar quando a `data` dessa `ver`==`LAST` correspondente, for igual a 
data de criação do launcher-main.
- Quando for o DBA for executar uma manobra de atualização, ele deve dar um `UPDATE` 
em todas as células `ver`, tornando com que nenhuma delas fique com o valor `LAST`.
- Após isso, ele deve dar um `INSERT` alocando `LAST` na célula `ver` nesta linha da tabela, 
significando que agora essa é a atualização atual.

*Necessário compilar, e o código inclui comentários para explicar melhor.*

## Receita do componente

Basta colocar na pasta raiz do game, e indicar o caminho do seu launcher/starter do game, 
criar a lógica de download do arquivo, e também configurar sua comunicação com o 
banco de dados em:

	objcon = New SqlClient.SqlConnection("Data Source=meu computador; INITIAL CATALOG=launcher ; USER=sa; PASSWORD=123456;")

## Exemplo 

<p align="center">
  	<img alt="exemplo" src="https://i.imgur.com/WvbEiyF.png" width="854" height="148" />
</p>

*Ao iniciar o `updater` ele verifica a se a data de atualização quando `ver == LAST`, 
é igual a data de criação do `launcher-main`*


## Deployed

<p align="center">
  	<img alt="updaterAPI" src="https://i.imgur.com/iVnYRvp.gif" width="640" height="480" />
</p>
<p align="left">
  	<img alt="EN-US" src="https://i.imgur.com/QqtGoQ4.gif" width="30" height="20" />
</p>

## Content

This project contains the updater, the file that updates the `launcher-main` of my main project;

It checks if the launcher-main is up to date by executing a query in the database;
It needs to do the update check, as only the updated launcher
will download the files that were updated in that corresponding version;
It has a simple and clean code, and is very interactive in terms of the frame.

## Code notes

- It was developed in `VBasic / .NET` to run in the simplest versions of` .NET Framework`,
thus maintaining transparency between operating systems.
- In the program routine, it must read a database and a specific table,
containing at least 3 cells.
- An `id (int or longint)` cell for DBA control over the amount of updates,
 a `data (update day)` cell for DBA control over the day that was updated
 and a `ver (LAST)` cell, where it is, will have a value of `LAST` when it is the current update.
- The updater should check when the `data` of that corresponding `ver` == `LAST` is equal to
launcher-main creation date.
- When the DBA is going to perform an update maneuver, he must give an `UPDATE`
in all the `ver` cells, making sure that none of them have the `LAST` value.
- After that, he must give an `INSERT` allocating `LAST` in the cell `ver` in this row of the table,
meaning that this is now the current update.

* Necessary to compile, and the code includes comments to explain further. *

## Component revenue

Just put in the game's root folder, and indicate the path of your game launcher / starter,
create the download logic of the file, and also configure its communication with the
database in:

	objcon = New SqlClient.SqlConnection ("Data Source=my computer; INITIAL CATALOG=launcher; USER=sa; PASSWORD=123456;")

## Example

<p align="center">
  	<img alt="exemplo" src="https://i.imgur.com/WvbEiyF.png" width="854" height="148" />
</p>

* When starting `updater`, it checks if the update date, when` ver == LAST`,
equals the `launcher-main` creation date *

## Deployed

<p align="center">
  	<img alt="updaterAPI" src="https://i.imgur.com/iVnYRvp.gif" width="640" height="480" />
</p>