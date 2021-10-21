using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mashPrompt : MonoBehaviour
{
    public SpriteRenderer spriteRendr;

    public Sprite[] sprites;

    public float animTime = 0.5f;

    float prevAnimTime;

    int i;

    // Start is called before the first frame update
    void Start()
    {
        prevAnimTime = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time - prevAnimTime >= animTime) {
            i = i == 1 ? 0 : 1;
            spriteRendr.sprite = sprites[i];
            prevAnimTime = Time.time;
        }
    }

    public void show()
    {
        spriteRendr.enabled = true;
    }

    public void hide()
    {
        spriteRendr.enabled = false;
    }
}
