﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MD.CloudConnect.Data;

namespace MD.CloudConnect.Api
{
    public class Track : AbstractApi<TrackingData>
    {
        public override string Function
        {
            get { return "tracks"; }
        }
    }
}
