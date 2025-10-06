# Plano de Testes de Usabilidade

O objetivo deste plano é avaliar a usabilidade da aplicação ConectaBairro, considerando a experiência real de moradores, comerciantes, ONGs e representantes da Prefeitura. Os objetivos específicos são:

- Verificar se os usuários conseguem fazer publicações de forma rápida e intuitiva.
- Avaliar se os usuários conseguem filtrar e localizar informações por categoria.
- Identificar possíveis barreiras de navegação no feed, chat e filtro.
- Testar a acessibilidade da aplicação para perfis variados, incluindo usuários com pouca familiaridade tecnológica.
- Avaliar o funcionamento e a clareza das notificações.

## Seleção dos participantes

- Moradores de diferentes idades - Usuários principais da plataforma para reportar problemas e interagir.

- Usuários com baixa alfabetização digital - Testar a acessibilidade e simplicidade da interface.

- ONGs e Prefeitura	- Responsáveis por acompanhar e agir em relação às publicações.

- Comerciantes locais -	Utilizam a plataforma para promover seus produtos e serviços.
  
**Quantidade recomendada:**
Mínimo: 5 participantes.
Ideal: Entre 18 e 60 para maior diversidade e confiabilidade prática.



## Definição de cenários de teste


**Cenário 1** - Morador relatando um buraco na rua

**Objetivo:** Avaliar se um morador consegue, de maneira intuitiva, criar conta, fazer login e publicar um problema (buraco) com foto e descrição, e verificar se a publicação aparece no feed.

**Contexto:** Você é um morador que encontrou um buraco perto da sua casa. Decide registrar a ocorrência no ConectaBairro para alertar vizinhos e Prefeitura. Precisa criar conta, entrar e publicar o relato com imagem.

**Tarefa:**  
- Acessar ConectaBairro.
- Criar conta de morador (preencher dados essenciais).
- Efetuar login com a nova conta.
- Criar publicação: adicionar título (“Buraco na Rua X”), descrição, anexar imagem e selecionar categoria “Zeladoria” ou similar.
- Publicar e verificar se aparece no feed.

**Critérios de sucesso:**
- Conta criada e login realizados sem assistência. (RF-001, RF-002)
- Publicação criada com título, descrição e imagem corretamente salvas. (RF-004)
- Publicação aparece no feed visível a outros usuários. (RF-015)
- Usuário não demonstrou confusão ao preencher campos (observação qualitativa).
  


**Cenário 2** - Administrador da Prefeitura atualiza status de demanda resolvida

**Objetivo:** Verificar se um administrador localiza corretamente uma publicação de demanda (buraco) e altera o status para “Resolvido”, registrando comentário e disparando notificação.

**Contexto:**  A Prefeitura recebeu um relatório de buraco que já foi consertado. O administrador precisa registrar isso no ConectaBairro para que moradores sejam informados.

**Tarefa:**  
- Efetuar login como administrador.
- Acessar o feed e localizar a publicação sobre o buraco (por busca/filtro/rolagem).
- Alterar o status da publicação para “Resolvido” e, se disponível, adicionar comentário com detalhes (ex.: data do conserto).
- Salvar alterações e confirmar se houve notificação para o autor/participantes.

**Critérios de sucesso:** 
- Administrador encontrou a publicação sem ajuda. (RF-002, RF-015)
- Status alterado com sucesso. (RF-008)
- Comentário/registro da ação aparece na publicação. (RF-011 / RF-004)
- Notificações foram geradas e redirecionam corretamente para a publicação. (RF-006)



**Cenário 3** - Criar e publicar um anúncio

**Objetivo:** Verificar se um usuário consegue criar e publicar um anúncio de forma intuitiva, incluindo imagem e categoria, e confirmar se aparece no feed.

**Contexto:** Você é dono de um pequeno comércio e deseja divulgar uma promoção na plataforma para atrair moradores do bairro.

**Tarefa:** 
- Acessar a tela de criação de publicação.
- Inserir título, descrição, imagem e selecionar a categoria apropriada.
- Publicar o anúncio.
- Verificar se o anúncio aparece no feed.

**Critérios de sucesso:** 
- Anúncio publicado e visível no feed. (RF-004, RF-015)
- O botão/fluxo “Enviar mensagem” abre canal de comunicação e as mensagens chegam ao destinatário. (RF-009)


**Cenário 4** - Enviar mensagem em resposta a um anúncio

**Objetivo:** Avaliar se um usuário consegue localizar um anúncio no feed e utilizar corretamente o recurso de mensagens para entrar em contato com o anunciante.

**Contexto:** Você viu um anúncio de promoção no feed e deseja tirar uma dúvida diretamente com o anunciante.

**Tarefa:** 
- Acessar o feed.
- Localizar um anúncio.
- Clicar em “Enviar mensagem”.
- Escrever e enviar uma mensagem.

**Critério(s) de Sucesso(s):**
- O usuário consegue encontrar o anúncio sem dificuldade.
- O botão “Enviar mensagem” funciona corretamente. (RF-009)
- A mensagem é enviada e registrada no chat.
- Nenhuma etapa gera confusão ou bloqueio



**Cenário 5** - Moderação: administrador remove comentários ofensivos e modera publicação

**Objetivo:** Avaliar a facilidade para o administrador identificar e remover comentários inapropriados.

**Pré-Condição** Estar logado na aplicação como administrador

**Contexto:** Um administrador monitora o feed e encontra comentários que violam as regras; precisa removê-los.

**Tarefa:** 
- Efetuar login como administrador.
- Localizar publicação com comentários ofensivos.
- Selecionar comentário(s) e executar exclusão.
- Verificar que os comentários removidos não aparecem mais e que outras partes da publicação permanecem.

**Critério(s) de Sucesso(s):**
- Administrador localiza e exclui comentário com facilidade. (RF-011, RF-012)
- Comentário removido definitivamente do feed público. (RF-011)
- A publicação e demais comentários permanecem intactos (sem efeitos colaterais). (RF-010)


**Cenário 6** - Interações e Notificações

**Objetivo:** Verificar todo o fluxo de interação: um usuário reage/comenta em uma publicação e o autor recebe notificação que o direciona corretamente ao conteúdo.

**Contexto:** Um morador comentou em uma publicação; o autor deve receber notificação e, ao clicar, ser levado à publicação correta.

**Tarefa:** 
- Usuário A publica um post.
- Usuário B curte e comenta no post.
- Usuário A verifica a área de notificações.
- Usuário A clica na notificação e é redirecionado ao post.
- 
**Critério(s) de Sucesso(s):**
- Reações e comentários são registrados e visíveis. (RF-005)
- Notificações são geradas para o autor/participantes e mostram motivo claro. (RF-006)
- Clique na notificação redireciona para a publicação correta. (RF-015)


**Cenário 7** - ONG monitora publicações de saúde e solicita troca de endereço

**Objetivo:** Garantir que a ONG possa acompanhar publicações relacionadas à saúde e, caso identifique inconsistências no cadastro de algum usuário, solicitar a atualização do endereço.

**Contexto:** A ONG entra no sistema, utiliza o filtro de publicações para visualizar apenas aquelas da categoria “Saúde” e, ao notar que uma publicação veio de um usuário com endereço incorreto, emite uma solicitação de troca de endereço. O administrador recebe a solicitação e realiza a alteração.

**Tarefa:** 
- ONG acessa o feed e aplica filtro de publicações da categoria Saúde (RF-007 e RF-015).
- ONG identifica inconsistência no endereço de um usuário.
- ONG solicita a troca de endereço (RF-013).
- Administrador recebe a solicitação.
- Administrador altera o endereço do usuário (RF-014).

**Critério(s) de Sucesso(s):**
- As publicações da categoria Saúde são exibidas corretamente.
- A solicitação de troca de endereço é registrada no sistema.
- O administrador recebe a solicitação.
- O endereço do usuário é atualizado somente após ação do administrador.



## Métodos de coleta de dados

Os dados coletados devem ajudar a entender a experiência dos usuários e os dados podem ser coletados por observação direta incluindo métricas quantitativas (quantidade de cliques, número de erros, tempo gasto para cada tarefa etc.), métricas qualitativas (dificuldades, comentários etc.) e questionários pós-teste (A interface foi fácil de entender? Você encontrou dificuldades em alguma etapa? O que poderia ser melhorado?)

Para cada voluntário do teste, é fundamental coletar e apresentar todos os dados/métricas previamente definidos, mas não se esqueça: atendendo à LGPD (Lei Geral de Proteção de Dados), nenhum dado sensível, que permita identificar o voluntário, deverá ser apresentado).

As referências abaixo irão auxiliá-lo na geração do artefato "Plano de Testes de Usabilidade".

> **Links Úteis**:
> - [Teste De Usabilidade: O Que É e Como Fazer Passo a Passo (neilpatel.com)](https://neilpatel.com/br/blog/teste-de-usabilidade/)
> - [Teste de usabilidade: tudo o que você precisa saber! | by Jon Vieira | Aela.io | Medium](https://medium.com/aela/teste-de-usabilidade-o-que-voc%C3%AA-precisa-saber-39a36343d9a6/)
> - [Planejando testes de usabilidade: o que (e o que não) fazer | iMasters](https://imasters.com.br/design-ux/planejando-testes-de-usabilidade-o-que-e-o-que-nao-fazer/)
> - [Ferramentas de Testes de Usabilidade](https://www.usability.gov/how-to-and-tools/resources/templates.html)
