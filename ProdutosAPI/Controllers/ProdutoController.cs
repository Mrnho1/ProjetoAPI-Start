using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ProdutosAPI.Data;
using ProdutosAPI.Data.DTOs;
using ProdutosAPI.Models;

namespace ProdutosAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutoController : ControllerBase
{

    private PedidoContext _context;
    private IMapper _mapper;

    public ProdutoController(PedidoContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult PostProduto([FromBody] CreateProdutoDto produtoDto)
    {
        Produto produto = _mapper.Map<Produto>(produtoDto);
        _context.Produtos.Add(produto);
        _context.SaveChanges();
        //essa linha padroniza o retorno do caminho do item criado no momento do POST
        return CreatedAtAction(nameof(GetProdutosById), new {id = produto.id}, produto);
    }

    [HttpGet]
    public IEnumerable<ReadProdutoDto> GetProdutos([FromQuery] int skip = 0 , [FromQuery] int take = 50) {
        return _mapper.Map<List<ReadProdutoDto>>(_context.Produtos.Skip(skip).Take(take));
    }

    [HttpGet("{id}")]
    public IActionResult GetProdutosById(int id)
    {
       var produto = _context.Produtos.FirstOrDefault(produto => produto.id == id);
        if (produto == null) return NotFound();
        var produtoDto = _mapper.Map<ReadProdutoDto>(produto);
        return Ok(produtoDto);
    }

    [HttpPut("{id}")]
    public IActionResult UpdateProduto(int id, [FromBody] UpdateProdutoDto produtoDto)
    {
        var produto = _context.Produtos.FirstOrDefault(produto => produto.id == id);
        if(produto == null) return NotFound();
        _mapper.Map(produtoDto, produto);
        _context.SaveChanges();
        return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteProduto(int id) 
    {
        var produto = _context.Produtos.FirstOrDefault(produto => produto.id == id);
        if(produto == null) return NotFound();
        _context.Remove(produto);
        _context.SaveChanges();
        return NoContent();
    }
}
