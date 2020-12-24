using UnityEngine;
using UnityEngine.SceneManagement;

public class CanvasLoadScene : MonoBehaviour
{
    public void OKButton()
    {
        SceneManager.LoadScene("Main Scene");
        DontDestroy.instance.generateRandom = false;
    }

    public void RandomButton()
    {
        SceneManager.LoadScene("Main Scene");
        DontDestroy.instance.generateRandom = true;
    }
}
