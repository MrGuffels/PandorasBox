using ImGuiNET;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace PandorasBox.FeaturesSetup
{
    public static class FeatureConfigEditor
    {

        public static bool ColorEditor(string name, ref object configOption)
        {
            switch (configOption)
            {
                case Vector4 v4 when ImGui.ColorEdit4(name, ref v4):
                    configOption = v4;
                    return true;
                case Vector3 v3 when ImGui.ColorEdit3(name, ref v3):
                    configOption = v3;
                    return true;
                default:
                    return false;
            }
        }

        public static bool SimpleColorEditor(string name, ref object configOption)
        {
            switch (configOption)
            {
                case Vector4 v4 when ImGui.ColorEdit4(name, ref v4, ImGuiColorEditFlags.NoInputs | ImGuiColorEditFlags.AlphaPreview | ImGuiColorEditFlags.AlphaBar):
                    configOption = v4;
                    return true;
                default:
                    return false;
            }
        }

    }
}
