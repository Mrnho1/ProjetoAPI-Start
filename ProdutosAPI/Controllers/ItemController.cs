using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using ProdutosAPI.Data;
using ProdutosAPI.Data.DTOs;
using ProdutosAPI.Models;

namespace ProdutosAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class ItemController : ControllerBase
{
    private ItemContext _context;
    private IMapper _mapper;

    public ItemController(ItemContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    [HttpPost]
    public IActionResult PostItem(CreateItemDto itemDto)
    {
        Item item = _mapper.Map<Item>(itemDto);
        _context.Items.Add(item);
        _context.SaveChanges();
        return CreatedAtAction(nameof(GetItemById), new { pedidoId = item.pedidoIdFk,
            produtoId = item.produtoIdFk
        }, item);
    }

    [HttpGet]
    public IEnumerable<ReadItemDto> GetItem()
    {
        return _mapper.Map<List<ReadItemDto>>(_context.Items.ToList());
    }

    [HttpGet("{filmeId}/{cinemaId}")]
    public IActionResult GetItemById(int produtoId, int pedidoId)
    {
        Item item = _context.Items.FirstOrDefault(item => item.pedidoIdFk == pedidoId && item.produtoIdFk == produtoId);
        if (item != null)
        {
            ReadItemDto itemDto = _mapper.Map<ReadItemDto>(item);

            return Ok(itemDto);
        }
        return NotFound();
    }
}

