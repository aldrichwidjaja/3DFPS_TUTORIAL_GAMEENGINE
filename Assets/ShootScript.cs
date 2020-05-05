using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShootScript : MonoBehaviour
{
    public Text scoreTxt;
    int en01score = 0;
    int score = 0;

    private void Start()
    {
        en01score = PlayerPrefs.GetInt("Enemy01score");
        print("Enemy score: " + en01score);

        scoreTxt.text = score.ToString();
    }
    // Start is called before the first frame update
    private void Update()
    {
        Debug.DrawRay(transform.position, transform.forward * 1000, Color.yellow);
    }

    // Update is called once per frame
    public void Shoot(float range)
    {
        RaycastHit hit;
        if ( Physics.Raycast(transform.position, transform.forward, out hit, range) && hit.transform.gameObject.tag == "Enemy")
        {
            print("enemy hit!");
            hit.transform.gameObject.GetComponent<EnemyMovement>().Respawn();

            score += en01score;
            print("score: " + score);
            PlayerPrefs.SetInt("Score", score);
            scoreTxt.text = score.ToString();


        }
    }
}
