using UnityEngine;

// 보간: 시작점과 끝점이 주어졌을 때 두 점 사이의 진행률(비율)에 따라 그 사이의 특정한 지점을 얻는 것
// 진행률(비율) -> 0 ~ 1 사이의 값
// 뭔가를 "부드럽게"할 때 사용

// Curve(곡선): 연속적인 점의 집합
public class CurveExample : MonoBehaviour
{
    // 보간을 시각적으로 볼 수 있는 그래프 에디터
    public AnimationCurve curve;

    public Transform Start;
    public Transform End;

    private float _progress;  // 진행률: 0 ~ 1
    public float Duration = 3f;
    
    public bool StartToEnd = true;
    void Update()
    {
        if (StartToEnd)
        {
            _progress += Time.deltaTime / Duration;
        }
        else
        {
            _progress -= Time.deltaTime / Duration;
        }

        if (_progress > 1f)
        {
            _progress = 1f;
            StartToEnd = false;
        }
        else if (_progress < 0f)
        {
            _progress = 0f;
            StartToEnd = true;
        }
        // Vector3.Lerp(시작 좌표, 종료 좌표, 진행률)
        transform.position = Vector3.Lerp(Start.position, End.position, curve.Evaluate(_progress));
    }

}
