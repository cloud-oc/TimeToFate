using UnityEngine;
using System.Collections.Generic;

public class LanguageManager : MonoBehaviour
{
    public enum Language
    {
        Chinese,
        English,
        Japanese
    }

    private static Language currentLanguage;

    void Start()
    {
        // 根据系统语言初始化
        DetectSystemLanguage();
    }

    /// <summary>
    /// 检测系统语言并设置当前语言
    /// </summary>
    private static void DetectSystemLanguage()
    {
        SystemLanguage sysLang = Application.systemLanguage;

        switch (sysLang)
        {
            case SystemLanguage.Chinese:
            case SystemLanguage.ChineseSimplified:
                currentLanguage = Language.Chinese;
                break;
            case SystemLanguage.Japanese:
                currentLanguage = Language.Japanese;
                break;
            case SystemLanguage.English:
            default:
                currentLanguage = Language.English;
                break;
        }

        Debug.Log($"System Language Detected: {sysLang}, Current Language Set to: {currentLanguage}");
    }

    /// <summary>
    /// 手动设置语言
    /// </summary>
    public static void SetLanguage(Language language)
    {
        currentLanguage = language;
        Debug.Log($"Language Changed to: {currentLanguage}");
    }

    /// <summary>
    /// 获取当前语言
    /// </summary>
    public static Language GetCurrentLanguage()
    {
        return currentLanguage;
    }

    /// <summary>
    /// 获取小六壬预测结果文本
    /// </summary>
    public static string GetFortuneTellResult(int order)
    {
        int resultIndex = order % 6;

        switch (currentLanguage)
        {
            case Language.Chinese:
                return GetChineseFortune(resultIndex);
            case Language.English:
                return GetEnglishFortune(resultIndex);
            case Language.Japanese:
                return GetJapaneseFortune(resultIndex);
            default:
                return GetChineseFortune(resultIndex);
        }
    }

    // 中文结果
    private static string GetChineseFortune(int index)
    {
        string[] results = {
            "\n大吉\n阶段：身不动时\n五行：青龙木\n颜色：青\n方位：东\n数字：1，4，5\n意蕴：静止，心安，吉祥",
            "\n小凶\n阶段：人未归时\n五行：腾蛇土\n颜色：暗\n方位：四方\n数字：2，7，8\n意蕴：喑味不明，延迟，纠缠，拖延，漫长",
            "\n中吉\n阶段：人即至时\n五行：朱雀火\n颜色：红\n方位：南\n数字：3，6，9\n意蕴：快速，喜庆，吉利，时机已到",
            "\n中凶\n阶段：官事凶时\n五行：白虎金\n颜色：白\n方位：西\n数字：4，1，2\n意蕴：不吉，惊恐，凶险，口舌是非",
            "\n小吉\n阶段：人来喜时\n五行：玄武水\n颜色：黄\n方位：北\n数字：5，3，8\n意蕴：和合，吉利",
            "\n大凶\n阶段：音信稀时\n五行：勾陈土\n颜色：黑\n方位：中央\n数字：6，5，10\n意蕴：不吉，无果，忧虑"
        };
        return results[index];
    }

    // 英文结果
    private static string GetEnglishFortune(int index)
    {
        string[] results = {
            "\nGreat Luck (Da An)\nPhase: When body is still\nElement: Azure Dragon Wood\nColor: Green\nDirection: East\nNumbers: 1, 4, 5\nMeaning: Stillness, peace of mind, auspiciousness",
            "\nSmall Misfortune (Liu Lian)\nPhase: When people haven't returned\nElement: Crimson Snake Earth\nColor: Dark\nDirection: All directions\nNumbers: 2, 7, 8\nMeaning: Unclear, delayed, entangled, dragging, prolonged",
            "\nMedium Luck (Su Xi)\nPhase: When people are about to arrive\nElement: Vermillion Bird Fire\nColor: Red\nDirection: South\nNumbers: 3, 6, 9\nMeaning: Swift, joyful, auspicious, right timing",
            "\nMedium Misfortune (Chi Kou)\nPhase: When official matters are ominous\nElement: White Tiger Metal\nColor: White\nDirection: West\nNumbers: 4, 1, 2\nMeaning: Inauspicious, frightening, dangerous, disputes",
            "\nSmall Luck (Xiao Ji)\nPhase: When people arrive with joy\nElement: Black Tortoise Water\nColor: Yellow\nDirection: North\nNumbers: 5, 3, 8\nMeaning: Harmony, auspiciousness",
            "\nGreat Misfortune (Kong Wang)\nPhase: When news is sparse\nElement: Hook Chen Earth\nColor: Black\nDirection: Center\nNumbers: 6, 5, 10\nMeaning: Inauspicious, fruitless, sorrowful"
        };
        return results[index];
    }

    // 日文结果
    private static string GetJapaneseFortune(int index)
    {
        string[] results = {
            "\n大吉(大安)\n段階：身が動かない時\n五行：青龍木\n色：青\n方位：東\n数字：1, 4, 5\n意味：静止、心の安定、吉祥",
            "\n小凶(流連)\n段階：人がまだ帰らない時\n五行：腾蛇土\n色：暗\n方位：四方\n数字：2, 7, 8\n意味：不明瞭、遅延、纠纷、引き延ばし、長引く",
            "\n中吉(速喜)\n段階：人が間もなく到着する時\n五行：朱雀火\n色：赤\n方位：南\n数字：3, 6, 9\n意味：迅速、喜び、吉利、時機到来",
            "\n中凶(赤口)\n段階：公務が凶の時\n五行：白虎金\n色：白\n方位：西\n数字：4, 1, 2\n意味：不吉、恐怖、危険、口論",
            "\n小吉(小吉)\n段階：人が喜びをもたらす時\n五行：玄武水\n色：黄\n方位：北\n数字：5, 3, 8\n意味：調和、吉利",
            "\n大凶(空亡)\n段階：ニュースが少ない時\n五行：勾陳土\n色：黒\n方位：中央\n数字：6, 5, 10\n意味：不吉、無益、憂慮"
        };
        return results[index];
    }
}
