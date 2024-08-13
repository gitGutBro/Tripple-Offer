using UnityEngine;
using UnityEngine.UI;

public class ToggleOffers : MonoBehaviour
{
    [SerializeField] private Canvas _offers;
    [SerializeField] private Button _toggleButton;

    private void Start()
    {
        _offers.gameObject.SetActive(false);

        _toggleButton.onClick.AddListener(OnSwitchOffersVisibility);
    }

    private void OnSwitchOffersVisibility() => 
        _offers.gameObject.SetActive(!_offers.gameObject.activeSelf);
}