<h1 align="center">API CRUD com Validação de Login</h1>

<!-- Descrição -->
<p align="center">Esta é uma API que fornece operações básicas de CRUD (Create, Read, Update e Delete) para usuários, juntamente com um endpoint para validar o login de usuários.</p>

<!-- Badges -->
<p align="center">
  <img alt="Tecnologias" src="https://img.shields.io/badge/ASP.NET_Core-5C2D91?logo=.net&logoColor=white&style=flat-square">
  <img alt="Banco de Dados" src="https://img.shields.io/badge/Banco_de_Dados-Oracle_SQL-A60000?logo=oracle&logoColor=white&style=flat-square">
  <img alt="License" src="https://img.shields.io/github/license/seuusuario/seuprojeto?style=flat-square">
</p>

<!-- Conteúdo -->
## :bookmark_tabs: Conteúdo

#### FUNCIONALIDADES:
> - CRUD (Create, Read, Update e Delete) de usuários.
> - Validação de login.

### CRUD de Usuários

- **Listar Usuários:**
  - **Descrição:** Retorna uma lista de todos os usuários cadastrados.
  - **Endpoint:** `GET /api/User`
  - **Códigos de Status:**
    - :white_check_mark: 200 (OK) - Sucesso.
    - :x: 404 (Not Found) - Usuários não encontrados.
    
    ![IMAGEM](Documentacao/get_exemplo.png)

- **Adicionar Usuário:**
  - **Descrição:** Adiciona um novo usuário.
  - **Endpoint:** `POST /api/User`
  - **Códigos de Status:**
    - :white_check_mark: 200 (OK) - Sucesso.
    - :warning: 400 (Bad Request) - Dados de entrada inválidos.

    ![IMAGEM](Documentacao/post_exemplo.png)

- **Atualizar Usuário:**
  - **Descrição:** Atualiza os dados de um usuário existente, informando o ID.
  - **Endpoint:** `PUT /api/User/{id}`
  - **Códigos de Status:**
    - :white_check_mark: 200 (OK) - Sucesso.
    - :x: 404 (Not Found) - Usuário não encontrado.

    ![IMAGEM](Documentacao/put_exemplo.png)

- **Excluir Usuário:**
  - **Descrição:** Exclui um usuário existente.
  - **Endpoint:** `DELETE /api/User/{id}`
  - **Códigos de Status:**
    - :white_check_mark: 200 (OK) - Sucesso.
    - :x: 404 (Not Found) - Usuário não encontrado.

---

### Validação de Login

- **Login de Usuário:**
  - **Descrição:** Valida as credenciais de login de um usuário.
  - **Endpoint:** `POST /api/Login/login`
  - **Códigos de Status:**
    - :white_check_mark: 200 (OK) - Sucesso.
    - :x: 400 (Bad Request) - Usuário não encontrado ou senha incorreta.

    ![IMAGEM](Documentacao/login_exemplo.png)

    

<!-- Instruções de uso do projeto -->

## :busts_in_silhouette: Integrantes

> 
>**INTEGRANTES** <BR>
> Nome: Eduardo Fagundes Correa | RM: 97195 <BR>
> Nome: Murilo Ariel Reis | RM: 97002 <BR>
> Nome: Luiz Henrique de Jesus do Nascimento | RM: 96335 <BR>
> Nome: Samuel Enderson Lima da Silva | RM: 96677 <BR>

---

<!-- Rodapé -->
<p align="center">
  <sub>Built with ❤️ by Your Team</sub>
</p>