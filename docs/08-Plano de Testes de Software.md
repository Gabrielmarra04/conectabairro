# Plano de Testes de Software

<span style="color:red">Pré-requisitos: <a href="2-Especificação do Projeto.md"> Especificação do Projeto</a></span>, <a href="3-Projeto de Interface.md"> Projeto de Interface</a>

Apresente os cenários de testes utilizados na realização dos testes da sua aplicação. Escolha cenários de testes que demonstrem os requisitos sendo satisfeitos.

Não deixe de enumerar os casos de teste de forma sequencial e de garantir que o(s) requisito(s) associado(s) a cada um deles está(ão) correto(s) - de acordo com o que foi definido na seção "2 - Especificação do Projeto". 

Por exemplo:

| **Caso de Teste** | **Requisito Associado** | **Objetivo do Teste** | **Passos** | **Critério de Êxito** |
|-------------------|--------------------------|-----------------------|------------|-----------------------|
| CT01 – Cadastrar perfil | RF-001 - A aplicação deve permitir que usuários do tipo moradores, ONGs e prefeitura efetuem seu próprio registro (autorregistro) e tenham acesso às funções de gerenciamento de seus dados pessoais. | Verificar se o usuário consegue se cadastrar na aplicação. | - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Criar conta" <br> - Preencher os campos obrigatórios <br> - Clicar em "Registrar" | O cadastro foi realizado com sucesso. |
| CT02 – Efetuar login | RF-002 - A aplicação deve permitir ao usuário realizar login com e-mail e senha. | Verificar se o usuário consegue realizar login. | - Acessar o navegador <br> - Informar o endereço do site <br> - Clicar em "Entrar" <br> - Preencher e-mail e senha <br> - Clicar em "Login" | O login foi realizado com sucesso. |
| CT03 – Alterar senha | RF-003 - A aplicação deve permitir ao usuário trocar senha e login. | Verificar se o usuário consegue alterar sua senha. | - Acessar a página de login <br> - Clicar em “Esqueci minha senha” <br> - Ser direcionado para a tela de redefinição de senha <br> - Informar e-mail <br> - Informar nova senha e confirmar <br> - Salvar alterações <br> - Retornar à tela de login <br> - Efetuar login com a nova senha | O login é realizado com sucesso utilizando a nova senha. |
| CT04 – Criar publicações | RF-004 - A aplicação deve permitir criar e administrar publicações. | Verificar se o usuário consegue criar publicações. | - Efetuar login <br> - Acessar área de publicações <br> - Preencher título, descrição, categoria, anexos <br> - Salvar | A publicação é registrada com status “em aberto”. |
| CT05 – Interagir em publicações | RF-005 - A aplicação deve permitir interações nas publicações. | Validar curtidas e comentários. | - Efetuar login <br> - Acessar uma publicação <br> - Clicar em “Curtir/Não Curtir” <br> - Inserir comentário | A reação é registrada e o comentário exibido. |
| CT06 – Notificações | RF-006 - A aplicação deve enviar notificações. | Verificar se o usuário recebe notificações ao interagir. | - Efetuar login <br> - Criar publicação <br> - Interagir com ela (curtida/comentário) <br> - Verificar notificações recebidas | Notificações exibidas corretamente no painel do usuário. |
| CT07 – Filtro de publicações | RF-007 - A aplicação deve permitir filtros por categoria, data e palavra-chave. | Validar a busca e filtro de publicações. | - Efetuar login <br> - Acessar feed <br> - Selecionar filtros de categoria, data ou palavra-chave | O feed exibe apenas publicações filtradas. |
| CT08 – Alteração de status por ONGs/Prefeitura | RF-008 - ONGs e Prefeitura podem alterar status de todas publicações. | Verificar se o status pode ser alterado. | - Efetuar login como ONG/Prefeitura <br> - Acessar publicação existente <br> - Alterar status <br> - Inserir comentário | O status é atualizado e visível para todos. |
| CT09 – Chat entre usuários | RF-009 - O sistema deve permitir contato via chat. | Validar envio de mensagens no chat. | - Efetuar login <br> - Acessar publicação <br> - Clicar em “Entrar em contato” <br> - Enviar mensagem no chat | A mensagem é enviada e recebida pelo destinatário. |
| CT10 – Remover publicação | RF-010 - O administrador pode remover publicações. | Verificar se o administrador consegue excluir uma publicação. | - Efetuar login como administrador <br> - Acessar publicação existente <br> - Clicar em “Remover” | A publicação desaparece do feed geral. |
| CT11 – Excluir comentários | RF-011 - O administrador pode excluir comentários. | Validar a remoção de comentários. | - Efetuar login como administrador <br> - Acessar publicação com comentários <br> - Selecionar comentário <br> - Clicar em “Excluir” | O comentário não aparece mais na publicação. |
| CT12 – Desativar conta | RF-012 - O administrador pode desativar contas (exclusão lógica). | Verificar se o administrador consegue desativar perfis. | - Efetuar login como administrador <br> - Acessar lista de usuários <br> - Selecionar um usuário <br> - Alterar status para “Inativo” | O usuário não consegue mais acessar o sistema. |
| CT13 – Solicitar troca de endereço | RF-013 - A aplicação deve permitir solicitar troca de endereço. | Validar solicitação de troca de endereço. | - Efetuar login <br> - Acessar perfil <br> - Solicitar troca de endereço <br> - Enviar solicitação | A solicitação é enviada ao administrador. |
| CT14 – Alterar endereço (Administrador) | RF-014 - Somente o administrador pode alterar endereços. | Validar a alteração de endereço pelo administrador. | - Efetuar login como administrador <br> - Acessar solicitações de endereço <br> - Confirmar alteração | O endereço atualizado aparece no perfil do usuário. |
| CT15 – Visualizar feed geral | RF-015 - O sistema deve permitir acesso ao feed geral. | Validar se o usuário acessa o feed após login. | - Efetuar login <br> - Ser redirecionado automaticamente ao feed <br> - Visualizar todas as publicações e alertas | O feed é exibido corretamente. |

---



 
> **Links Úteis**:
> - [IBM - Criação e Geração de Planos de Teste](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Práticas e Técnicas de Testes Ágeis](http://assiste.serpro.gov.br/serproagil/Apresenta/slides.pdf)
> -  [Teste de Software: Conceitos e tipos de testes](https://blog.onedaytesting.com.br/teste-de-software/)
> - [Criação e Geração de Planos de Teste de Software](https://www.ibm.com/developerworks/br/local/rational/criacao_geracao_planos_testes_software/index.html)
> - [Ferramentas de Test para Java Script](https://geekflare.com/javascript-unit-testing/)
> - [UX Tools](https://uxdesign.cc/ux-user-research-and-user-testing-tools-2d339d379dc7)
