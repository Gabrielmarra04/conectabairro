# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas
| **Nome**            | **Idade** | **Ocupação**                           | **Comportamento**                                                                                                                                      | **Objetivos no sistema**                                                                                               |
|----------------------|-----------|-----------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------|
| **Maria Silva**     | 35 anos   | Professora de ensino fundamental        | - Preocupada com a segurança dos filhos no trajeto escola–casa.<br>- Costuma tirar fotos de buracos, postes apagados ou lixo acumulado.<br>- Consome produtos e serviços do próprio bairro. | - Criar alertas de forma rápida.<br>- Ter retorno sobre problemas que afetam sua família.<br>- Receber promoções e serviços locais. |
| **Dona Ana**        | 68 anos   | Aposentada                              | - Vive há décadas no bairro e conhece bem os vizinhos.<br>- Reclama principalmente de iluminação e acúmulo de lixo perto de praças.                     | - Reportar problemas de forma simples (com ajuda de familiares ou vizinhos).<br>- Acompanhar melhorias feitas pela prefeitura. |
| **Matheus Henrique**| 28 anos   | Desempregado                            | - Atualmente sem emprego.<br>- Enfrenta dificuldades para encontrar trabalho em sua região.                                                             | - Procurar emprego ou freelancers.<br>- Divulgar serviço e currículo em um espaço confiável do bairro.                     |
| **Carlos Mendes**   | 45 anos   | Diretor de Zeladoria Urbana (Prefeitura) | - Responsável por equipes de manutenção da cidade.<br>- Cobrado por resultados pelos superiores e população.                                             | - Monitorar alertas em tempo real.<br>- Responder com status (“Em andamento”, “Resolvido”, “Pendente”).                     |
| **Andreia Ferreira**| 38 anos   | Auxiliar da ONG                         | - Responsável por dar feedbacks de respostas ao público.<br>- Direcionar grupos e pessoas para voluntários e locais de atenção.                          | - Visualizar alertas criados pela população.<br>- Publicar imagens e dados de trabalhos feitos pela ONG.                    |


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Morador  | criar alertas de problemas no bairro           |  para melhorar a segurança e qualidade de vida             |
|Comerciante       | divulgar meus serviços                 | alcançar mais clientes locais |
|Prefeitura (Admin)| moderar conteúdos e atualizar status de alertas| manter a comunidade informada e engajada | 

Apresente aqui as histórias de usuário que são relevantes para o projeto de sua solução. As Histórias de Usuário consistem em uma ferramenta poderosa para a compreensão e elicitação dos requisitos funcionais e não funcionais da sua aplicação. Se possível, agrupe as histórias de usuário por contexto, para facilitar consultas recorrentes à essa parte do documento.

> **Links Úteis**:
> - [Histórias de usuários com exemplos e template](https://www.atlassian.com/br/agile/project-management/user-stories)
> - [Como escrever boas histórias de usuário (User Stories)](https://medium.com/vertice/como-escrever-boas-users-stories-hist%C3%B3rias-de-usu%C3%A1rios-b29c75043fac)
> - [User Stories: requisitos que humanos entendem](https://www.luiztools.com.br/post/user-stories-descricao-de-requisitos-que-humanos-entendem/)
> - [Histórias de Usuários: mais exemplos](https://www.reqview.com/doc/user-stories-example.html)
> - [9 Common User Story Mistakes](https://airfocus.com/blog/user-story-mistakes/)

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| Ser possível entrar em contato com o Anunciador Via Chat na própria Aplicação. | ALTA |
|RF-002| O sistema deve enviar notificação como alteração de Status, comentário e curtida. | ALTA |
|RF-003| O sistema deve permitir ao usuário criar anúncios e colocar informações. | ALTA |
|RF-004| Possibilidade de adicionar categorias, imagens e vídeos curtos em cada publicação. | ALTA |
|RF-005| O sistema deve permitir ao usuário realizar login com e-mail e senha. | ALTA |
|RF-006| Filtrar publicações por categoria, data ou palavra-chave. |  ALTA  |
|RF-007| O sistema deve permitir ao usuário interagir nas publicações. | ALTA |
|RF-008| 
|RF-009| 
|RF-010| 
|RF-011| 
|RF-012| 





### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| 
|RNF-002| 
|RNF-003| O Código deve seguir boas práticas de desenvolvimento com comentários claros e padrões de codificação. |  ALTA  |
|RNF-004| A consulta das informações no sistema deve demorar no máximo 5 segundos. |  ALTA  |
|RNF-005| As informações cadastrais dos usuários devem estar disponíveis apenas para eles e os desenvolvedores. |  ALTA  |
|RNF-006| Interface intuitiva e acessível para todas as idades. |  ALTA  |
|RNF-007| A aplicação deve ser compatível com os principais navegadores.     |  ALTA  |
|RNF-008| 
|RNF-009| 
|RNF-010| 
|RNF-011| 
|RNF-012| 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| Não pode ser desenvolvido um módulo de backend        |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
