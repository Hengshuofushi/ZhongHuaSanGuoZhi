﻿namespace GameObjects.Influences.InfluenceKindPack
{
    using GameObjects;
    using GameObjects.Influences;
    using System;

    internal class InfluenceKind824 : InfluenceKind
    {
        private float rate = 1f;

        public override void ApplyInfluenceKind(Troop troop)
        {
            troop.OffenceRateOnSubdueShuijun = this.rate;
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.rate = float.Parse(parameter);
            }
            catch
            {
            }
        }
    }
}

