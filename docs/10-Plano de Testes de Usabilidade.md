# Plano de Testes de Usabilidade

Os testes de usabilidade permitem avaliar a qualidade da interface com o usuário da aplicação interativa.

Um plano de teste de usabilidade deverá conter: 

## Definição do(s) objetivo(s)

Antes de iniciar os testes, é essencial definir o que se deseja avaliar na usabilidade do sistema. 
Alguns exemplos de objetivos são:
- Verificar se os usuários conseguem concluir tarefas essenciais sem dificuldades.
- Identificar barreiras na navegação e interação com o sistema.
- Avaliar a eficiência e a satisfação do usuário ao utilizar a interface.
- Testar a acessibilidade para diferentes perfis de usuários.

--

O objetivo deste plano é avaliar a usabilidade da aplicação ConectaBairro considerando a experiência real dos moradores e agentes da comunidade. Os objetivos específicos são:

- Verificar se os usuários conseguem fazer publicações de forma rápida e intuitiva.
- Avaliar se os usuários conseguem filtrar e localizar informações por categoria.
- Medir a facilidade de interação entre moradores nas publicações e a clareza da interface.
- Identificar possíveis barreiras de navegação no feed, chat e filtro.
- Avaliar a satisfação dos usuários quanto à facilidade de uso, estética e percepção de valor da aplicação.
- Testar a acessibilidade da aplicação para perfis variados, incluindo usuários com pouca familiaridade tecnológica



## Seleção dos participantes

Para garantir que o teste reflita o uso real do sistema, escolha participantes representativos do público-alvo.

**Critérios para selecionar participantes:**
- Perfis variados (experientes e iniciantes no sistema).
- Diferentes níveis de familiaridade com tecnologia.
- Pessoas com necessidades especiais (se aplicável).

**Quantidade recomendada:**
Mínimo: 5 participantes.
Ideal: Entre 8 e 12 para maior diversidade.
--

Para garantir que os testes reflitam o uso real do sistema, os participantes serão selecionados com base nas personas do projeto:

- Moradores de diferentes idades, que utilizam ou desejam utilizar a aplicação para reportar problemas, acessar informações e interagir com vizinhos.
- Pessoas com diferentes níveis de familiaridade tecnológica, incluindo iniciantes e usuários frequentes de redes sociais.
- Representantes de ONGs ou da Prefeitura, responsáveis por monitorar alertas e coordenar ações locais.
- Comerciantes do bairro, interessados em divulgar produtos e serviços.


## Definição de cenários de teste

Os cenários representam tarefas reais que os usuários executam no sistema. Neste projeto, cada grupo deverá definir, no mínimo, **CINCO cenários para a aplicação** e cada cenário deve incluir:

- Objetivo: O que será avaliado.
- Contexto: A situação que leva o usuário a interagir com o sistema.
- Tarefa: A ação que o usuário deve realizar.
- Critério de sucesso: Como determinar se a tarefa foi concluída corretamente.

**Exemplo: Cenário 1**

**Objetivo:** Avaliar a facilidade e eficiência do usuário em pesquisar, adicionar um produto ao carrinho e finalizar a compra sem dificuldades.

**Contexto:** O usuário deseja comprar um notebook para uso pessoal. Para isso, ele deverá entrar no site www.compras.com.br para buscar opções disponíveis, comparar preços, adicionar o produto ao carrinho e finalizar a compra com pagamento via cartão de crédito.

**Tarefa(s):** 
- Acessar o site e localizar a barra de pesquisa.
- Pesquisar por "notebook" e utilizar os filtros para refinar a busca (exemplo: marca, preço, processador).
- Escolher um dos notebooks listados e acessar a página do produto.
- Adicionar o produto ao carrinho.
- Finalizar a compra, preenchendo os dados de pagamento e endereço de entrega.
- Confirmar a transação e verificar a tela de pedido concluído.

**Critério(s) de Sucesso(s):**
- O usuário consegue encontrar e filtrar os produtos sem dificuldades.
- O produto é adicionado ao carrinho corretamente.
- O usuário consegue preencher as informações de pagamento e entrega sem erros.
- A compra é finalizada com sucesso, e o usuário visualiza a confirmação do pedido.
- Todo o processo ocorre em menos de 5 minutos, sem necessidade de assistência.

**Cenário 1** - Criar uma publicação no feed

**Objetivo:** Avaliar a facilidade do usuário em criar qualquer tipo de publicação

**Contexto:**  Usuário deseja registrar uma informação no bairro (ex.: anúncio, evento ou aviso)

**Tarefa:**  Abrir a aplicação → Selecionar “Nova Publicação” → Adicionar título, descrição, categoria, imagem/vídeo → Publicar

**Critérios de sucesso:**
- O usuário consegue abrir feed e criar uma publicação sem dificuldades.
- O título, descrição, categoria e imagem/vídeo são adicionados corretamente.
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

**Objetivo:** Avaliar experiência em curtir, comentar e compartilhar

**Contexto:**  Usuário encontra uma postagem sobre evento esportivo

**Tarefa:**  Curtir a postagem → Não curti → Escrever comentário 

**Critérios de sucesso:** 
- O botão de curtida funciona corretamente e muda de estado.
- O comentário é enviado e exibido corretamente na postagem.


**Cenário 4** - Interagir com postagem

**Objetivo:** Avaliar experiência em curtir, comentar e compartilhar

**Contexto:**  Usuário encontra uma postagem sobre evento esportivo

**Tarefa:**  Curtir a postagem → Não curti → Escrever comentário 

**Critérios de sucesso:** 
- O botão de curtida funciona corretamente e muda de estado.
- O comentário é enviado e exibido corretamente na postagem.


**Cenário 5** - Alterar status e comentar publicações

**Objetivo:** Avaliar a facilidade com que ONGs e Prefeitura conseguem alterar o status de publicações e adicionar comentários.

**Contexto:** Uma ONG ou o setor da Prefeitura precisa atualizar o andamento de uma ocorrência ou aviso criado por moradores.

**Tarefa:** Acessar a publicação no feed → Alterar o status da publicação (ex.: “Em andamento”, “Resolvido”, “Pendente”) → Adicionar um comentário informativo sobre a ação realizada → Salvar a alteração.

**Critério(s) de Sucesso(s):**
-O usuário consegue localizar a publicação desejada sem dificuldades.
-O status da publicação é alterado corretamente e refletido no feed.
-O comentário é adicionado e exibido corretamente na publicação.


**Cenário 7** - Excluir comentários de usuários

**Objetivo:** Avaliar a facilidade com que o administrador consegue localizar e remover comentários inapropriados.

**Contexto:** O administrador identificou comentários que violam regras da plataforma ou são irrelevantes e precisa removê-los do feed.

**Tarefa:** Acessar a publicação com comentários → Selecionar o comentário que deve ser removido  → Executar a ação de exclusão  → Confirmar a remoção do comentário.

**Critério(s) de Sucesso(s):**
- O administrador consegue localizar o comentário sem dificuldades.
- O comentário é removido corretamente e não aparece mais no feed.
- O restante da publicação permanece intacto e funcional.







## Métodos de coleta de dados

Os dados coletados devem ajudar a entender a experiência dos usuários e os dados podem ser coletados por observação direta incluindo métricas quantitativas (quantidade de cliques, número de erros, tempo gasto para cada tarefa etc.), métricas qualitativas (dificuldades, comentários etc.) e questionários pós-teste (A interface foi fácil de entender? Você encontrou dificuldades em alguma etapa? O que poderia ser melhorado?)

Para cada voluntário do teste, é fundamental coletar e apresentar todos os dados/métricas previamente definidos, mas não se esqueça: atendendo à LGPD (Lei Geral de Proteção de Dados), nenhum dado sensível, que permita identificar o voluntário, deverá ser apresentado).

As referências abaixo irão auxiliá-lo na geração do artefato "Plano de Testes de Usabilidade".

> **Links Úteis**:
> - [Teste De Usabilidade: O Que É e Como Fazer Passo a Passo (neilpatel.com)](https://neilpatel.com/br/blog/teste-de-usabilidade/)
> - [Teste de usabilidade: tudo o que você precisa saber! | by Jon Vieira | Aela.io | Medium](https://medium.com/aela/teste-de-usabilidade-o-que-voc%C3%AA-precisa-saber-39a36343d9a6/)
> - [Planejando testes de usabilidade: o que (e o que não) fazer | iMasters](https://imasters.com.br/design-ux/planejando-testes-de-usabilidade-o-que-e-o-que-nao-fazer/)
> - [Ferramentas de Testes de Usabilidade](https://www.usability.gov/how-to-and-tools/resources/templates.html)
