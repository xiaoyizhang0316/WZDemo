using System.Collections;
using System.Collections.Generic;
using UnityEngine;




[CreateAssetMenu(menuName = "Attachment")]
public class Attachment : ScriptableObject
{
    [SerializeField] string attachmentName;
    [SerializeField] float buffNum;
}
