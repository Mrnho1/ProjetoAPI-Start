﻿using System.ComponentModel.DataAnnotations;

namespace ProdutosAPI.Data.DTOs;

public class ReadProdutoDto
{
    public string nome_produto { get; set; }
    public float valor_produto { get; set; }
    public string categoria { get; set; }
}