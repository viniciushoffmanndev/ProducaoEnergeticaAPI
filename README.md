


CocalAPI é uma API REST desenvolvida com ASP.NET Core 8.0, voltada para fornecer dados de produção de biocombustíveis e energia limpa.

## 🚀 Tecnologias Utilizadas

- ASP.NET Core 8.0
- Swagger (Swashbuckle)
- CORS

## 📦 Funcionalidades

A API fornece dados simulados (mockados) sobre a produção de:

- Etanol
- Energia
- Biometano
- CO₂ Verde

## 📁 Estrutura do Projeto

- `Program.cs`: Configura os serviços e o pipeline da aplicação.
- `ProducaoController.cs`: Controlador com endpoints para dados de produção.
- `CocalAPI.csproj`: Arquivo de configuração do projeto .NET.
- `CocalAPI.http`: Arquivo de testes HTTP para uso com Visual Studio ou VS Code.

## 🔗 Endpoints Disponíveis

| Método | Endpoint                     | Descrição                  |
|--------|------------------------------|----------------------------|
| GET    | /api/producao/etanol        | Retorna dados de etanol    |
| GET    | /api/producao/energia       | Retorna dados de energia   |
| GET    | /api/producao/biometano     | Retorna dados de biometano |
| GET    | /api/producao/co2-verde     | Retorna dados de CO₂ verde |

## 🧪 Testes

Utilize o arquivo `CocalAPI.http` para testar os endpoints diretamente no Visual Studio ou VS Code.

## 📌 Observações

Os dados retornados são simulados (mockados) e servem como base para testes e desenvolvimento inicial.

## 📄 Licença

Este projeto está licenciado sob os termos da licença MIT.
