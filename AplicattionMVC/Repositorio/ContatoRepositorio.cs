﻿using AplicattionMVC.Data;
using AplicattionMVC.Models;

namespace AplicattionMVC.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext) 
        {
            _bancoContext = bancoContext;
        }
        public ContatoModel Adicionar(ContatoModel contato)
        {
           _bancoContext.Contatos.Add(contato);
           _bancoContext.SaveChanges();
           return contato;
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }
    }
}
