﻿//////////////////////////////////////////////////////
// MK Glow Editor Helper UI Content	           		//
//					                                //
// Created by Michael Kremmel                       //
// www.michaelkremmel.de | www.michaelkremmel.store //
// Copyright © 2019 All rights reserved.            //
//////////////////////////////////////////////////////
#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace MK.Glow.Editor
{
    internal static partial class EditorHelper
    {
        internal static class EditorUIContent
        {
            internal static class Tooltips
            {
                //Main
                internal static readonly GUIContent allowGeometryShaders = new GUIContent("Allow Geometry Shaders", "Allowing the pipeline to use geometry shader if available.");
                internal static readonly GUIContent allowComputeShaders = new GUIContent("Allow Compute Shaders", "Allowing the pipeline to use compute shader if available.");
                internal static readonly GUIContent debugView = new GUIContent("Debug View", "Displaying of different render steps. \n \n" +
                                                                               "None: Debug view is disabled. \n\n" +
                                                                               "Raw Bloom: Shows extracted bloom map. \n\n" +
                                                                               "Raw Lens Flare: Shows extracted lens flare map. \n\n" +
                                                                               "Raw Glare: Shows extracted glare map. \n\n" +
                                                                               "Bloom: Shows created bloom without lens surface. \n\n" +
                                                                               "Lens Flare: Shows created lens flare without lens surface. \n\n" +
                                                                               "Glare: Shows created glare without lens surface. \n\n" +
                                                                               "Composite: Shows combined bloom, lensflare, glare and lens surface, just without source image. \n");
                internal static readonly GUIContent quality = new GUIContent("Quality", "General rendered quality of the glow. Higher setting results in better looking and less aliasing.");
                internal static readonly GUIContent workflow = new GUIContent("Workflow", "Basic definition of the workflow. \n\n" +
                                                                              "Luminance: Glow map is defined by the pixels brightness and threshold setup. Just use the emission of the shaders and raise it up. This should be chosen in most cases. Performs significantly faster than selective workflow.\n\n" +
                                                                               "Selective: Glow map is created by using separate shaders (MK/Glow/Selective).");
                internal static readonly GUIContent selectiveRenderLayerMask = new GUIContent("Render Layer", "In most cases 'Everything' should be chosen to avoid Z issues.");
                internal static readonly GUIContent anamorphicRatio = new GUIContent("Anamorphic", "Anamorphic scaling. \n\n" +
                                                                                     "> 0: scaling horizontally\n" +
                                                                                     "< 0: scaling vertically\n" +
                                                                                     "0: no scaling");
                internal static readonly GUIContent lumaScale = new GUIContent("Luma Scale", "Mixing of the relative luminance (Luminosity function) into the glow map. Each color part contributes a different amount of light.");
                internal static readonly GUIContent blooming = new GUIContent("Blooming", "Blooming increases glowing parts even further. Increasing this value value gives the scene a more bloomy look.");

                //Bloom
                internal static readonly GUIContent bloomThreshold = new GUIContent("Threshold", "Threshold in gamma space for extraction of bright areas. \n\n Min: Minimum brightness until the bloom starts. \n Max: Maximum brightness for cutting off colors.");
                internal static readonly GUIContent bloomScattering = new GUIContent("Scattering", "Scattering of the bloom. A higher value increases the scattered area.");
                internal static readonly GUIContent bloomIntensity = new GUIContent("Intensity", "Intensity of the bloom in gamma space.");

                //Lens Surface
                internal static readonly GUIContent allowLensSurface = new GUIContent("", "");
                internal static readonly GUIContent lensSurfaceDirtTexture = new GUIContent("Dirt", "Dirt overlay which will be applied to the glow (RGB). Best results if texture is tileable.");
                internal static readonly GUIContent lensSurfaceDirtIntensity = new GUIContent("Intensity", "Intensity of the dirt effect. Value is in gamma space.");
                internal static readonly GUIContent lensSurfaceDiffractionTexture = new GUIContent("Diffraction", "Diffraction overlay which will be applied to the glow (RGB). Texture is rotating based on view.");
                internal static readonly GUIContent lensSurfaceDiffractionIntensity = new GUIContent("Intensity", "Intensity of the diffraction effect in gamma space.");

                //Lens flare
                internal static readonly GUIContent allowLensFlare = new GUIContent("", "");
                internal static readonly GUIContent lensFlareGhostFade = new GUIContent("Fade", "Fading of the ghosts. A higher value make the ghosts less visible");
                internal static readonly GUIContent lensFlareGhostIntensity = new GUIContent("Intensity", "Intensity of the ghosts in gamma space.");
                internal static readonly GUIContent lensFlareThreshold = new GUIContent("Threshold", "Threshold in gamma space for extraction of bright areas. \n\n Min: Minimum brightness until the lens flare starts. \n Max: Maximum brightness for cutting off colors.");
                internal static readonly GUIContent lensFlareScattering = new GUIContent("Scattering", "Scattering of the lens flare. A higher value increases the scattered area and blurs the flare stronger.");
                internal static readonly GUIContent lensFlareColorRamp = new GUIContent("Color Ramp", "Color ramp of the lens flare. Tint will applied radially (RGB).");
                internal static readonly GUIContent lensFlareChromaticAberration = new GUIContent("Chromatic Aberration", "Strength of the chromatic aberration. A higher / lower value spread the color parts further away.");
                internal static readonly GUIContent lensFlareGhostCount = new GUIContent("Count", "Count of the ghosts which are created.");
                internal static readonly GUIContent lensFlareGhostDispersal = new GUIContent("Dispersal", "Dispersion between the ghosts.");
                internal static readonly GUIContent lensFlareHaloFade = new GUIContent("Fade", "Fading of the halo. A higher value make the halo less visible.");
                internal static readonly GUIContent lensFlareHaloIntensity = new GUIContent("Intensity", "Intensity of the halo in gamma space.");
                internal static readonly GUIContent lensFlareHaloSize = new GUIContent("Size", "Overall radius of the halo");

                //Glare
                internal static readonly GUIContent allowGlare = new GUIContent("", "");
                internal static readonly GUIContent glareBlend = new GUIContent("Blend", "Blending between bloom and glare. 0: more/only bloom visible, 1: more/only glare visible.");
                internal static readonly GUIContent glareThreshold = new GUIContent("Threshold", "Threshold in gamma space for extraction of bright areas. \n\n Min: Minimum brightness until the glare starts. \n Max: Maximum brightness for cutting off colors.");
                internal static readonly GUIContent glareSample0Scattering = new GUIContent("Scattering", "Scattering of the glare sample. A higher value increases the scattered area.");
                internal static readonly GUIContent glareSample0Intensity = new GUIContent("Intensity", "Intensity of the glare sample in gamma space.");
                internal static readonly GUIContent glareSample0Angle = new GUIContent("Angle", "Angle of the glare sample in degree.");
                internal static readonly GUIContent glareSample0Offset = new GUIContent("Offset", "Offset of the sample based on the center.");
                internal static readonly GUIContent glareSample1Scattering = new GUIContent("Scattering", "Scattering of the glare sample. A higher value increases the scattered area.");
                internal static readonly GUIContent glareSample1Intensity = new GUIContent("Intensity", "Intensity of the glare sample in gamma space.");
                internal static readonly GUIContent glareSample1Angle = new GUIContent("Angle", "Angle of the glare sample in degree.");
                internal static readonly GUIContent glareSample1Offset = new GUIContent("Offset", "Offset of the sample based on the center.");
                internal static readonly GUIContent glareSample2Scattering = new GUIContent("Scattering", "Scattering of the glare sample. A higher value increases the scattered area.");
                internal static readonly GUIContent glareSample2Intensity = new GUIContent("Intensity", "Intensity of the glare sample in gamma space.");
                internal static readonly GUIContent glareSample2Angle = new GUIContent("Angle", "Angle of the glare sample in degree.");
                internal static readonly GUIContent glareSample2Offset = new GUIContent("Offset", "Offset of the sample based on the center.");
                internal static readonly GUIContent glareSample3Scattering = new GUIContent("Scattering", "Scattering of the glare sample. A higher value increases the scattered area.");
                internal static readonly GUIContent glareSample3Intensity = new GUIContent("Intensity", "Intensity of the glare sample in gamma space.");
                internal static readonly GUIContent glareSample3Angle = new GUIContent("Angle", "Angle of the glare sample in degree.");
                internal static readonly GUIContent glareSample3Offset = new GUIContent("Offset", "Offset of the sample based on the center.");
            }

            internal static readonly string mainTitle = "Main";
            internal static readonly string bloomTitle = "Bloom";
            internal static readonly string lensSurfaceTitle = "Lens Surface";
            internal static readonly string dirtTitle = "Dirt:";
            internal static readonly string diffractionTitle = "Diffraction:";
            internal static readonly string lensFlareTitle = "Lens Flare (SM 3.0+)";
            internal static readonly string ghostsTitle = "Ghosts:";
            internal static readonly string haloTitle = "Halo:";
            internal static readonly string glareTitle = "Glare (SM 4.0+)";
            internal static readonly string sample0Title = "Sample 0:";
            internal static readonly string sample1Title = "Sample 1:";
            internal static readonly string sample2Title = "Sample 2:";
            internal static readonly string sample3Title = "Sample 3:";

            internal static void LensFlareFeatureNotSupportedWarning()
            {
                EditorGUILayout.HelpBox("Lens flare feature is not supported on your active graphics api / render setup.", MessageType.Warning);
            }

            internal static void GlareFeatureNotSupportedWarning()
            {
                EditorGUILayout.HelpBox("Glare feature is not supported on your active graphics api / render setup.", MessageType.Warning);
            }

            internal static void OptimalSetupWarning(Camera camera, bool warningAllowed)
            {
                if(warningAllowed)
                {
                    string msg = "";
                    if(!camera.allowHDR && PlayerSettings.colorSpace != ColorSpace.Linear)
                    {
                        msg = "linear color space and hdr";
                    }
                    else if(PlayerSettings.colorSpace != ColorSpace.Linear)
                    {
                        msg = "linear color space";
                    }
                    else if(!camera.allowHDR)
                    {
                        msg = "hdr";
                    }
                    if(!camera.allowHDR || PlayerSettings.colorSpace != ColorSpace.Linear)
                        EditorGUILayout.HelpBox("For best looking results its recommend to use " + msg, MessageType.Warning);
                }
            }

            internal static void XRUnityVersionWarning()
            {
                #if UNITY_2018_3_OR_NEWER
                #else
                if(PlayerSettings.virtualRealitySupported)
                {
                    EditorGUILayout.HelpBox("Your are currently targeting XR. For best XR support its recommend to update to unity 2018.3 or higher.", MessageType.Warning);
                }
                #endif
            }

            internal static void SelectiveWorkflowVRWarning(Workflow workflow)
            {
                if(UnityEngine.Rendering.GraphicsSettings.renderPipelineAsset != null && workflow == Workflow.Selective)
                {
                    EditorGUILayout.HelpBox("Selective workflow isn't supported if a scriptable rendering pipeline is active. Please use Luminance workflow instead. ", MessageType.Warning);
                }
                if(PlayerSettings.virtualRealitySupported && workflow == Workflow.Selective)
                {
                    EditorGUILayout.HelpBox("Selective workflow isn't supported in XR. Please use Luminance workflow instead. ", MessageType.Warning);
                }
            }
        }
    }
}
#endif