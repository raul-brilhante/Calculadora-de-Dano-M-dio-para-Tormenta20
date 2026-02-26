# Calculadora de Dano Médio para Tormenta20
Este projeto consiste em uma ferramenta de software desenvolvida em C# para auxiliar jogadores e mestres do sistema de RPG Tormenta20 no cálculo de dano médio. A aplicação automatiza as projeções de dano considerando variáveis complexas como margem de ameaça e multiplicadores de crítico.

## Funcionalidades Principais
- Cálculo de Dano Base: Processamento de médias para diferentes combinações de dados e bônus numéricos fixos.
- Simulação de Crítico: Aplicação automática da margem de ameaça e do multiplicador de crítico sobre o dano final.
- Modificadores Específicos: Inclusão de cálculos para Concentração de Combate, Dilacerante e Lancinante (versão padrão e revisada).
- Acúmulo de Ataques: Sistema de somatória para múltiplos ataques.
- Interface Gráfica: Ambiente visual para entrada de dados e exibição de resultados em tempo real.

## Versões Disponíveis para Download
Na seção de Releases, estão disponíveis dois formatos de executáveis:

1. Versão Independente (Self-Contained): Possui aproximadamente 120 MB. Esta versão inclui internamente todos os componentes necessários do .NET 9.0, permitindo a execução imediata em qualquer computador Windows sem a necessidade de instalações prévias.
2. Versão Dependente (Framework-Dependent): Possui tamanho reduzido, na escala de KBs. Esta versão exige que o usuário tenha o .NET Desktop Runtime 9.0 instalado no sistema operacional para funcionar.

## Requisitos do Sistema
- SDK do .NET 9.0 ou superior para compilação.
- Sistema Operacional Windows para execução do framework Windows Forms.

## Instruções de Execução via Código
Para executar a aplicação através do terminal, utilize os seguintes comandos:
1. Navegue até o diretório raiz do projeto onde se encontra o arquivo .csproj.
2. Execute o comando para compilar e iniciar a aplicação:
`dotnet run`

## Estrutura do Projeto
O código está organizado seguindo as práticas recomendadas de separação de responsabilidades no ecossistema .NET:
- Program.cs: Ponto de entrada da aplicação e configuração do ciclo de vida do processo.
- Form.cs: Implementação da lógica de negócio, processamento matemático dos dados e manipulação de eventos de interface.
- Form.Designer.cs: Definição técnica da estrutura visual, instanciamento de componentes e gerenciamento de recursos gráficos.

## Lógica de Cálculo
O algoritmo processa as entradas de texto para extrair a quantidade de dados e faces. A média é calculada através da fórmula:
((Quantidade + (Quantidade * Faces)) / 2)

Os resultados são exibidos em oito categorias distintas para permitir a comparação imediata entre diferentes cenários de combate e otimização de personagem.

# Aviso de Segurança
Devido à ausência de uma assinatura digital paga, o Windows SmartScreen pode exibir um alerta ao iniciar o aplicativo pela primeira vez. O software é seguro e de código aberto. Para prosseguir, clique em "Mais informações" e selecione "Executar assim mesmo".
