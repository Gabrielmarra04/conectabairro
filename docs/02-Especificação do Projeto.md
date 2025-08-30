# Especificações do Projeto

## Personas

<img src="img/Personas (1).png" alt="Logo" width="200">
| **Nome**            | **Idade** | **Ocupação**                           | **Comportamento**                                                                                                                                      | **Objetivos no sistema**                                                                                               |
|----------------------|-----------|-----------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------|
| **Maria Silva**     | 35 anos   | Professora de ensino fundamental        | - Preocupada com a segurança dos filhos no trajeto escola–casa.<br>- Costuma tirar fotos de buracos, postes apagados ou lixo acumulado.<br>- Consome produtos e serviços do próprio bairro. | - Criar alertas de forma rápida.<br>- Ter retorno sobre problemas que afetam sua família.<br>- Receber promoções e serviços locais. |
| **Dona Ana**        | 68 anos   | Aposentada                              | - Vive há décadas no bairro e conhece bem os vizinhos.<br>- Reclama principalmente de iluminação e acúmulo de lixo perto de praças.                     | - Reportar problemas de forma simples (com ajuda de familiares ou vizinhos).<br>- Acompanhar melhorias feitas pela prefeitura. |
| **Matheus Henrique**| 28 anos   | Desempregado                            | - Atualmente sem emprego.<br>- Enfrenta dificuldades para encontrar trabalho em sua região.                                                             | - Procurar emprego ou freelancers.<br>- Divulgar serviço e currículo em um espaço confiável do bairro.                     |
| **Carlos Mendes**   | 45 anos   | Diretor de Zeladoria Urbana (Prefeitura) | - Responsável por equipes de manutenção da cidade.<br>- Cobrado por resultados pelos superiores e população.                                             | - Monitorar alertas em tempo real.<br>- Responder com status (“Em andamento”, “Resolvido”, “Pendente”).                     |
| **Andreia Ferreira**| 38 anos   | Auxiliar da ONG                         | - Responsável por dar feedbacks de respostas ao público.<br>- Direcionar grupos e pessoas para voluntários e locais de atenção.                          | - Visualizar alertas criados pela população.<br>- Publicar imagens e dados de trabalhos feitos pela ONG.                    |
| **José Pereira**| 45 anos   | Comerciante (dono de mercearia do bairro)                         | - Sempre atento às movimentações do bairro para manter o comércio seguro.<br>- Costuma divulgar promoções nas redes sociais, mas sente falta de um meio mais eficiente para alcançar clientes próximos.                          | - Divulgar promoções e serviços para moradores do bairro. 


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
|Maria Silva (Moradora)| quero criar alertas com fotos |  para relatar problemas no bairro rapidamente|
|Maria Silva (Moradora)| quero receber notificações sobre promoções e serviços|para economizar tempo nas minhas compras do dia a dia e apoiar o comércio local|
|                       |
|Dona Ana (Moradora) | quero uma interface simples  | para usar a aplicação sem dificuldades |
|Dona Ana (Moradora)| quero poder enviar os alertas que eu criei para meus familiares e vizinhos | para que eles possam me ajudar a acompanhar a resolução e saber o que está acontecendo|
|                     |
|Matheus Henrique (Morador)| quero divulgar meu currículo e meus serviços em um espaço de confiança do bairro| para que os comerciantes e moradores possam me encontrar e oferecer trabalhos freelancers ou temporários | 
| Matheus Henrique (Morador) | quero receber alertas de novas vagas de emprego que sejam relevantes para meu perfil profissional | para não perder nenhuma oportunidade de trabalho na minha região|
|                       |
|Andreia Ferreira (ONG)|quero visualizar alertas criados pelos moradores |para direcionar voluntáris e recursos de forma eficiente|
|Andreia Ferreira (ONG)|quero publicar imagens e informações sobre os trabalhos realizados pela ONG| para dar um retorno à população e mostrar que os alertas estão gerando resultados concretos|
|                     |
|                     |                                               |                                                    |
|                     |
|José (Comerciante) | quero cadastrar promoções e descontos especiais|para que os moradores do bairro possam ver as ofertas da minha mercearia|
|José (Comerciante) | quero acompanhar o desempenho das minhas promoções|para entender quais ofertas geram mais interesse e ajustar minhas estratégias para aumentar minhas vendas|


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve permitir aos usuários criar cadastro | ALTA |
|RF-002| A aplicação deve permitir ao usuário realizar login com e-mail e senha | ALTA |
|RF-003| A aplicação deve permitir ao usuário trocar senha de login | ALTA |
|RF-004| A aplicação deve permitir ao usuário criar e editar anúncios, informações como categorias, imagens e vídeos curtos em cada publicação | ALTA |
|RF-005| A aplicação deve permitir que usuários interajam em outras publicações | ALTA |
|RF-006| A aplicação deve enviar notificação como alteração de status, comentários e curtidas |  ALTA  |
|RF-007| A aplicação deve permitir os usuários filtrarem publicações por categoria, data ou palavra-chave | ALTA |
|RF-008| A aplicação deve permitir que ONGs e Prefeitura alterem status e adicione relatórios de conclusão dos avisos | ALTA |
|RF-009| Ser possível entrar em contato com o Anunciador Via Chat na própria Aplicação | ALTA |
|RF-010| A aplicação deve permitir ao Admin excluir publicações, apagar comentários e deletar contas de usuários | ALTA |
|RF-011| A aplicação deve permitir o usuário solicitar a troca de endereço para o Admin | ALTA |
|RF-012| O sistema deve permitir o usuário a modificar seus dados básicos com agilidade (Nome, email, senha e telefone) | ALTA |





### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| Os formulários devem apresentar mensagens de erro claras e em tempo real, indicando como o usuário pode corrigir |  ALTA  |
|RNF-002| O Código deve seguir boas práticas de desenvolvimento de acordo com as Heurísticas de Nielsen |  ALTA  |
|RNF-003| As informações cadastrais dos usuários devem estar disponíveis apenas para eles e os desenvolvedores |  ALTA  |
|RNF-004| A aplicação deve ser compatível com os principais navegadores como Chrome, Firefox, Edge e Safari |  ALTA  |
|RNF-005| A aplicação deve ter uma opção para modo escuro |  ALTA  |
|RNF-006| A aplicação deve ser totalmente utilizável em smartphones, tablets e computadores, sem perda de funcionalidades |  ALTA  |
|RNF-007| Todas as comunicações entre cliente e servidor devem ser criptografadas via HTTPS/TLS |  ALTA  |
|RNF-008| A aplicação deve ter uma interface simples, com botões visíveis e textos claros |  ALTA  |
|RNF-009| Todas as telas do sistema devem seguir o mesmo padrão visual de cores, tipografia e posicionamento de botões. |  ALTA  |
|RNF-010| Todas as alterações no código devem estar vinculadas a um identificador único de requisito ou ticket de manutenção no sistema de gerenciamento |  ALTA  |
|RNF-011| O código deve ser estruturado de forma organizada para facilitar futuras atualizações e manutenção |  ALTA  |
|RNF-012|  |  ALTA  |


## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O prazo para a entrega do projeto é 07/12/2025|
|02| Atualmente, não há orçamento definido para o projeto.|
|03| Nossa equipe é composta por estudantes com diferentes áreas de conhecimento e habilidades complementares.|


## Diagrama de Casos de Uso

<img width="1918" height="1079" alt="image" src="https://github.com/user-attachments/assets/dbc59050-89fb-4ae7-a1ba-4fbb1798d923" />

