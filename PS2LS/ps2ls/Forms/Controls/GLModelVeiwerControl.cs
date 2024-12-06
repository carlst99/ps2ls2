using System;
using OpenTK.GLControl;
using OpenTK.Windowing.Common;

namespace ps2ls.Forms.Controls
{
    public class GLModelVeiwerControl : GLControl
    {
        public GLModelVeiwerControl()
            : base(new GLControlSettings
            {
                //Flags = ContextFlags.ForwardCompatible,
                APIVersion = new Version(2, 1),
                Profile = ContextProfile.Any,
                AlphaBits = 8,
                BlueBits = 8,
                GreenBits = 8,
                RedBits = 8,
                DepthBits = 24,
                StencilBits = 8,
                NumberOfSamples = 8
            })
        {
        }
    }
}
