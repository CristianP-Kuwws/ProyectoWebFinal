﻿namespace ShopAppGFive.DAL.Core
{
    public abstract class BaseShopEntity
    {
        public DateTime creation_date { get; set; }

        public int? modify_user { get; set; }

        public int creation_user { get; set; }

        public int? delete_user { get; set; }

        public DateTime? modify_date { get; set; }

        public DateTime? delete_date { get; set; }

    }
}
