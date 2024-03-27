using UnityEngine;
using UnityEngine.UI;

public class ChangeTextAndActivateButtons : MonoBehaviour
{
    public Text textField; // Ссылка на текстовое поле, которое вы хотите изменить
    public string[] texts; // Массив текстов, которые вы хотите показывать
    public int activationCount; // Количество нажатий для активации дополнительных кнопок
    public GameObject[] buttonsToActivate; // Массив объектов кнопок, которые нужно активировать
    public AudioClip[] buttonSounds; // Массив аудиодорожек для воспроизведения при нажатии на кнопку
    private AudioSource audioSource; // Компонент AudioSource для проигрывания звука
    private int currentIndex = 0; // Индекс текущего текста
    private int clickCounter = 0; // Счётчик нажатий

    // Инициализация
    void Start()
    {
        // Получаем компонент AudioSource из объекта
        audioSource = GetComponent<AudioSource>();
    }

    // Вызывается при нажатии на кнопку
    public void ChangeTextAndActivate()
    {
        // Убедитесь, что есть текстовое поле и массив текстов не пуст
        if (textField != null && texts != null && texts.Length > 0)
        {
            // Проверяем, не вышли ли мы за пределы массива текстов
            if (currentIndex < texts.Length)
            {
                // Останавливаем воспроизведение аудиодорожки, если она воспроизводится
                if (audioSource.isPlaying)
                {
                    audioSource.Stop();
                }

                // Изменяем текст на текущий элемент в массиве
                textField.text = texts[currentIndex];

                // Увеличиваем индекс, чтобы перейти к следующему тексту в массиве
                currentIndex++;

                // Увеличиваем счётчик нажатий
                clickCounter++;

                // Выбираем случайную аудиодорожку из массива
                AudioClip randomSound = buttonSounds[Random.Range(0, buttonSounds.Length)];

                // Проигрываем выбранную аудиодорожку
                if (randomSound != null)
                {
                    audioSource.PlayOneShot(randomSound);
                }

                // Проверяем, достигли ли мы заданного количества нажатий
                if (clickCounter >= activationCount)
                {
                    // Активируем указанные кнопки
                    foreach (GameObject button in buttonsToActivate)
                    {
                        button.SetActive(true);
                    }
                }
            }
        }
    }
}
