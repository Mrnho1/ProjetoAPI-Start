using Microsoft.AspNetCore.Mvc;
using ProdutosAPI.Models;

namespace ProdutosAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ProdutoController : ControllerBase
{
    //declaração da lista onde Produto vem da classe Models
    private static List<Produto> produtos = new List<Produto>();

    [HttpPost]
    public IActionResult PostProduto([FromBody] Produto produto)
    {
        produtos.Add(produto);
        //essa linha padroniza o retorno do caminho do item criado no momento do POST
        return CreatedAtAction(nameof(GetProdutosById), new {id = produto.id_produto}, produto);
    }

    [HttpGet]
    public IEnumerable<Produto> GetProdutos([FromQuery] int skip = 0 , [FromQuery] int take = 50) { 
        return produtos.Skip(skip).Take(take);
    }

    [HttpGet("{id}")]
    public IActionResult GetProdutosById(int id)
    {
       var produto = produtos.FirstOrDefault(produto => produto.id_produto == id);
        if (produto == null) return NotFound();
        else return Ok();
    }
}
