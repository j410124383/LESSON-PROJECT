using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : FindMG
{
    public float Score;
    public GameObject UI_LP;
    public GameObject UI_GO;

    private void Awake()
    {
        Score = 0;

    }

    public void Update()
    {

            if (GameObject.FindWithTag("Player").GetComponent<PlayerState>().isDie)
            {
                StartCoroutine(GameOver());
            }


    }

    public void ScoreAdd(float count)
    {
        Score += count;
    }

    public void LevelPass()
    {
        UI_LP.SetActive(true);
    }

    IEnumerator  GameOver()
    {
        yield return new WaitForSeconds(1.0f);
        UI_GO.SetActive(true);
        Time.timeScale = 0;
    }


}
