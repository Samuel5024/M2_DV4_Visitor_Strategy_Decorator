using UnityEngine;
using Chapter.Decorator;

public class ClientDecorator : MonoBehaviour
{
    private BikeWeapon2 _bikeWeapon;
    private bool _isWeaponDecorated;

    void Start()
    {
        _bikeWeapon = (BikeWeapon2)FindObjectOfType(typeof(BikeWeapon2));
    }

    void OnGUI()
    {
        if(!_isWeaponDecorated)
        {
            if(GUILayout.Button("Decorate Weapon"))
            {
                _bikeWeapon.Decorate();
                _isWeaponDecorated = !_isWeaponDecorated;
            }
        }

        if(_isWeaponDecorated)
        {
            if(GUILayout.Button("Reset Weapon"))
            {
                _bikeWeapon.Reset();
                _isWeaponDecorated = !_isWeaponDecorated;
            }
        }

        if(GUILayout.Button("Toggle Fire"))
        {
            _bikeWeapon.ToggleFire();
        }
    }
}
