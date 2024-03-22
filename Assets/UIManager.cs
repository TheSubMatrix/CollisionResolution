using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] Image _healthBarMask;
    [SerializeField] TMP_Text _scoreText;
    [SerializeField] TMP_Text _resultText;
    [SerializeField] GameObject _gameOverUI;
    [SerializeField] GameObject _gameplayUI;
    public void UpdateHealthBar(uint health, uint maxHealth)
    {
        _healthBarMask.fillAmount = (float) health / (float) maxHealth;
    }
    public void UpdateScore(int score) 
    {
        if(_scoreText  != null)
        {
            _scoreText.text = "Score: " + score;
        }
    }
    public void OnGameOver(bool gameWon) 
    {
        _gameplayUI.SetActive(false);
        _gameOverUI.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        if(gameWon)
        {
            if(_resultText != null)
            {
                _resultText.text = "You Win!!!";
            }
        }
        else
        {
            if (_resultText != null)
            {
                _resultText.text = "You Lose!!!";
            }
        }
    }
    public void OnQuitButtonPressed()
    {
        Application.Quit();
    }
    public void OnRetryButtonPressed()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
    public void OnMenuButtonPressed()
    {
        SceneManager.LoadScene("Main Menu");
    }
    public void OnPlayButtonPressed()
    {
        SceneManager.LoadScene("Game Scene");
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }
}
