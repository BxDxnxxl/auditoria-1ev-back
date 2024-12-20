using models;
using System;
using System.Collections.Generic;

public static class InicializadorDatos
{
    public static void InicializarDatos()
    {
        InicializarCategorias();
        InicializarPeliculas();
        InicializarSalas();
        InicializarSesiones();
        InicializarModelosAutoria();
    }

    //poner ambos inicializadores de categorias antes que los de peliculas para corregir error de que no encuentre categorias
    private static void InicializarCategorias()
    {
        DataStore.Categorias.AddRange(new List<Categoria>
        {
        new Categoria("Acción"),
        new Categoria("Ciencia Ficción"),
        new Categoria("Superhéroes"),
        new Categoria("Animación"),
        new Categoria("Fantasía"),
        new Categoria("Aventura"),
        new Categoria("Terror"),
        new Categoria("Suspenso"),
        new Categoria("Thriller"),
        new Categoria("Drama"),
        new Categoria("Musical"),
        new Categoria("Crimen"),
        new Categoria("Gore"),
        new Categoria("Misterio"),
        new Categoria("Romance"),
        new Categoria("Comedia")
        });
    }

    private static void InicializarPeliculas()
    {
        
        var accion = DataStore.Categorias.FirstOrDefault(c => c.Nombre == "Acción");
        var cienciaFiccion = DataStore.Categorias.FirstOrDefault(c => c.Nombre == "Ciencia Ficción");
        var superhéroes = DataStore.Categorias.FirstOrDefault(c => c.Nombre == "Superhéroes");
        var animacion = DataStore.Categorias.FirstOrDefault(c => c.Nombre == "Animación");
        var fantasia = DataStore.Categorias.FirstOrDefault(c => c.Nombre == "Fantasía");
        var aventura = DataStore.Categorias.FirstOrDefault(c => c.Nombre == "Aventura");
        var terror = DataStore.Categorias.FirstOrDefault(c => c.Nombre == "Terror");
        var suspenso = DataStore.Categorias.FirstOrDefault(c => c.Nombre == "Suspenso");
        var thriller = DataStore.Categorias.FirstOrDefault(c => c.Nombre == "Thriller");
        var drama = DataStore.Categorias.FirstOrDefault(c => c.Nombre == "Drama");
        var musical = DataStore.Categorias.FirstOrDefault(c => c.Nombre == "Musical");
        var romance = DataStore.Categorias.FirstOrDefault(c => c.Nombre == "Romance");
        var comedia = DataStore.Categorias.FirstOrDefault(c => c.Nombre == "Comedia");
        var comediaNegra = DataStore.Categorias.FirstOrDefault(c => c.Nombre == "Comedia Negra");
        var misterio = DataStore.Categorias.FirstOrDefault(c => c.Nombre == "Misterio");
        var gore = DataStore.Categorias.FirstOrDefault(c => c.Nombre == "Gore");
        var crimen = DataStore.Categorias.FirstOrDefault(c => c.Nombre == "Crimen");

        DataStore.Peliculas.AddRange(new List<Pelicula>
        {
            new Pelicula(
                nombre: "Vengadores: Infinity War",
                descripcion: "Los Vengadores intentan detener a Thanos antes de que destruya la mitad del universo.",
                director: "Anthony y Joe Russo",
                categorias: new List<Categoria> { accion, cienciaFiccion, superhéroes},
                anioDeSalida: new DateTime(2018, 4, 27),
                imagenBannerUrl: "VengadoresInfinityWar_Banner.jpg",
                imagenPequeniaUrl: "VengadoresInfinityWar_Estandar.jpg",
                duracion: 160,
                valoracion: 8.50
            ),
            new Pelicula(
                nombre: "Cómo entrenar a tu dragón 3",
                descripcion: "Hipo y Desdentao enfrentan nuevos desafíos mientras buscan un mundo escondido para los dragones.",
                director: "Dean DeBlois",
                categorias: new List<Categoria> { animacion, fantasia, aventura},
                anioDeSalida: new DateTime(2019, 2, 22),
                imagenBannerUrl: "ComoEntrenarATuDragon3_Banner.jpg",
                imagenPequeniaUrl: "ComoEntrenarATuDragon3_Estandar.jpg",
                duracion: 105,
                valoracion: 9.00
            ),
            new Pelicula(
                nombre: "Halloween (2018)",
                descripcion: "Laurie Strode se enfrenta nuevamente a Michael Myers en este reinicio de la franquicia.",
                director: "David Gordon Green",
                categorias: new List<Categoria> { terror, suspenso},
                anioDeSalida: new DateTime(2018, 10, 19),
                imagenBannerUrl: "Halloween2018_Banner.jpg",
                imagenPequeniaUrl: "Halloween2018_Estandar.jpg",
                duracion: 105,
                valoracion: 7.00
            ),
            new Pelicula(
                nombre: "Halloween Kills",
                descripcion: "Michael Myers continúa su masacre mientras Haddonfield decide luchar contra él.",
                director: "David Gordon Green",
                categorias: new List<Categoria> { terror, suspenso},
                anioDeSalida: new DateTime(2021, 10, 15),
                imagenBannerUrl: "HalloweenKills_Banner.jpg",
                imagenPequeniaUrl: "HalloweenKills_Estandar.jpg",
                duracion: 105,
                valoracion: 6.50
            ),
            new Pelicula(
                nombre: "Halloween Ends",
                descripcion: "Laurie Strode se enfrenta a Michael Myers por última vez en un enfrentamiento épico.",
                director: "David Gordon Green",
                categorias: new List<Categoria> { terror, suspenso},
                anioDeSalida: new DateTime(2022, 10, 14),
                imagenBannerUrl: "HalloweenEnds_Banner.jpg",
                imagenPequeniaUrl: "HalloweenEnds_Estandar.jpg",
                duracion: 110,
                valoracion: 6.00
            ),
            new Pelicula(
                nombre: "Tenet",
                descripcion: "Un agente intenta evitar una catástrofe temporal con la ayuda de la inversión del tiempo.",
                director: "Christopher Nolan",
                categorias: new List<Categoria> { cienciaFiccion, accion, thriller},
                anioDeSalida: new DateTime(2020, 8, 26),
                imagenBannerUrl: "Tenet_Banner.jpg",
                imagenPequeniaUrl: "Tenet_Estandar.jpg",
                duracion: 150,
                valoracion: 7.40
            ),
            new Pelicula(
                nombre: "Interstellar",
                descripcion: "Un grupo de astronautas busca un nuevo hogar para la humanidad a través de un agujero de gusano.",
                director: "Christopher Nolan",
                categorias: new List<Categoria> { cienciaFiccion, drama},
                anioDeSalida: new DateTime(2014, 11, 7),
                imagenBannerUrl: "Interstellar_Banner.jpg",
                imagenPequeniaUrl: "Interstellar_Estandar.jpg",
                duracion: 169,
                valoracion: 8.60
            ),
            new Pelicula(
                nombre: "John Wick",
                descripcion: "Un asesino retirado regresa al mundo del crimen después de que matan a su perro.",
                director: "Chad Stahelski",
                categorias: new List<Categoria> { accion, thriller},
                anioDeSalida: new DateTime(2014, 10, 24),
                imagenBannerUrl: "JohnWick_Banner.jpg",
                imagenPequeniaUrl: "JohnWick_Estandar.jpg",
                duracion: 101,
                valoracion: 7.40
            ),
            new Pelicula(
                nombre: "Mad Max: Fury Road",
                descripcion: "Max y Furiosa luchan por la libertad en un mundo postapocalíptico.",
                director: "George Miller",
                categorias: new List<Categoria> { accion, aventura, cienciaFiccion},
                anioDeSalida: new DateTime(2015, 5, 15),
                imagenBannerUrl: "MadMaxFuryRoad_Banner.jpg",
                imagenPequeniaUrl: "MadMaxFuryRoad_Estandar.jpg",
                duracion: 120,
                valoracion: 8.10
            ),
            new Pelicula(
                nombre: "Black Panther",
                descripcion: "T'Challa, rey de Wakanda, debe defender su trono y a su nación de un enemigo poderoso.",
                director: "Ryan Coogler",
                categorias: new List<Categoria> { accion, aventura, superhéroes},
                anioDeSalida: new DateTime(2018, 2, 16),
                imagenBannerUrl: "BlackPanther_Banner.jpg",
                imagenPequeniaUrl: "BlackPanther_Estandar.jpg",
                duracion: 134,
                valoracion: 7.30
            ),
            new Pelicula(
                nombre: "El Renacido",
                descripcion: "Hugh Glass lucha por sobrevivir en el desierto tras ser atacado por un oso y traicionado por su equipo.",
                director: "Alejandro G. Iñárritu",
                categorias: new List<Categoria> { drama, aventura},
                anioDeSalida: new DateTime(2015, 12, 25),
                imagenBannerUrl: "ElRenacido_Banner.jpg",
                imagenPequeniaUrl: "ElRenacido_Estandar.jpg",
                duracion: 156,
                valoracion: 8.00
            ),
            new Pelicula(
                nombre: "La La Land",
                descripcion: "Una historia de amor entre un músico de jazz y una actriz aspirante en Los Ángeles.",
                director: "Damien Chazelle",
                categorias: new List<Categoria> { drama, musical, romance},
                anioDeSalida: new DateTime(2016, 12, 9),
                imagenBannerUrl: "LaLaLand_Banner.jpg",
                imagenPequeniaUrl: "LaLaLand_Estandar.jpg",
                duracion: 128,
                valoracion: 8.00
            ),
            new Pelicula(
                nombre: "The Batman",
                descripcion: "Bruce Wayne investiga una serie de asesinatos conectados a la corrupción en Gotham.",
                director: "Matt Reeves",
                categorias: new List<Categoria> { accion, crimen, thriller},
                anioDeSalida: new DateTime(2022, 3, 4),
                imagenBannerUrl: "TheBatman_Banner.jpg",
                imagenPequeniaUrl: "TheBatman_Estandar.jpg",
                duracion: 176,
                valoracion: 8.20
            ),
            new Pelicula(
                nombre: "A Quiet Place",
                descripcion: "Una familia vive en silencio para evitar a criaturas que cazan por el sonido.",
                director: "John Krasinski",
                categorias: new List<Categoria> { terror, drama, suspenso},
                anioDeSalida: new DateTime(2018, 4, 6),
                imagenBannerUrl: "AQuietPlace_Banner.jpg",
                imagenPequeniaUrl: "AQuietPlace_Estandar.jpg",
                duracion: 90,
                valoracion: 7.50
            ),
            new Pelicula(
                nombre: "Get Out",
                descripcion: "Un joven descubre un oscuro secreto durante una visita a la familia de su novia.",
                director: "Jordan Peele",
                categorias: new List<Categoria> { terror, thriller, misterio},
                anioDeSalida: new DateTime(2017, 2, 24),
                imagenBannerUrl: "GetOut_Banner.jpg",
                imagenPequeniaUrl: "GetOut_Estandar.jpg",
                duracion: 104,
                valoracion: 8.00
            ),
            new Pelicula(
                nombre: "Knives Out",
                descripcion: "Un detective investiga la muerte de un novelista famoso en su excéntrica familia.",
                director: "Rian Johnson",
                categorias: new List<Categoria> { crimen, drama, comedia},
                anioDeSalida: new DateTime(2019, 11, 27),
                imagenBannerUrl: "KnivesOut_Banner.jpg",
                imagenPequeniaUrl: "KnivesOut_Estandar.jpg",
                duracion: 130,
                valoracion: 7.90
            ),
            new Pelicula(
                nombre: "Smile 2",
                descripcion: "Una nueva ola de terror psicológico amenaza a quienes presencian eventos inexplicables y aterradores.",
                director: "Parker Finn",
                categorias: new List<Categoria> { terror, thriller},
                anioDeSalida: new DateTime(2024, 10, 13),
                imagenBannerUrl: "Smile2_Banner.jpg",
                imagenPequeniaUrl: "Smile2_Estandar.jpg",
                duracion: 115,
                valoracion: 8.76
            ),
            new Pelicula(
                nombre: "Robot Salvaje",
                descripcion: "Un robot diseñado para la guerra encuentra un propósito inesperado al proteger a una comunidad en peligro.",
                director: "Neil Blomkamp",
                categorias: new List<Categoria> { cienciaFiccion, accion, drama},
                anioDeSalida: new DateTime(2024, 6, 10),
                imagenBannerUrl: "RobotSalvaje_Banner.jpg",
                imagenPequeniaUrl: "RobotSalvaje_Estandar.jpg",
                duracion: 125,
                valoracion: 8.80
            ),
            new Pelicula(
                nombre: "Venom 3",
                descripcion: "Eddie Brock y Venom enfrentan un nuevo enemigo con el poder de alterar la realidad misma.",
                director: "Kelly Marcel",
                categorias: new List<Categoria> { accion, cienciaFiccion, superhéroes},
                anioDeSalida: new DateTime(2024, 7, 12),
                imagenBannerUrl: "Venom3_Banner.jpg",
                imagenPequeniaUrl: "Venom3_Estandar.jpg",
                duracion: 135,
                valoracion: 8.85
            ),
            new Pelicula(
                nombre: "Terrifier 3",
                descripcion: "El payaso Art regresa para sembrar el caos con nuevas víctimas en una ciudad aterrorizada.",
                director: "Damien Leone",
                categorias: new List<Categoria> { terror, suspenso, gore},
                anioDeSalida: new DateTime(2024, 11, 1),
                imagenBannerUrl: "Terrifier_Banner.jpg",
                imagenPequeniaUrl: "Terrifier_Estandar.jpg",
                duracion: 108,
                valoracion: 8.90
            )
        });
    }

    private static void InicializarSalas()
    {
        DataStore.Salas.AddRange(new List<Sala>{
            new Sala(
                numero: "1",
                tipo: "3D",
                capacidad: 30
            ),

            new Sala(
                numero: "2",
                tipo: "Estandar",
                capacidad: 50
            ),

            new Sala(
                numero: "3",
                tipo: "3D",
                capacidad: 30
            ),

            new Sala(
                numero: "4",
                tipo: "Estandar",
                capacidad: 30
            ),

            new Sala(
                numero: "5",
                tipo: "Audio Dolby",
                capacidad: 40
            ),
        });
    }

    private static void InicializarModelosAutoria()
    {
        DataStore.Productos.AddRange(new List<ModeloAutoria>
        {
            new ModeloAutoria(
                nombre: "Palomitas Grandes",
                descripcion: "Palomitas de maíz con mantequilla",
                tipoProducto: "Snack",
                cantidadEnInventario: 100,
                precio: 5.50,
                fechaIngreso: DateTime.Now.AddDays(-10),
                disponible: true
            ),

            new ModeloAutoria(
                nombre: "Refresco Mediano",
                descripcion: "Refresco de cola de 500ml",
                tipoProducto: "Bebida",
                cantidadEnInventario: 200,
                precio: 3.00,
                fechaIngreso: DateTime.Now.AddDays(-15),
                disponible: true
            ),

            new ModeloAutoria(
                nombre: "Combo Nachos",
                descripcion: "Nachos con queso y salsa, incluye refresco",
                tipoProducto: "Combo",
                cantidadEnInventario: 50,
                precio: 8.75,
                fechaIngreso: DateTime.Now.AddDays(-5),
                disponible: true
            ),

            new ModeloAutoria(
                nombre: "Chocolate",
                descripcion: "Barra de chocolate de 100g",
                tipoProducto: "Snack",
                cantidadEnInventario: 80,
                precio: 2.50,
                fechaIngreso: DateTime.Now.AddDays(-20),
                disponible: false
            ),

            new ModeloAutoria(
                nombre: "Agua Mineral",
                descripcion: "Botella de agua de 500ml",
                tipoProducto: "Bebida",
                cantidadEnInventario: 120,
                precio: 2.00,
                fechaIngreso: DateTime.Now.AddDays(-8),
                disponible: true
            )
        });
    }


    private static void InicializarSesiones()
    {
        Random random = new Random();


        for (int i = 0; i < 70; i++)
        {
            
            DateTime fechaBase = new DateTime(2024, 12, 5);
        
            Random random2 = new Random();

            int diasAdicionales = random2.Next(0, 25);
 
            DateTime fechaRandom = fechaBase.AddDays(diasAdicionales);
            
            var pelicula = DataStore.Peliculas[random.Next(DataStore.Peliculas.Count)];
            var sala = DataStore.Salas[random.Next(DataStore.Salas.Count)];

            double descuento = Math.Round(random.NextDouble() * 0.5, 2);

            DateTime fechaInicio = fechaRandom.AddMinutes(random.Next(0, 1440));

            Sesion sesion = new Sesion(
                pelicula: pelicula,
                sala: sala,
                descuento: descuento,
                fechaInicio: fechaInicio
            );
            sesion.CalcularPrecio();
            sesion.AnadirAsientos();
            DataStore.Sesiones.Add(sesion);
        }
    }

}
