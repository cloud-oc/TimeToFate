using UnityEngine;

//获取要输出的字符串fateStr
public class OutputResult : MonoBehaviour
{
    public static string fateStr;

    // Start is called before the first frame update
    void Start()
    {
        GetResult();
    }

    private static void GetResult()
    {
        fateStr = LanguageManager.GetFortuneTellResult(GetOrder.order);
    }
}
