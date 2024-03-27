using UnityEngine;

public class Mute : MonoBehaviour
{
    void Start()
    {
        // Отключаем все звуки в игре
        AudioListener.volume = 0f;
    }

    // Вы можете добавить другие методы и функциональность по вашему усмотрению
}
