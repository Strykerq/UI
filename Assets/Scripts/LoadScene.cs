using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void DoodleLoad1()
    {
        SceneManager.LoadScene("DoodleJump");
    }

    public void DeadCellsLoad()
    {
        SceneManager.LoadScene("DeadCells");
    }
    
    public void ChessLoad()
    {
        SceneManager.LoadScene("Chess");
    }
    
    public void MainMenuBack()
    {
        SceneManager.LoadScene(0);
    }
    
    
}
