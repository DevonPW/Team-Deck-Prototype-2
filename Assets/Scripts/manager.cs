using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manager : MonoBehaviour
{
    public Player player;
    public Cat cat;
    public bgScroll bg;
    public mashPrompt mashPrompt;


    public float escapeTimeLimit = 5;//time player has to escape cat in secs
    public float dragSpeed = 1;//speed player is dragged away by cat

    public float mashDistance = 0.1f;//distance moved for each key press while mashing

    bool isEscaping = false;

    bool hasEscaped = false;

    bool hasFailed = false;

    float startEscapeTime;

    float catSpeed = 1;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isEscaping == true) {
            escaping();
        }
        else {
            cat.transform.Translate(catSpeed * Time.deltaTime, 0, 0);
            if (cat.transform.position.x >= -4.4f) {
                player.isHit = true;
            }
        }


        if (player.isHit == true) {
            player.isHit = false;
            playerCaught();
        }
    }

    void playerCaught()
    {
        bg.speed = 0;

        isEscaping = true;

        hasEscaped = false;

        startEscapeTime = Time.time;

        mashPrompt.show();

        player.transform.position = new Vector3(-3f, -3.13f);

        cat.transform.position = new Vector3(-7.71f, -3.38f);

        cat.caughtSprite();
        player.caughtSprite();
    }

    void escaping()
    {
        Vector3 playerTranslation = Vector3.zero;
        playerTranslation.x = -dragSpeed * Time.deltaTime;

        if (Input.GetKeyDown("x")) {
            playerTranslation.x += mashDistance;
        }

        player.transform.Translate(playerTranslation);
        cat.transform.Translate(playerTranslation);//cat moves with player

        if (player.transform.position.x >= 0) {//player has escaped
            escaped();
        }

        if (Time.time - startEscapeTime >= escapeTimeLimit) {//player has failed
            failed();
        }
    }

    void escaped()
    {
        bg.speed = 9;

        isEscaping = false;

        hasEscaped = false;

        mashPrompt.hide();

        player.transform.position = new Vector3(0, -3.13f);

        cat.transform.position = new Vector3(-8.88f, -3.38f);

        cat.normalSprite();
        player.normalSprite();
    }

    void failed()
    {
        SceneManager.LoadScene("GameOver");
    }
}
