using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Slider))]
public class HealthBarController : MonoBehaviour
{
    [SerializeField] private Slider _slider;

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            _slider.value += Time.deltaTime;
        }
        else
        {
            _slider.value -= Time.deltaTime;
        }
    }
}
