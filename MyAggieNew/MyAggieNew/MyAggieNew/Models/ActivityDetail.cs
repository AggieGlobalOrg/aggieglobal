﻿using System;
using System.Collections.Generic;

namespace MyAggieNew
{
    public class ActivityDetail
    {

    }

    public class ActivityDetailCountByDateResponse : ModelBase
    {
        public int ActivityCount { get; set; }
        public DateTime ActivityDate { get; set; }
    }

    public class ActivityDetailResponse : ModelBase
        public string ResourceMaintenaceCostTypeName { get; set; }
        public string ActivityDescription { get; set; }
        public decimal ResourceMaintenancePrice { get; set; }
}