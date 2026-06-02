using System;
using System.Collections.Generic;

public class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        // In C#, assigning with [] works for both adding and updating
        myDict[key] = value;

        return myDict;
    }
}
