﻿using BrewUp.Sales.SharedKernel.DomainIds;
using BrewUp.Sales.SharedKernel.Dtos;
using BrewUp.Shared.DomainIds;
using BrewUp.Shared.Dtos;
using Muflone.Messages.Events;

namespace BrewUp.Sales.Messages.Events;

public sealed class SalesOrderCreated : DomainEvent
{
    public readonly SalesOrderId SalesOrderId;
    public readonly CustomerId CustomerId;
    public readonly OrderDate OrderDate;

    public readonly IEnumerable<SalesOrderLineDto> Lines;

    public SalesOrderCreated(SalesOrderId aggregateId, CustomerId customerId, OrderDate orderDate,
        IEnumerable<SalesOrderLineDto> lines) : base(aggregateId)
    {
        SalesOrderId = aggregateId;
        CustomerId = customerId;
        OrderDate = orderDate;

        Lines = lines;
    }
}