using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

[CreateAssetMenu(fileName = "AR Post-processing Profile")]
public class ARPostProcessSettings : SingletonAsset<ARPostProcessSettings>
{
    public PostProcessProfile _Profile;
}
