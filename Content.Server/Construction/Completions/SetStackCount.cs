﻿using System.Threading.Tasks;
using Content.Server.Stack;
using Content.Shared.Construction;
using JetBrains.Annotations;
using Robust.Shared.GameObjects;
using Robust.Shared.Serialization.Manager.Attributes;

namespace Content.Server.Construction.Completions
{
    [UsedImplicitly]
    [DataDefinition]
    public class SetStackCount : IGraphAction
    {
        [DataField("amount")] public int Amount { get; } = 1;

        public async Task PerformAction(IEntity entity, IEntity? user)
        {
            if (entity.Deleted) return;

            EntitySystem.Get<StackSystem>().SetCount(entity.Uid, Amount);
        }
    }
}
