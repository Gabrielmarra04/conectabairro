# Plano de Testes de Usabilidade

O objetivo deste plano é avaliar a usabilidade da aplicação ConectaBairro considerando a experiência real dos moradores e agentes da comunidade. Os objetivos específicos são:

- Verificar se os usuários conseguem fazer publicações de forma rápida e intuitiva.
- Avaliar se os usuários conseguem filtrar e localizar informações por categoria.
- Medir a facilidade de interação entre moradores nas publicações e a clareza da interface.
- Identificar possíveis barreiras de navegação no feed, chat e filtro.
- 
- Testar a acessibilidade da aplicação para perfis variados, incluindo usuários com pouca familiaridade tecnológica.
- 
-


## Seleção dos participantes

- Moradores de diferentes idades, que utilizam ou desejam utilizar a aplicação para reportar problemas, acessar informações e interagir com vizinhos.
- Pessoas com diferentes níveis de familiaridade tecnológica, incluindo iniciantes e usuários frequentes de redes sociais.
- Representantes de ONGs ou da Prefeitura, responsáveis por monitorar alertas e coordenar ações locais.
- Comerciantes do bairro, interessados em divulgar produtos e serviços.

  
**Quantidade recomendada:**
Mínimo: 5 participantes.
Ideal: Entre 18 e 60 para maior diversidade.



## Definição de cenários de teste


**Cenário 1** - Criar uma publicação no feed

**Objetivo:** Avaliar a facilidade do usuário em criar qualquer tipo de publicação

**Contexto:**  Usuário deseja registrar uma informação no bairro (ex.: anúncio, evento ou aviso)

**Tarefa:**  Abrir a aplicação → Selecionar “Criar item” → Adicionar título, descrição, imagem → Publicar

**Critérios de sucesso:**
- O usuário consegue abrir feed e criar uma publicação sem dificuldades.
- O título, descrição e imagem são adicionados corretamente.
- A publicação é exibida corretamente no feed para todos os usuários.
  


**Cenário 2** - Filtrar postagens por categoria

**Objetivo:** Testar eficiência na navegação por categorias

**Contexto:**  Usuário deseja visualizar apenas postagens da categoria “Saúde”

**Tarefa:**  Abrir feed → Selecionar filtro “Saúde” → Visualizar postagens

**Critérios de sucesso:** 
- O usuário consegue localizar e selecionar o filtro de categoria facilmente.
- As postagens da categoria correta são exibidas sem erros.
- O usuário consegue navegar entre as postagens filtradas sem dificuldades.



**Cenário 3** - Interagir com postagem

**Objetivo:** Avaliar experiência em curtir, não curtir e comentar

**Contexto:**  Usuário encontra uma postagem

**Tarefa:**  Curtir a postagem → Não curti → Escrever comentário 

**Critérios de sucesso:** 
- O botão de curtida funciona corretamente e muda de estado.
- O botão de não curtida funciona corretamente e muda de estado
- O comentário é enviado e exibido corretamente na postagem.



**Cenário 4** - Interagir com postagem

**Objetivo:** Avaliar experiência em curtir, comentar e compartilhar

**Contexto:**  Usuário encontra uma postagem sobre evento esportivo

**Tarefa:**  Curtir a postagem → Não curti → Escrever comentário 

**Critérios de sucesso:** 
- O botão de curtida funciona corretamente e muda de estado.
- O comentário é enviado e exibido corretamente na postagem.



**Cenário 5** - Alterar status de publicações

**Objetivo:** Verificar se os usuários conseguem alterar corretamente o status de uma publicação feita por moradores.

**Contexto:** Um usuário acessa o feed e precisa atualizar o status de uma publicação para refletir seu andamento.

**Tarefa:** 
Acessar o feed. 
Localizar a publicação desejada.
Clicar na opção de alterar status.
Selecionar um novo status (ex: “Em andamento”, “Resolvido”, “Pendente”).
Confirmar e salvar a alteração.

**Critério(s) de Sucesso(s):**
- O usuário consegue localizar a publicação desejada sem dificuldades.
- O status da publicação pode ser alterado sem erros.

  

**Cenário 6** - Adicionar comentários às publicações

**Objetivo:** Testar se todos os usuários (moradores, ONGs, Prefeitura) conseguem comentar publicações, promovendo interação e atualização de informações.

**Contexto:** Após visualizar uma publicação, o usuário deseja deixar um comentário.

**Tarefa:** 
Acessar o feed.
Localizar a publicação desejada.
Escrever um comentário.
Enviar/publicar o comentário.

**Critério(s) de Sucesso(s):**
- A publicação correta é localizada facilmente.
- O campo de comentários é visível e funcional para todos os usuários.
- O comentário é exibido imediatamente.
- O comentário aparece com o nome do usuário.



**Cenário 7** - Excluir comentários de usuários

**Objetivo:** Avaliar a facilidade com que o administrador consegue localizar e remover comentários inapropriados.

**Contexto:** O administrador identificou comentários que violam regras da plataforma ou são irrelevantes e precisa removê-los do feed.

**Tarefa:** Acessar a publicação verificar os comentários, selecionar o comentário que deve ser removido e efetuar a exclusão.

**Critério(s) de Sucesso(s):**
- O administrador consegue localizar o comentário sem dificuldades.
- O comentário é removido corretamente e não aparece mais no feed.
- O restante da publicação permanece intacto e funcional.


**Cenário 8** - Receber notificações

**Objetivo:** Verificar se os usuários recebem notificações sobre ações relacionadas às publicações em que estão envolvidos.

**Contexto:** Um usuário (morador, ONG ou Prefeitura) interage com uma publicação é notificado quando houver algum comentários, envio de mensagem.

**Tarefa:** 
Criar ou interagir com uma publicação (comentar ou curtir)
Verificar se uma notificação é recebida
A notificação leva diretamente à publicação correta ao ser clicada

**Critério(s) de Sucesso(s):**
- O usuário recebe notificações relevantes apenas sobre publicações com as quais interagiu
- As notificações são visíveis
- A notificação leva o usuário diretamente à ação ou publicação relacionada





## Métodos de coleta de dados

Os dados coletados devem ajudar a entender a experiência dos usuários e os dados podem ser coletados por observação direta incluindo métricas quantitativas (quantidade de cliques, número de erros, tempo gasto para cada tarefa etc.), métricas qualitativas (dificuldades, comentários etc.) e questionários pós-teste (A interface foi fácil de entender? Você encontrou dificuldades em alguma etapa? O que poderia ser melhorado?)

Para cada voluntário do teste, é fundamental coletar e apresentar todos os dados/métricas previamente definidos, mas não se esqueça: atendendo à LGPD (Lei Geral de Proteção de Dados), nenhum dado sensível, que permita identificar o voluntário, deverá ser apresentado).

As referências abaixo irão auxiliá-lo na geração do artefato "Plano de Testes de Usabilidade".

> **Links Úteis**:
> - [Teste De Usabilidade: O Que É e Como Fazer Passo a Passo (neilpatel.com)](https://neilpatel.com/br/blog/teste-de-usabilidade/)
> - [Teste de usabilidade: tudo o que você precisa saber! | by Jon Vieira | Aela.io | Medium](https://medium.com/aela/teste-de-usabilidade-o-que-voc%C3%AA-precisa-saber-39a36343d9a6/)
> - [Planejando testes de usabilidade: o que (e o que não) fazer | iMasters](https://imasters.com.br/design-ux/planejando-testes-de-usabilidade-o-que-e-o-que-nao-fazer/)
> - [Ferramentas de Testes de Usabilidade](https://www.usability.gov/how-to-and-tools/resources/templates.html)
