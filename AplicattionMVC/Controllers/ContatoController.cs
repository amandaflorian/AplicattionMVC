﻿using AplicattionMVC.Models;
using AplicattionMVC.Repositorio;
using Microsoft.AspNetCore.Mvc;

namespace AplicattionMVC.Controllers
{
    public class ContatoController : Controller
    {
        private readonly IContatoRepositorio _contatoRepositorio;
        public ContatoController(IContatoRepositorio contatoRepositorio)
        {
            _contatoRepositorio = contatoRepositorio;
        }
        public IActionResult Index()
        {
            List<ContatoModel> contatos = _contatoRepositorio.BuscarTodos();
            return View(contatos);
        }
        public IActionResult Criar()
        {
            return View();
        }
        public IActionResult Editar(int id)
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }
        public IActionResult ApagarConfirmacao(int id)
        {
            ContatoModel contato = _contatoRepositorio.ListarPorId(id);
            return View(contato);
        }

        public IActionResult Apagar(int id)
        {
            try
            {
                    
                bool apagado = _contatoRepositorio.Apagar(id);
                if (apagado)
                {

                    TempData["MensagemSucesso"] = "Contato apagado com sucesso";
                    return RedirectToAction("Index");
                }
                else
                {
                    TempData["MensagemErro"] = "Ops, não conseguimos apagar seu contato";
                }

                return RedirectToAction("Index");
            }
            catch (Exception ex)
            {
                TempData["MensagemSucesso"] = $"Ops, não conseguimos apagar seu contato. Tente novamente. Detalhe do erro: {ex.Message}";
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public IActionResult Criar(ContatoModel contato)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepositorio.Adicionar(contato);
                    TempData["MensagemSucesso"] = "Contato cadastrado com sucesso";
                    return RedirectToAction("Index");
                }

                return View(contato);
            }
            catch (Exception ex)
            {
                TempData["MensagemSucesso"] = $"Ops, não conseguimos cadastrar seu contato. Tente novamente. Detalhe do erro: {ex.Message}";
                return RedirectToAction("Index");
            }

        }

        [HttpPost]
        public IActionResult Alterar(ContatoModel contato)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _contatoRepositorio.Atualizar(contato);
                    TempData["MensagemSucesso"] = "Contato alterado com sucesso";
                    return RedirectToAction("Index");
                }
                return View("Editar", contato);
            }
            catch (Exception ex)
            {
                TempData["MensagemSucesso"] = $"Ops, não conseguimos atualizar seu contato. Tente novamente. Detalhe do erro: {ex.Message}";
                return RedirectToAction("Index");
            }
        }

    }
}
