using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Scene))]
    public class AIDispatcherComponent: Entity, IAwake, IDestroy, ILoad
    {
        public static AIDispatcherComponent Instance;
        
        public Dictionary<string, AAIHandler> AIHandlers = new Dictionary<string, AAIHandler>();
    }
}