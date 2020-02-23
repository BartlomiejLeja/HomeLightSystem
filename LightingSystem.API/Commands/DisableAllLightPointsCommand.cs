﻿using MediatR;
using System;

namespace LightingSystem.API.Commands
{
    public class DisableAllLightPointsCommand : IRequest<Guid>
    {
        public Guid HomeLightSystemId { get; set; }

        public DisableAllLightPointsCommand(Guid homeLightSystemId)
        {
            HomeLightSystemId = homeLightSystemId;
        }
    }
}
