using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
   public SpriteRenderer ArmorRenderer;
   public List<UnityEngine.UI.Button> WeaponButtons;

   public List<UnityEngine.UI.Button> ArmorButtons;
    
    public void SetArmor(Sprite newSprite)
    {
        ArmorRenderer.sprite = newSprite;
    }
    
    public SpriteRenderer WeaponRenderer;
    public void SetWeapon(Sprite newSprite)
    {
        WeaponRenderer.sprite = newSprite;
    }

    public void SetRandomWeapon()
    { 
        WeaponButtons[Random.Range(0, 7)].onClick.Invoke();
    }

    public void SetRandomArmor()
    { 
        ArmorButtons[Random.Range(0,6)].onClick.Invoke();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
