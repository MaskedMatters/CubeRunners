// Libraries
using UnityEngine;
using UnityEngine.SceneManagement;

// Script class | All script
public class ButtonMech : MonoBehaviour
{
    bool seePauseMenu = false;

    public GameObject pauseMenu;

    // Pause Game Void Code
    public void Pause()
    {

        if (seePauseMenu == false)
        {
            seePauseMenu = true;

            // Set Pause Screen Active (Seeable)
            pauseMenu.SetActive(true);
        }
        else
        {
            seePauseMenu = false;

            // Set Pause Screen Unactive (Unseeable)
            pauseMenu.SetActive(false);
        }
    }

    // 4 Menu Quit Button
    public void Quit()
    {
        Debug.Log("QUUUUUUUIIIIIIIIIIIIIITTTTTTTTTTIIIIIIIIINGGGGGGGG!!!");
        Application.Quit();
    }
}
