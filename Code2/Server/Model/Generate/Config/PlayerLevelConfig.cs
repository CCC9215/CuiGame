using System;
using System.Collections.Generic;
using MongoDB.Bson.Serialization.Attributes;
using ProtoBuf;

namespace ET
{
    [ProtoContract]
    [Config]
    public partial class PlayerLevelConfigCategory : ProtoObject, IMerge
    {
        public static PlayerLevelConfigCategory Instance;
		
        [ProtoIgnore]
        [BsonIgnore]
        private Dictionary<int, PlayerLevelConfig> dict = new Dictionary<int, PlayerLevelConfig>();
		
        [BsonElement]
        [ProtoMember(1)]
        private List<PlayerLevelConfig> list = new List<PlayerLevelConfig>();
		
        public PlayerLevelConfigCategory()
        {
            Instance = this;
        }
        
        public void Merge(object o)
        {
            PlayerLevelConfigCategory s = o as PlayerLevelConfigCategory;
            this.list.AddRange(s.list);
        }
		
        public override void EndInit()
        {
            foreach (PlayerLevelConfig config in list)
            {
                config.EndInit();
                this.dict.Add(config.Id, config);
            }            
            this.AfterEndInit();
        }
		
        public PlayerLevelConfig Get(int id)
        {
            this.dict.TryGetValue(id, out PlayerLevelConfig item);

            if (item == null)
            {
                throw new Exception($"配置找不到，配置表名: {nameof (PlayerLevelConfig)}，配置id: {id}");
            }

            return item;
        }
		
        public bool Contain(int id)
        {
            return this.dict.ContainsKey(id);
        }

        public Dictionary<int, PlayerLevelConfig> GetAll()
        {
            return this.dict;
        }

        public PlayerLevelConfig GetOne()
        {
            if (this.dict == null || this.dict.Count <= 0)
            {
                return null;
            }
            return this.dict.Values.GetEnumerator().Current;
        }
    }

    [ProtoContract]
	public partial class PlayerLevelConfig: ProtoObject, IConfig
	{
		/// <summary>Id</summary>
		[ProtoMember(1)]
		public int Id { get; set; }
		/// <summary>所需经验值</summary>
		[ProtoMember(2)]
		public long NeedExp { get; set; }

	}
}
