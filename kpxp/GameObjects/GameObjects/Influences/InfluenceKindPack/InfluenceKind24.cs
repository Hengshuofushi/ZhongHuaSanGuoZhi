﻿namespace GameObjects.Influences.InfluenceKindPack
{
    using GameObjects;
    using GameObjects.Influences;
    using System;

    internal class InfluenceKind24 : InfluenceKind
    {
        private int multiple = 1;

        public override void ApplyInfluenceKind(Person person)
        {
            person.MultipleOfMoraleReputation += this.multiple - 1;
        }

        public override void PurifyInfluenceKind(Person person)
        {
            person.MultipleOfMoraleReputation -= this.multiple - 1;
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.multiple = int.Parse(parameter);
            }
            catch
            {
            }
        }
    }
}

