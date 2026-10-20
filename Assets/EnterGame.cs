using UnityEngine;

public class EnterGame : MonoBehaviour
{
    public Canvas GameMenu;

    private void OnTriggerEnter(Collider other)
    {
        // Kiểm tra va chạm với máy bay (phải gán Tag "Player" cho máy bay)
        if (other.CompareTag("Player"))
        {
            if (GameMenu != null)
            {
                GameMenu.enabled = true; // Bật Popup Menu
            }
        }
    }
}