using System.Collections.Generic;

namespace ET
{
    [ComponentOf(typeof(Scene))]
    public class ZoneSceneManagerComponent: Entity, IAwake, IDestroy
    {
        public static ZoneSceneManagerComponent Instance;
        public Dictionary<int, Scene> ZoneScenes = new Dictionary<int, Scene>();
    }
}