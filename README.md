<!-- título -->
<h1 align="center">
  📽 Trending Movies
</h1>

<!-- status -->
<p align="center"><b>Status: Concluído ✅</b></p>

<!-- badges -->
<p align="center">
  <img src="https://img.shields.io/github/languages/count/hbalardin/trending-movies?color=431d7c">
  <img src="https://img.shields.io/github/repo-size/hbalardin/trending-movies?color=F62E76"/>
  <a href="https://www.linkedin.com/in/hbalardin/">
    <img src="https://img.shields.io/badge/made%20by-Henrique%20Balardin-431d7c">
  </a>
  <img src="https://img.shields.io/github/last-commit/hbalardin/trending-movies?color=F62E76"/>
  <img alt="GitHub license" src="https://img.shields.io/github/license/hbalardin/trending-movies?color=431d7c">
</p>

<!-- index -->
<p align="center">
  <a href="#-sobre">Sobre</a> •
  <a href="#-requisitos">Requisitos</a> •
  <a href="#-ferramentas">Ferramentas</a> •
  <a href="#-executando-o-projeto">Executando o projeto</a> •
  <a href="#-licença">Licença</a>
</p>

---

<!-- gifs -->
<h4 align="center">
  <p>Web</p>
  <img width="100%" alt="WebDemonstration" title="WebDemonstration" src="./github/web.gif">
  <p>Mobile</p>
  <img width="25%" alt="MobileDemonstration" title="MobileDemonstration" src="./github/mobile.gif">
</h4>

---

## 📄 Sobre

O objetivo deste projeto é desenvolver uma aplicação frontend para consumir uma api de filmes, e listar os filmes que são tendências da semana.

A API utilizada foi: [TheMovieDB](https://www.themoviedb.org/documentation/api)

---

## 🔝 Requisitos

✅ O app deve conter uma navbar com um logo fictício, uma categoria(Trending), e um campo de buscas.

✅ Ao carregar a página, os filmes da categoria tendências(Trending), deverão ser exibidos em forma de cards em uma grid.

✅ Os filmes deverão ser ordenados por nota, da mais alta para a mais baixa.

✅ Os cards devem conter: uma miniatura da imagem da capa do filme, o título do filme, a data de lançamento no formato (ex.: "20 de nov de 2020") e a nota (vote_average).

✅ Você pode usar alguma forma visual para diferenciar filmes com nota acima de 6 e abaixo de 6 como um bônus.

✅ Ao clicar em um card, o usuário deve ser direcionado para a página de detalhe do filme selecionado.

✅ A página de detalhe deve conter a imagem do filme em um tamanho maior, juntamente com informações mais detalhadas sobre o mesmo (essas informações ficam a seu critério, o que achar importante e interessante mostrar para o usuário).

✅ No campo de busca da barra de navegação, o usuário poderá procurar por filmes por um título
Se a busca por um título não retornar nenhum resultado, o usuário deverá ser informado de forma amigável que não foi possível encontrar aquele título.

✅ A aplicação deve se comportar de forma responsiva para que seja exibida da melhor forma, tanto em telas mais pequenas quanto nas maiores.

---

### 🚀 Milha Extra

Além do que foi pedido, adicionei animações para deixar a aplicação mais agradável e fluida, e também uma página exclusiva para tratativa de erros.

## 🔨 Ferramentas

Estas são as principais ferramentas utilizadas na construção do projeto:

- [Typescript](https://www.typescriptlang.org/)
- [ReactJS](https://reactjs.org/)
- [Axios](https://github.com/axios/axios)
- [Styled Components](https://github.com/styled-components/styled-components)

---

## 🚀 Executando o projeto

Antes de qualquer coisa, você precisa ter o [Git](https://git-scm.com), o [Yarn](https://yarnpkg.com/) e o [Node.js](https://nodejs.org/en/) instalado na sua máquina. Feito isso, você pode prosseguir.

```bash
# Clone este repositório:
$ git clone https://github.com/hbalardin/trending-movies

# Acesse à pasta do projeto:
cd trending-movies

# Instale as depêndencias:
yarn

# Execute a aplicação em modo de desenvolvimento:
yarn start
```

Caso a página não abrir automaticamente, acesse: http://localhost:3000

---

## 📋 Licença

Esse repositório está sob a licença [MIT](https://github.com/hbalardin/trending-movies/blob/master/LICENSE.md).

---

## 🚀 Entre em contato!

Desenvolvido por [Henrique Balardin](https://www.linkedin.com/in/hbalardin).
