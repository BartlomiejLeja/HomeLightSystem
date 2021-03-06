﻿using MediatR;
using System;

namespace LightingSystem.API.Features.LightPoint.ChangeLightBulbStatus
{
    public class ChangeLightBulbStatusCommand : IRequest<Guid>
    {
        public Guid LightBulbId { get; set; }
        public bool Status { get; set; }

        public ChangeLightBulbStatusCommand(Guid lightBulbId, bool status)
        {
            LightBulbId = lightBulbId;
            Status = status;
        }
    }
}
