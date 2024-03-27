using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // Метод для загрузки сцены по её номеру
    public void LoadSceneByIndex(int sceneIndex)
    {
        // Проверяем, существует ли сцена с таким индексом
        if (sceneIndex >= 1 && sceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(sceneIndex);
        }
        else
        {
            Debug.LogWarning("Сцены с индексом " + sceneIndex + " не существует!");
        }
    }
}
