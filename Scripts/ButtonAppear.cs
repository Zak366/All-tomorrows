using UnityEngine;
using UnityEngine.UI;

public class ButtonAppear : MonoBehaviour
{
    public Button targetButton; // Ссылка на кнопку, которую нужно показать

    public float delayTime = 5f; // Время задержки перед появлением кнопки

    private bool buttonVisible = false; // Флаг, показывающий, видна ли кнопка в данный момент

    void Start()
    {
        // Вызываем метод для показа кнопки с задержкой
        ShowButtonWithDelay();
    }

    // Метод для отложенного показа кнопки
    public void ShowButtonWithDelay()
    {
        if (!buttonVisible)
        {
            Invoke("ShowButton", delayTime);
        }
    }

    // Метод для показа кнопки
    public void ShowButton()
    {
        targetButton.gameObject.SetActive(true);
        buttonVisible = true;
    }
}
