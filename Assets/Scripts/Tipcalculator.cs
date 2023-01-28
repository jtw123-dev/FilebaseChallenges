using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tipcalculator : MonoBehaviour
{
    private float _tipA, _tipB, _tipC,  _customTipTotal,_totalBill,_bill;
    [SerializeField] private float _customTip;
    // Start is called before the first frame update
    void Start()
    {
        _bill = 20;
        _customTipTotal = _customTip / 100*_bill;
        _totalBill = _bill + _customTipTotal;
        Debug.Log(" Your bill is $20");
        Debug.Log(" 15% tip = $3 with a final total of: $23 ");
        Debug.Log(" 20% tip = $3 with a final total of: $24");
        Debug.Log(" 25% tip = $5 with a final total of: $25");
        Debug.Log(" Your custom tip of " + _customTip + " % " + " = " + _customTipTotal + " with a final total of " + _totalBill );
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
