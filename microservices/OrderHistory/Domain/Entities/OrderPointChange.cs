﻿

using BuildingBlocks.Interfaces.Entities;

namespace Domain.Entities;

public class OrderPointChange:IEntity
{
    public int Id { get; set; }
    public int OrderId { get; set; }
    public int PointId { get; set; }
    public DateTime ChangeAt { get; set; } = DateTime.UtcNow;
}
