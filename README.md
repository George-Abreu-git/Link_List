# LinkList

Um catálogo musical em desenvolvimento, feito em C# para praticar programação orientada a objetos e construir, gradualmente, uma API REST.

O projeto começou a partir dos estudos de Screen Sound da Alura e está evoluindo com novas funcionalidades e organização própria. Atualmente, a interação acontece pelo console e os dados ficam em memória.

## Objetivo

Praticar classes, objetos, encapsulamento, herança, interfaces e coleções por meio do gerenciamento de artistas, bandas, álbuns e músicas. O próximo objetivo é completar o CRUD no console e depois levar as operações para uma API em ASP.NET Core.

## Funcionalidades atuais

- Cadastrar bandas e artistas solo, com IDs gerados no cadastro.
- Listar artistas, identificando seu tipo.
- Selecionar um artista pelo ID e verificar se ele existe.
- Abrir o menu da banda selecionada e excluí-la do cadastro.
- Cadastrar, listar e excluir álbuns de uma banda pelo nome.
- Carregar dados iniciais para explorar o sistema sem cadastrar tudo manualmente.

Os modelos também possuem operações para adicionar e listar integrantes, adicionar e remover músicas e alterar nome e gênero de uma música. Essas operações ainda não estão todas disponíveis nos menus.

## Estado do desenvolvimento

O CRUD ainda está em construção. Atualmente:

- O menu de integrantes é exibido, mas sua ação ainda não foi implementada.
- A seleção de artista solo mostra seu nome, sem abrir o gerenciamento de álbuns.
- O menu de músicas e a edição de dados pelos menus ainda estão pendentes.
- No menu de álbuns, a opção 3 está rotulada como seleção, mas atualmente executa a exclusão após a busca pelo nome.
- As entradas numéricas usam `int.Parse`; o tratamento de entradas inválidas ainda não está completo.
- As mensagens do console ainda usam o nome Screen Sound em alguns pontos. O projeto e os namespaces continuam como `TesteAlura`.

Não há banco de dados, endpoints HTTP ou reprodução de áudio nesta versão. Ao encerrar o programa, as alterações são perdidas; na próxima execução, os seeds são carregados novamente.

## Tecnologias e conceitos

- C# e .NET 7, com aplicação de console.
- `Dictionary<int, Artista>` para guardar artistas por ID.
- `List<T>` para os álbuns, músicas e integrantes.
- Herança: `Banda` é uma especialização de `Artista`.
- Interface `IMenu`, com o contrato `Exibir()`.
- Compartilhamento de objetos pelos construtores dos menus.
- LINQ para calcular a duração total dos álbuns.

## Organização dos arquivos

```text
TesteAlura/
├── README.md
└── TesteAlura/
    ├── Program.cs
    ├── TesteAlura.csproj
    ├── Cadastros/
    │   └── CadastroArtistas.cs
    ├── Interface/
    │   └── IMenu.cs
    ├── Menus/
    │   ├── MenuArtistas.cs
    │   ├── MenuBanda.cs
    │   └── MenuAlbum.cs
    ├── Models/
    │   └── Musica/
    │       ├── Artista.cs
    │       ├── Banda.cs
    │       ├── Album.cs
    │       ├── Musica.cs
    │       └── Genero.cs
    └── Seeds/
        └── DadosIniciais.cs
```

### Responsabilidades

- **Program:** cria o cadastro, carrega os seeds e inicia o menu de artistas.
- **CadastroArtistas:** mantém o dicionário, gera os IDs e oferece cadastro, consulta e exclusão.
- **Menus:** recebem as entradas e coordenam a navegação e as operações.
- **Models:** representam os dados e os comportamentos dos objetos. Algumas listagens ainda escrevem diretamente no console.
- **Seeds:** criam os objetos de exemplo e conectam artistas, álbuns, músicas e integrantes.

Cada artista possui sua lista de álbuns. Cada álbum possui sua lista de músicas. Bandas também possuem uma lista de nomes de integrantes. Artistas solo são representados diretamente pela classe `Artista`.

O cadastro é criado uma única vez e compartilhado com os menus. Ao editar um objeto selecionado, as alterações afetam o mesmo objeto guardado no cadastro.

## Como executar

É necessário um SDK .NET capaz de compilar o projeto `net7.0` e o runtime .NET 7 para executá-lo com a configuração atual. O .NET 7 está fora de suporte; a migração para uma versão suportada faz parte das melhorias previstas.

Na pasta que contém este README, execute:

```sh
dotnet restore TesteAlura/TesteAlura.csproj
dotnet build TesteAlura/TesteAlura.csproj
dotnet run --project TesteAlura/TesteAlura.csproj
```

Use um terminal interativo, pois os menus utilizam `Console.ReadLine`, `Console.ReadKey` e `Console.Clear`.

No Visual Studio, abra `TesteAlura/TesteAlura.csproj` e execute o projeto de console.

## Explorando o sistema

1. Escolha **Listar Artistas** para consultar os IDs dos seeds.
2. Escolha **Selecionar Artista** e informe o ID de uma banda.
3. No menu da banda, escolha **Gerenciar Álbuns**.
4. Cadastre ou liste álbuns. A opção 3 desse menu atualmente exclui um álbum pelo nome exato.
5. Use **Voltar** nos submenus. No menu inicial, a opção 0 encerra o programa, embora seu texto ainda seja “Voltar”.

## Dados iniciais

Os seeds incluem três bandas e um artista representado como solo:

- **Slipknot:** integrantes da formação histórica de *Iowa*, álbum e duas músicas.
- **Linkin Park:** integrantes da formação histórica de *Meteora*, álbum e duas músicas.
- **System of a Down:** integrantes, álbum *Toxicity* e duas músicas.
- **Marilyn Manson:** representado como artista solo neste exercício, com *The Pale Emperor* e duas músicas.

São quatro álbuns e oito músicas. A seleção não representa discografias completas. As durações são aproximadas e a disponibilidade das músicas é fictícia, usada apenas para praticar o campo booleano. O ano de início dos gêneros não foi preenchido.

## Próximos passos

- [ ] Completar o gerenciamento de integrantes.
- [ ] Disponibilizar álbuns para artistas solo.
- [ ] Separar a seleção de um álbum de sua exclusão.
- [ ] Implementar os menus de gerenciamento de músicas.
- [ ] Completar as operações de atualização nos menus.
- [ ] Padronizar mensagens e navegação com a identidade LinkList.
- [ ] Separar gradualmente a exibição no console das operações dos modelos e do cadastro.
- [ ] Ampliar as validações e os testes dos fluxos.
- [ ] Migrar para uma versão suportada do .NET.
- [ ] Persistir os dados em banco de dados.
- [ ] Criar uma API REST com ASP.NET Core.
- [ ] Explorar usuários, favoritos e avaliações.

## Referência de estudo

Desenvolvido durante os estudos de C# e orientação a objetos, usando como referência o [ScreenSound03 da Alura](https://github.com/alura-cursos/ScreenSound03).
