using System.Globalization;

var number = 6764;
string textnumber = number.ToString();
char[] litera = textnumber.ToCharArray();
int[] licznik = new int[10];
licznik[0] = 0;
licznik[1] = 0;
licznik[2] = 0;
licznik[3] = 0;
licznik[4] = 0;
licznik[5] = 0; 
licznik[6] = 0;
licznik[7] = 0;
licznik[8] = 0;
licznik[9] = 0;

for (int i = 0; i < litera.Length; i++)
{
    int x = 0;
    if (litera[i] == '0')
    {
        licznik[x]++;
    }
    else
    {
        x++;
        if (litera[i] == '1')
        {
            licznik[x]++;
        }
        else
        {
            x++;
            if (litera[i] == '2')
            {
                licznik[x]++;
            }
            else
            {
                x++;
                if (litera[i] == '3')
                {
                    licznik[x]++;
                }
                else
                {
                    x++;
                    if (litera[i] == '4')
                    {
                        licznik[x]++;
                    }
                    else
                    {
                        x++;
                        if (litera[i] == '5')
                        {
                            licznik[x]++;
                        }
                        else
                        {
                            x++;
                            if (litera[i] == '6')
                            {
                                licznik[x]++;
                            }
                            else
                            {
                                x++;
                                if (litera[i] == '7')
                                {
                                    licznik[x]++;
                                }
                                else
                                {
                                    x++;
                                    if (litera[i] == '8')
                                    {
                                        licznik[x]++;
                                    }
                                    else
                                    {
                                        x++;
                                        if (litera[i] == '9')
                                        {
                                            licznik[x]++;
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
for (int z = 0; z<10; z++)
{
    Console.WriteLine(z + ">=" + licznik[z]);
}
