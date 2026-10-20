using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    [Header("UI Canvas Reference")]
    public Canvas GameMenu;

    [Header("UI Elements")]
    public TMP_Text Title;
    public TMP_Text Message;
    public Button ContinueButton; // Nút Enter
    public Button RestartButton;  // Nút Restart

    private bool isShowingMenu = false;

    void Start()
    {
        // 1. Ẩn Menu Canvas khi bắt đầu Play
        if (GameMenu != null)
        {
            GameMenu.enabled = isShowingMenu;
        }

        // 2. Gán text động từ C# script theo Slide 29
        if (Title != null) Title.text = "Welcome to Unity!";
        if (Message != null) Message.text = "Do you want continue?";
        
        if (ContinueButton != null) 
            ContinueButton.GetComponentInChildren<TMP_Text>().text = "Enter";
            
        if (RestartButton != null) 
            RestartButton.GetComponentInChildren<TMP_Text>().text = "Restart";
    }

    // Chuyển sang Scene tiếp theo khi bấm nút Enter (Slide 33)
    public void NextScene()
    {
        SceneManager.LoadScene("_Scene_1");
    }

    // Load lại Scene hiện tại khi bấm nút Restart (Slide 33)
    public void RestartScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}