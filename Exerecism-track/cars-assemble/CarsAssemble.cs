static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        //throw new NotImplementedException("Please implement the (static) AssemblyLine.SuccessRate() method");
        if (speed == 0)
        {
            return 0;
        }
        else if(speed >= 1 && speed <= 4)
        {
            return 1;
        }
        else if (speed >= 5 && speed <= 8)
        {
            return 0.9;
        }
        else if (speed == 9)
        {
            return 0.8;
        }
        else
        {
            return 0.77;
        }
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        //throw new NotImplementedException("Please implement the (static) AssemblyLine.ProductionRatePerHour() method");

        if (speed == 0)
        {
            return 0;
        }
        else if (speed >= 1 && speed <= 4)
        {
            return speed * 221;
        }
        else if (speed >= 5 && speed <= 8)
        {
            return 0.9 * speed * 221;
        }
        else if (speed == 9)
        {
            return 0.8 * speed * 221;
        }
        else
        {
            return 0.77 * speed * 221;
        }
    }

    public static int WorkingItemsPerMinute(int speed)
    {
        //throw new NotImplementedException("Please implement the (static) AssemblyLine.WorkingItemsPerMinute() method");
        if (speed == 0)
        {
            return 0;
        }
        else if (speed >= 1 && speed <= 4)
        {
            return (int)(speed * 221 / 60);
        }
        else if (speed >= 5 && speed <= 8)
        {
            return (int)(0.9 * speed * 221 / 60);
        }
        else if (speed == 9)
        {
            return (int)(0.8 * speed * 221 / 60);
        }
        else
        {
            return (int)(0.77 * speed * 221 / 60);
        }
    }
}
