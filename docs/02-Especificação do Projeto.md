# Especificações do Projeto

## Personas
<figure>
  <img src=https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-2-e2-proj-int-t5-conectabairro/blob/fa5056424fa643286a5ed250540ef196725ed0b0/docs/img/persona1.png
    <figcaption>
</figure>
<figure>
  <img src=https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-2-e2-proj-int-t5-conectabairro/blob/fa5056424fa643286a5ed250540ef196725ed0b0/docs/img/persona2.png
    <figcaption>
</figure>
<figure>
  <img src=https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-2-e2-proj-int-t5-conectabairro/blob/fa5056424fa643286a5ed250540ef196725ed0b0/docs/img/persona3.png
    <figcaption>
</figure>
<figure>
  <img src=https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-2-e2-proj-int-t5-conectabairro/blob/fa5056424fa643286a5ed250540ef196725ed0b0/docs/img/persona4.png
    <figcaption>
</figure>
<figure>
  <img src=https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-2-e2-proj-int-t5-conectabairro/blob/fa5056424fa643286a5ed250540ef196725ed0b0/docs/img/persona5.png
    <figcaption>
</figure>
<figure>
  <img src=https://github.com/ICEI-PUC-Minas-PMV-ADS/pmv-ads-2025-2-e2-proj-int-t5-conectabairro/blob/fa5056424fa643286a5ed250540ef196725ed0b0/docs/img/persona6.png
    <figcaption>
</figure>


| **Nome**            | **Idade** | **Ocupação**                           | **Comportamento**                                                                                                                                      | **Objetivos no sistema**                                                                                               |
|----------------------|-----------|-----------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------|-------------------------------------------------------------------------------------------------------------------------|
| **Maria Silva**     | 35 anos   | Professora de ensino fundamental        | - Preocupada com a segurança dos filhos no trajeto escola–casa.<br>- Costuma tirar fotos de buracos, postes apagados ou lixo acumulado.<br>- Consome produtos e serviços do próprio bairro. | - Criar alertas de forma rápida.<br>- Ter retorno sobre problemas que afetam sua família.<br>- Receber promoções e serviços locais. |
| **Dona Ana**        | 68 anos   | Aposentada                              | - Vive há décadas no bairro e conhece bem os vizinhos.<br>- Reclama principalmente de iluminação e acúmulo de lixo perto de praças.                     | - Reportar problemas de forma simples (com ajuda de familiares ou vizinhos).<br>- Acompanhar melhorias feitas pela prefeitura. |
| **Bruno Seixas**| 28 anos   | Desempregado                            | - Atualmente sem emprego.<br>- Enfrenta dificuldades para encontrar trabalho em sua região.                                                             | - Procurar emprego ou freelancers.<br>- Divulgar serviço e currículo em um espaço confiável do bairro.                     |
| **Carlos Mendes**   | 45 anos   | Diretor de Zeladoria Urbana (Prefeitura) | - Responsável por equipes de manutenção da cidade.<br>- Cobrado por resultados pelos superiores e população.                                             | - Monitorar alertas em tempo real.<br>- Responder com status (“Em andamento”, “Resolvido”, “Pendente”).                     |
| **Andreia Ferreira**| 38 anos   | Auxiliar da ONG                         | - Responsável por dar feedbacks de respostas ao público.<br>- Direcionar grupos e pessoas para voluntários e locais de atenção.                          | - Visualizar alertas criados pela população.<br>- Publicar imagens e dados de trabalhos feitos pela ONG.                    |
| **José Pereira**| 45 anos   | Comerciante (dono de mercearia do bairro)                         | - Sempre atento às movimentações do bairro para manter o comércio seguro.<br>- Costuma divulgar promoções nas redes sociais, mas sente falta de um meio mais eficiente para alcançar clientes próximos.                          | - Divulgar promoções e serviços para moradores do bairro. 


## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

|EU COMO... `PERSONA`| QUERO/PRECISO ... `FUNCIONALIDADE` |PARA ... `MOTIVO/VALOR`                 |
|--------------------|------------------------------------|----------------------------------------|
| Maria Silva (Moradora) | Alertar sobre problemas no bairro de forma rápida | Garantir a segurança dos meus filhos no trajeto |
| Maria Silva (Moradora) | Saber sobre promoções e serviços do bairro | Economizar tempo nas compras e apoiar o comércio local |
| Dona Ana (Moradora) | Informar problemas no bairro de forma simples | Acompanhar melhorias feitas pela prefeitura sem processos complicados |
| Dona Ana (Moradora) | Acompanhar o andamento das soluções nos alertas criados | Saber se a iluminação e limpeza das praças estão sendo realizadas |
| Bruno Seixas (Morador) | Encontrar oportunidades de emprego e serviço no bairro | Aumentar minhas chances de conseguir renda no próprio bairro |
| Bruno Seixas (Morador) | Divulgar meu currículo e serviços de freelancer | Ser encontrado facilmente pelos moradores e comerciantes locais |
| Andreia Ferreira (ONG) | Ficar por dentro dos alertas do bairro | Direcionar voluntários e recursos de forma eficiente |
| Andreia Ferreira (ONG) | Mostrar os trabalhos realizados pela ONG | Dar retorno à população |
| Carlos Mendes (Prefeitura) | Ver quais problemas precisam de atenção primeiro | Planejar a manutenção do bairro |
| Carlos Mendes (Prefeitura) | Atualizar o status dos alertas | Manter os moradores informados e reduzir reclamações |
| José (Comerciante) | Divulgar promoções e descontos especiais | Para que os moradores vejam as ofertas da minha mercearia |
| José (Comerciante) | Acompanhar o desempenho das minhas promoções | Entender quais ofertas geram mais interesse e melhorar minhas vendas |


## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A aplicação deve permitir que usuários do tipo moradores, ONGs e prefeitura efetuem seu próprio registro (autorregistro) e tenham acesso às funções de gerenciamento de seus dados pessoais, permitindo consultar, atualizar e excluir essas informações. | ALTA |
|RF-002| A aplicação deve permitir ao usuário realizar login com e-mail e senha. | ALTA |
|RF-003| A aplicação deve permitir ao usuário redefinir sua senha na tela de login, caso a tenha esquecido. | ALTA |
|RF-004| A aplicação deve permitir que os usuários do tipo moradores, ONGs e prefeitura criem e administrem publicações, preenchendo os campos obrigatórios: título, descrição, categorias (como anúncios, avisos, eventos etc.), status somente da sua publicação, imagens e vídeos curtos. Toda nova publicação deve ser registrada automaticamente com o status “em aberto”. | ALTA |
|RF-005| A aplicação deve permitir aos usuários a possibilidade de interagir nas publicações, seja através de reações como “gostei” e “não gostei”, ou pela inclusão de comentários. | ALTA |
|RF-006| A aplicação deve enviar notificações referentes a alterações de status, comentários e curtidas. | ALTA |
|RF-007| A aplicação deve permitir que os usuários filtrem publicações por categoria, data ou palavra-chave. | ALTA |
|RF-008| A aplicação deve permitir que ONGs e Prefeitura alterem o status de todas publicações e adicionem comentários em uma publicação. | ALTA |
|RF-009| O sistema deve permitir que os usuários entrem em contato com o anunciador via chat dentro da aplicação. | MÉDIA |
|RF-010| O sistema deve permitir que o administrador remova publicações existentes. | ALTA |
|RF-011| O sistema deve permitir que o administrador exclua comentários feitos pelos usuários. | ALTA |
|RF-012| O sistema deve permitir que o administrador desative contas de usuários por meio de exclusão lógica, alterando o status do perfil em vez de realizar a exclusão física.| MÉDIA |
|RF-013| A aplicação deve permitir que o usuário solicite a troca de endereço para o administrador. | MÉDIA |
|RF-014| O sistema deve permitir somente ao administrador realizar a alteração de endereço do usuário. | MÉDIA |
|RF-015| O sistema deve permitir que o usuário, após efetuar o login, tenha acesso ao feed geral com todas as publicações e alertas criados. | ALTA |
|RF-016| O sistema deve exibir os comentários adicionados ao Post, ao expandi-lo | ALTA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
|RNF-001| O código deve seguir boas práticas de desenvolvimento, de acordo com as Heurísticas de Nielsen.|  ALTA  |
|RNF-002| As informações cadastrais dos usuários devem estar acessíveis apenas ao próprio usuário e aos desenvolvedores autorizados. |  ALTA  |
|RNF-003| A aplicação deve ser compatível com os principais navegadores: Chrome, Firefox, Edge e Safari. |  ALTA  |
|RNF-004| A aplicação deve oferecer opção de alternância para modo escuro.|  ALTA  |
|RNF-005| A aplicação deve ser responsiva, funcionando integralmente em smartphones, tablets e computadores. |  ALTA  |
|RNF-006| Todas as comunicações entre cliente e servidor devem ser criptografadas utilizando HTTPS/TLS.|  ALTA  |
|RNF-007| A aplicação deve adotar o padrão de arquitetura MVC, garantindo separação entre lógica de negócios, interface de usuário e controle de fluxo. | ALTA|
|RNF-008| A aplicação deve ser desenvolvida na linguagem de programação C#. |  ALTA  |
|RNF-009| A aplicação deve utilizar o framework Bootstrap para estilização e componentes de interface. |  ALTA  |


## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O prazo para a entrega do projeto é 07/12/2025|
|02| Atualmente, não há orçamento definido para o projeto.|
|03| Nossa equipe é composta por estudantes com diferentes áreas de conhecimento e habilidades complementares.|


## Diagrama de Casos de Uso

<img width="1170" height="684" alt="image" src="https://github.com/user-attachments/assets/1d2cb458-9fcc-42d4-a10a-b398a4908996" />




