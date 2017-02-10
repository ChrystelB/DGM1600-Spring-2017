If Statements vs Else Statements

/*If statements

    "If" statements is a way to help the operator to determine whether there is a 
stopping point in a value, or whether we need to use a else/booleon variable. For 
example...

void TemperatureTest ()
{
    if(Input.GetkeyDown(KeyCode.Space))
        TemperatureTest();

    HotchocolateTemperature -= Time.deltaTime * 5f;
}

*/
void TemperatureTest ()
{
    If(HotchocolateTemperature > hotlimitTemperature)
    {
        Debug.Log("Hot Chocolate is WAY too hot.");
    }
    Else if()
    }

/*If something is too hot, then something else needs to happen. It's helping us understand 
that once something gets to a point, another action must be undertaken. Whether too hot, or
too cold, or even whether the cup is about to overflow, it needs to stop and change. The "If"
statment functions as it normally would in our English syntax.
