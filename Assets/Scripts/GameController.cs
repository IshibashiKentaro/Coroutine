using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{

    public GameObject enemy;
    public GameObject stage;
    public GameObject player;
    public float totalTime;
    int seconds;//
    public static int time;// 10行追加
    public static int gettime()
    {
        return time;
    }
    public static int highScore;
    public static int gethighScore()
    {
        return highScore;
    }
    public Text NowTime;//1/9
    public Text BestTime;//1/9
    //public Text Record;//1/10
    //Text record;//1/10
    GameObject[] enemies;
    float stageWidth;
    float stageHeight;
    Player playerScript;

    void Start()
    {
        if (SceneManager.GetActiveScene().name == "Main")//1/9
        {
            if (PlayerPrefs.HasKey("highScore"))
            {
                highScore = PlayerPrefs.GetInt("highScore");
            }
            stageWidth = stage.GetComponent<Renderer>().bounds.size.x;
            stageHeight = stage.GetComponent<Renderer>().bounds.size.z;
            playerScript = player.GetComponent<Player>();

            for (int n = 0; n < 5; n++)
            {
                Instantiate(enemy, new Vector3(Random.Range(-stageWidth / 2, stageWidth / 2), 1, Random.Range(-stageHeight / 2, stageHeight / 2)), Quaternion.identity);
            }
           // record = Record.GetComponent<Text>();//1/10
            //record.enabled = false;
        }

       
    }

    void Update()
    {

        if (SceneManager.GetActiveScene().name == "Main")//1/9
        {
            totalTime -= Time.deltaTime;
            seconds = (int)totalTime;

            enemies = GameObject.FindGameObjectsWithTag("Enemy");

            if (playerScript.getDestroy == true)
            {
                StartCoroutine("GenerateEnemy");
                playerScript.getDestroy = false;
            }
            else if (enemies.Length < 1)
            {
                time = seconds;//5行追加
                if (highScore < time)
                {
                    PlayerPrefs.SetInt("highScore", time);
                }
                StopCoroutine("GenerateEnemy");
                Invoke("gameclear", 3);
            }
            if (totalTime < 0)//ここ
            {
                Invoke("gameover", 3);
            }
        }

        if(SceneManager.GetActiveScene().name == "GameClear")//1/9
        {
            NowTime.text = "Time : " + (60 - (time+3)) + " sec";
            BestTime.text = "Best : " + (60 - highScore) + " sec";
        }
    }

    public void gameclear()//追記
    {
        SceneManager.LoadScene("GameClear");
    }

    public void gameover()
    {
        SceneManager.LoadScene("corotine_gameover");
    }


    IEnumerator GenerateEnemy()
    {
        yield return new WaitForSeconds(5.0f);
        Instantiate(enemy, new Vector3(Random.Range(-stageWidth / 2, stageWidth / 2), 1, Random.Range(-stageHeight / 2, stageHeight / 2)), Quaternion.identity);
    }
}