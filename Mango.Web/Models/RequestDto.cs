﻿using static Mango.Web.Utility.SD;

namespace Mango.Web.Models
{
    public class RequestDto
    {
        public ApiType ApiType { get; set; } = ApiType.GET;
        public string Url { get; set; }
        public CouponDto Data { get; set; }
        public string AccessToken { get; set; }
    }
}
