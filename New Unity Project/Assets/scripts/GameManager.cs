using UnityEngine;

public class GameManager : MonoBehaviour
{[Header("兔子")]
   public Transform rabbit;
    [Header("蝙蝠")]
    public Transform bat;
    [Header("虛擬搖桿")]
    public FloatingJoystick joystick;
    [Header("旋轉速度"), Range(0.1f, 20f)]
    public float turn = 1.5f;
    [Header("縮放"), Range(0f, 5f)]
    public float size = 0.3f;

    private void Start()
    {
        print("開始事件");
    }

    private void Update()
    {
        print("更新事件");
        print(joystick.Vertical);

        bat.Rotate(0, joystick.Horizontal * turn , 0);
        rabbit.Rotate(0, joystick.Horizontal * turn , 0);

        bat.localScale += new Vector3(1, 1, 1) * joystick.Vertical* size;
    }
}
