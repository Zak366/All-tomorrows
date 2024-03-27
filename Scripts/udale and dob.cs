using UnityEngine;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Text textField; // ������ �� ��������� ����, ������� ����� ��������
    public string newText; // ����� ����� ��� ��������� ����� ������� ������
    public GameObject[] buttonsToToggleOff; // ������ ������, ������� ����� ������
    public GameObject[] buttonsToToggleOn; // ������ ������, ������� ����� ��������

    // ���������� ��� ������� �� ������
    public void ToggleButtonsStateAndChangeText()
    {
        // �������� ��������� ����, ���� ������ ����� �����
        if (textField != null && !string.IsNullOrEmpty(newText))
        {
            textField.text = newText;
        }

        // ������ ��������� ������
        foreach (GameObject button in buttonsToToggleOff)
        {
            button.SetActive(false);
        }

        // �������� ��������� ������
        foreach (GameObject button in buttonsToToggleOn)
        {
            button.SetActive(true);
        }
    }
}
