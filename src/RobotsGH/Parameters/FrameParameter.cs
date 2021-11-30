﻿using System;
using System.Collections.Generic;
using Grasshopper.Kernel;

namespace Robots.Grasshopper
{
    public class FrameParameter : GH_PersistentParam<GH_Frame>
    {
        public FrameParameter() : base("Frame parameter", "Frame", "This is a robot base frame", "Robots", "Parameters") { }
        public override GH_Exposure Exposure => GH_Exposure.secondary;
        protected override System.Drawing.Bitmap Icon => Properties.Resources.iconFrameParam;
        public override Guid ComponentGuid => new Guid("{6A012ECB-D161-4F93-BB60-D03391DF1A7C}");
        protected override GH_GetterResult Prompt_Singular(ref GH_Frame value)
        {
            value = new GH_Frame();
            return GH_GetterResult.success;
        }
        protected override GH_GetterResult Prompt_Plural(ref List<GH_Frame> values)
        {
            values = new List<GH_Frame>();
            return GH_GetterResult.success;
        }
    }
}