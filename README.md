# 🚀 SpaceGuard - Sistema de Monitoramento Ambiental por Satélites

## Integrantes | RMs
* Luan Orlandelli Ramos | 554747
* Arthur Bobadilla Franchi | 555056
* Jorge Luiz Silva Santos | 554418

## 📖 Sobre o Projeto

O **SpaceGuard** é uma aplicação desenvolvida em C# (.NET 8) para auxiliar no monitoramento ambiental utilizando conceitos relacionados à observação terrestre por satélites.

O projeto foi criado como parte da **Global Solution FIAP**, alinhado ao tema da utilização de tecnologias espaciais para monitoramento e prevenção de desastres ambientais.

A solução permite o cadastro de satélites, sensores ambientais e alertas de risco, simulando um sistema capaz de registrar ocorrências de incêndios e enchentes monitoradas por sensores e satélites.

---

# 🎯 Problema

Eventos climáticos extremos, queimadas e enchentes geram impactos ambientais, sociais e econômicos significativos.

Atualmente, sistemas de monitoramento ambiental utilizam sensores e satélites para identificar riscos em tempo real, permitindo ações preventivas antes que os problemas se agravem.

O desafio proposto pela Global Solution consiste em desenvolver uma solução alinhada ao tema espacial, utilizando conceitos de desenvolvimento de software e Programação Orientada a Objetos.

---

# 💡 Solução Proposta

O SpaceGuard simula um sistema de monitoramento ambiental capaz de:

* Cadastrar satélites responsáveis pela observação terrestre;
* Cadastrar sensores ambientais;
* Registrar alertas de incêndios;
* Registrar alertas de enchentes;
* Armazenar histórico de ocorrências;
* Gerar relatórios de monitoramento;
* Validar dados de entrada;
* Tratar erros e exceções de forma segura.

---

# 🏗 Estrutura do Projeto

```text
SpaceGuard
│
├── Abstracts
│   └── EntidadeEspacial.cs
│
├── Interfaces
│   └── IMonitoravel.cs
│
├── Models
│   ├── Satelite.cs
│   ├── Sensor.cs
│   ├── Alerta.cs
│   ├── AlertaIncendio.cs
│   └── AlertaEnchente.cs
│
├── Services
│   └── MonitoramentoService.cs
│
├── Structs
│   └── Coordenada.cs
│
├── Partials
│   ├── Relatorio.cs
│   └── Relatorio.Historico.cs
│
├── Utils
│   └── ConsoleHelper.cs
│
└── Program.cs
```

---

# ⚙ Funcionalidades

### 1. Cadastro de Satélites

Permite registrar satélites utilizados para monitoramento ambiental.

### 2. Cadastro de Sensores

Permite registrar sensores ambientais responsáveis pela coleta de dados.

### 3. Registro de Alertas

O sistema permite registrar:

* Alertas de incêndio;
* Alertas de enchente.

Cada alerta contém:

* Descrição;
* Nível de risco;
* Coordenadas geográficas;
* Data e hora de registro.

### 4. Listagem de Dados

O usuário pode consultar:

* Satélites cadastrados;
* Sensores cadastrados;
* Alertas registrados.

### 5. Relatórios

O sistema gera um resumo contendo:

* Quantidade total de alertas;
* Histórico completo;
* Data e hora de geração.

---

# 🧠 Conceitos de C# Aplicados

## Modelagem de Domínio e Programação Orientada a Objetos

### Classes

Foram utilizadas diversas classes para representar as entidades do domínio:

* Satelite
* Sensor
* Alerta
* AlertaIncendio
* AlertaEnchente
* Relatorio

### Encapsulamento

Os atributos foram protegidos utilizando modificadores de acesso e propriedades controladas.

Exemplo:

```csharp
public string Nome { get; private set; }
```

---

## Herança

A classe Alerta serve como classe base para outros tipos de alerta.

```csharp
public class AlertaIncendio : Alerta
```

```csharp
public class AlertaEnchente : Alerta
```

---

## Polimorfismo

Cada tipo de alerta possui sua própria implementação do método:

```csharp
public override void ExibirDetalhes()
```

Permitindo comportamentos diferentes para incêndios e enchentes.

---

# Abstração

Foi utilizada a classe abstrata:

```csharp
EntidadeEspacial
```

Ela define características comuns das entidades espaciais e obriga as classes filhas a implementarem:

```csharp
ExibirInformacoes()
```

---

# Interfaces

Foi criada a interface:

```csharp
IMonitoravel
```

Responsável por definir o contrato de monitoramento dos sensores.

```csharp
void Monitorar();
```

---

# Injeção de Dependência

A classe:

```csharp
MonitoramentoService
```

recebe objetos através da interface:

```csharp
IMonitoravel
```

reduzindo acoplamento e aumentando a flexibilidade do sistema.

---

# 📅 Manipulação de Datas

O sistema utiliza:

```csharp
DateTime.Now
```

para registrar:

* Data de criação dos alertas;
* Data de geração dos relatórios.

Exemplo:

```csharp
DataRegistro = DateTime.Now;
```

---

# 🔄 Estruturas de Controle e Fluxo

Foram utilizadas:

* while
* switch
* if
* foreach
* try/catch

para controle do fluxo da aplicação.

---

# ⚠ Tratamento de Exceções

O sistema realiza tratamento de erros para evitar encerramentos inesperados.

Exemplos:

### Entrada inválida

```text
Nível de risco: abc
Digite apenas números válidos.
```

### Regra de negócio

```text
Nível de risco: 10
Erro de validação: O nível de risco deve estar entre 1 e 5.
```

---

# 📌 Struct

Foi utilizada a struct:

```csharp
Coordenada
```

para representar:

* Latitude
* Longitude

das ocorrências monitoradas.

---

# 📌 Partial Class

A classe Relatorio foi dividida em dois arquivos:

```text
Relatorio.cs
Relatorio.Historico.cs
```

demonstrando a utilização do recurso Partial Class.

---

# ✅ Atendimento aos Requisitos da Disciplina

| Requisito                                  | Implementação no Projeto                                                                                     |
| ------------------------------------------ | ------------------------------------------------------------------------------------------------------------ |
| Projeto em .NET alinhado à Global Solution | Aplicação Console em C#/.NET 8 com tema de monitoramento ambiental por satélites                             |
| Classes públicas                           | `Satelite`, `Sensor`, `Alerta`, `AlertaIncendio`, `AlertaEnchente`, `Relatorio`                              |
| Encapsulamento                             | Uso de propriedades com `private set`, protegendo alterações diretas nos atributos                           |
| Herança                                    | `AlertaIncendio` e `AlertaEnchente` herdam da classe base `Alerta`                                           |
| Polimorfismo                               | Cada tipo de alerta sobrescreve o método `ExibirDetalhes()`                                                  |
| Classe abstrata                            | `EntidadeEspacial`, utilizada como base conceitual para entidades espaciais                                  |
| Interfaces                                 | `IMonitoravel`, definindo o contrato de monitoramento                                                        |
| Injeção de Dependência                     | `MonitoramentoService` recebe um objeto `IMonitoravel` no construtor                                         |
| Métodos/Funções                            | O `Program.cs` foi modularizado em métodos como `CadastrarSatelite`, `ListarAlertas`, `GerarRelatorio` etc.  |
| Estruturas de controle                     | Uso de `while`, `switch`, `if`, `foreach` e `try/catch`                                                      |
| DateTime                                   | Registro da data/hora dos alertas e da geração dos relatórios                                                |
| Tratamento de Exceções                     | Tratamento de `FormatException`, `ArgumentException` e `Exception`                                           |
| Struct                                     | `Coordenada`, utilizada para representar latitude e longitude                                                |
| Partial Class                              | `Relatorio.cs` e `Relatorio.Historico.cs` dividem a classe `Relatorio`                                       |
| Organização                                | Projeto separado em pastas: `Models`, `Services`, `Interfaces`, `Abstracts`, `Structs`, `Partials` e `Utils` |
| Evidências de execução                     | Foram registradas evidências das principais funcionalidades e dos tratamentos de erro                        |

---

# 🔄 Diagrama de Fluxo

```mermaid
flowchart TD
    A[Início] --> B[Exibir Menu Principal]
    B --> C{Usuário escolhe uma opção}

    C -->|1| D[Cadastrar Satélite]
    D --> B

    C -->|2| E[Listar Satélites]
    E --> B

    C -->|3| F[Cadastrar Sensor]
    F --> G[Iniciar Monitoramento]
    G --> B

    C -->|4| H[Listar Sensores]
    H --> B

    C -->|5| I[Registrar Alerta de Incêndio]
    I --> J{Dados válidos?}
    J -->|Sim| K[Salvar Alerta de Incêndio]
    J -->|Não| L[Exibir Erro de Validação]
    K --> B
    L --> B

    C -->|6| M[Registrar Alerta de Enchente]
    M --> N{Dados válidos?}
    N -->|Sim| O[Salvar Alerta de Enchente]
    N -->|Não| P[Exibir Erro de Validação]
    O --> B
    P --> B

    C -->|7| Q[Listar Alertas]
    Q --> B

    C -->|8| R[Gerar Relatório]
    R --> S[Exibir Histórico de Alertas]
    S --> B

    C -->|0| T[Encerrar Sistema]
    T --> U[Fim]

    C -->|Opção inválida| V[Exibir Mensagem de Opção Inválida]
    V --> B
```


---

# ▶ Como Executar

## Pré-requisitos

* Visual Studio 2022
* .NET 8 SDK

## Passos

1. Abrir a solução no Visual Studio;
2. Compilar o projeto;
3. Executar utilizando:

```text
F5
```

ou

```text
Ctrl + F5
```

---

# 📷 Evidências de Execução

Durante os testes foram validadas as seguintes funcionalidades:

✅ Cadastro de satélites

<img width="800" alt="CadastrarSatélite" src="https://github.com/user-attachments/assets/8c9377a6-2747-4f64-82bc-66e550c6227b" />

✅ Listagem de satélites

<img width="800" alt="ListarSatélites" src="https://github.com/user-attachments/assets/e9a6f84d-c595-4e57-8fe2-46c61bcaaf45" />

✅ Cadastro de sensores

<img width="800" alt="CadastrarSensor" src="https://github.com/user-attachments/assets/773c968d-babc-44c1-b797-74c1654a6bde" />

✅ Listagem de sensores

<img width="800" alt="ListarSensores" src="https://github.com/user-attachments/assets/a1e310f1-355c-4071-a29b-51bff53563bc" />

✅ Registro de alertas de incêndio

<img width="800" alt="RegistrarAlertadeIncêndio" src="https://github.com/user-attachments/assets/49d4e511-1d99-4bf9-ad95-77679514278d" />

✅ Registro de alertas de enchente

<img width="800" alt="RegistrarAlertadeEnchente" src="https://github.com/user-attachments/assets/3e79a70f-84d3-4576-83a9-53ee79b1366e" />

✅ Listagem de alertas

<img width="800" alt="ListarAlertas" src="https://github.com/user-attachments/assets/8d61b9bb-e056-4d4b-bbe5-b9870cfd86bd" />

✅ Geração de relatórios

<img width="800" alt="GerarRelatório" src="https://github.com/user-attachments/assets/3c30c476-d627-45d6-997b-23b7a9e49964" />

✅ Tratamento de exceções

<img width="800" alt="ErrodeValidação(ORiscoDeveEstarEntre1e5)" src="https://github.com/user-attachments/assets/704422fc-af83-4abc-8289-9e531aa4c6fe" />

<img width="800" alt="ErroDeValidação(DigiteApenasNúmeroVálidos)" src="https://github.com/user-attachments/assets/2a1ff5da-cd1e-4de8-bafe-436075a95a44" />

✅ Encerramento seguro do sistema

<img width="800" alt="Sair" src="https://github.com/user-attachments/assets/e22ae513-1fee-46d8-839e-e3e719968a22" />

---

# 👨‍💻 Tecnologias Utilizadas

* C#
* .NET 8
* Visual Studio 2022

---

# 📚 Projeto Acadêmico

Projeto desenvolvido para a disciplina de **C# Software Development** da FIAP, como parte da **Global Solution**, aplicando conceitos de Programação Orientada a Objetos, abstração, interfaces, injeção de dependência, tratamento de exceções e boas práticas de desenvolvimento.
