﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;

namespace ScreenSound.Banco
{
    internal class ArtistaDAL: DAL
    {

        private readonly ScreenSoundContext context;

        public ArtistaDAL(ScreenSoundContext context)
        {
            this.context = context;
        }


        public IEnumerable<Artista> Listar()
        {
            return context.Artistas.ToList();
        }

        public void Adicionar(Artista artista)
        {
            context.Artistas.Add(artista);
            context.SaveChanges();
            
        }

        public void Atualizar(Artista artista)
        {
            context.Artistas.Update(artista);
            context.SaveChanges();
        }

        public void Deletar(Artista artista)
        {
            context.Artistas.Remove(artista);
            context.SaveChanges();
        }

        public Artista? RecuperarPleoNome(string nome)
        {
            return context.Artistas.FirstOrDefault(a => a.Nome.Equals(nome));
        }
    }
}
