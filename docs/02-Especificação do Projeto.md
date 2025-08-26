# Especificações do Projeto

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
| ONG | receber alertas relevantes e divulgar minhas ações| fortalecer o engajamento comunitário|


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
|RNF-001| Os formulários devem apresentar mensagens de erro claras e em tempo real, indicando como o usuário pode corrigir. |  ALTA  |
|RNF-002| O Código deve seguir boas práticas de desenvolvimento com comentários claros e padrões de codificação. |  ALTA  |
|RNF-003| O sistema deve estar disponível pelo menos 99% das 24 horas do dia, nos 7 dias da semana. |  ALTA  |
|RNF-004| A consulta das informações no sistema deve demorar no máximo 5 segundos. |  ALTA  |
|RNF-005| As informações cadastrais dos usuários devem estar disponíveis apenas para eles e os desenvolvedores. |  ALTA  |
|RNF-006| Interface intuitiva e acessível para todas as idades. |  ALTA  |
|RNF-007| A aplicação deve ser compatível com os principais navegadores. |  ALTA  |
|RNF-008| A aplicação deve ter uma opção para modo escuro. |  ALTA  |
|RNF-009| 
|RNF-010| 
|RNF-011| 
|RNF-012| 


## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do 2° semestre de 2025|
|02| Não pode ser desenvolvido um módulo de backend        |
|03| Projeto realizado somente pela equipe pré-definida    |
|04|                                   |
|05|                                   |


## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
