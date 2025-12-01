using UnityEngine;
using UnityEngine.InputSystem;
public class MyHandController : MonoBehaviour
{
    [SerializeField] InputActionReference actionGrip;
    [SerializeField] InputActionReference actionTrigger;
    private Animator _handAnimator;

    private void Awake()
    {
        _handAnimator = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        float triggerValue = actionTrigger.action.ReadValue<float>(); // a float because the chosen action tells us how much
                                                                                 // is the trigger pressed (instead of just a boolean stating if its pressed or not)

        _handAnimator.SetFloat("Trigger", triggerValue); // using the oculus hand models pinch animation

        float gripValue = actionGrip.action.ReadValue<float>();

        _handAnimator.SetFloat("Grip", gripValue); // using the oculus hand models grip animation
    }
}
