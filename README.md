# Calculadora de Dano Tormenta20
Este projeto consiste em uma ferramenta de software desenvolvida em C# para auxiliar jogadores e mestres do sistema de RPG Tormenta20 no cálculo de dano médio. A aplicação automatiza as projeções de dano considerando variáveis complexas como margem de ameaça e multiplicadores de crítico.

## Funcionalidades Principais
- Cálculo de Dano Base: Processamento de médias para diferentes combinações de dados e bônus numéricos fixos.
- Simulação de Crítico: Aplicação automática da margem de ameaça e do multiplicador de crítico sobre o dano final.
- Modificadores Específicos: Inclusão de cálculos para Concentração de Combate, Dilacerante e Lancinante (versão padrão e revisada).
- Acúmulo de Ataques: Sistema de somatória para múltiplos ataques.
- Interface Gráfica: Ambiente visual para entrada de dados e exibição de resultados em tempo real.

## Requisitos de Sistema
- SDK do .NET 6.0 ou superior.
- Sistema Operacional Windows (para execução do framework Windows Forms).

## Instruções de Execução
Para executar a aplicação via terminal, utilize os seguintes comandos:
1. Navegue até o diretório raiz do projeto onde se encontra o arquivo .csproj.
2. Execute o comando para compilar e iniciar a aplicação:
```dotnet run```

## Estrutura do Projeto
O código está organizado seguindo as práticas recomendadas de separação de responsabilidades no ecossistema .NET:
- Program.cs: Ponto de entrada da aplicação e configuração do ciclo de vida do processo.
- Form.cs: Implementação da lógica de negócio, processamento matemático dos dados e manipulação de eventos de interface.
- Form.Designer.cs: Definição técnica da estrutura visual, instanciamento de componentes e gerenciamento de recursos gráficos.

## Lógica de Cálculo
O algoritmo processa as entradas de texto para extrair a quantidade de dados e faces. A média é calculada através da fórmula:
((Quantidade + (Quantidade * Faces)) / 2)

Os resultados são exibidos em oito categorias distintas para permitir a comparação imediata entre diferentes cenários de combate e otimização de personagem.