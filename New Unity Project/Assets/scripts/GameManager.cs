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
    [Header("兔子動畫")]
    public Animator anirabbit;
    [Header("蝙蝠動畫")]
    public Animator anibat;

    //public float test =1 ;
    //public float test2 = 1;

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

        bat.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(bat.localScale.x, 0.5f, 3.5f);

        rabbit.localScale += new Vector3(1, 1, 1) * joystick.Vertical * size;

        rabbit.localScale = new Vector3(1, 1, 1) * Mathf.Clamp(bat.localScale.x, 0.5f, 3.5f);

        //test = Mathf.Clamp(test, 0.5f, 9.9f);

        //print(Mathf.Clamp(-1, 0, 10));
    }
    
    public void Attack()
    {
        print("攻擊");
        anibat.SetTrigger("AT");
        anirabbit.SetTrigger("AT");

    }

    public void DIE()
    {
        print("死亡");
        anibat.SetTrigger("DI");
        anirabbit.SetTrigger("DI");

    }

    public void MOVE()
    {
        print("移動");
        anibat.SetTrigger("MO");
        anirabbit.SetTrigger("MO");

    }

    public void PlayAnimation(string aniname)
    {
        print(aniname);
        anibat.SetTrigger(aniname);
        anirabbit.SetTrigger(aniname);


    }

}


