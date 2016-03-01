﻿namespace GameObjects.TroopDetail.EventEffect.EventEffectKindPack
{
    using GameObjects;
    using GameObjects.Influences;
    using GameObjects.TroopDetail.EventEffect;
    using System;

    internal class EventEffectKind100 : EventEffectKind
    {
        private int number = -1;

        public override void ApplyEffectKind(Person person)
        {
            if (person.LocationTroop != null)
            {
                Influence t = person.Scenario.GameCommonData.AllInfluences.GetInfluence(this.number);
                if (t != null)
                {
                    person.LocationTroop.EventInfluences.Add(t);
                    t.ApplyInfluence(person.LocationTroop, Applier.Event, 0);
                }
            }
        }

        public override void ApplyEffectKind(Troop troop)
        {
            Influence t = troop.Scenario.GameCommonData.AllInfluences.GetInfluence(this.number);
            if (t != null)
            {
                troop.EventInfluences.Add(t);
                t.ApplyInfluence(troop, Applier.Event, 0);
            }
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.number = int.Parse(parameter);
            }
            catch
            {
            }
        }
    }
}

