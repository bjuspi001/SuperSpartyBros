using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfiniteScrolling : MonoBehaviour
{
    [SerializeField]
    private bool infiniteHorizontal;

    private float textureUnitSizeX;

    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer renderer = GetComponent<SpriteRenderer>();
        Sprite sprite = renderer.sprite;
        Texture2D texture = sprite.texture;

        textureUnitSizeX = texture.width / sprite.pixelsPerUnit;
    }

    // Update is called once per frame
    void Update()
    {
        if (infiniteHorizontal)
        {
            if (Mathf.Abs(Camera.main.transform.position.x - transform.position.x) >= textureUnitSizeX)
            {
                float offsetX = (Camera.main.transform.position.x - transform.position.x) % textureUnitSizeX;
                transform.position = new Vector3(Camera.main.transform.position.x + offsetX, transform.position.y, transform.position.z);
            }
        }
    }
}
