using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuControl : MonoBehaviour
{
    public void PlayGame() 
    {
        SceneManager.LoadSceneAsync("Level01");
    }

}
