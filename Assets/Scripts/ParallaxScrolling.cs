using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScrolling : MonoBehaviour
{
    [SerializeField]
    private Vector2 parallaxEffectMultiplier;

    Transform cameraTransform;
    Vector3 lastCameraPosition;

    // Start is called before the first frame update
    void Start()
    {
        cameraTransform = Camera.main.transform;
        lastCameraPosition = cameraTransform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 deltaPosition = cameraTransform.position - lastCameraPosition;
        transform.position = new Vector3(transform.position.x + (deltaPosition.x * parallaxEffectMultiplier.x), transform.position.y + (deltaPosition.y * parallaxEffectMultiplier.y), transform.position.y);
        lastCameraPosition = cameraTransform.position;
    }
}
