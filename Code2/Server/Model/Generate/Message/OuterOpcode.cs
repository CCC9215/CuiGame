namespace ET
{
	public static partial class OuterOpcode
	{
		 public const ushort C2M_TestRequest = 10002;
		 public const ushort M2C_TestResponse = 10003;
		 public const ushort Actor_TransferRequest = 10004;
		 public const ushort Actor_TransferResponse = 10005;
		 public const ushort C2G_EnterMap = 10006;
		 public const ushort G2C_EnterMap = 10007;
		 public const ushort MoveInfo = 10008;
		 public const ushort UnitInfo = 10009;
		 public const ushort M2C_CreateUnits = 10010;
		 public const ushort M2C_CreateMyUnit = 10011;
		 public const ushort M2C_StartSceneChange = 10012;
		 public const ushort M2C_RemoveUnits = 10013;
		 public const ushort C2M_PathfindingResult = 10014;
		 public const ushort C2M_Stop = 10015;
		 public const ushort M2C_PathfindingResult = 10016;
		 public const ushort M2C_Stop = 10017;
		 public const ushort C2G_Ping = 10018;
		 public const ushort G2C_Ping = 10019;
		 public const ushort G2C_Test = 10020;
		 public const ushort C2M_Reload = 10021;
		 public const ushort M2C_Reload = 10022;
		 public const ushort C2R_Login = 10023;
		 public const ushort R2C_Login = 10024;
		 public const ushort C2G_LoginGate = 10025;
		 public const ushort G2C_LoginGate = 10026;
		 public const ushort G2C_TestHotfixMessage = 10027;
		 public const ushort C2M_TestRobotCase = 10028;
		 public const ushort M2C_TestRobotCase = 10029;
		 public const ushort C2M_TransferMap = 10030;
		 public const ushort M2C_TransferMap = 10031;
		 public const ushort C2A_LoginAccount = 10032;
		 public const ushort A2C_LoginAccount = 10033;
		 public const ushort A2C_Disconnect = 10034;
		 public const ushort ServerInfoProto = 10035;
		 public const ushort C2A_GetServerInfos = 10036;
		 public const ushort A2C_GetServerInfos = 10037;
		 public const ushort RoleInfoProto = 10038;
		 public const ushort C2A_CreateRole = 10039;
		 public const ushort A2C_CreateRole = 10040;
		 public const ushort C2A_GetRoles = 10041;
		 public const ushort A2C_GetRoles = 10042;
		 public const ushort C2A_DeleteRole = 10043;
		 public const ushort A2C_DeleteRole = 10044;
		 public const ushort C2A_GetRealmKey = 10045;
		 public const ushort A2C_GetRealmKey = 10046;
		 public const ushort C2R_LoginRealm = 10047;
		 public const ushort R2C_LoginRealm = 10048;
		 public const ushort C2G_LoginGameGate = 10049;
		 public const ushort G2C_LoginGameGate = 10050;
		 public const ushort C2G_EnterGame = 10051;
		 public const ushort G2C_EnterGame = 10052;
		 public const ushort M2C_NoticeUnitNumeric = 10053;
		 public const ushort C2M_TestUnitNumeric = 10054;
		 public const ushort M2C_TestUnitNumeric = 10055;
		 public const ushort C2M_AddAttributePoint = 10056;
		 public const ushort M2C_AddAttributePoint = 10057;
		 public const ushort C2M_StartGameLevel = 10058;
		 public const ushort M2C_StartGameLevel = 10059;
		 public const ushort C2M_EndGameLevel = 10060;
		 public const ushort M2C_EndGameLevel = 10061;
		 public const ushort C2M_UpRoleLevel = 10062;
		 public const ushort M2C_UpRoleLevel = 10063;
		 public const ushort ItemInfo = 10064;
		 public const ushort M2C_AllItemsList = 10065;
		 public const ushort M2C_ItemUpdateOpInfo = 10066;
		 public const ushort AttributeEntryProto = 10067;
		 public const ushort EquipInfoProto = 10068;
		 public const ushort C2M_EquipItem = 10069;
		 public const ushort M2C_EquipItem = 10070;
		 public const ushort C2M_UnloadEquipItem = 10071;
		 public const ushort M2C_UnloadEquipItem = 10072;
		 public const ushort C2M_SellItem = 10073;
		 public const ushort M2C_SellItem = 10074;
		 public const ushort ProductionProto = 10075;
		 public const ushort C2M_StartProduction = 10076;
		 public const ushort M2C_StartProduction = 10077;
		 public const ushort C2M_ReceiveProduction = 10078;
		 public const ushort M2C_ReceiveProduction = 10079;
		 public const ushort M2C_AllProductionList = 10080;
		 public const ushort TaskInfoProto = 10081;
		 public const ushort M2C_UpdateTaskInfo = 10082;
		 public const ushort M2C_AllTaskInfoList = 10083;
		 public const ushort C2M_ReceiveTaskReward = 10084;
		 public const ushort M2C_ReceiveTaskReward = 10085;
		 public const ushort RankInfoProto = 10086;
		 public const ushort C2Rank_GetRanksInfo = 10087;
		 public const ushort Rank2C_GetRanksInfo = 10088;
		 public const ushort C2Chat_SendChatInfo = 10089;
		 public const ushort Chat2C_SendChatInfo = 10090;
		 public const ushort Chat2C_NoticeChatInfo = 10091;
	}
}
