using RimWorld;
using RRYautja;

namespace ToolkitAlienVsPredatorPatch
{
    public class IncidentHelper_UnknownShipImpact : WagerIncidentHelper<IncidentWorker_CrashedShip>
    {
        public IncidentHelper_UnknownShipImpact() : base(IncidentCategoryDefOf.ThreatBig, IncidentDef.Named("RRY_XenomorphCrashedShipPartCrash"), RaidStrategyDefOf.ImmediateAttack, PawnsArrivalModeDefOf.CenterDrop) { }
    }

    public class IncidentHelper_HiveInfestation : WagerIncidentHelper<IncidentWorker_Hivelike>
    {
        public IncidentHelper_HiveInfestation() : base(IncidentCategoryDefOf.ThreatBig, IncidentDef.Named("RRY_XenomorphInfestation")) { }
    }

    public class IncidentHelper_FriendlyXenoRaid : WagerIncidentHelper<IncidentWorker_RaidFriendly_FactionSpecific>
    {
        public IncidentHelper_FriendlyXenoRaid() : base(IncidentCategoryDefOf.AllyAssistance, IncidentDef.Named("RaidFriendly_FactionSpecific"), RaidStrategyDefOf.ImmediateAttack, PawnsArrivalModeDefOf.EdgeDrop) { }
    }

    public class IncidentHelper_EnemyXenoRaid : WagerIncidentHelper<IncidentWorker_RaidEnemy_FactionSpecific>
    {
        public IncidentHelper_EnemyXenoRaid() : base(IncidentCategoryDefOf.ThreatBig, IncidentDef.Named("RRY_RaidEnemy_FactionSpecific"), RaidStrategyDefOf.ImmediateAttack, PawnsArrivalModeDefOf.EdgeWalkIn) { }
    }

    public class IncidentHelper_StrangeFungusSprouts : NormalIncidentHelper<IncidentWorker_NeomorphFungusSprout>
    {
        public IncidentHelper_StrangeFungusSprouts() : base(IncidentCategoryDefOf.Misc, IncidentDef.Named("RRY_Neomorph_FungusSprout")) { }
    }

    public class IncidentHelper_StrangeFungusSproutsSilent : NormalIncidentHelper<IncidentWorker_NeomorphFungusSprout>
    {
        public IncidentHelper_StrangeFungusSproutsSilent() : base(IncidentCategoryDefOf.Misc, IncidentDef.Named("RRY_Neomorph_FungusSprout_Hidden")) { }
    }

    public class IncidentHelper_PowerCutV1 : NormalIncidentHelper<IncidentWorker_PowerCut>
    {
        public IncidentHelper_PowerCutV1() : base(IncidentCategoryDefOf.Misc, IncidentDef.Named("RRY_PowerCut_Xenomorph")) { }
    }

    public class IncidentHelper_PowerCutV2 : NormalIncidentHelper<IncidentWorker_PowerCutP1>
    {
        public IncidentHelper_PowerCutV2() : base(IncidentCategoryDefOf.Misc, IncidentDef.Named("RRY_PowerCut_XenomorphV2")) { }
    }
}
