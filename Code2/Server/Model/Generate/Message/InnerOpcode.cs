namespace ET
{
	public static partial class InnerOpcode
	{
		 public const ushort ObjectQueryRequest = 20002;
		 public const ushort M2A_Reload = 20003;
		 public const ushort A2M_Reload = 20004;
		 public const ushort G2G_LockRequest = 20005;
		 public const ushort G2G_LockResponse = 20006;
		 public const ushort G2G_LockReleaseRequest = 20007;
		 public const ushort G2G_LockReleaseResponse = 20008;
		 public const ushort ObjectAddRequest = 20009;
		 public const ushort ObjectAddResponse = 20010;
		 public const ushort ObjectLockRequest = 20011;
		 public const ushort ObjectLockResponse = 20012;
		 public const ushort ObjectUnLockRequest = 20013;
		 public const ushort ObjectUnLockResponse = 20014;
		 public const ushort ObjectRemoveRequest = 20015;
		 public const ushort ObjectRemoveResponse = 20016;
		 public const ushort ObjectGetRequest = 20017;
		 public const ushort ObjectGetResponse = 20018;
		 public const ushort R2G_GetLoginKey = 20019;
		 public const ushort G2R_GetLoginKey = 20020;
		 public const ushort M2M_UnitTransferResponse = 20021;
		 public const ushort G2M_SessionDisconnect = 20022;
		 public const ushort A2L_LoginAccountRequest = 20023;
		 public const ushort L2A_LoginAccountResponse = 20024;
		 public const ushort L2G_DisconnectGateUnit = 20025;
		 public const ushort G2L_DisconnectGateUnit = 20026;
		 public const ushort A2R_GetRealmKey = 20027;
		 public const ushort R2A_GetRealmKey = 20028;
		 public const ushort R2G_GetLoginGateKey = 20029;
		 public const ushort G2R_GetLoginGateKey = 20030;
		 public const ushort G2L_AddLoginRecord = 20031;
		 public const ushort L2G_AddLoginRecord = 20032;
		 public const ushort G2M_RequestEnterGameState = 20033;
		 public const ushort M2G_RequestEnterGameState = 20034;
		 public const ushort G2M_RequestExitGame = 20035;
		 public const ushort M2G_RequestExitGame = 20036;
		 public const ushort G2L_RemoveLoginRecord = 20037;
		 public const ushort L2G_RemoveLoginRecord = 20038;
		 public const ushort Other2UnitCache_AddOrUpdateUnit = 20039;
		 public const ushort UnitCache2Other_AddOrUpdateUnit = 20040;
		 public const ushort Other2UnitCache_GetUnit = 20041;
		 public const ushort Other2UnitCache_DeleteUnit = 20042;
		 public const ushort UnitCache2Other_DeleteUnit = 20043;
		 public const ushort G2Chat_EnterChat = 20044;
		 public const ushort Chat2G_EnterChat = 20045;
		 public const ushort G2Chat_RequestExitChat = 20046;
		 public const ushort Chat2G_RequestExitChat = 20047;
	}
}
