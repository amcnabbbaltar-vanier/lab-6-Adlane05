using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI; // Add this namespace

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    public int score = 0;
    private Text scoreText;
    public int targetScore = 4; // Score to reach before changing scenes

    void Awake()
    {
        // Singleton pattern
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); // Optional
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void AddScore(int amount)
    {
        score += amount;
        UpdateUI();
    }

    private void UpdateUI()
    {
        if (scoreText != null)
        {
            scoreText.text = $"Score: {score}";
        }
    }


    public void LoadNextScene()
    {
       SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1 );
    }
}
