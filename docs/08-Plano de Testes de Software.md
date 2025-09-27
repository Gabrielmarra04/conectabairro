# Plano de Testes de Software

| Caso de Teste | Requisito Associado | Objetivo do Teste | Passos | Critério de Êxito |
|---------------|----------------------|------------------|--------|-------------------|
| CT01 | RF-001 | Verificar se o usuário consegue se cadastrar na aplicação. | - Acessar o navegador<br>- Informar o endereço do site<br>- Clicar em "Criar conta"<br>- Preencher os campos obrigatórios<br>- Clicar em "Registrar" | O cadastro foi realizado com sucesso. |
| CT02 | RF-001 | Validar se o usuário consegue visualizar seus dados pessoais. | - Efetuar login<br>- Acessar a área de perfil<br>- Visualizar informações cadastradas | Os dados do usuário são exibidos corretamente. |
| CT03 | RF-001 | Verificar se o usuário consegue alterar seus dados. | - Efetuar login<br>- Acessar área de perfil<br>- Editar informações (ex.: nome, endereço, senha)<br>- Salvar alterações | As alterações são salvas e exibidas corretamente. |
| CT04 | RF-001 | Verificar se o usuário consegue excluir sua conta. | - Efetuar login<br>- Acessar área de perfil<br>- Solicitar exclusão da conta | A conta é desativada e o usuário não consegue mais acessar o sistema. |
| CT05 | RF-002 | Verificar se o usuário consegue realizar login. | - Acessar o navegador<br>- Informar o endereço do site<br>- Clicar em "Entrar"<br>- Preencher e-mail e senha<br>- Clicar em "Login" | O login foi realizado com sucesso. |
| CT06 | RF-003 | Verificar se o usuário consegue redefinir sua senha esquecida. | - Acessar a página de login<br>- Clicar em “Esqueci minha senha”<br>- Informar e-mail<br>- Informar nova senha e confirmar<br>- Salvar alterações<br>- Retornar à tela de login<br>- Efetuar login com a nova senha | O login é realizado com sucesso utilizando a nova senha. |
| CT07 | RF-004 | Verificar se o usuário consegue criar publicações. | - Efetuar login<br>- Acessar área de publicações<br>- Preencher título, descrição, categoria, anexos<br>- Salvar | A publicação é registrada com status “em aberto”. |
| CT08 | RF-004 | Validar se o usuário consegue visualizar suas publicações. | - Efetuar login<br>- Acessar área de publicações<br>- Selecionar publicação existente | A publicação é exibida corretamente. |
| CT09 | RF-004 | Verificar se o usuário consegue alterar suas publicações. | - Efetuar login<br>- Acessar área de publicações<br>- Selecionar publicação existente<br>- Alterar dados<br>- Salvar alterações | As alterações são salvas e exibidas corretamente. |
| CT10 | RF-004 | Verificar se o usuário consegue excluir suas publicações. | - Efetuar login<br>- Acessar área de publicações<br>- Selecionar publicação existente<br>- Excluir publicação | A publicação é removida do feed geral. |
| CT11 | RF-005 | Validar curtidas e comentários em publicações. | - Efetuar login<br>- Acessar uma publicação<br>- Clicar em “Curtir/Não Curtir”<br>- Inserir comentário | A reação é registrada e o comentário exibido. |
| CT12 | RF-006 | Verificar se o usuário recebe notificações ao interagir. | - Efetuar login<br>- Criar publicação<br>- Interagir com ela (curtida/comentário)<br>- Verificar notificações recebidas | Notificações exibidas corretamente no painel do usuário. |
| CT13 | RF-007 | Validar a busca e filtro de publicações. | - Efetuar login<br>- Acessar feed<br>- Selecionar filtros de categoria, data ou palavra-chave | O feed exibe apenas publicações filtradas. |
| CT14 | RF-008 | Verificar se ONGs/Prefeitura conseguem alterar status. | - Efetuar login como ONG/Prefeitura<br>- Acessar publicação existente<br>- Alterar status<br>- Inserir comentário | O status é atualizado e visível para todos. |
| CT15 | RF-009 | Validar envio de mensagens no chat. | - Efetuar login<br>- Acessar publicação<br>- Clicar em “Entrar em contato”<br>- Enviar mensagem no chat | A mensagem é enviada e recebida pelo destinatário. |
| CT16 | RF-010 | Verificar se o administrador consegue excluir publicações. | - Efetuar login como administrador<br>- Acessar publicação existente<br>- Clicar em “Remover” | A publicação desaparece do feed geral. |
| CT17 | RF-011 | Validar a remoção de comentários. | - Efetuar login como administrador<br>- Acessar publicação com comentários<br>- Selecionar comentário<br>- Clicar em “Excluir” | O comentário não aparece mais na publicação. |
| CT18 | RF-012 | Verificar se o administrador consegue desativar perfis. | - Efetuar login como administrador<br>- Acessar lista de usuários<br>- Selecionar um usuário<br>- Alterar status para “Inativo” | O usuário não consegue mais acessar o sistema. |
| CT19 | RF-013 | Validar solicitação de troca de endereço. | - Efetuar login<br>- Acessar perfil<br>- Solicitar troca de endereço<br>- Enviar solicitação | A solicitação é enviada ao administrador. |
| CT20 | RF-014 | Validar alteração de endereço pelo administrador. | - Efetuar login como administrador<br>- Acessar solicitações de endereço<br>- Confirmar alteração | O endereço atualizado aparece no perfil do usuário. |
| CT21 | RF-015 | Validar se o usuário acessa o feed após login. | - Efetuar login<br>- Ser redirecionado automaticamente ao feed<br>- Visualizar todas as publicações e alertas | O feed é exibido corretamente. |
| CT22 | RNF-003 | Validar funcionamento da aplicação em navegadores suportados. | - Acessar a aplicação no Chrome, Firefox, Edge e Safari<br>- Realizar login e navegação básica | A aplicação funciona corretamente em todos os navegadores suportados. |
| CT23 | RNF-004 | Validar alternância de tema claro/escuro. | - Acessar a tela de login<br>- Localizar a opção de alternância de tema (ícone)<br>- Ativar modo escuro<br>- Ativar novamente o modo claro | A interface alterna corretamente entre os modos sem necessidade de login. |
| CT24 | RNF-005 | Validar responsividade em múltiplos dispositivos. | - Acessar a aplicação em smartphone, tablet e computador<br>- Testar a navegação | A interface adapta-se a cada dispositivo, sem perda de funcionalidade. |

---
