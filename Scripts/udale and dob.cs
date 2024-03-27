using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Text textField; // Ссылка на текстовое поле, которое нужно изменить
    public string newText; // Новый текст для установки после нажатия кнопки
    public GameObject[] buttonsToToggleOff; // Массив кнопок, которые нужно скрыть
    public GameObject[] buttonsToToggleOn; // Массив кнопок, которые нужно показать

    // Вызывается при нажатии на кнопку
    public void ToggleButtonsStateAndChangeText()
    {
        // Изменить текстовое поле, если указан новый текст
        if (textField != null && !string.IsNullOrEmpty(newText))
        {
            textField.text = newText;
        }

        // Скрыть указанные кнопки
        foreach (GameObject button in buttonsToToggleOff)
        {
            button.SetActive(false);
        }

        // Показать указанные кнопки
        foreach (GameObject button in buttonsToToggleOn)
        {
            button.SetActive(true);
        }
    }
}
