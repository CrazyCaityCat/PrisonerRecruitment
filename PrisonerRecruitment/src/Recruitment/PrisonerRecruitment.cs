using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Threading;
using TaleWorlds.Core;
using TaleWorlds.Localization;
using TaleWorlds.MountAndBlade;
using TaleWorlds.CampaignSystem;
using TaleWorlds.CampaignSystem.SandBox.GameComponents;


public class PrisonerRecruitment : DefaultPrisonerRecruitmentCalculationModel

{ 
        public override int GetConformityChangePerHour(PartyBase party)
              { 
                return 5;
              }

        public override float[] GetDailyRecruitedPrisoners(MobileParty mainParty)
              {
                return new float[7]
                    {
                    6f,
                    3f,
                    1.5f,
                    0.75f,
                    0.385f,
                    0.2f,
                    0.1f
                    };
             }
}