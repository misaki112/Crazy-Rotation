using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerScript2 : MonoBehaviour
{

    public float moveSpeed = 400f;

    public Text score;
    public GameObject Score;
    public GameObject center;

    public GameObject gameOver;
    public Text finalScore;

    private void Start()
    {
        Spawner.instance.stop = false;
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);
            touchPosition.z = 0f;
            if (touchPosition.x < 0)
            {
                transform.RotateAround(Vector3.zero, Vector3.forward, 1f * Time.deltaTime * -moveSpeed);
            }
            else
            {
                transform.RotateAround(Vector3.zero, Vector3.forward, 1f * Time.deltaTime * moveSpeed);
            }
        }
        score.text = Spawner.instance.score.ToString();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        finalScore.text = Spawner.instance.score.ToString();
        Spawner.instance.score = 0;
        Spawner.instance.stop = true;
        Destroy(this.gameObject);
        Score.SetActive(false);
        center.SetActive(false);
        score.gameObject.SetActive(false);
        gameOver.SetActive(true);
        finalScore.gameObject.SetActive(true);
    }
}
