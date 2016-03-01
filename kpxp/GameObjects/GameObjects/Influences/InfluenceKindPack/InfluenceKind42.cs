﻿namespace GameObjects.Influences.InfluenceKindPack
{
    using GameObjects;
    using GameObjects.Influences;
    using System;

    internal class InfluenceKind42 : InfluenceKind
    {
        private float multiple = 1;

        public override void ApplyInfluenceKind(Person person)
        {
            if (person.LocationTroop != null)
            {
                person.LocationTroop.MultipleOfCombatTechniquePoint += this.multiple - 1;
            }
        }

        public override void PurifyInfluenceKind(Person person)
        {
            if (person.LocationTroop != null)
            {
                person.LocationTroop.MultipleOfCombatTechniquePoint -= this.multiple - 1;
            }
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.multiple = float.Parse(parameter);
            }
            catch
            {
            }
        }
    }
}

