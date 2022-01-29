/*
    While I know this is a generally a bad thing, it's the only way to avoid depending of create-keyboards

    Wraps the old keyboards.resx creation
*/
using System.Windows.Forms.Internal;

class Program
{
    public static void Main(string[] args)
    {
        CreateKeyboards.Create();
    }
}
