﻿using BrewUp.Shared.Dtos;

namespace BrewUp.Sales.ReadModel.Entities;

public class SalesOrderRow
{
    public string BeerId { get; set; } = string.Empty;
    public string BeerName { get; set; } = string.Empty;
    public Quantity Quantity { get; set; } = default!;
    public Price Price { get; set; } = default!;
}