using UnityEngine;

public class Mute : MonoBehaviour
{
    void Start()
    {
        // ��������� ��� ����� � ����
        AudioListener.volume = 0f;
    }

    // �� ������ �������� ������ ������ � ���������������� �� ������ ����������
}
