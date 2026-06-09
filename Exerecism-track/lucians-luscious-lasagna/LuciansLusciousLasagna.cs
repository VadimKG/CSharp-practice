// TODO: define the 'ExpectedMinutesInOven()' method

// TODO: define the 'RemainingMinutesInOven()' method

// TODO: define the 'PreparationTimeInMinutes()' method

// TODO: define the 'ElapsedTimeInMinutes()' method

class Lasagna
{
    public int ExpectedMinutesInOven() => 40

    public int RemainingMinutesInOven(int actual)
    {
        return 40 - actual;
    }

    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    public int ElapsedTimeInMinutes(int layers, int actual)
    {
        return layers * 2 + actual;
    }
}