﻿using System;

namespace ET.Event
{
    [FriendClass(typeof(AdventureComponent))]
    public class AdventureBattleRoundEvent_CalculateDamage: AEventAsync<EventType.AdventureBattleRound>
    {
        protected override async ETTask Run(EventType.AdventureBattleRound args)
        {
            if (!args.AttackUnit.IsAlive() || !args.TargetUnit.IsAlive())
            {
                return;
            }

            SRandom random = args.ZoneScene.CurrentScene().GetComponent<AdventureComponent>().Random;
            
            int damage = DamageCalcuateHelper.CalcuateDamageValue(args.AttackUnit, args.TargetUnit, ref random);
            int HP     = args.TargetUnit.GetComponent<NumericComponent>().GetAsInt(NumericType.Hp) - damage;

            if (HP <= 0)
            {
                HP = 0;
                args.TargetUnit.SetAlive(false);
            }
            
            args.TargetUnit.GetComponent<NumericComponent>().Set(NumericType.Hp,HP);
            Log.Debug($"************* {args.TargetUnit.Type}被攻击剩余血量: {HP} ***************");
            
            Game.EventSystem.PublishAsync(new EventType.ShowDamageValueView()
            {
                ZoneScene = args.ZoneScene,TargetUnit = args.TargetUnit,DamamgeValue = damage
            }).Coroutine();
            

            await ETTask.CompletedTask;
        }
    }
}