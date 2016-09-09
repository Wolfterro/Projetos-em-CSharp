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
#### O programa funciona de dois modos: Modo Toque e Modo Constante.
#### O Modo Toque permite que o usuário faça bipar o auto-falante quando ele utilizar o teclado, permitindo inserir ritmos.
#### O Modo Constante faz o console bipar constantemente até o programa ser encerrado.
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
