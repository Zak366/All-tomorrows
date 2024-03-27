using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    // ����� ��� �������� ����� �� � ������
    public void LoadSceneByIndex(int sceneIndex)
    {
        // ���������, ���������� �� ����� � ����� ��������
        if (sceneIndex >= 1 && sceneIndex < SceneManager.sceneCountInBuildSettings)
        {
            SceneManager.LoadScene(sceneIndex);
        }
        else
        {
            Debug.LogWarning("����� � �������� " + sceneIndex + " �� ����������!");
        }
    }
}
