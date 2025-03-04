﻿namespace ET
{
    [ComponentOf(typeof(Scene))]
    [ChildType(typeof(DBComponent))]
    public class DBManagerComponent: Entity, IAwake, IDestroy
    {
        public static DBManagerComponent Instance;
        
        public DBComponent[] DBComponents = new DBComponent[IdGenerater.MaxZone];
    }
}