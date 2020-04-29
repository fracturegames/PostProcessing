using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class ARPostProcessTest : MonoBehaviour
{
    public PostProcessProfile _Profile;
    [Range(0,1)]
    public float _Opacity = 1f;

    public Texture2D _BackgroundImage;

    PostProcessLayer _postProcessLayer;

    private void Awake()
    {
        _postProcessLayer = GetComponent<PostProcessLayer>();
        Matrix4x4 displayMatrix = Matrix4x4.zero;
        displayMatrix[0, 0] = -1;
        displayMatrix[1, 1] = 1;
        displayMatrix[2, 0] = 1;
        _postProcessLayer._DisplayMatrix = displayMatrix;
        GetComponent<PostProcessVolume>().profile = _Profile;
        _postProcessLayer._BackgroundTextureY = _BackgroundImage;
    }

    // Update is called once per frame
    void Update()
    {
        _postProcessLayer._ContentOpacity = _Opacity;
    }
}
