
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjDestroy : MonoBehaviour
{
    
    private void Awake()
    {
        Invoke("DeleteObj", 10);//after 6s use DeleteObj
    }
    void Start()
    {

    }
    void Update()
    {

    }
   private void DeleteObj()
    {
        Destroy(gameObject);//gameObject是脚本的Component类的属性，可以将其理解为当前 组件或者脚本 附加的对象

        //以下为SetActive方法，同样能使物体消失，但并不是严格意义上的销毁
        //gameObject.SetActive(false);
    }
}