
using UnityEngine;

public class PanelControl : MonoBehaviour
{
    public GameObject panel;

    public void OpenAndClosePanel()
    {
        Animator animator = panel.GetComponent<Animator>();

        bool isOpen = animator.GetBool("open");
        animator.SetBool("open",!isOpen);
    }
}
