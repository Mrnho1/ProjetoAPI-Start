using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProdutosAPI.Data.DTOs;
using ProdutosAPI.Data;
using ProdutosAPI.Models;

namespace ProdutosAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ClienteController : ControllerBase
{
    private ItemContext _context;
    private IMapper _mapper;

    public ClienteController(ItemContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult PostCliente([FromBody] CreateClienteDto clienteDto)
    {
        Cliente cliente = _mapper.Map<Cliente>(clienteDto);
        _context.Clientes.Add(cliente);
        _context.SaveChanges();
        //essa linha padroniza o retorno do caminho do item criado no momento do POST
        return CreatedAtAction(nameof(GetClienteById), new { id = cliente.clienteId }, cliente);
    }

    [HttpGet]
    public IEnumerable<ReadClienteDto> GetClientes([FromQuery] int skip = 0, [FromQuery] int take = 50)
    {
        return _mapper.Map<List<ReadClienteDto>>(_context.Clientes.Skip(skip).Take(take));
    }

    [HttpGet("{id}")]
    public IActionResult GetClienteById(int id)
    {
        var cliente = _context.Clientes.FirstOrDefault(cliente => cliente.clienteId == id);
        if (cliente == null) return NotFound();
        var clienteDto = _mapper.Map<ReadClienteDto>(cliente);
        return Ok(clienteDto);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateCliente(int id, [FromBody] UpdateClienteDto clienteDto)
    {
        var cliente = _context.Clientes.FirstOrDefault(cliente => cliente.clienteId == id);
        if (cliente == null) return NotFound();
        _mapper.Map(clienteDto, cliente);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteCliente(int id)
    {
        var cliente = _context.Clientes.FirstOrDefault(cliente => cliente.clienteId == id);
        if (cliente == null) return NotFound();
        _context.Remove(cliente);
        _context.SaveChanges();
        return NoContent();
    }
}
