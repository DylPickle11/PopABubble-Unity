using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; //Access to rawimagetype

public class ImageViewer : MonoBehaviour
{
    public MeasureDepth mMeasureDepth;

    //Source of Data Gives us color and depth data
    public MultiSourceManager mMultiSource;

    // Output the color we are getting from the kinect
    public RawImage mRawImage;

    public RawImage mRawDepth;


    // Update is called once per frame
    void Update()
    {
        mRawImage.texture = mMultiSource.GetColorTexture();

        mRawDepth.texture = mMeasureDepth.mDepthTexture;
    }
}
