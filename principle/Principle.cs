using System;
using KRPC.Service;
using KRPC.Service.Attributes;
using System.Reflection;
using System.Linq;
using UnityEngine;

namespace Principle
{
    [KRPCService(Name = "Principia")]
    public static class Principle
    {
        static void CheckAPI()
        {
            if (!PrincipiaWrapper.Ready) 
                throw new InvalidOperationException ("Principia is not available");
        }
        
        
        [KRPCProperty]
        public static bool Available => PrincipiaWrapper.Ready;

        [KRPCProcedure(GameScene = GameScene.Flight)]
        public static bool FlightPlanExists()
        {
            CheckAPI();
            return PrincipiaWrapper.FlightPlanExists(FlightGlobals.ActiveVessel.id);
        }
    }
}