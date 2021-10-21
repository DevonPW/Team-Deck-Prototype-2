using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cat : MonoBehaviour
{
    // Start is called before the first frame update

    public SpriteRenderer spriteRendr;

    public Sprite normal;
    public Sprite caught;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void caughtSprite()
    {
        spriteRendr.sprite = caught;
    }

    public void normalSprite()
    {
        spriteRendr.sprite = normal;
    }
}
