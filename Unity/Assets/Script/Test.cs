using System.Collections;
using System.Collections.Generic;

using Google.Protobuf;

using School;

using UnityEngine;

public class Test : MonoBehaviour {
    // Start is called before the first frame update
    void Start () {

        Clazz clazz = new Clazz {
            Id = 1024,
            Students = {
            new Student {
            Id = 1,
            Info = new Base.Person {
            Name = "First",
            Email = "first@email.com",
            Phone = "1"
            }
            },
            new Student {
            Id = 2,
            Info = new Base.Person {
            Name = "Second",
            Email = "second@email.com",
            Phone = "2"
            }
            }
            },
            Teachers = {
            new Teacher {
            Id = 3,
            Info = new Base.Person {
            Name = "Third",
            Email = "third@email.com",
            Phone = "3"
            }
            }
            }
        };

        UnityEngine.Debug.Log (clazz.ToString ());

        var b = clazz.ToByteArray ();

        var cc = Clazz.Parser.ParseFrom (b);

        UnityEngine.Debug.Log (cc.ToString ());
    }
}