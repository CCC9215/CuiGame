namespace ET
{
    public static class CoroutineLockType
    {
        public const int None = 0;
        public const int Location = 1;                  // location进程上使用
        public const int ActorLocationSender = 2;       // ActorLocationSender中队列消息 
        public const int Mailbox = 3;                   // Mailbox中队列
        public const int UnitId = 4;                    // Map服务器上线下线时使用
        public const int DB = 5;
        public const int Resources = 6;
        public const int ResourcesLoader = 7;

        public const int LoadUIBaseWindows = 15; 

        public const int LoginAccount = 8;
        public const int LoginCenterLock = 9;
        public const int GateLoginLock = 10;

        public const int CreateRole = 11;

        public const int LoginRealm = 12;

        public const int LoginGate = 13;

        public const int UnitCacheGet = 14;

        public const int Max = 100; // 这个必须最大
    }
}