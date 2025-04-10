using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace finalcial_app
{
    public class ExeptionTest
    {
        int GetInt(int[] array, int index)
    {
    try
    {
        return array[index];
    }
    catch (IndexOutOfRangeException e) when (index < 0) 
    {
        throw new ArgumentOutOfRangeException(
            "Parameter index cannot be negative.", e);
    }
    catch (IndexOutOfRangeException e)
    {
        throw new ArgumentOutOfRangeException(
            "Parameter index cannot be greater than the array size.", e);
    }
    }

static int GetValueFromArray(int[] array, int index)
{
    try
    {
        return array[index];
    }
    catch (IndexOutOfRangeException e)
    {
        throw new ArgumentOutOfRangeException(
            "Parameter index is out of range.", e);
    }
}
 
    }
}