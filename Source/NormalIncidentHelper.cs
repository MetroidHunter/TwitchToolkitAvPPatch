using RimWorld;
using System;
using TwitchToolkit;
using TwitchToolkit.Store;
using Verse;

namespace ToolkitAlienVsPredatorPatch
{
    public abstract class NormalIncidentHelper<T> : IncidentHelper where T : IncidentWorker
    {
        private IncidentDef incidentDef;
        private IncidentCategoryDef incidentCategoryDef;
        private IncidentParms parms = null;
        private IncidentWorker worker = null;

        private bool shouldForceFire = false;

        public NormalIncidentHelper(IncidentCategoryDef incidentCategoryDef, IncidentDef incidentDef) : this (incidentCategoryDef, incidentDef, false)
        {
        }

        public NormalIncidentHelper(IncidentCategoryDef incidentCategoryDef, IncidentDef incidentDef, bool shouldForceFire)
        {
            this.incidentDef = incidentDef;
            this.incidentCategoryDef = incidentCategoryDef;
            this.shouldForceFire = true;
        }

        protected void Log(string msg)
        {
            Verse.Log.Message($"<color=#6441FF>[AvPToolkit_{GetType().Name}]</color> {msg}");
        }

        public override bool IsPossible()
        {
            Log("Checking if possible..");
            worker = Activator.CreateInstance<T>();
            worker.def = incidentDef;

            Map map = Helper.AnyPlayerMap;

            if (map != null)
            {
                parms = StorytellerUtility.DefaultParmsNow(incidentCategoryDef, map);
                parms.forced = shouldForceFire;

                return worker.CanFireNow(parms);
            }

            return false;
        }

        public override void TryExecute()
        {
            bool success = worker.TryExecute(parms);
        }
    }
}
