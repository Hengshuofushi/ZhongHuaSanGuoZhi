﻿namespace GameObjects.Influences.InfluenceKindPack
{
    using GameObjects;
    using GameObjects.Influences;
    using System;

    internal class InfluenceKind710 : InfluenceKind
    {
        private int increment;

        public override void ApplyInfluenceKind(Troop troop)
        {
            troop.IncrementOfChaosAfterSurroundAttackChance += this.increment;
        }


        public override void PurifyInfluenceKind(Troop troop)
        {
            troop.IncrementOfChaosAfterSurroundAttackChance -= this.increment;
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.increment = int.Parse(parameter);
            }
            catch
            {
            }
        }
    }
}

