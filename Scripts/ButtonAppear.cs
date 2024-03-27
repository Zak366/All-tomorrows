using UnityEngine;
using UnityEngine.UI;

public class ButtonAppear : MonoBehaviour
{
    public Button targetButton; // ������ �� ������, ������� ����� ��������

    public float delayTime = 5f; // ����� �������� ����� ���������� ������

    private bool buttonVisible = false; // ����, ������������, ����� �� ������ � ������ ������

    void Start()
    {
        // �������� ����� ��� ������ ������ � ���������
        ShowButtonWithDelay();
    }

    // ����� ��� ����������� ������ ������
    public void ShowButtonWithDelay()
    {
        if (!buttonVisible)
        {
            Invoke("ShowButton", delayTime);
        }
    }

    // ����� ��� ������ ������
    public void ShowButton()
    {
        targetButton.gameObject.SetActive(true);
        buttonVisible = true;
    }
}
