using UnityEngine;
using UnityEngine.UI;
public class LanguageManager : MonoBehaviour
{
    [SerializeField] private LanguageScriptable[] languages;
    public Text bienvenido;
    public Text config;
    public Text audio;
    public Text video;

    void Start()
    {
        bienvenido.text = languages[0].bienvenidoString;
        config.text = languages[0].configuraciónString;
        audio.text = languages[0].audioString;
        video.text = languages[0].videoString;
    }

    public void Transalte(int languageSelection)
    {
        bienvenido.text = languages[languageSelection].bienvenidoString;
        config.text = languages[languageSelection].configuraciónString;
        audio.text = languages[languageSelection].audioString;
        video.text = languages[languageSelection].videoString;
    }
}
