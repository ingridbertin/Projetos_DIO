var fotoAtual = 0;
var figuras = new Array();

for (var i = 0; i < 5; i++) {
  // Instanciando um objeto Image a cada elemento do Array
  figuras[i] = new Image();
}
figuras[0].src = './img/imagem_rodar.jpg';
figuras[1].src = './img/imagem_rodar2.jpg';
figuras[2].src = './img/imagem_rodar3.jpg';
figuras[3].src = './img/imagem_rodar4.jpg';
figuras[4].src = './img/imagem_rodar5.jpg';
var imagem = document.querySelector('#passar-foto');
imagem.appendChild(figuras[0]);
function change() {
  fotoAtual >= 4 ? (fotoAtual = 0) : fotoAtual++;
  var teste = imagem.getElementsByTagName('img');
  if (fotoAtual == 0) teste[0].src = `./img/imagem_rodar.jpg`;
  else teste[0].src = `${figuras[fotoAtual].src}`;
}

window.onload = function () {
  setInterval(change, 5000);
};
