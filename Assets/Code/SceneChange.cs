using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    // Start is called before the first frame update
    public void Mainto2ndScene()
    {
        SceneManager.LoadScene("SecondScene");
    }
    public void toBark()
    {
        SceneManager.LoadScene("newScene");
    }
    public void toPoop()
    {
        SceneManager.LoadScene("PoopScene");
    }
    public void toRepeat()
    {
        SceneManager.LoadScene("Repeat");
    }
    public void toSnack()
    {
        Application.OpenURL("https://drive.google.com/file/d/11WnF7SqDWotzBMmZj7A7lfXttJJUI_Rs/view?usp=sharing");
    }
}
