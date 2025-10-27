# Programação de Funcionalidades (INCLUIR A PROGRAMAÇAÕ DE FUNCIONALIDADE EM PROFUNDIDADE)

|ID    | Descrição do Requisito  | Artefatos produzidos | Aluno(a) responsável |
|------|-----------------------------------------|----|----|
|RF-001| A aplicação deve permitir que usuários do tipo moradores, ONGs e prefeitura efetuem seu próprio registro (autorregistro) e tenham acesso às funções de gerenciamento de seus dados pessoais, permitindo consultar, atualizar e excluir essas informações.| Gabriel - Migrations InitialCreateFinal, MakeCnpjNullable, AlterarColunaEmail, AddResetTokenFieldsToUsuario, AddSenhaObrigatoria. UsuariosController.cs. AppDbContext.cs. Usuario.cs. View Usuários - Create.cshtml, Delete.cshtml, Edit.cshtml. // Luiz - MeusDados, MeusDados.cshtml, Novas classes CSSm, Usuario.cs | Gabriel Yuri e Luiz Felipe Ribeiro Liquer |
|RF-002| A aplicação deve permitir ao usuário realizar login com e-mail e senha. | Migrations InitialCreateFinal, MakeCnpjNullable, AlterarColunaEmail, AddResetTokenFieldsToUsuario, AddSenhaObrigatoria. UsuariosController.cs. Usuario.cs. View Usuários - Login.cshtml | Gabriel Yuri |
|RF-003| A aplicação deve permitir ao usuário redefinir sua senha na tela de login, caso a tenha esquecido. | Migrations InitialCreateFinal, MakeCnpjNullable, AlterarColunaEmail, AddResetTokenFieldsToUsuario, AddSenhaObrigatoria. UsuariosController.cs. Usuario.cs. View Usuários - EsqueciSenha.cshtml, RedefinirSenha.cshtml  | Gabriel Yuri |
| RF-004 | A aplicação deve permitir que os usuários do tipo moradores, ONGs e prefeitura criem e administrem publicações, preenchendo os campos obrigatórios: título, descrição, categorias (como anúncios, avisos, eventos etc.), status somente da sua publicação, imagens e vídeos curtos. Toda nova publicação deve ser registrada automaticamente com o status “em aberto”. | Migrations relacionadas a criação da tabela Posts. Model Post.cs (propriedades: PostId, AutorId, Título, Descrição, Categoria, Status, Caminho da Imagem/Vídeo). Controller PostsController.cs — métodos Create, Index e integração com o usuário logado. Views/Posts/Create.cshtml — formulário com campos obrigatórios (Título, Descrição, Categoria, Upload de Imagem/Vídeo). Views/Home/Index.cshtml — feed “O que está acontecendo no Conecta Bairros” exibindo posts cadastrados e link para criação de nova publicação. | João Vitor Macedo |
|RF-005| A aplicação deve permitir aos usuários a possibilidade de interagir nas publicações, seja através de reações como “gostei” e “não gostei”, ou pela inclusão de comentários.|  |  |
|RF-006| A aplicação deve enviar notificações referentes a alterações de status, comentários e curtidas.|  |  |
|RF-007| A aplicação deve permitir que os usuários filtrem publicações por categoria ou palavra-chave.| Controllers/HomeController.cs: A Action Index foi modificada para aceitar parâmetros de filtro (termoBusca, categoria, ordenacaoData). Ela agora usa IQueryable para construir uma consulta dinâmica, aplicando filtros Where() condicionais para palavra-chave e categoria, e ordenação (OrderBy()) para a data. O ViewData é usado para enviar os filtros selecionados de volta para a View. Views/Home/Index.cshtml: Foi adicionado um <form method="get"> que agrupa os campos de filtro (<input> de pesquisa, <select> de categoria e <select> de ordenação). A lógica Razor (@ViewData["..."]) é usada para ler os dados enviados pelo Controller e manter os campos de filtro preenchidos após a pesquisa. | Luiz Felipe |
|RF-008| A aplicação deve permitir que ONGs e Prefeitura alterem o status de todas publicações e adicionem comentários em uma publicação.|  |  |

# Instruções de acesso

Não deixe de informar o link onde a aplicação estiver disponível para acesso (por exemplo: https://adota-pet.herokuapp.com/src/index.html).

Se houver usuário de teste, o login e a senha também deverão ser informados aqui (por exemplo: usuário - admin / senha - admin).

O link e o usuário/senha descritos acima são apenas exemplos de como tais informações deverão ser apresentadas.

> **Links Úteis**:
>
> - [Trabalhando com HTML5 Local Storage e JSON](https://www.devmedia.com.br/trabalhando-com-html5-local-storage-e-json/29045)
> - [JSON Tutorial](https://www.w3resource.com/JSON)
> - [JSON Data Set Sample](https://opensource.adobe.com/Spry/samples/data_region/JSONDataSetSample.html)
> - [JSON - Introduction (W3Schools)](https://www.w3schools.com/js/js_json_intro.asp)
> - [JSON Tutorial (TutorialsPoint)](https://www.tutorialspoint.com/json/index.htm)
