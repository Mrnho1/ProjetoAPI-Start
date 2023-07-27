using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProdutosAPI.Data.DTOs;
using ProdutosAPI.Data;
using ProdutosAPI.Models;

namespace ProdutosAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class PedidoController : ControllerBase
{

    private PedidoContext _context;
    private IMapper _mapper;

    public PedidoController(PedidoContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult PostPedido([FromBody] CreatePedidoDto pedidoDto)
    {
        Pedido pedido = _mapper.Map<Pedido>(pedidoDto);
        _context.Pedidos.Add(pedido);
        _context.SaveChanges();
        //essa linha padroniza o retorno do caminho do item criado no momento do POST
        return CreatedAtAction(nameof(GetPedidoById), new { id = pedido.id }, pedido);
    }

    [HttpGet]
    public IEnumerable<ReadPedidoDto> GetPedidos()
    {
        return _mapper.Map<List<ReadPedidoDto>>(_context.Pedidos.ToList());
    }

    [HttpGet("{id}")]
    public IActionResult GetPedidoById(int id)
    {
        var pedido = _context.Pedidos.FirstOrDefault(pedido => pedido.id == id);
        if (pedido == null) return NotFound();
        var pedidoDto = _mapper.Map<ReadPedidoDto>(pedido);
        return Ok(pedidoDto);
    }

    [HttpPut("{id}")]
    public IActionResult UpdatePeidido(int id, [FromBody] UpdatePedidoDto pedidoDto)
    {
        var pedido = _context.Pedidos.FirstOrDefault(pedido => pedido.id == id);
        if (pedido == null) return NotFound();
        _mapper.Map(pedidoDto, pedido);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeletePedido(int id)
    {
        var pedido = _context.Pedidos.FirstOrDefault(pedido => pedido.id == id);
        if (pedido == null) return NotFound();
        _context.Remove(pedido);
        _context.SaveChanges();
        return NoContent();
    }
}
