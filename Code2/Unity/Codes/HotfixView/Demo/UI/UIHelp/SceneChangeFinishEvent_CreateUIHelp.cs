﻿namespace ET
{
    public class SceneChangeFinishEvent_CreateUIHelp : AEventAsync<EventType.SceneChangeFinish>
    {
        protected override async ETTask Run(EventType.SceneChangeFinish args)
        {
            await ETTask.CompletedTask;
            //await args.CurrentScene.GetComponent<UIComponent>().ShowWindowAsync(WindowID.WindowID_Helper);
        }
    }
}
