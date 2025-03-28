

using System.Net;

namespace ET
{
    public static class SceneFactory
    {
        public static async ETTask<Scene> Create(Entity parent, string name, SceneType sceneType)
        {
            long instanceId = IdGenerater.Instance.GenerateInstanceId();
            return await Create(parent, instanceId, instanceId, parent.DomainZone(), name, sceneType);
        }
        
        public static async ETTask<Scene> Create(Entity parent, long id, long instanceId, int zone, string name, SceneType sceneType, StartSceneConfig startSceneConfig = null)
        {
            await ETTask.CompletedTask;
            Scene scene = EntitySceneFactory.CreateScene(id, instanceId, zone, sceneType, name, parent);

            scene.AddComponent<MailBoxComponent, MailboxType>(MailboxType.UnOrderMessageDispatcher);

            switch (scene.SceneType)
            {
                case SceneType.Realm:
                    scene.AddComponent<NetKcpComponent, IPEndPoint, int>(startSceneConfig.InnerIPOutPort, SessionStreamDispatcherType.SessionStreamDispatcherServerOuter);
                    scene.AddComponent<TokenComponent>();
                    break;
                case SceneType.Gate:
                    scene.AddComponent<NetKcpComponent, IPEndPoint, int>(startSceneConfig.InnerIPOutPort, SessionStreamDispatcherType.SessionStreamDispatcherServerOuter);
                    scene.AddComponent<PlayerComponent>();
                    scene.AddComponent<GateSessionKeyComponent>();
                    break;
                case SceneType.Map:
                    scene.AddComponent<UnitComponent>();
                    scene.AddComponent<AOIManagerComponent>();
                  
                    break;
                case SceneType.Location:
                    scene.AddComponent<LocationComponent>();
                    break;
                case SceneType.Account:
                    scene.AddComponent<NetKcpComponent, IPEndPoint, int>(startSceneConfig.InnerIPOutPort, SessionStreamDispatcherType.SessionStreamDispatcherServerOuter);
                    scene.AddComponent<TokenComponent>();
                    scene.AddComponent<AccountSessionsComponent>();
                    scene.AddComponent<ServerInfoManagerComponent>();
                    break;
                case SceneType.LoginCenter:
                    scene.AddComponent<LoginInfoRecordComponent>();
                    break;
                case SceneType.UnitCache:
                    scene.AddComponent<UnitCacheComponent>();
                    break;
                case SceneType.Rank:
                    await scene.AddComponent<RankInfosComponent>().LoadRankInfo();
                    break;
                case SceneType.ChatInfo:
                    scene.AddComponent<ChatInfoUnitsComponent>();
                    break;
                
            }

            return scene;
        }
    }
}