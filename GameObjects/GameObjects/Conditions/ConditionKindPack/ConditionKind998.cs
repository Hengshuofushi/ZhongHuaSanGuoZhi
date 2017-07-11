﻿namespace GameObjects.Conditions.ConditionKindPack
{
    using GameObjects;
    using GameObjects.Conditions;
    using System;

    internal class ConditionKind998 : ConditionKind
    {
        public override bool CheckConditionKind(Person person)
        {
            return person.Scenario.IsPlayer(person.BelongedFactionWithPrincess);
        }

        public override bool CheckConditionKind(Architecture architecture)
        {
            return architecture.Scenario.IsPlayer(architecture.BelongedFaction);
        }

        public override bool CheckConditionKind(Faction faction)
        {
            return faction.Scenario.IsPlayer(faction);
        }

        public override bool CheckConditionKind(Troop troop)
        {
            return troop.Scenario.IsPlayer(troop.BelongedFaction);
        }
    }
}

