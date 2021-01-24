using System;
using System.Text;

public class RSAEncrypt {

    string plaintext = "6357294171489311547190987615544575133581967886499484091352661406414044440475205342882841236357665973431462491355089413710392273380203038793241564304774271529108729717"; 

    public RSAEncrypt()
    {
        StringBuilder stringBuilder = new StringBuilder();

        for(int a=0; a<plaintext.Length; a++)
        {
            int r = int.Parse(""+plaintext[a]);
            stringBuilder.Append((r*r*r).ToString());
        }

        Console.WriteLine(stringBuilder.ToString());
    }
}