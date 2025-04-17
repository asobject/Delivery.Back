﻿using BuildingBlocks.Messaging.Events;
using Domain.Interfaces.Repositories;
using MassTransit;
using MediatR;

namespace Application.Features.OrderChanges.Commands.PointChange;

public class OrderPointChangeCommandHandler(IUnitOfWork unitOfWork) 
: IRequestHandler<OrderPointChangeCommand, OrderPointChangeResponse>
{
    public async Task<OrderPointChangeResponse> Handle(OrderPointChangeCommand request, CancellationToken cancellationToken)
    {
        await unitOfWork.PointChanges.AddAsync(
            new Domain.Entities.OrderPointChange
            {
                OrderId = request.OrderId,
                PointId = request.PointId
            });
        return new OrderPointChangeResponse(Message: "order current point change successful");
    }
}
