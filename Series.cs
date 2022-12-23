using System;
using System.Collections.Generic;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        List<string> retVal = new List<string>();
        if(sliceLength<=0)
        {
            throw new ArgumentException();
        }
        if(numbers.Length==0)
        {
            throw new ArgumentException();
        }
        if(numbers.Length >= sliceLength)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                retVal.Add(numbers.Substring(i, sliceLength));   
                if(i==numbers.Length-sliceLength)
                {
                    break;
                }
            }
        }
        else
        {
            throw new ArgumentException();
        }
        
        return retVal.ToArray();
    }
}