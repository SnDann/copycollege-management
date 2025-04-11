# Sistema de Gerenciamento Acadêmico

Sistema de gerenciamento acadêmico desenvolvido em .NET para controle de cursos, disciplinas, matrículas e alunos.

## 🚀 Funcionalidades

### Gerenciamento de Cursos
- Listagem de cursos
- Criação de novos cursos
- Atualização de cursos existentes
- Exclusão de cursos
- Consulta detalhada de cursos

### Gerenciamento de Disciplinas
- Listagem de disciplinas
- Listagem de disciplinas por curso
- Criação de novas disciplinas
- Atualização de disciplinas existentes
- Exclusão de disciplinas
- Consulta detalhada de disciplinas

### Gerenciamento de Matrículas
- Listagem de matrículas
- Listagem de matrículas por aluno
- Criação de novas matrículas
- Atualização de matrículas existentes
- Exclusão de matrículas
- Consulta detalhada de matrículas

### Gerenciamento de Turmas
- Listagem de turmas
- Listagem de turmas por disciplina
- Criação de novas turmas
- Atualização de turmas existentes
- Exclusão de turmas
- Consulta detalhada de turmas

### Gerenciamento de Alunos
- Listagem de alunos
- Criação de novos alunos
- Atualização de alunos existentes
- Exclusão de alunos
- Consulta detalhada de alunos

### Autenticação e Autorização
- Sistema de login
- Controle de acesso baseado em permissões
- Gerenciamento de usuários
- Proteção de rotas

## 🛠️ Tecnologias Utilizadas

- .NET Core
- Entity Framework Core
- SQL Server
- ASP.NET Core
- JWT para autenticação
- Swagger para documentação da API

## 📁 Estrutura do Projeto

```
college-management/
├── Constantes/           # Constantes e enums do sistema
├── Contextos/           # Contextos do Entity Framework
├── Dados/              # Camada de acesso a dados
│   ├── Repositorios/   # Implementações dos repositórios
│   └── BaseDeDados.cs  # Configuração do banco de dados
├── Models/             # Classes de domínio
├── Servicos/           # Lógica de negócios
│   ├── AcademicoServico.cs    # Serviço de cursos e disciplinas
│   ├── MatriculaServico.cs    # Serviço de matrículas e turmas
│   └── AutenticacaoServico.cs # Serviço de autenticação
└── Utilitarios/        # Classes utilitárias
```

## 🔧 Configuração do Ambiente

1. Clone o repositório:
```bash
git clone https://github.com/SnDann/copycollege-management.git
```

2. Restaure os pacotes NuGet:
```bash
dotnet restore
```

3. Configure a string de conexão no arquivo `appsettings.json`:
```json
{
  "ConnectionStrings": {
    "DefaultConnection": "sua-string-de-conexao"
  }
}
```

4. Execute as migrações do banco de dados:
```bash
dotnet ef database update
```

5. Execute o projeto:
```bash
dotnet run
```

## 🔐 Segurança

- Autenticação via JWT
- Controle de acesso baseado em permissões
- Criptografia de senhas
- Proteção contra ataques comuns (XSS, CSRF, etc.)

## 📝 Documentação da API

A documentação da API está disponível via Swagger em:
```
http://localhost:5000/swagger
```

## 🤝 Contribuição

1. Faça um fork do projeto
2. Crie uma branch para sua feature (`git checkout -b feature/AmazingFeature`)
3. Commit suas mudanças (`git commit -m 'Add some AmazingFeature'`)
4. Push para a branch (`git push origin feature/AmazingFeature`)
5. Abra um Pull Request

## 📄 Licença

Este projeto está sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

## 👥 Autores

- [Seu Nome](https://github.com/seu-usuario)

## 🙏 Agradecimentos

- Equipe de desenvolvimento
- Contribuidores
- Comunidade .NET
