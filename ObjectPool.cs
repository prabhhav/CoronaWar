using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ZenvaVR
{

    public class ObjectPool : MonoBehaviour
   {

       public GameObject poolPrefab;
        public int initialNum = 10;

       List<GameObject> pooledObjects;

        void Awake()
       {
           pooledObjects = new List<GameObject>();


          for (int i = 0; i <  initialNum; i++ )
        {
            GameObject newObj = Instantiate(poolPrefab);
             newObj.SetActive(false);
             pooledObjects.Add(newObj); 

         }
     }
      void CreateObj()
      {
          GameObject newObj = Instantiate(poolPrefab);

         newObj.SetActive(false);
         pooledObjects.Add(newObj);
     }

   }
}

       