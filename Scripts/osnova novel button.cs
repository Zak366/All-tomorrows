using UnityEngine;
using UnityEngine.UI;

public class ChangeTextAndActivateButtons : MonoBehaviour
{
    public Text textField; // ������ �� ��������� ����, ������� �� ������ ��������
    public string[] texts; // ������ �������, ������� �� ������ ����������
    public int activationCount; // ���������� ������� ��� ��������� �������������� ������
    public GameObject[] buttonsToActivate; // ������ �������� ������, ������� ����� ������������
    public AudioClip[] buttonSounds; // ������ ������������ ��� ��������������� ��� ������� �� ������
    private AudioSource audioSource; // ��������� AudioSource ��� ������������ �����
    private int currentIndex = 0; // ������ �������� ������
    private int clickCounter = 0; // ������� �������

    // �������������
    void Start()
    {
        // �������� ��������� AudioSource �� �������
        audioSource = GetComponent<AudioSource>();
    }

    // ���������� ��� ������� �� ������
    public void ChangeTextAndActivate()
    {
        // ���������, ��� ���� ��������� ���� � ������ ������� �� ����
        if (textField != null && texts != null && texts.Length > 0)
        {
            // ���������, �� ����� �� �� �� ������� ������� �������
            if (currentIndex < texts.Length)
            {
                // ������������� ��������������� ������������, ���� ��� ���������������
                if (audioSource.isPlaying)
                {
                    audioSource.Stop();
                }

                // �������� ����� �� ������� ������� � �������
                textField.text = texts[currentIndex];

                // ����������� ������, ����� ������� � ���������� ������ � �������
                currentIndex++;

                // ����������� ������� �������
                clickCounter++;

                // �������� ��������� ������������ �� �������
                AudioClip randomSound = buttonSounds[Random.Range(0, buttonSounds.Length)];

                // ����������� ��������� ������������
                if (randomSound != null)
                {
                    audioSource.PlayOneShot(randomSound);
                }

                // ���������, �������� �� �� ��������� ���������� �������
                if (clickCounter >= activationCount)
                {
                    // ���������� ��������� ������
                    foreach (GameObject button in buttonsToActivate)
                    {
                        button.SetActive(true);
                    }
                }
            }
        }
    }
}
