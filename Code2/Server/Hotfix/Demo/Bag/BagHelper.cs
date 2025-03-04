﻿namespace ET
{
    public static class BagHelper
    {
        public static bool AddItemByConfigId(Unit unit, int configId)
        {
            BagComponent bagComponent = unit.GetComponent<BagComponent>();
            if ( bagComponent == null)
            {
                return false;
            }

            if (!bagComponent.IsCanAddItemByConfigId(configId))
            {
                return false;
            }

            return bagComponent.AddItemByConfigId(configId);
        }
    }
}