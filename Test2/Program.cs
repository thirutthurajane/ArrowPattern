// See https://aka.ms/new-console-template for more information

using Microsoft.VisualBasic;

void Arrow(int param)
{
    int curSpace = 0;
    for (int i = 0; i < param; i++)
    {
        if(i < (param / 2))
        {
            curSpace += 1;
            Console.WriteLine(new String(' ', i) + "*");
        }
        else if(i == (param / 2) && param % 2 > 0)
        {
            if (i % 2 == 0)
            {

                curSpace += 1;
                Console.WriteLine(new String(' ', curSpace) + "*");
            }
            else
            {
                Console.WriteLine(new String(' ', i) + "*");
            }
        }
        else if((i == (param / 2) || i == (param / 2) - 1) && param % 2 == 0)
        {
            curSpace -= 1;
            Console.WriteLine(new String(' ', curSpace) + "*");

        }
        else
        {
            curSpace -= 1;
            Console.WriteLine(new String(' ', curSpace) + "*");
        }
    }
}

Arrow(15);
