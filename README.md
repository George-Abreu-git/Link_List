# LinkList

Catálogo musical de console em C#, criado durante os estudos de orientação a objetos e com evolução planejada para uma API REST.

## Escopo atual

O fluxo ativo trabalha somente com artistas solo. A classe `Banda`, sua lista de integrantes e o `MenuBanda` permanecem no projeto para estudo e uso futuro, sem participação nos menus, no cadastro ou nos seeds atuais.

## Funcionalidades

- Cadastro de artistas solo com IDs gerados em memória.
- Listagem e seleção por ID, verificando se o registro existe.
- Menu do artista selecionado com detalhes, acesso aos álbuns e exclusão definitiva do cadastro.
- Cadastro e listagem de álbuns do artista selecionado.
- Busca de álbum pelo nome; a ação após encontrar o álbum ainda está em construção.
- Seed de Marilyn Manson, representado como artista solo, com The Pale Emperor e duas músicas.

As durações dos seeds são aproximadas e a disponibilidade é fictícia. Os dados não persistem após encerrar a execução.

## Organização

```text
TesteAlura/
├── Program.cs
├── TesteAlura.csproj
├── Cadastros/
│   └── CadastroArtistas.cs
├── Interface/
│   └── IMenu.cs
├── Menus/
│   ├── MenuArtistas.cs
│   ├── MenuBanda.cs              # Preservado, fora do fluxo ativo
│   ├── MenuArtista.cs
│   └── MenuAlbum.cs
├── Models/Musica/
│   ├── Artista.cs
│   ├── Banda.cs                 # Preservada, fora do fluxo ativo
│   ├── Album.cs
│   ├── Musica.cs
│   └── Genero.cs
└── Seeds/
    └── DadosIniciais.cs
```

O `Program` cria uma única instância de `CadastroArtistas`, carrega os seeds e inicia `MenuArtistas`. Este menu cadastra, lista e seleciona registros. `MenuArtista` recebe o artista selecionado, o mesmo cadastro e seu ID. `MenuAlbum` recebe esse artista e trabalha com sua lista de álbuns. Cada álbum mantém sua lista de músicas.

Os modelos já oferecem algumas operações ainda não ligadas aos menus, como remover álbuns, adicionar e remover músicas e alterar nome e gênero das músicas. Algumas listagens ainda escrevem diretamente no console.

## Como executar

A partir da pasta que contém este README:

```sh
dotnet restore TesteAlura/TesteAlura.csproj
dotnet build TesteAlura/TesteAlura.csproj
dotnet run --project TesteAlura/TesteAlura.csproj
```

É necessário um SDK capaz de compilar `net7.0` e o runtime .NET 7 para a configuração atual. Esse framework está fora de suporte; sua atualização está prevista. Também é possível abrir o arquivo de projeto no Visual Studio.

Use um terminal interativo: os menus utilizam `Console.ReadLine`, `Console.ReadKey` e `Console.Clear`. Selecione o artista de ID 1 para explorar os álbuns do seed. A opção 0 volta nos submenus e encerra no menu inicial.

## Próximos passos

- Completar a seleção e o gerenciamento de álbuns e músicas.
- Implementar o estado ativo/inativo. Atualmente a exclusão remove o registro, não o desativa.
- Ampliar a validação das entradas: a leitura numérica ainda utiliza `int.Parse`.
- Separar a apresentação no console das operações dos modelos e do cadastro.
- Atualizar o .NET, adicionar persistência e criar endpoints REST com ASP.NET Core.
- Explorar usuários, favoritos e avaliações.

O projeto ainda não possui banco de dados, endpoints HTTP ou reprodução de áudio. Os namespaces e o nome do projeto permanecem `TesteAlura`.

## Referência

Projeto desenvolvido a partir dos estudos de [ScreenSound03 da Alura](https://github.com/alura-cursos/ScreenSound03), com adaptações próprias.