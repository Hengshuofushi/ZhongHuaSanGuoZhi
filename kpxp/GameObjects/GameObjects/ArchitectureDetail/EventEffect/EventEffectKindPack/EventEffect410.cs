﻿namespace GameObjects.ArchitectureDetail.EventEffect
{
    using GameObjects;
    using System;

    internal class EventEffect410 : EventEffectKind
    {
        private int type;

        public override void ApplyEffectKind(Person person, Event e)
        {
            person.Braveness += type;
        }

        public override void InitializeParameter(string parameter)
        {
            try
            {
                this.type = int.Parse(parameter);
            }
            catch
            {
            }
        }
    }
}

