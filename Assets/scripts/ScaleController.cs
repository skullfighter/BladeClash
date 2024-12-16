using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScaleController : MonoBehaviour
{
    [Header("UI")]
    public Slider scaleSlider;
    public Transform xrRigTransform; // Reference to the transform of the XR Rig or other suitable parent object

    private void Awake()
    {
        // If the ScaleController is attached to the same GameObject as the XR Rig or parent object
        xrRigTransform = transform;
    }

    // Start is called before the first frame update
    void Start()
    {
        scaleSlider.onValueChanged.AddListener(OnSliderValueChanged);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnSliderValueChanged(float value)
    {
        if (scaleSlider != null && xrRigTransform != null)
        {
            xrRigTransform.localScale = Vector3.one / value;
        }
    }
}
