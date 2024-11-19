using System;
// Importar otros metodos de extension (where, select, selectmany/any)
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace PrimeraApp
{
    // Con el where, hacemos que <T> sea de un tipo Media
    public class PlayList<T> where T : Song
    {
        //Creamos un ArrayList
        List<T> mediaList = new List<T>();

        //Añades todas las canciones a la lista
        public void AddSong(T Media)
        {
            //Añades la lista con las canciones
            mediaList.Add(Media);
        }
        public void PlayAll()
        {
            //Bucle que recorra la lista y va mostrando las canciones una a una
            foreach (T media in mediaList)
            {
                Console.WriteLine(media);
            }
        }

        public void Preview()
        {
            if (mediaList.Count > 0)
            {
                Console.WriteLine(mediaList[0]);
            }
        }

        // Filtrar por categorías
        public List<T> SearchForCategory(String categoria)
        {
            // Creamos una lista con todas las canciones
            List<T> songs = new List<T>();
            // Recorremos toda la lista
            foreach (T song in mediaList) 
            {
                // Si la categoría de la cancion coincide con la que buscamos,
                // se añade al return
                if (song.Category == categoria)
                {
                    songs.Add(song);
                }
            }
            return songs;
        }

        // El mismo que arriba pero aplicando el where
        public List<T> SearchForTitle(string titulo)
        {
            var songs = mediaList.Where(x => x.Title == titulo).ToList();
            return songs;
        }

        // Devolver todos los titulos de canciones
        public List<string> GimmeTitlesFromSongs() 
        {
            var titles = mediaList.Select(x => x.Title);
            return titles.ToList();
        }

        // Retornas todos los nombres de artistas
        public List<string> GimmeNamesOfArtists()
        {
            var namesOfArtists = mediaList.SelectMany(x => x.Artists)
                                          .Select(x => x.Name);
            return namesOfArtists.ToList();
        }

        // Retorna si existe x titulo en la playList
        public bool HaveATitle(string Title) 
        { 
            return mediaList.Any(x => x.Title == Title);
        }

        // Retorna la primera cancion con menos de 60 segundos
        public Song GetFirstSongLess1Minute()
        {
            var song =   mediaList.First(x => x.Seconds < 60);
            return song;
        }

        // Retorna la última cancion con menos de 60 segundos
        public Song GetLastSongLess1Minute()
        {
            var song = mediaList.Last(x => x.Seconds < 60);
            return song;
        }

        // Retorna el top 10 mas visitas
        public List<T> Top10()
        {
            return mediaList.OrderBy(x => x.Visits).Take(10).ToList();
        }

        // Retorna las 10 menos vistas
        public T[] Botom10() 
        {
            return mediaList.OrderByDescending(x => x.Visits).Take(10).ToArray();
        }

        // Organiza por categorías
        public void GroupFromCategory()
        {
            mediaList.GroupBy(x => x.Category).ToDictionary(x => x.Key);
        }

        // Retorna el top 20 saltando las 10 primeras agregadas
        public List<T> Skip10Top20() 
        {
            return mediaList.Skip(10).Take(10).ToList();
        }

        // Convertir de mediaList a Media
        public List<Media> ToConvertMedia()
        {
            return mediaList.OfType<Media>().ToList();
        }
    }
}
