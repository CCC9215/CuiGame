using ET;
using ProtoBuf;
using System.Collections.Generic;
namespace ET
{
	[Message(MongoOpcode.ObjectQueryResponse)]
	[ProtoContract]
	public partial class ObjectQueryResponse: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(1)]
		public Entity entity { get; set; }

	}

	[ResponseType(nameof(M2M_UnitTransferResponse))]
	[Message(MongoOpcode.M2M_UnitTransferRequest)]
	[ProtoContract]
	public partial class M2M_UnitTransferRequest: Object, IActorRequest
	{
		[ProtoMember(1)]
		public int RpcId { get; set; }

		[ProtoMember(2)]
		public Unit Unit { get; set; }

		[ProtoMember(3)]
		public List<Entity> Entitys = new List<Entity>();

	}

	[Message(MongoOpcode.UnitCache2Other_GetUnit)]
	[ProtoContract]
	public partial class UnitCache2Other_GetUnit: Object, IActorResponse
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(91)]
		public int Error { get; set; }

		[ProtoMember(92)]
		public string Message { get; set; }

		[ProtoMember(4)]
		public List<Entity> EntityList = new List<Entity>();

		[ProtoMember(5)]
		public List<string> ComponentNameList = new List<string>();

	}

	[Message(MongoOpcode.Map2Rank_AddOrUpdateRankInfo)]
	[ProtoContract]
	public partial class Map2Rank_AddOrUpdateRankInfo: Object, IActorMessage
	{
		[ProtoMember(90)]
		public int RpcId { get; set; }

		[ProtoMember(1)]
		public RankInfo RankInfo { get; set; }

	}

}
