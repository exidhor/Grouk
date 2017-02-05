using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

namespace Grouk
{
    public class EventManager : MonoBehaviour
    {
        public void OnWizardTowerSelected()
        {
            Debug.Log("Wizard Tower Selected");
        }

        public void OnSignSelected()
        {
            Debug.Log("Sign Selected");
        }
    }
}