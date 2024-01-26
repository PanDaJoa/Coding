using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Example17 : MonoBehaviour
{
    // 파스칼 표기법 public은 무조건 대문자로 시작.
    public string Id;
    public string Password;

    // const가 붙으면 상수다. 상수값은 변할 수 없다.
    const string ID = "teemo";
    const string PASSWORD = "1234";

    // Start is called before the first frame update
    void Start()
    {
        // 1. ID가 다르면 "존재하지 않는 ID입니다."
        // 2. ID는 같고 PASSWORD가 다르면 "비밀번호가 틀렸습니다."
        // 3. ID와 PASSWORD가 같다면 "로그인 되었습니다."
        if (Id != ID) // 만약: ID가 다르면
        {
            Debug.Log("존재하지 않는 ID입니다.");
        }

        if (Id == ID && Password != PASSWORD)
        {
            Debug.Log("비밀번호가 틀렸습니다.");
        }

        if (Id == ID && Password == PASSWORD)
        {
            Debug.Log("로그인 되었습니다.");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
