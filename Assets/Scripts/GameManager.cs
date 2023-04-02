using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager instance;

    public float initialGameSpeed = 5f;
    public float gameSpeedIncrease = 0.1f;
    public float gameSpeed { get; private set; }

    private GameManager() { }

    public static GameManager GetInstance()
    {
        return instance;
    }

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    private void Start()
    {
        NewGame();
    }

    private void Update()
    {
        gameSpeed += gameSpeedIncrease * Time.deltaTime;
    }

    private void NewGame()
    {
        gameSpeed = initialGameSpeed;
    }
}