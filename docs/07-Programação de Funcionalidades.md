# Programação de Funcionalidades (INCLUIR A PROGRAMAÇAÕ DE FUNCIONALIDADE EM PROFUNDIDADE)

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="4-Metodologia.md"> Metodologia</a>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>, <a href="5-Arquitetura da Solução.md"> Arquitetura da Solução</a>

Nesta seção, a implementação do sistema descrita por meio dos requisitos funcionais e/ou não funcionais. Nesta seção, é essencial relacionar os requisitos atendidos com os artefatos criados (código fonte) e com o(s) responsável(is) pelo desenvolvimento de cada artefato a cada etapa. Nesta seção também deverão ser apresentadas, se necessário, as instruções para acesso e verificação da **implementação que deve estar funcional no ambiente de hospedagem, OBRIGATORIAMENTE, a partir da Etapa 03**.

**O que DEVE ser utilizado para o desenvolvimento da aplicação:**
- Microsoft Visual Studio (IDE de Codificação)
- HTML e CSS (frontend)
- Javascript (frontend)
- C# (backend)
- MySQL ou SQLServer(Base de Dados)
- Bootstrap (template responsivo para frontend)
- Github (documentação e controle de versão)

**O que NÃO PODE ser utilizado:**
- Template React (e qualquer outro template - exceto o Bootstrap)
- Qualquer outra liguagem de programação diferente de C#

A tabela a seguir é um exemplo de como ela deverá ser preenchida considerando os artefatos desenvolvidos.

|ID    | Descrição do Requisito  | Artefatos produzidos | Aluno(a) responsável |
|------|-----------------------------------------|----|----|
|RF-001| A aplicação deve permitir que usuários do tipo moradores, ONGs e prefeitura efetuem seu próprio registro (autorregistro) e tenham acesso às funções de gerenciamento de seus dados pessoais, permitindo consultar, atualizar e excluir essas informações.| Gabriel - Migrations InitialCreateFinal, MakeCnpjNullable, AlterarColunaEmail, AddResetTokenFieldsToUsuario, AddSenhaObrigatoria. UsuariosController.cs. AppDbContext.cs. Usuario.cs. View Usuários - Create.cshtml, Delete.cshtml, Edit.cshtml. // Luiz - | Gabriel Yuri e Luiz Felipe Ribeiro Liquer |
|RF-002| A aplicação deve permitir ao usuário realizar login com e-mail e senha. | Migrations InitialCreateFinal, MakeCnpjNullable, AlterarColunaEmail, AddResetTokenFieldsToUsuario, AddSenhaObrigatoria. UsuariosController.cs. Usuario.cs. View Usuários - Login.cshtml | Gabriel Yuri |
|RF-003| A aplicação deve permitir ao usuário redefinir sua senha na tela de login, caso a tenha esquecido. | Migrations InitialCreateFinal, MakeCnpjNullable, AlterarColunaEmail, AddResetTokenFieldsToUsuario, AddSenhaObrigatoria. UsuariosController.cs. Usuario.cs. View Usuários - EsqueciSenha.cshtml, RedefinirSenha.cshtml  | Gabriel Yuri |
|RF-004| A aplicação deve permitir que os usuários do tipo moradores, ONGs e prefeitura criem e administrem publicações, preenchendo os campos obrigatórios: título, descrição, categorias (como anúncios, avisos, eventos etc.), status somente da sua publicação, imagens e vídeos curtos. Toda nova publicação deve ser registrada automaticamente com o status “em aberto”.	|  |  |
|RF-005| A aplicação deve permitir aos usuários a possibilidade de interagir nas publicações, seja através de reações como “gostei” e “não gostei”, ou pela inclusão de comentários.|  |  |
|RF-006| A aplicação deve enviar notificações referentes a alterações de status, comentários e curtidas.|  |  |
|RF-007| A aplicação deve permitir que os usuários filtrem publicações por categoria, data ou palavra-chave.|  |  |
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
