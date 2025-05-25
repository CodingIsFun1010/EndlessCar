using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager Instance;
    public Text scoreText;
    public Text mphText;

    private float score = 0f;
    private float mph = 30f;

    void Awake()
    {
        Instance = this;
    }

    void Update()
    {
        score += Time.deltaTime * 60; // Increments score quickly
        scoreText.text = "Score: " + Mathf.FloorToInt(score).ToString();
        mphText.text = mph + " MPH";
    }

    public void ResetScore()
    {
        score = 0f;
    }
}
