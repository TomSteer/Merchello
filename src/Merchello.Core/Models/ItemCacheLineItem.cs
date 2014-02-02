﻿using System;
using System.Runtime.Serialization;

namespace Merchello.Core.Models
{
    /// <summary>
    /// Represents a customer cached line item
    /// </summary>
    /// <remarks>
    /// Needed for typed query mapper
    /// </remarks>
    [Serializable]
    [DataContract(IsReference = true)]
    public class ItemCacheLineItem : LineItemBase, IItemCacheLineItem
    {

        public ItemCacheLineItem(string name, string sku, decimal amount) 
            : base(name, sku, amount)
        {}

        public ItemCacheLineItem(string name, string sku, int quantity, decimal amount) 
            : base(name, sku, quantity, amount)
        {}

        public ItemCacheLineItem(LineItemType lineItemType, string name, string sku, int quantity, decimal amount) 
            : base(lineItemType, name, sku, quantity, amount)
        {}

        public ItemCacheLineItem(LineItemType lineItemType, string name, string sku, int quantity, decimal amount, ExtendedDataCollection extendedData) 
            : base(lineItemType, name, sku, quantity, amount, extendedData)
        {}

        public ItemCacheLineItem(Guid lineItemTfKey, string name, string sku, int quantity, decimal amount, ExtendedDataCollection extendedData) 
            : base(lineItemTfKey, name, sku, quantity, amount, extendedData)
        {}
    }
}