using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RenPy : MonoBehaviour
{
    // Iamge를 입력햇을 때 나오는 3가지 타입이 존재한다. 그 중 내가 무엇을 사용하는지 확실히 알아두고 해당 엔진과 연결되게 하자.
    // 지금과 같은 경우는 UnityEngine.UI.Image를 사용한다.
    [SerializeField] Image img_BG; //배경
    [SerializeField] Image[] img_Character; //캐릭터 이미지
    [SerializeField] TextMeshProUGUI Text_Name; //이름 : 레이나
    [SerializeField] TextMeshProUGUI Text_Dialogue; //대사 : 어떤가? 나의 분신이라고는 하지만, 그 힘은 본체와 같다네.
    [SerializeField] TextMeshProUGUI Text_NameTitle; //이름 타이틀 : 벨레티


    int id = 1;

    void Start()
    {
        int characterID = SData.GetDialogueData(id).Character;// 대사 테이블의 1번 ID의 캐릭터 ID컬럼을 가져온다.
        Text_Name.text = SData.GetCharacterData(characterID).Name; // 캐릭터 테이블에서 캐릭터 ID에 이름을 가지고 온다.
        Text_NameTitle.text = SData.GetCharacterData(characterID).Title; // 캐릭터 테이블에서 타이틀을 가지고 온다.

        Text_Dialogue.text = SData.GetDialogueData(id).Dialogue;
    }

    public void OnClickButton()
    {
        id++; // 버튼을 클릭할 때마다 id를 증가시킨다.

        int characterID = SData.GetDialogueData(id).Character;// 대사 테이블의 1번 ID의 캐릭터 ID컬럼을 가져온다.
        Text_Name.text = SData.GetCharacterData(characterID).Name; // 캐릭터 테이블에서 캐릭터 ID에 이름을 가지고 온다.
        Text_NameTitle.text = SData.GetCharacterData(characterID).Title; // 캐릭터 테이블에서 타이틀을 가지고 온다.

        Text_Dialogue.text = SData.GetDialogueData(id).Dialogue;
    }

}
