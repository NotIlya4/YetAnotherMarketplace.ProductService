﻿using Domain.Entities;

namespace Infrastructure.ProductService.Views;

public class GetProductsResult
{
    public List<Product> Products { get; }
    public int Total { get; }

    public GetProductsResult(List<Product> products, int total)
    {
        Products = products;
        Total = total;
    }
}