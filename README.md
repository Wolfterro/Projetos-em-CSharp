# Projetos em CSharp
## Pequenos projetos e testes simples em linguagem CSharp

#### Os programas apresentados neste repositório são apenas projetos simples e testes escritos na linguagem CSharp.
#### Alguns destes programas são utilitários e scripts que podem ser utilizados no dia-a-dia para realização de algumas funções.
#### Os programas aqui contidos foram desenvolvidos pensando nas plataformas Windows, Linux e UNIX em geral.

## Programas:

## Hora & Data

### Descrição:

#### Este é um simples programa que possui a função de mostrar a hora e a data para o usuário.
#### O programa utiliza o terminal ou prompt de comando do usuário para mostrar a hora e data atualizada para o usuário, atualizando a cada 1 segundo na mesma linha.
#### Meu primeiro programa em CSharp, apenas para aprender um pouco da sintaxe desta linguagem de programação.

### Requisitos:
- ***Windows:*** Microsoft .NET Framework 4.0 ou mais recente
- ***Linux/Outros:*** Mono 4.0 ou mais recente

### Download:

#### Utilize o git para clonar o repositório e executar o binário:

    git clone https://github.com/Wolfterro/Projetos-em-CSharp.git
    cd Projetos-em-CSharp/HoraData/bin
    ./HoraData.exe

#### Caso queira compilar o programa, seguir os passos abaixo (utilizando o mono):

    git clone https://github.com/Wolfterro/Projetos-em-CSharp.git
    cd Projetos-em-CSharp/HoraData/src
    mcs HoraData.cs -win32icon:Icon.ico
    ./HoraData.exe

## Beep: O programa que bipa!

### Descrição:

#### Este é um simples programa que faz bipar o auto-falante do computador.
#### O programa funciona de três modos: Modo Toque, Modo Constante e Modo Teclado.
#### O Modo Toque permite que o usuário faça bipar o auto-falante quando ele utilizar o teclado, permitindo inserir ritmos.
#### O Modo Constante faz o console bipar constantemente até o programa ser encerrado.
<br />
#### O Modo Teclado, diferente do Modo Toque, faz com que cada tecla tenha uma frequência específica, permitindo que você o use como "teclado musical".
#### As teclas QWERTYUIOP possuem variação de 500 hertz da esquerda para direita, isto é, a menor sendo a tecla Q e a maior a tecla P.
#### As demais teclas com caracteres possuem variação de 200 hertz, pulando as teclas que já possuem variação de 500 hertz. Começando com a tecla A e terminando na tecla M. Verifique o código-fonte para saber qual frequência cada tecla possui.
#### Demais teclas possuem frequência de 800 hertz!
<br />
#### Este não é um programa sério, fiz apenas para uma brincadeira na sala de aula.

### Requisitos:
- ***Windows:*** Microsoft .NET Framework 4.0 ou mais recente
- ***Linux/Outros:*** Mono 4.0 ou mais recente

### Download:

#### Utilize o git para clonar o repositório e executar o binário:

    git clone https://github.com/Wolfterro/Projetos-em-CSharp.git
    cd Projetos-em-CSharp/Beep/bin
    ./Beep.exe

#### Caso queira compilar o programa, seguir os passos abaixo (utilizando o mono):

    git clone https://github.com/Wolfterro/Projetos-em-CSharp.git
    cd Projetos-em-CSharp/Beep/src
    mcs Beep.cs -win32icon:Beep-Icon.ico
    ./Beep.exe

## PCSpecs

### Descrição:

#### Este é um simples programa que possui a função de mostrar algumas especificações do PC para o usuário.
#### O programa utiliza o terminal ou prompt de comando do usuário para mostrar as especificações para o usuário, como a versão do sistema, a versão da CLR e se o sistema é 64-bit.
#### O programa também poderá criar um arquivo de texto com as especificações, caso utilize o argumento '-f' ou '--file'.

### Requisitos:
- ***Windows:*** Microsoft .NET Framework 4.0 ou mais recente
- ***Linux/Outros:*** Mono 4.0 ou mais recente

### Download:

#### Utilize o git para clonar o repositório e o mcs/csc para compilar o programa (exemplo utilizando o mono):

    git clone https://github.com/Wolfterro/Projetos-em-CSharp.git
    cd Projetos-em-CSharp/PCSpecs/src
    mcs PCSpecs.cs
    ./PCSpecs.exe

## Light-Year Converter

### Descrição:

#### Este é um simples programa que possui a função de converter quilômetros para anos-luz e vice-versa.
#### O programa utiliza o terminal ou prompt de comando do usuário para realizar as conversões e mostrar o resultado para o usuário.

### Requisitos:
- ***Windows:*** Microsoft .NET Framework 4.0 ou mais recente
- ***Linux/Outros:*** Mono 4.0 ou mais recente

### Download:

#### Utilize o git para clonar o repositório e o mcs/csc para compilar o programa (exemplo utilizando o mono):

    git clone https://github.com/Wolfterro/Projetos-em-CSharp.git
    cd Projetos-em-CSharp/LightYearConverter/src
    mcs LightYearConverter.cs -r:System.Numerics.dll
    ./LightYearConverter.exe

## Beepson: Siga a sequência!

### Descrição:

#### Este é um simples jogo no estilo [Simon](https://en.wikipedia.org/wiki/Simon_(game)) mas que utiliza os sons do Windows (beeps do console) e as teclas correspondentes para inserir a sequência de comandos necessária.
<br />
#### O jogo utiliza quatro teclas: A, S, D e F. 
#### Cada tecla possui um som diferente. Quando o computador emitir a sequência desejada, o jogador deverá inserir as teclas correspondentes.
<br />
#### A medida que as fases vão passando, o jogo vai ficando cada vez mais difícil e levemente mais rápido (apesar de ser difícil notar nas primeiras fases).

### Requisitos:
- ***Windows:*** Microsoft .NET Framework 4.0 ou mais recente
- ***Linux/Outros:*** Mono 4.0 ou mais recente

### Download:

#### Utilize o git para clonar o repositório e executar o binário:

    git clone https://github.com/Wolfterro/Projetos-em-CSharp.git
    cd Projetos-em-CSharp/Beepson/bin
    ./Beepson.exe

#### Caso queira compilar o programa, seguir os passos abaixo (utilizando o mono):

    git clone https://github.com/Wolfterro/Projetos-em-CSharp.git
    cd Projetos-em-CSharp/Beepson/src
    mcs Beepson.cs -win32icon:Beepson-Icon.ico
    ./Beepson.exe

## Trump.cs - Construa seu próprio muro!

#### *** Este programa é apenas fruto de uma simples brincadeira aliada ao ócio de um programador, por favor não leve a sério! ***
#### Este é um simples programa que, ao ser executado, irá criar um "muro" em seu terminal.
#### Para encerrar o programa, basta apertar CTRL + C e ele irá dizer o tamanho do muro que você construiu.
#### Versão original escrita em C: [Projetos em C](https://github.com/Wolfterro/Projetos-em-C)

#### Aqui está uma lista com os possíveis argumentos:
      
      Opções:
      -------
      '-h' ou '--help':                   Mostra o menu de ajuda.
      
      Cores:
      ------
      '-rw' ou '--red-wall':              Constrói um muro vermelho.
      '-gw' ou '--green-wall':            Constrói um muro verde.
      '-yw' ou '--yellow-wall':           Constrói um muro amarelo.
      '-bw' ou '--blue-wall':             Constrói um muro azul.
      '-mw' ou '--magenta-wall':          Constrói um muro magenta.
      '-cw' ou '--cyan-wall':             Constrói um muro ciano.
      '-ww' ou '--white-wall':            Constrói um muro branco.

### Download:
#### Assim como o muro, você também precisa "construir" o programa, isto é, compilar (utilizando o mono).

    git clone https://github.com/Wolfterro/Projetos-em-CSharp.git
    cd Projetos-em-CSharp/Trump/src
    mcs Trump.cs
    ./Trump.exe
