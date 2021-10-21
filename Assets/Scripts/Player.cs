using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public bool isHit = false;

    public SpriteRenderer spriteRendr;

    public Sprite normal;
    public Sprite caught;


    // Start is called before the first frame update
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
