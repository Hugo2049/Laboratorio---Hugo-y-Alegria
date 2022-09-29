<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/animate.css/4.0.0/animate.min.css" />
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.13.1/css/all.min.css" />
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css" />
    <link rel="stylesheet" href="https://unpkg.com/swiper/swiper-bundle.min.css" />
    <link rel="stylesheet" href="style.css">
    <title>Amigos Asosiación</title>
</head>

<body data-spy="scroll" data-target="menu">
    <!-- ? NAVBAR -->
    <nav class="navbar navbar-expand-lg navbar-light bg-light sticky-top" id="menu">
        <div class="container-fluid">
            <a href="#" class="navbar-brand"><img src="img/logo.png" alt="Logo" width="150" height="100"></a>
            <a href="#" class="navbar-brand">Asosiación Amigos</a>
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarMain"
                aria-controls="navbarMain" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>

            <div class="collapse navbar-collapse justify-content-center" id="navbarMain">
                <ul class="navbar-nav">
                    <li class="nav-item">
                        <a href="#home" class="nav-link">Inicio</a>
                    </li>
                    <li class="nav-item">
                        <a href="#sobre-nosotros" class="nav-link">Sobre Nosotros</a>
                    </li>
                    <li class="nav-item">
                        <a href="#galeria" class="nav-link">Galeria</a>
                    </li>
                    <li class="nav-item">
                        <a href="#precio" class="nav-link">Proyectos</a>
                    </li>
                    <li class="nav-item">
                        <a href="#contacto" class="nav-link">Contacto</a>
                    </li>
                </ul>
            </div>
        </div>

    </nav>
    <!-- ? HEADER / HERO -->
    <header class="hero text-white" id="home">
        <div class="container">
            <div class="row">
                <div class="col-md-5 d-none d-md-block">
                    <img src="img/header-hero/hero-mobile.png" alt="hero mobile"
                        class="mobile-image animate__animated animate__fadeInUp animate__slower">
                </div>
                <div class="col-12 col-md-7">
                    <h1 class="mb-5 animate__animated animate__fadeInUp animate__slow">Kit de Energía Solar</h1>
                    <p class="mb-5 animate__animated animate__fadeInUp animate__slow">Con un único y mínimo donativo puedes hacer felíz a una familia que podra tener por primera vez Luz en su hogar la cual tendrá una vida útil de 20 años. Contáctanos para mas información.</p>
                   
                </div>
            </div>
        </div>
    </header>
    <!-- ? SOBRE NOSOTROS -->
    <section id="sobre-nosotros">
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <div class="text-center">
                        <img src="img/logo.png" alt="Logo">
                        <h5 class="text-muted mt-2 mb-4 wow animate__animated animate__headShake" data-wow-delay="1s">
                            Sobre nosotros</h5>
                        <h3 class="text-info mb-5 wow animate__animated animate__headShake" data-wow-delay="1s">
                       ¿Quíenes somos?
                           </h3>
                        <h4 class="mb-4 text-muted">Somos una organización de carácter privado, no lucrativa, no religiosa apolítica, cultural, educativa, científica, humanitaria de colaboración y ayuda mutua en beneficio social y de desarrollo integral.</h4>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- ? GALERIA -->
    <section class="mt-5" id="galeria">
        <div class="container-fluid">
            <div class="row">
                <div class="col-12 col-sm-6">
                    <div class="swiper-container pb-4 wow animate__animated animate__fadeInRight">
                        <div class="swiper-wrapper text-center">
                            <div class="swiper-slide">
                                <img src="img/galeria/mobile-1.png" alt="" />
                            </div>
                            <div class="swiper-slide">
                                <img src="img/galeria/mobile-2.png" alt="" />
                            </div>
                            <div class="swiper-slide">
                                <img src="img/galeria/mobile-3.png" alt="" />
                            </div>
                        </div>
                        <div class="swiper-pagination"></div>
                    </div>
                </div>
                <div class="col-12 col-sm-5 col-lg-3 text-center text-sm-left mt-5 text-white">
                    <div class="mb-3">
                        
                        <h3>Por medio de la Bondad podemos aprender a Compartir</h3>
                    </div>
                    <p>Ser un medio valioso y constante para impulsar el bienestar de nuestras Comunidades.
Colaborar en la educación presencial o a distancia de quien tenga la voluntad de aprender.
Velar porque la ayuda llegue a cada uno de los beneficiados.</p>
                  
                </div>
            </div>
        </div>
    </section>
    <!-- ? PRECIO -->
    <section id="precio">
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <div class="text-center text-muted mb-5">
                        <h5>Proyectos</h5>
                        <h3>Ayudanos a patrocinar nuestros proyectos</h3>
                    </div>
                </div>
            </div>
            <div class="row">
                <div class="col-12 col-md-4">
                    <div class="price-box">
                        <div class="price-header">
                            <div class="price-icon">
                                <i class="fa fa-user-plus"></i>
                            </div>
                            <h4>Normal</h4>
                        </div>
                        <div class="price-body">
                            <ul class="price-list-features">
                                <li>Quedara a tu disposición</li>
                                <li>Ayudanos </li>
                                <li>pero tu pon el precio</li>
                            </ul>
                        </div>
                        <div class="price-rate text-info">
                            <span class="rate">1-...<sup>&dollar;</sup></span>
                            <small>/Mes</small>
                        </div>
                        <div class="price-footer">
                            <button type="button" class="btn btn-info">contactanos</button>
                        </div>
                    </div>
                </div>

                <div class="col-12 col-md-4">
                    <div class="price-box">
                        <div class="price-header">
                            <div class="price-icon">
                                <i class="fa fa-user-tie"></i>
                            </div>
                            <h4>Asociation partner</h4>
                        </div>
                        <div class="price-body">
                            <ul class="price-list-features">
                                <li>Ayudanos a </li>
                                <li>Lograr más proyectos</li>
                               
                            </ul>
                        </div>
                        <div class="price-rate text-info">
                            <span class="rate">49<sup>&dollar;</sup></span>
                            <small>/Mes</small>
                        </div>
                        <div class="price-footer">
                            <button type="button" class="btn btn-info">Contactanos</button>
                        </div>
                    </div>
                </div>

        
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- ? CONTACTO -->
    <section class="subscribe-area" id="contacto">
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <div class="subscribe-form text-center">
                        <h3 class="text-info">Suscribete para más información</h3>
                        <form class="form-inline justify-content-center">
                            <label for="emailInput" class="sr-only">Email</label>
                            <input type="text" id="emailInput" class="form-control mr-sm-2" placeholder="Email">
                            <button type="submit" class="btn btn-info w-100 d-sm-none">Suscribir</button>
                            <button type="submit" class="btn btn-info d-none d-sm-block">Suscribir</button>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </section>
    <!-- ? FOOTER -->
    <footer>
        <div class="container">
            <div class="row">
                <div class="col-12">
                    <div class="footer-box text-center">
                     
                        <p class="copy">
                            Copyright &copy; 2020 |
                            <a href="#" class="copy-link">@NavisCode</a>
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </footer>



    <script src="https://code.jquery.com/jquery-3.5.1.slim.min.js"
        integrity="sha384-DfXdz2htPH0lsSSs5nCTpuj/zy4C+OGpamoFVy38MVBnE+IbbVYUew+OrCXaRkfj"
        crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"
        integrity="sha384-OgVRvuATP1z7JjHLkuOU7Xw704+h835Lr+6QL9UvYjZE3Ipu6Tp75j7Bh/kR0JKI"
        crossorigin="anonymous"></script>

    <script src="https://unpkg.com/swiper/swiper-bundle.min.js"></script>
    <script src="  https://cdnjs.cloudflare.com/ajax/libs/wow/1.1.2/wow.min.js"></script>

    <script>
        var swiper = new Swiper(".swiper-container", {
            pagination: {
                el: ".swiper-pagination",
                dynamicBullets: true,
            }
        })
        // WOW
        new WOW().init()
    </script>
</body>

</html>