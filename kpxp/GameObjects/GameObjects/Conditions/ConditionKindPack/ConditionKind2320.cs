﻿namespace GameObjects.Conditions.ConditionKindPack
{
    using GameObjects;
    using GameObjects.Conditions;
    using System;

    internal class ConditionKind2320 : ConditionKind
    {
        private int val;

        public override bool CheckConditionKind(Architecture a)
        {
            return a.Meinvkongjian - a.Feiziliebiao.Count >= val;
        }

        public override bool CheckConditionKind(Faction faction)
        {
            return faction.meinvkongjian() - faction.feiziCount() >= val;
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.val = int.Parse(parameter);
            }
            catch
            {
            }
        }

    }
}

