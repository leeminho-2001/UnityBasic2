using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RenPy : MonoBehaviour
{
    // Iamge�� �Է����� �� ������ 3���� Ÿ���� �����Ѵ�. �� �� ���� ������ ����ϴ��� Ȯ���� �˾Ƶΰ� �ش� ������ ����ǰ� ����.
    // ���ݰ� ���� ���� UnityEngine.UI.Image�� ����Ѵ�.
    [SerializeField] Image img_BG; //���
    [SerializeField] Image[] img_Character; //ĳ���� �̹���
    [SerializeField] TextMeshProUGUI Text_Name; //�̸� : ���̳�
    [SerializeField] TextMeshProUGUI Text_Dialogue; //��� : ���? ���� �н��̶��� ������, �� ���� ��ü�� ���ٳ�.
    [SerializeField] TextMeshProUGUI Text_NameTitle; //�̸� Ÿ��Ʋ : ����Ƽ


    int id = 1;

    void Start()
    {
        int characterID = SData.GetDialogueData(id).Character;// ��� ���̺��� 1�� ID�� ĳ���� ID�÷��� �����´�.
        Text_Name.text = SData.GetCharacterData(characterID).Name; // ĳ���� ���̺��� ĳ���� ID�� �̸��� ������ �´�.
        Text_NameTitle.text = SData.GetCharacterData(characterID).Title; // ĳ���� ���̺��� Ÿ��Ʋ�� ������ �´�.

        Text_Dialogue.text = SData.GetDialogueData(id).Dialogue;
    }

    public void OnClickButton()
    {
        id++; // ��ư�� Ŭ���� ������ id�� ������Ų��.

        int characterID = SData.GetDialogueData(id).Character;// ��� ���̺��� 1�� ID�� ĳ���� ID�÷��� �����´�.
        Text_Name.text = SData.GetCharacterData(characterID).Name; // ĳ���� ���̺��� ĳ���� ID�� �̸��� ������ �´�.
        Text_NameTitle.text = SData.GetCharacterData(characterID).Title; // ĳ���� ���̺��� Ÿ��Ʋ�� ������ �´�.

        Text_Dialogue.text = SData.GetDialogueData(id).Dialogue;
    }

}
