# XPDesafioTecnico API

## Descrição

A API XPDesafioTecnico é uma API para gerenciar clientes. Ela fornece endpoints para listar clientes, obter detalhes de clientes e criar novos clientes.

## Pré-requisitos

Certifique-se de ter o Docker e o Docker Compose instalados na sua máquina para executar o SQL Server em um contêiner.

## Configuração

### 1. Iniciar o SQL Server

Para executar o SQL Server em um contêiner Docker, vá até a raiz do projeto e execute o seguinte comando:

docker-compose up -d

Este comando inicia um contêiner Docker com o SQL Server configurado. Certifique-se de que o SQL Server está em execução antes de iniciar a API.

### 2. Iniciar a API

#### Usando o Visual Studio

Para iniciar a API usando o Visual Studio, siga estas etapas:

1. Abra a solução do projeto no Visual Studio.

2. Certifique-se de que o projeto `XPDesafioTecnico` esteja definido como o projeto de inicialização.

3. Clique com o botão direito do mouse no projeto `XPDesafioTecnico` no Solution Explorer.

4. Selecione "Debug" > "Start Debugging" ou pressione F5.

A API estará disponível em `http://localhost:5000`. Certifique-se de que o SQL Server e a API estejam em execução antes de usar os endpoints.

## Endpoints

### Listar Clientes

- **URL:** `/clientes`
- **Método:** `GET`
- **Descrição:** Retorna a lista de todos os clientes.

### Listar Clientes Detalhados

- **URL:** `/clientes/detalhe`
- **Método:** `GET`
- **Descrição:** Retorna a lista de todos os clientes com detalhes adicionais.

### Criar Cliente

- **URL:** `/clientes`
- **Método:** `POST`
- **Descrição:** Cria um novo cliente com os dados fornecidos no corpo da solicitação.

## Exemplo de Uso

### Listar Clientes
GET http://localhost:5000/clientes

### Listar Clientes Detalhados
GET http://localhost:5000/clientes/detalhe

### Criar Cliente
POST http://localhost:5000/clientes

Corpo da solicitação (JSON):
{
"nomeCompleto": "John Doe",
"telefone": "123-456-7890",
"email": "john@example.com",
"rua": "123 Main St",
"cidade": "City",
"estado": "State",
"cep": "12345"
}
