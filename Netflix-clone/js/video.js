var botao = document.getElementById('assistir');

botao.addEventListener('click', function () {
  botao.style.visibility = 'hidden';
  carrossel = document.querySelector('#carrossel-filmes').remove();
  filme = document.querySelector('#filme-principal');
  filme.innerHTML = `<iframe  height="1005" src="https://www.youtube.com/embed/kasvV-XyzqU" frameborder="0" allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture" allowfullscreen></iframe>`;
  filme.style.background = '#141414';
  filme.style.visibility = 'visible';
  filme.style.margin = '20px';
});
