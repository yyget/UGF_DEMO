using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityGameFramework.Runtime;

namespace Demo6
{

    public class HeroLogic : EntityLogic
    {
       protected HeroLogic()
        {

        }
        protected override void OnShow(object userData)
        {
            base.OnShow(userData); 
            Log.Debug("œ‘ æ”¢–€ µÃÂ.");
        }
    }
}
