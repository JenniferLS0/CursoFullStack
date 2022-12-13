using Microsoft.AspNetCore.Mvc;
using ProEventos.API.Models;

namespace ProEventos.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EventoController : ControllerBase
{

    public IEnumerable<Evento> _evento = new Evento[]{
        new Evento() {
                EventoID = 1,
                Tema = "Angular 14 e .NET 6",
                Local = "São Paulo",
                Lote = "1° Lote",
                QtdPessoas = 250,
                DataEvento = DateTime.Now.AddDays(2).ToString(),
                ImagemURL = "foto.png"
            },

            new Evento() {
                EventoID = 2,
                Tema = "Angular 14 suas novidades",
                Local = "Santa Catarina",
                Lote = "2° Lote",
                QtdPessoas = 500,
                DataEvento = DateTime.Now.AddDays(3).ToString(),
                ImagemURL = "foto2.png"
            }
        };


    public EventoController()
    {

    }

    [HttpGet]
    public IEnumerable<Evento> Get()
    {
        return _evento;
    }

    [HttpGet("{id}")]
    public IEnumerable<Evento> GetById(int id)
    {
        return _evento.Where(evento => evento.EventoID == id);
    }


    [HttpPost]
    public String Post()
    {
        return "exemplo de post";
    }

    [HttpPut("{id}")]
    public String Put(int id)
    {
        return $"exemplo de put com id = {id}";
    }

    [HttpDelete("{id}")]
    public String Delete(int id)
    {
        return $"exemplo de Delete  com id = {id}";
    }

    //Diego Higa é muito brabo by matheus


}
