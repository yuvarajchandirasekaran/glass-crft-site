window.addEventListener('scroll', function() {
    var header = document.getElementById('header');

    if (window.scrollY > 50) {
      header.style.top = '-45px';
    } else {
      header.style.top = '0';
    }
  });