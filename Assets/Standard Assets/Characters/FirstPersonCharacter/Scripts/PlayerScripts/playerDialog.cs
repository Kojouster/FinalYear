
using UnityEngine;

public class playerDialog : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] public SaveScript ss;
    [SerializeField] GameObject playerIntroDialog;
    void Start()
    {
        //disabling dialog if game is loaded
        playerIntroDialog.SetActive(false);
        //activating if it is a new game
        if (ss.NewGame == true)
        {
            playerIntroDialog.SetActive(true);

        }
    }

}
