public class Program 
{
    public static bool ValidatePIN(string pin) 
    {
		int num;
        if(int.TryParse(pin, out num))
        {
			if(!(pin.StartsWith("-") || pin.StartsWith("+")))
            if(pin.Length == 4 || pin.Length == 6)
							return true;
        }
            return false;
      }
}

